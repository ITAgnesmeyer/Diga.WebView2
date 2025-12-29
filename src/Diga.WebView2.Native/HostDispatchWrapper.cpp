#include "pch.h"
#include "HostDispatchWrapper.h"
#include "CallableDispatch.h"
#include <unordered_map>
#include <string>
#include <vector>
#include <atomic>

// ===== Helpers =====

static std::wstring ToLower(const wchar_t* s)
{
    std::wstring out = s ? s : L"";
    for (auto& c : out) c = (wchar_t)towlower(c);
    return out;
}

static void VariantToJson(std::wstring& dst, const VARIANT& v)
{
    switch (v.vt)
    {
    case VT_EMPTY:
    case VT_NULL:
        dst += L"null";
        break;
    case VT_BOOL:
        dst += (v.boolVal == VARIANT_FALSE) ? L"false" : L"true";
        break;
    case VT_I4:
        dst += std::to_wstring(v.lVal);
        break;
    case VT_BSTR:
        dst += L"\"";
        dst += (v.bstrVal ? v.bstrVal : L"");
        dst += L"\"";
        break;
    default:
        dst += L"\"[unsupported]\"";
        break;
    }
}

static std::wstring BuildJsonArgs(const DISPPARAMS& dp)
{
    std::wstring json = L"[";
    for (UINT i = 0; i < dp.cArgs; i++)
    {
        if (i) json += L",";
        const VARIANT& v = dp.rgvarg[dp.cArgs - 1 - i];
        VariantToJson(json, v);
    }
    json += L"]";
    return json;
}


// ===== HostDispatchWrapper =====



// ===== Implementation =====

HRESULT HostDispatchWrapper::QueryInterface(REFIID riid, void** ppv)
{
    if (!ppv) return E_POINTER;
    *ppv = nullptr;

    if (riid == IID_IUnknown || riid == IID_IDispatch)
        *ppv = static_cast<IDispatch*>(this);
    else if (riid == IID_IHostWrapper)
        *ppv = static_cast<IHostWrapper*>(this);
    else
        return E_NOINTERFACE;

    AddRef();
    return S_OK;
}

ULONG HostDispatchWrapper::AddRef()
{
    return (ULONG)InterlockedIncrement(&m_ref);
}

ULONG HostDispatchWrapper::Release()
{
    ULONG rc = (ULONG)InterlockedDecrement(&m_ref);
    if (rc == 0) delete this;
    return rc;
}

HRESULT HostDispatchWrapper::add_HostInvokeTarget(
    IHostInvokeTarget* target, EventRegistrationToken* token)
{
    if (!target || !token) return E_POINTER;

    token->value = ++m_nextToken;
    target->AddRef();
    m_targets[token->value] = target;
    m_activeToken = token->value;
    return S_OK;
}

HRESULT HostDispatchWrapper::remove_HostInvokeTarget(EventRegistrationToken token)
{
    auto it = m_targets.find(token.value);
    if (it == m_targets.end()) return E_INVALIDARG;

    it->second->Release();
    m_targets.erase(it);

    if (m_activeToken == token.value)
        m_activeToken = m_targets.empty() ? 0 : m_targets.begin()->first;

    return S_OK;
}

HRESULT HostDispatchWrapper::GetTypeInfoCount(UINT* pctinfo)
{
    if (!pctinfo) return E_POINTER;
    *pctinfo = 0;
    return S_OK;
}

HRESULT HostDispatchWrapper::GetTypeInfo(UINT, LCID, ITypeInfo**)
{
    return DISP_E_BADINDEX;
}

HRESULT HostDispatchWrapper::GetIDsOfNames(
    REFIID, LPOLESTR* names, UINT c, LCID, DISPID* ids)
{
    for (UINT i = 0; i < c; i++)
    {
        std::wstring key = ToLower(names[i]);
        auto it = m_nameToDispid.find(key);
        if (it == m_nameToDispid.end())
        {
            DISPID id = ++m_nextDispid;
            m_nameToDispid[key] = id;
            m_dispidToName[id] = key;
            ids[i] = id;
        }
        else ids[i] = it->second;
    }
    return S_OK;
}

HRESULT HostDispatchWrapper::Invoke(
    DISPID id, REFIID, LCID, WORD flags, DISPPARAMS* dp,
    VARIANT* result, EXCEPINFO* pExcepInfo, UINT* puArgErr)
{
    if (!dp) return E_POINTER;
    if (result) VariantInit(result);

    auto it = m_dispidToName.find(id);
    if (it == m_dispidToName.end())
        return DISP_E_MEMBERNOTFOUND;

    const std::wstring& name = it->second;

    // 1) PROPERTYGET -> gib callable zurück (für Methoden)
    if (flags & DISPATCH_PROPERTYGET)
    {
        if (!result) return E_POINTER;

        auto* callable = new (std::nothrow) CallableDispatch(this, name);
        if (!callable) return E_OUTOFMEMORY;

        result->vt = VT_DISPATCH;
        result->pdispVal = callable; // refcount=1
        return S_OK;
    }

    // 2) PropertyPut weiter wie gehabt (wenn du echte Properties willst)
    // 3) DISPATCH_METHOD direkt unterstützen (falls WebView2 es doch so ruft)
    if (flags & DISPATCH_METHOD)
    {
        return InvokeByName_Internal(name.c_str(), (USHORT)flags, dp, result, pExcepInfo, puArgErr);
    }

    return DISP_E_MEMBERNOTFOUND;
}

HRESULT HostDispatchWrapper::InvokeByName_Internal(LPCWSTR memberName, USHORT dispatchFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, UINT* puArgErr)
{
    IHostInvokeTarget* target = GetActiveTarget();
    if (!target) return DISP_E_MEMBERNOTFOUND;

    std::wstring jsonArgs = BuildJsonArgs(*pDispParams);

    BSTR managedResult = nullptr;
    HRESULT hr = target->InvokeByName(memberName, dispatchFlags, jsonArgs.c_str(), &managedResult);
    if (FAILED(hr))
    {
        if (pExcepInfo)
        {
            ZeroMemory(pExcepInfo, sizeof(EXCEPINFO));
            pExcepInfo->bstrDescription = SysAllocString(L"InvokeByName failed.");
        }
        if (managedResult) SysFreeString(managedResult);
        return DISP_E_EXCEPTION;
    }

    if (pVarResult)
    {
        VariantInit(pVarResult);
        pVarResult->vt = VT_BSTR;
        pVarResult->bstrVal = managedResult; // ownership to caller
        managedResult = nullptr;
    }
    if (managedResult) SysFreeString(managedResult);
    return S_OK;
}

IHostInvokeTarget* HostDispatchWrapper::GetActiveTarget()
{
    if (m_activeToken == 0) return nullptr;
    auto it = m_targets.find(m_activeToken);
    return it == m_targets.end() ? nullptr : it->second;
}

HostDispatchWrapper::~HostDispatchWrapper()
{
    for (auto& kv : m_targets)
        kv.second->Release();
    m_targets.clear();
}


