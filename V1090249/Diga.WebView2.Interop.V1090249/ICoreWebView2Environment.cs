// Decompiled with JetBrains decompiler
// Type: Diga.WebView2.Interop.ICoreWebView2Environment
// Assembly: Diga.WebView2.Interop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: AAF9543A-0FE1-46E7-BB2C-D24EA0535C0F
// Assembly location: O:\webview2\v1077444\Diga.WebView2.Interop.dll

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;

namespace Diga.WebView2.Interop
{
  [Guid("B96D755E-0319-4E92-A296-23436F46A1FC")]
  [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
  [ComImport]
  public interface ICoreWebView2Environment
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void CreateCoreWebView2Controller(
      [ComAliasName("Diga.WebView2.Interop.wireHWND")] IntPtr ParentWindow,
      [MarshalAs(UnmanagedType.Interface)] ICoreWebView2CreateCoreWebView2ControllerCompletedHandler handler);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.Interface)]
    ICoreWebView2WebResourceResponse CreateWebResourceResponse(
      [MarshalAs(UnmanagedType.Interface), In] IStream Content,
      [In] int StatusCode,
      [MarshalAs(UnmanagedType.LPWStr), In] string ReasonPhrase,
      [MarshalAs(UnmanagedType.LPWStr), In] string Headers);

    [DispId(1610678274)]
    string BrowserVersionString { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.LPWStr)] get; }

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void add_NewBrowserVersionAvailable(
      [MarshalAs(UnmanagedType.Interface), In] ICoreWebView2NewBrowserVersionAvailableEventHandler eventHandler,
      out EventRegistrationToken token);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void remove_NewBrowserVersionAvailable([In] EventRegistrationToken token);
  }
}
