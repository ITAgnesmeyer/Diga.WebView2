#pragma once
#include <windows.h>
//#include <initguid.h>
#include <comdef.h>

//EXTERN_C const IID IID_IRpcObject;
EXTERN_C const IID __declspec(selectany) IID_IRpcObject = { 0x492ab1ff, 0xff27, 0x4a23,{ 0x93, 0xa8, 0x54, 0x0a, 0x4b, 0x9d, 0xac, 0x37 } };

// GUIDs definieren
// {492AB1FF-FF27-4A23-93A8-540A4B9DAC37}
//DEFINE_GUID(IID_IRpcObject,
//    0x492ab1ff, 0xff27, 0x4a23, 0x93, 0xa8, 0x54, 0x0a, 0x4b, 0x9d, 0xac, 0x37);

// IRpcObject-Schnittstelle
interface IRpcObject : public IDispatch
{
    virtual HRESULT STDMETHODCALLTYPE get_id(BSTR * pValue) = 0;
    virtual HRESULT STDMETHODCALLTYPE put_id(BSTR value) = 0;
    virtual HRESULT STDMETHODCALLTYPE get_objId(BSTR* pValue) = 0;
    virtual HRESULT STDMETHODCALLTYPE put_objId(BSTR value) = 0;
    virtual HRESULT STDMETHODCALLTYPE get_varname(BSTR* pValue) = 0;
    virtual HRESULT STDMETHODCALLTYPE put_varname(BSTR value) = 0;
    virtual HRESULT STDMETHODCALLTYPE get_action(BSTR* pValue) = 0;
    virtual HRESULT STDMETHODCALLTYPE put_action(BSTR value) = 0;
    virtual HRESULT STDMETHODCALLTYPE get_param(BSTR* pValue) = 0;
    virtual HRESULT STDMETHODCALLTYPE put_param(BSTR value) = 0;
    virtual HRESULT STDMETHODCALLTYPE get_item(IUnknown** pValue) = 0;
    virtual HRESULT STDMETHODCALLTYPE put_item(IUnknown* value) = 0;
    virtual HRESULT STDMETHODCALLTYPE get_idFullName(BSTR* pValue) = 0;
    virtual HRESULT STDMETHODCALLTYPE get_idName(BSTR* pValue) = 0;
    virtual HRESULT STDMETHODCALLTYPE Clone(IRpcObject** ppClone) = 0;
};
