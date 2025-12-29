#pragma once
#include "pch.h"
#include "HostDispatchWrapper.h"


class CallableDispatch final : public IDispatch
{
public:
    CallableDispatch(HostDispatchWrapper* owner, std::wstring memberName)
        : m_ref(1), m_owner(owner), m_member(std::move(memberName))
    {
        if (m_owner) m_owner->AddRef();
    }

    // IUnknown
    HRESULT STDMETHODCALLTYPE QueryInterface(REFIID riid, void** ppv) override
    {
        if (!ppv) return E_POINTER;
        *ppv = nullptr;
        if (riid == IID_IUnknown || riid == IID_IDispatch)
        {
            *ppv = static_cast<IDispatch*>(this);
            AddRef();
            return S_OK;
        }
        return E_NOINTERFACE;
    }

    ULONG STDMETHODCALLTYPE AddRef() override
    {
        return (ULONG)InterlockedIncrement(&m_ref);
    }

    ULONG STDMETHODCALLTYPE Release() override
    {
        ULONG rc = (ULONG)InterlockedDecrement(&m_ref);
        if (rc == 0) delete this;
        return rc;
    }

    // IDispatch (minimal)
    HRESULT STDMETHODCALLTYPE GetTypeInfoCount(UINT* pctinfo) override
    {
        if (!pctinfo) return E_POINTER;
        *pctinfo = 0;
        return S_OK;
    }

    HRESULT STDMETHODCALLTYPE GetTypeInfo(UINT, LCID, ITypeInfo**) override
    {
        return DISP_E_BADINDEX;
    }

    HRESULT STDMETHODCALLTYPE GetIDsOfNames(REFIID, LPOLESTR*, UINT, LCID, DISPID*) override
    {
        // Callable bekommt direkt Invoke(DISPATCH_METHOD) ab.
        return DISP_E_UNKNOWNNAME;
    }

    HRESULT STDMETHODCALLTYPE Invoke(
        DISPID /*dispidMember*/,
        REFIID,
        LCID,
        WORD wFlags,
        DISPPARAMS* pDispParams,
        VARIANT* pVarResult,
        EXCEPINFO* pExcepInfo,
        UINT* puArgErr) override;

private:
    ~CallableDispatch() 
    {
        if (m_owner) m_owner->Release();
    }

    LONG m_ref;
    HostDispatchWrapper* m_owner;
    std::wstring m_member;
};