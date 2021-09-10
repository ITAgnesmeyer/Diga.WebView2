// Decompiled with JetBrains decompiler
// Type: WebView2.ICoreWebView2FrameInfoCollection
// Assembly: WebView2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CB197DC1-34BC-456D-8BC3-B58B9CD2508E
// Assembly location: O:\webview2\v1086435\WebView2.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Diga.WebView2.Interop
{
  [Guid("8F834154-D38E-4D90-AFFB-6800A7272839")]
  [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
  [ComImport]
  public interface ICoreWebView2FrameInfoCollection
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.Interface)]
    ICoreWebView2FrameInfoCollectionIterator GetIterator();
  }
}
