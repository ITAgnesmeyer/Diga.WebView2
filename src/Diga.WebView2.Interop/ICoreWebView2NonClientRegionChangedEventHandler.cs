// Decompiled with JetBrains decompiler
// Type: Diga.WebView2.Interop.ICoreWebView2NonClientRegionChangedEventHandler
// Assembly: Diga.WebView2.Interop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 84D13381-11FC-4303-9DB0-23B921C377B0
// Assembly location: D:\temp\webview2\microsoft.web.webview2.1.0.2849.39\Diga.WebView2.Interop.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Diga.WebView2.Interop
{
  [Guid("4A794E66-AA6C-46BD-93A3-382196837680")]
  [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
  [ComImport]
  public interface ICoreWebView2NonClientRegionChangedEventHandler
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void Invoke(
      [MarshalAs(UnmanagedType.Interface), In] ICoreWebView2CompositionController sender,
      [MarshalAs(UnmanagedType.Interface), In] ICoreWebView2NonClientRegionChangedEventArgs args);
  }
}
