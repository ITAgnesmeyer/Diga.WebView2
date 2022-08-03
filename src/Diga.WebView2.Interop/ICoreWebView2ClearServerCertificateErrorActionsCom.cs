// Decompiled with JetBrains decompiler
// Type: Diga.WebView2.Interop.ICoreWebView2ClearServerCertificateErrorActionsCompletedHandler
// Assembly: Diga.WebView2.Interop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 78C6AA08-CDE2-4921-BDB5-AF4A988C5D7D
// Assembly location: O:\webview2\microsoft.web.webview2.1.0.1264.42\Diga.WebView2.Interop.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Diga.WebView2.Interop
{
  [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
  [Guid("3B40AAC6-ACFE-4FFD-8211-F607B96E2D5B")]
  [ComImport]
  public interface ICoreWebView2ClearServerCertificateErrorActionsCompletedHandler
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void Invoke([MarshalAs(UnmanagedType.Error), In] int errorCode);
  }
}
