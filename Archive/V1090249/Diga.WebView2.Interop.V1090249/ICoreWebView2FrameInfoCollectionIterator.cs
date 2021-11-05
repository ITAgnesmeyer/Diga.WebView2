// Decompiled with JetBrains decompiler
// Type: WebView2.ICoreWebView2FrameInfoCollectionIterator
// Assembly: WebView2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CB197DC1-34BC-456D-8BC3-B58B9CD2508E
// Assembly location: O:\webview2\v1086435\WebView2.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Diga.WebView2.Interop
{
  [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
  [Guid("1BF89E2D-1B2B-4629-B28F-05099B41BB03")]
  [ComImport]
  public interface ICoreWebView2FrameInfoCollectionIterator
  {
    [DispId(1610678272)]
    int hasCurrent { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.Interface)]
    ICoreWebView2FrameInfo GetCurrent();

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    int MoveNext();
  }
}
