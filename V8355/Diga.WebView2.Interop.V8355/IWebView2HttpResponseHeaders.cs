// Decompiled with JetBrains decompiler
// Type: WebView2.IWebView2HttpResponseHeaders
// Assembly: WebView2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5F0D75F7-60BF-43BB-8231-ACD9063B7411
// Assembly location: O:\macos\WebView2.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Diga.WebView2.Interop
{
  [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
  [Guid("6D1A13A6-C677-41AA-852F-827B53F35301")]
  [ComImport]
  public interface IWebView2HttpResponseHeaders
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void AppendHeader([MarshalAs(UnmanagedType.LPWStr), In] string name, [MarshalAs(UnmanagedType.LPWStr), In] string value);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    int Contains([MarshalAs(UnmanagedType.LPWStr), In] string name);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void GetHeaders(
      [MarshalAs(UnmanagedType.LPWStr), In] string name,
      [MarshalAs(UnmanagedType.Interface)] out IWebView2HttpHeadersCollectionIterator iterator);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void GetIterator(
      [MarshalAs(UnmanagedType.Interface)] out IWebView2HttpHeadersCollectionIterator iterator);
  }
}
