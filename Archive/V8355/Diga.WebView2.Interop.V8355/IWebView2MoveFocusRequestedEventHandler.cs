// Decompiled with JetBrains decompiler
// Type: WebView2.IWebView2MoveFocusRequestedEventHandler
// Assembly: WebView2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5F0D75F7-60BF-43BB-8231-ACD9063B7411
// Assembly location: O:\macos\WebView2.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Diga.WebView2.Interop
{
  [Guid("F3A49DD0-EA49-469C-8B7A-8CC5E8E4EF27")]
  [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
  [ComImport]
  public interface IWebView2MoveFocusRequestedEventHandler
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void Invoke([MarshalAs(UnmanagedType.Interface), In] IWebView2WebView webview, [MarshalAs(UnmanagedType.Interface), In] IWebView2MoveFocusRequestedEventArgs args);
  }
}
