// Decompiled with JetBrains decompiler
// Type: Diga.WebView2.Interop.ICoreWebView2NavigationCompletedEventArgs
// Assembly: Diga.WebView2.Interop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: AAF9543A-0FE1-46E7-BB2C-D24EA0535C0F
// Assembly location: O:\webview2\v1077444\Diga.WebView2.Interop.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Diga.WebView2.Interop
{
  [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
  [Guid("30D68B7D-20D9-4752-A9CA-EC8448FBB5C1")]
  [ComImport]
  public interface ICoreWebView2NavigationCompletedEventArgs
  {
    [DispId(1610678272)]
    int IsSuccess { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

    [DispId(1610678273)]
    COREWEBVIEW2_WEB_ERROR_STATUS WebErrorStatus { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

    [DispId(1610678274)]
    ulong NavigationId { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }
  }
}
