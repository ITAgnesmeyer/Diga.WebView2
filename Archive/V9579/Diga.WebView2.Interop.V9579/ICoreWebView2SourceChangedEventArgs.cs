// Decompiled with JetBrains decompiler
// Type: WebView2.ICoreWebView2SourceChangedEventArgs
// Assembly: WebView2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6399528E-A51C-4F53-9554-F4718EFA3992
// Assembly location: O:\webview2\V9579\WebView2.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Diga.WebView2.Interop
{
  [Guid("BD9A4BFB-BE19-40BD-968B-EBCF0D727EF3")]
  [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
  [ComImport]
  public interface ICoreWebView2SourceChangedEventArgs
  {
    [DispId(1610678272)]
    int IsNewDocument { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }
  }
}
