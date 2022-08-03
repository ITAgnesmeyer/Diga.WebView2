// Decompiled with JetBrains decompiler
// Type: Diga.WebView2.Interop.ICoreWebView2ServerCertificateErrorDetectedEventHandler
// Assembly: Diga.WebView2.Interop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 78C6AA08-CDE2-4921-BDB5-AF4A988C5D7D
// Assembly location: O:\webview2\microsoft.web.webview2.1.0.1264.42\Diga.WebView2.Interop.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Diga.WebView2.Interop
{
  [Guid("969B3A26-D85E-4795-8199-FEF57344DA22")]
  [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
  [ComImport]
  public interface ICoreWebView2ServerCertificateErrorDetectedEventHandler
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void Invoke(
      [MarshalAs(UnmanagedType.Interface), In] ICoreWebView2 sender,
      [MarshalAs(UnmanagedType.Interface), In] ICoreWebView2ServerCertificateErrorDetectedEventArgs args);
  }
}
