// Decompiled with JetBrains decompiler
// Type: WebView2.IWebView2Environment2
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
  [Guid("013124F3-02FD-4DFF-8911-06016AF1E3EE")]
  [ComImport]
  public interface IWebView2Environment2 : IWebView2Environment
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
    string BrowserVersionInfo { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.LPWStr)] get; }
  }
}
