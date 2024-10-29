// Decompiled with JetBrains decompiler
// Type: Diga.WebView2.Interop.ICoreWebView2NonClientRegionChangedEventArgs
// Assembly: Diga.WebView2.Interop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 84D13381-11FC-4303-9DB0-23B921C377B0
// Assembly location: D:\temp\webview2\microsoft.web.webview2.1.0.2849.39\Diga.WebView2.Interop.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Diga.WebView2.Interop
{
  [Guid("AB71D500-0820-4A52-809C-48DB04FF93BF")]
  [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
  [ComImport]
  public interface ICoreWebView2NonClientRegionChangedEventArgs
  {
    [DispId(1610678272)]
    COREWEBVIEW2_NON_CLIENT_REGION_KIND RegionKind { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }
  }
}
