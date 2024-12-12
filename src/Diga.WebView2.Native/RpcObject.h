#pragma once
#include "pch.h" 
#include "IRpcObject.h"
#include <string>

// RpcObject-Klasse
class RpcObject : public IRpcObject
{
private:
    LONG m_refCount;
    BSTR m_id;
    BSTR m_objId;
    BSTR m_varname;
    BSTR m_action;
    BSTR m_param;
    IUnknown* m_item;

public:
    RpcObject()
        : m_refCount(1), m_id(nullptr), m_objId(nullptr), m_varname(nullptr), m_action(nullptr), m_param(nullptr), m_item(nullptr) {
		
    }

    virtual ~RpcObject() {
        if (m_id) SysFreeString(m_id);
        if (m_objId) SysFreeString(m_objId);
        if (m_varname) SysFreeString(m_varname);
        if (m_action) SysFreeString(m_action);
        if (m_param) SysFreeString(m_param);
        if (m_item) m_item->Release();
    }

    // IUnknown-Methoden
    HRESULT STDMETHODCALLTYPE QueryInterface(REFIID riid, void** ppvObject) override {
        if (!ppvObject) return E_POINTER;
        if (riid == IID_IUnknown || riid == IID_IDispatch || riid == IID_IRpcObject) {
            *ppvObject = static_cast<IRpcObject*>(this);
            AddRef();
            return S_OK;
        }
        *ppvObject = nullptr;
        return E_NOINTERFACE;
    }

    ULONG STDMETHODCALLTYPE AddRef() override {
        return InterlockedIncrement(&m_refCount);
    }

    ULONG STDMETHODCALLTYPE Release() override {
        ULONG refCount = InterlockedDecrement(&m_refCount);
        if (refCount == 0) {
            delete this;
        }
        return refCount;
    }

    // IDispatch-Methoden
    HRESULT STDMETHODCALLTYPE GetTypeInfoCount(UINT* pctinfo) override {
        if (!pctinfo) return E_POINTER;
        *pctinfo = 0; // Keine Typinformationen verfügbar
        return S_OK;
    }

    HRESULT STDMETHODCALLTYPE GetTypeInfo(UINT iTInfo, LCID lcid, ITypeInfo** ppTInfo) override {
        return E_NOTIMPL; // Keine Typinformationen implementiert
    }

    HRESULT STDMETHODCALLTYPE GetIDsOfNames(REFIID riid, LPOLESTR* rgszNames, UINT cNames, LCID lcid, DISPID* rgDispId) override {
        return DISP_E_UNKNOWNNAME; // Keine Unterstützung für Namensauflösung
    }

