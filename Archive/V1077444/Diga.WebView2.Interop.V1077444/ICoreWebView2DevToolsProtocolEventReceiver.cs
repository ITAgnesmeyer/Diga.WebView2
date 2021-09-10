// Decompiled with JetBrains decompiler
// Type: Diga.WebView2.Interop.ICoreWebView2DevToolsProtocolEventReceiver
// Assembly: Diga.WebView2.Interop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: AAF9543A-0FE1-46E7-BB2C-D24EA0535C0F
// Assembly location: O:\webview2\v1077444\Diga.WebView2.Interop.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Diga.WebView2.Interop
{
  [Guid("B32CA51A-8371-45E9-9317-AF021D080367")]
  [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
  [ComImport]
  public interface ICoreWebView2DevToolsProtocolEventReceiver
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void add_DevToolsProtocolEventReceived(
      [MarshalAs(UnmanagedType.Interface), In] ICoreWebView2DevToolsProtocolEventReceivedEventHandler handler,
      out EventRegistrationToken token);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void remove_DevToolsProtocolEventReceived([In] EventRegistrationToken token);
  }
}
