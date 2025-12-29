#pragma once
#include "pch.h"

#include <windows.h>
#include <oleauto.h>
#include <EventToken.h>
#ifndef INITGUID
#define INITGUID
#endif
#include <guiddef.h>

// ================= GUIDS =================
// MUSS zu den C# [Guid(...)] Attributen passen!

// {B952EA6F-C1BA-4A0E-8B8D-446234D8D23A}
DEFINE_GUID(IID_IHostInvokeTarget,
    0xb952ea6f, 0xc1ba, 0x4a0e, 0x8b, 0x8d, 0x44, 0x62, 0x34, 0xd8, 0xd2, 0x3a);

// {6205965B-1A33-4AF8-9FEE-FD2B1A9FBE49}
DEFINE_GUID(IID_IHostWrapper,
    0x6205965b, 0x1a33, 0x4af8, 0x9f, 0xee, 0xfd, 0x2b, 0x1a, 0x9f, 0xbe, 0x49);
// ========================================


//// C# struct EventRegistrationToken
//struct EventRegistrationToken
//{
//    LONGLONG value;
//};


// ---------- IHostInvokeTarget (C# Callback) ----------
struct IHostInvokeTarget : public IUnknown
{
    virtual HRESULT STDMETHODCALLTYPE InvokeByName(
        LPCWSTR memberName,
        USHORT dispatchFlags,
        LPCWSTR jsonArgs,
        BSTR* bstrResult) = 0;
};


// ---------- IHostWrapper (C# Steuerung) ----------
struct IHostWrapper : public IUnknown
{
    virtual HRESULT STDMETHODCALLTYPE add_HostInvokeTarget(
        IHostInvokeTarget* target,
        EventRegistrationToken* token) = 0;

    virtual HRESULT STDMETHODCALLTYPE remove_HostInvokeTarget(
        EventRegistrationToken token) = 0;
};


class HostDispatchWrapper final : public IHostWrapper, public IDispatch
{
public:
    HostDispatchWrapper() : m_ref(1) {}

    // IUnknown
    HRESULT STDMETHODCALLTYPE QueryInterface(REFIID riid, void** ppv) override;
    ULONG STDMETHODCALLTYPE AddRef() override;
    ULONG STDMETHODCALLTYPE Release() override;

    // IHostWrapper
    HRESULT STDMETHODCALLTYPE add_HostInvokeTarget(
        IHostInvokeTarget* target,
        EventRegistrationToken* token) override;

    HRESULT STDMETHODCALLTYPE remove_HostInvokeTarget(
        EventRegistrationToken token) override;

    // IDispatch
    HRESULT STDMETHODCALLTYPE GetTypeInfoCount(UINT* pctinfo) override;
    HRESULT STDMETHODCALLTYPE GetTypeInfo(UINT, LCID, ITypeInfo**) override;
    HRESULT STDMETHODCALLTYPE GetIDsOfNames(
        REFIID, LPOLESTR*, UINT, LCID, DISPID*) override;
    HRESULT STDMETHODCALLTYPE Invoke(
        DISPID, REFIID, LCID, WORD, DISPPARAMS*,
        VARIANT*, EXCEPINFO*, UINT*) override;

    HRESULT InvokeByName_Internal(
        LPCWSTR memberName,
        USHORT dispatchFlags,
        DISPPARAMS* pDispParams,
        VARIANT* pVarResult,
        EXCEPINFO* pExcepInfo,
        UINT* puArgErr);

private:
    ~HostDispatchWrapper();

    IHostInvokeTarget* GetActiveTarget();

    LONG m_ref;
    std::atomic<LONGLONG> m_nextToken{ 0 };
    std::atomic<DISPID>  m_nextDispid{ 100 };

    LONGLONG m_activeToken = 0;
    std::unordered_map<LONGLONG, IHostInvokeTarget*> m_targets;
    std::unordered_map<std::wstring, DISPID> m_nameToDispid;
    std::unordered_map<DISPID, std::wstring> m_dispidToName;
};




//// ---------- Factory ----------
//extern "C" __declspec(dllexport)
//HRESULT __stdcall CreateHostDispatchWrapper(IHostWrapper** wrapper);
//#pragma once