    HRESULT STDMETHODCALLTYPE Invoke(
        DISPID dispIdMember,
        REFIID riid,
        LCID lcid,
        WORD wFlags,
        DISPPARAMS* pDispParams,
        VARIANT* pVarResult,
        EXCEPINFO* pExcepInfo,
        UINT* puArgErr) override
    {
        // Parameterüberprüfung
        if (pDispParams == nullptr) return E_POINTER;

        // Eigenschaften-Dispatch-IDs
        const DISPID DISPID_ID = 1;
        const DISPID DISPID_OBJID = 2;
        const DISPID DISPID_ACTION = 3;
        const DISPID DISPID_PARAM = 4;
		const DISPID DISPID_ITEM = 5;
		const DISPID DISPID_IDFULLNAME = 6;
		const DISPID DISPID_IDNAME = 7;
        const DISPID DISPID_CLONE = 8;

        switch (dispIdMember)
        {
        case DISPID_ID: // Zugriff auf die Eigenschaft 'id'
            if (wFlags & DISPATCH_PROPERTYGET)
            {
                if (pVarResult == nullptr) return E_POINTER;
                VariantInit(pVarResult);
                pVarResult->vt = VT_BSTR;
                pVarResult->bstrVal = SysAllocString(m_id);
                return S_OK;
            }
            else if (wFlags & DISPATCH_PROPERTYPUT)
            {
                if (pDispParams->cArgs != 1 || pDispParams->rgvarg[0].vt != VT_BSTR)
                {
                    return DISP_E_TYPEMISMATCH;
                }
                put_id(pDispParams->rgvarg[0].bstrVal);
                return S_OK;
            }
            break;

        case DISPID_OBJID: // Zugriff auf die Eigenschaft 'objId'
            if (wFlags & DISPATCH_PROPERTYGET)
            {
                if (pVarResult == nullptr) return E_POINTER;
                VariantInit(pVarResult);
                pVarResult->vt = VT_BSTR;
                pVarResult->bstrVal = SysAllocString(m_objId);
                return S_OK;
            }
            else if (wFlags & DISPATCH_PROPERTYPUT)
            {
                if (pDispParams->cArgs != 1 || pDispParams->rgvarg[0].vt != VT_BSTR)
                {
                    return DISP_E_TYPEMISMATCH;
                }
                put_objId(pDispParams->rgvarg[0].bstrVal);
                return S_OK;
            }
            break;

        case DISPID_ACTION: // Zugriff auf die Eigenschaft 'action'
            if (wFlags & DISPATCH_PROPERTYGET)
            {
                if (pVarResult == nullptr) return E_POINTER;
                VariantInit(pVarResult);
                pVarResult->vt = VT_BSTR;
                pVarResult->bstrVal = SysAllocString(m_action);
                return S_OK;
            }
            else if (wFlags & DISPATCH_PROPERTYPUT)
            {
                if (pDispParams->cArgs != 1 || pDispParams->rgvarg[0].vt != VT_BSTR)
                {
                    return DISP_E_TYPEMISMATCH;
                }
                put_action(pDispParams->rgvarg[0].bstrVal);
                return S_OK;
            }
            break;

        case DISPID_PARAM: // Zugriff auf die Eigenschaft 'param'
            if (wFlags & DISPATCH_PROPERTYGET)
            {
                if (pVarResult == nullptr) return E_POINTER;
                VariantInit(pVarResult);
                pVarResult->vt = VT_BSTR;
                pVarResult->bstrVal = SysAllocString(m_param);
                return S_OK;
            }
            else if (wFlags & DISPATCH_PROPERTYPUT)
            {
                if (pDispParams->cArgs != 1 || pDispParams->rgvarg[0].vt != VT_BSTR)
                {
                    return DISP_E_TYPEMISMATCH;
                }
                put_param(pDispParams->rgvarg[0].bstrVal);
                return S_OK;
            }
            break;
        case DISPID_ITEM:
			// Zugriff auf die Eigenschaft 'item'
			if (wFlags & DISPATCH_PROPERTYGET)
			{
				if (pVarResult == nullptr) return E_POINTER;
				VariantInit(pVarResult);
				pVarResult->vt = VT_UNKNOWN;
				pVarResult->punkVal = m_item;
				if (m_item) m_item->AddRef();
				return S_OK;
			}
			else if (wFlags & DISPATCH_PROPERTYPUT)
			{
				if (pDispParams->cArgs != 1 || pDispParams->rgvarg[0].vt != VT_UNKNOWN)
				{
					return DISP_E_TYPEMISMATCH;
				}
				put_item(pDispParams->rgvarg[0].punkVal);
				return S_OK;
			}
			break;
		case DISPID_IDFULLNAME: // Zugriff auf die Eigenschaft 'idFullName'
			if (wFlags & DISPATCH_PROPERTYGET)
			{
				if (pVarResult == nullptr) return E_POINTER;
				VariantInit(pVarResult);
				pVarResult->vt = VT_BSTR;
				get_idFullName(&pVarResult->bstrVal);
				return S_OK;
			}
			break;
		case DISPID_IDNAME: // Zugriff auf die Eigenschaft 'idName'
			if (wFlags & DISPATCH_PROPERTYGET)
			{
				if (pVarResult == nullptr) return E_POINTER;
				VariantInit(pVarResult);
				pVarResult->vt = VT_BSTR;
				get_idName(&pVarResult->bstrVal);
				return S_OK;
			}
			break;
        case DISPID_CLONE: // Aufruf der Methode 'Clone'
            if (wFlags & DISPATCH_METHOD)
            {
                if (pVarResult == nullptr) return E_POINTER;
                IRpcObject* clone = nullptr;
                Clone(&clone);
                VariantInit(pVarResult);
                pVarResult->vt = VT_UNKNOWN;
                pVarResult->punkVal = clone;
                return S_OK;
            }
            break;

        default:
            return DISP_E_MEMBERNOTFOUND;
        }

        return DISP_E_MEMBERNOTFOUND;
    }

    // IRpcObject-Methoden
    HRESULT STDMETHODCALLTYPE get_id(BSTR* pValue) override {
        if (!pValue) return E_POINTER;
        *pValue = SysAllocString(m_id);
        return S_OK;
    }

    HRESULT STDMETHODCALLTYPE put_id(BSTR value) override {
        if (m_id) SysFreeString(m_id);
        m_id = SysAllocString(value);
        return S_OK;
    }

