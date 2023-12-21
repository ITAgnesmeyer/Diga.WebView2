// Decompiled with JetBrains decompiler
// Type: Diga.WebView2.Interop.ICoreWebView2ProfileAddBrowserExtensionCompletedHandler
// Assembly: Diga.WebView2.Interop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E890F85C-2747-4676-BEB3-566B145AA00D
// Assembly location: F:\temp\microsoft.web.webview2.1.0.2210.55\Diga.WebView2.Interop.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Diga.WebView2.Interop
{
  [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
  [Guid("DF1AAB27-82B9-4AB6-AAE8-017A49398C14")]
  [ComImport]
  public interface ICoreWebView2ProfileAddBrowserExtensionCompletedHandler
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void Invoke([MarshalAs(UnmanagedType.Error), In] int errorCode, [MarshalAs(UnmanagedType.Interface), In] ICoreWebView2BrowserExtension extension);
  }
}
