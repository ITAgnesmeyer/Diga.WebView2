// Decompiled with JetBrains decompiler
// Type: WebView2.IWebView2Environment
// Assembly: WebView2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5F0D75F7-60BF-43BB-8231-ACD9063B7411
// Assembly location: O:\macos\WebView2.dll

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Diga.WebView2.Interop
{
  [Guid("33D17ECE-82FA-47D9-8978-CD17FF3C3CC6")]
  [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
  [ComImport]
  public interface IWebView2Environment
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void CreateWebView(
      IntPtr parentWindow,
      [MarshalAs(UnmanagedType.Interface)] IWebView2CreateWebViewCompletedHandler handler);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void CreateWebResourceResponse(
      [MarshalAs(UnmanagedType.Interface)] IStream Content,
      int StatusCode,
      [MarshalAs(UnmanagedType.LPWStr)] string ReasonPhrase,
      [MarshalAs(UnmanagedType.LPWStr)] string Headers,
      [MarshalAs(UnmanagedType.Interface)] ref IWebView2WebResourceResponse Response);
  }
}
