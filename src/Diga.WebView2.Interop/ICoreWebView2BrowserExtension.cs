// Decompiled with JetBrains decompiler
// Type: Diga.WebView2.Interop.ICoreWebView2BrowserExtension
// Assembly: Diga.WebView2.Interop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E890F85C-2747-4676-BEB3-566B145AA00D
// Assembly location: F:\temp\microsoft.web.webview2.1.0.2210.55\Diga.WebView2.Interop.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Diga.WebView2.Interop
{
  [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
  [Guid("7EF7FFA0-FAC5-462C-B189-3D9EDBE575DA")]
  [ComImport]
  public interface ICoreWebView2BrowserExtension
  {
    [DispId(1610678272)]
    string id { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.LPWStr)] get; }

    [DispId(1610678273)]
    string name { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.LPWStr)] get; }

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void Remove(
      [MarshalAs(UnmanagedType.Interface), In] ICoreWebView2BrowserExtensionRemoveCompletedHandler handler);

    [DispId(1610678275)]
    int IsEnabled { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void Enable(
      [In] int IsEnabled,
      [MarshalAs(UnmanagedType.Interface), In] ICoreWebView2BrowserExtensionEnableCompletedHandler handler);
  }
}
