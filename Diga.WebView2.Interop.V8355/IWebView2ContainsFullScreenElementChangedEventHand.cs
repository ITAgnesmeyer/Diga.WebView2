// Decompiled with JetBrains decompiler
// Type: WebView2.IWebView2ContainsFullScreenElementChangedEventHandler
// Assembly: WebView2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5F0D75F7-60BF-43BB-8231-ACD9063B7411
// Assembly location: O:\macos\WebView2.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Diga.WebView2.Interop
{
  [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
  [Guid("37CF6A21-4B0C-41B6-81A6-C85C0D0A7543")]
  [ComImport]
  public interface IWebView2ContainsFullScreenElementChangedEventHandler
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void Invoke([MarshalAs(UnmanagedType.Interface), In] IWebView2WebView5 webview, [MarshalAs(UnmanagedType.IUnknown), In] object args);
  }
}
