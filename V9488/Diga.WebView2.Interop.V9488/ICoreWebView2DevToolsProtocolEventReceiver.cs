// Decompiled with JetBrains decompiler
// Type: Diga.WebView2.Interop.ICoreWebView2DevToolsProtocolEventReceiver
// Assembly: WebView2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: B5F140DB-135D-4E8A-B1A2-1275CE2FD56A
// Assembly location: O:\webview2\webview2packages\V9488\WebView2.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Diga.WebView2.Interop
{
  [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
  [Guid("FE59C48C-540C-4A3C-8898-8E1602E0055D")]
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
