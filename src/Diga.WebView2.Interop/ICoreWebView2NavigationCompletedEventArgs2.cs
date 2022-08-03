// Decompiled with JetBrains decompiler
// Type: Diga.WebView2.Interop.ICoreWebView2NavigationCompletedEventArgs2
// Assembly: Diga.WebView2.Interop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 78C6AA08-CDE2-4921-BDB5-AF4A988C5D7D
// Assembly location: O:\webview2\microsoft.web.webview2.1.0.1264.42\Diga.WebView2.Interop.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Diga.WebView2.Interop
{
  [Guid("FDF8B738-EE1E-4DB2-A329-8D7D7B74D792")]
  [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
  [ComImport]
  public interface ICoreWebView2NavigationCompletedEventArgs2 : 
    ICoreWebView2NavigationCompletedEventArgs
  {
    [DispId(1610678272)]
    new int IsSuccess { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

    [DispId(1610678273)]
    new COREWEBVIEW2_WEB_ERROR_STATUS WebErrorStatus { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

    [DispId(1610678274)]
    new ulong NavigationId { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

    [DispId(1610743808)]
    int HttpStatusCode { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }
  }
}
