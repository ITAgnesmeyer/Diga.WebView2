// Decompiled with JetBrains decompiler
// Type: WebView2.IWebView2Environment3
// Assembly: WebView2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5F0D75F7-60BF-43BB-8231-ACD9063B7411
// Assembly location: O:\macos\WebView2.dll

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;

namespace Diga.WebView2.Interop
{
  [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
  [Guid("D82C6A26-370F-4084-8149-C08FF1598C9B")]
  [ComImport]
  public interface IWebView2Environment3 : IWebView2Environment2
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    new void CreateWebView(
      IntPtr parentWindow,
      [MarshalAs(UnmanagedType.Interface)] IWebView2CreateWebViewCompletedHandler handler);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    new void CreateWebResourceResponse(
      [MarshalAs(UnmanagedType.Interface)] IStream Content,
      int StatusCode,
      [MarshalAs(UnmanagedType.LPWStr)] string ReasonPhrase,
      [MarshalAs(UnmanagedType.LPWStr)] string Headers,
      [MarshalAs(UnmanagedType.Interface)] ref IWebView2WebResourceResponse Response);

    [DispId(1610743808)]
    new string BrowserVersionInfo { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.LPWStr)] get; }

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void add_NewVersionAvailable(
      [MarshalAs(UnmanagedType.Interface), In] IWebView2NewVersionAvailableEventHandler eventHandler,
      out EventRegistrationToken token);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void remove_NewVersionAvailable([In] EventRegistrationToken token);
  }
}
