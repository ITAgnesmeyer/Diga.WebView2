// Decompiled with JetBrains decompiler
// Type: WebView2Experimental.ICoreWebView2ExperimentalCursorChangedEventHandler
// Assembly: WebView2Experimental, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 2FA7ABB2-ECD1-41D1-96C7-3EF46A31C524
// Assembly location: O:\webview2\V9515\WebView2Experimental.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Diga.WebView2.Interop.Experimental
{
  [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
  [Guid("8F4840F1-9364-4629-AE12-4D21DFD69306")]
  [ComImport]
  public interface ICoreWebView2ExperimentalCursorChangedEventHandler
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void Invoke(
      [MarshalAs(UnmanagedType.Interface), In] ICoreWebView2ExperimentalCompositionController sender,
      [MarshalAs(UnmanagedType.IUnknown), In] object args);
  }
}
