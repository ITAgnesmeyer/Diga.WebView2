// Decompiled with JetBrains decompiler
// Type: WebView2.ICoreWebView2SourceChangedEventArgs
// Assembly: WebView2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 4848E93B-2D8E-488A-B413-2977821823D1
// Assembly location: O:\webview2\V9515\WebView2.dll

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
