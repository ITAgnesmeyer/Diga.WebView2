// Decompiled with JetBrains decompiler
// Type: WebView2.ICoreWebView2DevToolsProtocolEventReceivedEventHandler
// Assembly: WebView2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 4848E93B-2D8E-488A-B413-2977821823D1
// Assembly location: O:\webview2\V9515\WebView2.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Diga.WebView2.Interop
{
  [Guid("8E1DED79-A40B-4271-8BE6-57640C167F4A")]
  [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
  [ComImport]
  public interface ICoreWebView2DevToolsProtocolEventReceivedEventHandler
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void Invoke(
      [MarshalAs(UnmanagedType.Interface), In] ICoreWebView2 sender,
      [MarshalAs(UnmanagedType.Interface), In] ICoreWebView2DevToolsProtocolEventReceivedEventArgs args);
  }
}
