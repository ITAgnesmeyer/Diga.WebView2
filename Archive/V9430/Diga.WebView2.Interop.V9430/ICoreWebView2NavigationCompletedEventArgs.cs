// Decompiled with JetBrains decompiler
// Type: WebView2.ICoreWebView2NavigationCompletedEventArgs
// Assembly: WebView2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 390039CF-BF77-421E-8AE4-CC8FD0DF2A08
// Assembly location: O:\dev\webview2-interop-master\Src\WebView2.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Diga.WebView2.Interop
{
  [Guid("1337EED4-BC5B-48FB-9672-80D18733CFD5")]
  [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
  [ComImport]
  public interface ICoreWebView2NavigationCompletedEventArgs
  {
    [DispId(1610678272)]
    int IsSuccess { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

    [DispId(1610678273)]
    CORE_WEBVIEW2_WEB_ERROR_STATUS WebErrorStatus { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

    [DispId(1610678274)]
    ulong NavigationId { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }
  }
}
