// Decompiled with JetBrains decompiler
// Type: Diga.WebView2.Interop.ICoreWebView2Environment6
// Assembly: Diga.WebView2.Interop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 768C7F4D-BDF8-4A7A-A16F-3879CF339892
// Assembly location: O:\webview2\V10102030\Diga.WebView2.Interop.dll

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;

namespace Diga.WebView2.Interop
{
  [Guid("E59EE362-ACBD-4857-9A8E-D3644D9459A9")]
  [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
  [ComImport]
  public interface ICoreWebView2Environment6 : ICoreWebView2Environment5
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    new void CreateCoreWebView2Controller(
      IntPtr ParentWindow,
      [MarshalAs(UnmanagedType.Interface)] ICoreWebView2CreateCoreWebView2ControllerCompletedHandler handler);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.Interface)]
    new ICoreWebView2WebResourceResponse CreateWebResourceResponse(
      [MarshalAs(UnmanagedType.Interface), In] IStream Content,
      [In] int StatusCode,
      [MarshalAs(UnmanagedType.LPWStr), In] string ReasonPhrase,
      [MarshalAs(UnmanagedType.LPWStr), In] string Headers);

    [DispId(1610678274)]
    new string BrowserVersionString { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.LPWStr)] get; }

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    new void add_NewBrowserVersionAvailable(
      [MarshalAs(UnmanagedType.Interface), In] ICoreWebView2NewBrowserVersionAvailableEventHandler eventHandler,
      out EventRegistrationToken token);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    new void remove_NewBrowserVersionAvailable([In] EventRegistrationToken token);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.Interface)]
    new ICoreWebView2WebResourceRequest CreateWebResourceRequest(
      [MarshalAs(UnmanagedType.LPWStr), In] string uri,
      [MarshalAs(UnmanagedType.LPWStr), In] string Method,
      [MarshalAs(UnmanagedType.Interface), In] IStream postData,
      [MarshalAs(UnmanagedType.LPWStr), In] string Headers);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    new void CreateCoreWebView2CompositionController(
      IntPtr ParentWindow,
      [MarshalAs(UnmanagedType.Interface)] ICoreWebView2CreateCoreWebView2CompositionControllerCompletedHandler handler);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.Interface)]
    new ICoreWebView2PointerInfo CreateCoreWebView2PointerInfo();

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.IUnknown)]
    new object GetProviderForHwnd(IntPtr hwnd);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    new void add_BrowserProcessExited(
      [MarshalAs(UnmanagedType.Interface), In] ICoreWebView2BrowserProcessExitedEventHandler eventHandler,
      out EventRegistrationToken token);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    new void remove_BrowserProcessExited([In] EventRegistrationToken token);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.Interface)]
    ICoreWebView2PrintSettings CreatePrintSettings();
  }
}