	HRESULT STDMETHODCALLTYPE get_objId(BSTR* pValue) override {
		if (!pValue) return E_POINTER;
		*pValue = SysAllocString(m_objId);
		return S_OK;
	}

	HRESULT STDMETHODCALLTYPE put_objId(BSTR value) override {
		if (m_objId) SysFreeString(m_objId);
		m_objId = SysAllocString(value);
		return S_OK;
	}

	HRESULT STDMETHODCALLTYPE get_varname(BSTR* pValue) override {
		if (!pValue) return E_POINTER;
		*pValue = SysAllocString(m_varname);
		return S_OK;
	}

	HRESULT STDMETHODCALLTYPE put_varname(BSTR value) override {
		if (m_varname) SysFreeString(m_varname);
		m_varname = SysAllocString(value);
		return S_OK;
	}

	HRESULT STDMETHODCALLTYPE get_action(BSTR* pValue) override {
		if (!pValue) return E_POINTER;
		*pValue = SysAllocString(m_action);
		return S_OK;
	}

	HRESULT STDMETHODCALLTYPE put_action(BSTR value) override {
		if (m_action) SysFreeString(m_action);
		m_action = SysAllocString(value);
		return S_OK;
	}

	HRESULT STDMETHODCALLTYPE get_param(BSTR* pValue) override {
		if (!pValue) return E_POINTER;
		*pValue = SysAllocString(m_param);
		return S_OK;
	}

	HRESULT STDMETHODCALLTYPE put_param(BSTR value) override {
		if (m_param) SysFreeString(m_param);
		m_param = SysAllocString(value);
		return S_OK;
	}

	HRESULT STDMETHODCALLTYPE get_item(IUnknown** pValue) override {
		if (!pValue) return E_POINTER;
		*pValue = m_item;
        
		if (m_item) m_item->AddRef();
		return S_OK;
	}

	HRESULT STDMETHODCALLTYPE put_item(IUnknown* value) override {
		if (m_item) m_item->Release();
		m_item = value;
		if (m_item) m_item->AddRef();
		return S_OK;
	}

	HRESULT STDMETHODCALLTYPE get_idFullName(BSTR* pValue) override {
        if (pValue == nullptr)
        {
            return E_POINTER;
        }

        // Überprüfen, ob `m_id` gesetzt ist
        if (m_id == nullptr)
        {
            *pValue = SysAllocString(L"");
            return S_OK;
        }

        // Konvertiere BSTR `m_id` in einen std::wstring
        std::wstring id(m_id);

        // Ersetze alle `-` durch `_`
        size_t pos = 0;
        while ((pos = id.find(L"-", pos)) != std::wstring::npos)
        {
            id.replace(pos, 1, L"_");
            pos += 1; // Gehe zum nächsten Zeichen
        }

        // Erstelle den vollständigen Namen
        std::wstring fullName = L"window.diga._HEAP_" + id;

        // Konvertiere zurück in einen BSTR
        *pValue = SysAllocString(fullName.c_str());
        return S_OK;
	}

	HRESULT STDMETHODCALLTYPE get_idName(BSTR* pValue) override {
        if (pValue == nullptr)
        {
            return E_POINTER;
        }

        // Überprüfen, ob `m_id` gesetzt ist
        if (m_id == nullptr)
        {
            *pValue = SysAllocString(L"");
            return S_OK;
        }

        // Konvertiere BSTR `m_id` in einen std::wstring
        std::wstring id(m_id);

        // Ersetze alle `-` durch `_`
        size_t pos = 0;
        while ((pos = id.find(L"-", pos)) != std::wstring::npos)
        {
            id.replace(pos, 1, L"_");
            pos += 1; // Gehe zum nächsten Zeichen
        }

        // Erstelle den `idName`
        std::wstring idName = L"_HEAP_" + id;

        // Konvertiere zurück in einen BSTR
        *pValue = SysAllocString(idName.c_str());
        return S_OK;
	}





    HRESULT STDMETHODCALLTYPE Clone(IRpcObject** ppClone) override {
        if (!ppClone) return E_POINTER;
        RpcObject* clone = new RpcObject();
        clone->put_id(m_id);
		clone->put_objId(m_objId);
		clone->put_varname(m_varname);
		clone->put_action(m_action);
		clone->put_param(m_param);
		clone->put_item(m_item);
        *ppClone = clone;
        return S_OK;
    }

    // Andere Getter und Setter folgen einem ähnlichen Muster...
};