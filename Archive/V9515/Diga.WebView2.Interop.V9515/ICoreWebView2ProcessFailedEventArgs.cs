// Decompiled with JetBrains decompiler
// Type: WebView2.ICoreWebView2ProcessFailedEventArgs
// Assembly: WebView2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 4848E93B-2D8E-488A-B413-2977821823D1
// Assembly location: O:\webview2\V9515\WebView2.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Diga.WebView2.Interop
{
  [Guid("EA45D1F4-75C0-471F-A6E9-803FBFF8FEF2")]
  [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
  [ComImport]
  public interface ICoreWebView2ProcessFailedEventArgs
  {
    [DispId(1610678272)]
    COREWEBVIEW2_PROCESS_FAILED_KIND ProcessFailedKind { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }
  }
}
