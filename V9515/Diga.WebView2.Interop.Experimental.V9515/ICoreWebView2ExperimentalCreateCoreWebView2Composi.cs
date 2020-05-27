// Decompiled with JetBrains decompiler
// Type: WebView2Experimental.ICoreWebView2ExperimentalCreateCoreWebView2CompositionControllerCompletedHandler
// Assembly: WebView2Experimental, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 2FA7ABB2-ECD1-41D1-96C7-3EF46A31C524
// Assembly location: O:\webview2\V9515\WebView2Experimental.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Diga.WebView2.Interop.Experimental
{
  [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
  [Guid("F8089361-D9C5-4A3C-B7FD-3633E28FFF39")]
  [ComImport]
  public interface ICoreWebView2ExperimentalCreateCoreWebView2CompositionControllerCompletedHandler
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void Invoke(
      [MarshalAs(UnmanagedType.Error)] int result,
      [MarshalAs(UnmanagedType.Interface)] ICoreWebView2ExperimentalCompositionController webView);
  }
}
