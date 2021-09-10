// Decompiled with JetBrains decompiler
// Type: Diga.WebView2.Interop.ICoreWebView2DevToolsProtocolEventReceiver
// Assembly: Diga.WebView2.Interop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 1E8B0323-528E-4C9C-8FF8-A486637C87E1
// Assembly location: O:\webview2\V1096133\Diga.WebView2.Interop.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Diga.WebView2.Interop
{
  [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
  [Guid("B32CA51A-8371-45E9-9317-AF021D080367")]
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
