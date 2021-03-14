using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;

namespace Diga.WebView2.Wrapper.Types
{

#pragma warning disable 618

    [Guid("00020400-0000-0000-C000-000000000046")]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    [ComImport]
    public interface IDispatch
    {
        int GetTypeInfoCount();

        [return: MarshalAs(UnmanagedType.Interface)]
        ITypeInfo GetTypeInfo([MarshalAs(UnmanagedType.U4), In] int iTInfo, [MarshalAs(UnmanagedType.U4), In] int lcid);

        [MethodImpl(MethodImplOptions.PreserveSig)]
        int GetIDsOfNames([In] ref Guid riid, 
            [MarshalAs(UnmanagedType.LPArray), In] string[] rgszNames, 
            [MarshalAs(UnmanagedType.U4), In] int cNames, 
            [MarshalAs(UnmanagedType.U4), In] int lcid, 
            [MarshalAs(UnmanagedType.LPArray), Out] int[] rgDispId);

        [MethodImpl(MethodImplOptions.PreserveSig)]
        int Invoke(
            int dispIdMember,
            [In] ref Guid riid,
            [MarshalAs(UnmanagedType.U4), In] int lcid,
            [MarshalAs(UnmanagedType.U4), In] int dwFlags,
            [In, Out] DispParams pDispParams,
            [MarshalAs(UnmanagedType.LPArray), Out] object[] pVarResult,
            [In, Out] ExcepInfo pExcepInfo,
            [MarshalAs(UnmanagedType.LPArray), Out] IntPtr[] pArgErr);
    }
}