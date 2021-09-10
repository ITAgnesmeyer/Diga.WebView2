// Decompiled with JetBrains decompiler
// Type: WebView2.ICoreWebView2WebResourceRequestedEventArgs
// Assembly: WebView2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 390039CF-BF77-421E-8AE4-CC8FD0DF2A08
// Assembly location: O:\dev\webview2-interop-master\Src\WebView2.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Diga.WebView2.Interop
{
  [Guid("6EF9912F-5A9D-42A9-8C17-9BB53E1D5C63")]
  [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
  [ComImport]
  public interface ICoreWebView2WebResourceRequestedEventArgs
  {
    [DispId(1610678272)]
    ICoreWebView2WebResourceRequest Request { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

    [DispId(1610678273)]
    ICoreWebView2WebResourceResponse Response { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: MarshalAs(UnmanagedType.Interface), In] set; }

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.Interface)]
    ICoreWebView2Deferral GetDeferral();

    [DispId(1610678276)]
    CORE_WEBVIEW2_WEB_RESOURCE_CONTEXT ResourceContext { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }
  }
}
