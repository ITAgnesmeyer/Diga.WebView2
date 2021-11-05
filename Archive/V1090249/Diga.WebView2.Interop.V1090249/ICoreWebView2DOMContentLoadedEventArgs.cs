// Decompiled with JetBrains decompiler
// Type: Diga.WebView2.Interop.ICoreWebView2DOMContentLoadedEventArgs
// Assembly: Diga.WebView2.Interop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: AAF9543A-0FE1-46E7-BB2C-D24EA0535C0F
// Assembly location: O:\webview2\v1077444\Diga.WebView2.Interop.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Diga.WebView2.Interop
{
  [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
  [Guid("16B1E21A-C503-44F2-84C9-70ABA5031283")]
  [ComImport]
  public interface ICoreWebView2DOMContentLoadedEventArgs
  {
    [DispId(1610678272)]
    ulong NavigationId { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }
  }
}
