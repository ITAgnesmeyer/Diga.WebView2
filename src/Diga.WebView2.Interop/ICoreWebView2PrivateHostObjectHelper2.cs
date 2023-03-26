// Decompiled with JetBrains decompiler
// Type: Diga.WebView2.Interop.ICoreWebView2Profile
// Assembly: Diga.WebView2.Interop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 7E16C74E-5A5B-41DB-9F54-62C7717B4DB7
// Assembly location: O:\webview2\V10121039\Diga.WebView2.Interop.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Diga.WebView2.Interop
{
    [Guid("A791A659-3AD9-41C3-9C7E-768FCC233666")]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    [ComImport]
    public interface ICoreWebView2PrivateHostObjectHelper2
    {
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        int IsAsyncMethod([MarshalAs(UnmanagedType.Struct), In] ref object @object, [MarshalAs(UnmanagedType.LPWStr), In] string methodName, [In] int parameterCount);

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void SetAsyncMethodContinuation(
          [MarshalAs(UnmanagedType.Struct), In] ref object @object,
          [MarshalAs(UnmanagedType.LPWStr), In] string methodName,
          [In] int parameterCount,
          [MarshalAs(UnmanagedType.Struct), In] ref object methodResult,
          [MarshalAs(UnmanagedType.Interface), In] ICoreWebView2PrivateHostObjectAsyncMethodContinuation continuation);
    }
}
