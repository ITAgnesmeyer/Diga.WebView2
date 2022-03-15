// Decompiled with JetBrains decompiler
// Type: Diga.WebView2.Interop.ICoreWebView2BasicAuthenticationRequestedEventHandler
// Assembly: Diga.WebView2.Interop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 1645D9E8-6474-401A-8219-075683886512
// Assembly location: O:\webview2\V10115038\Diga.WebView2.Interop.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Diga.WebView2.Interop
{
  [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
  [Guid("58B4D6C2-18D4-497E-B39B-9A96533FA278")]
  [ComImport]
  public interface ICoreWebView2BasicAuthenticationRequestedEventHandler
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void Invoke(
      [MarshalAs(UnmanagedType.Interface), In] ICoreWebView2 sender,
      [MarshalAs(UnmanagedType.Interface), In] ICoreWebView2BasicAuthenticationRequestedEventArgs args);
  }
}
