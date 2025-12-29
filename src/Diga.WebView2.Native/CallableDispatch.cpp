#include "pch.h"
#include "CallableDispatch.h"

HRESULT __stdcall CallableDispatch::Invoke(DISPID, REFIID, LCID, WORD wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, UINT* puArgErr)
{
    if (!(wFlags & DISPATCH_METHOD))
        return DISP_E_MEMBERNOTFOUND;

    return m_owner->InvokeByName_Internal(
        m_member.c_str(),
        (USHORT)wFlags,
        pDispParams,
        pVarResult,
        pExcepInfo,
        puArgErr);
}
