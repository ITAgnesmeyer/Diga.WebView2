// Decompiled with JetBrains decompiler
// Type: WebView2.IWebView2DocumentTitleChangedEventHandler
// Assembly: WebView2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5F0D75F7-60BF-43BB-8231-ACD9063B7411
// Assembly location: O:\macos\WebView2.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Diga.WebView2.Interop
{
  [Guid("E190F4F4-7C94-4CB3-BA4D-DDCDA7AC7693")]
  [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
  [ComImport]
  public interface IWebView2DocumentTitleChangedEventHandler
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void Invoke([MarshalAs(UnmanagedType.Interface), In] IWebView2WebView3 webview, [MarshalAs(UnmanagedType.IUnknown), In] object args);
  }
}
