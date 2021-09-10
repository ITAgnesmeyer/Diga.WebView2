// Decompiled with JetBrains decompiler
// Type: WebView2.ICoreWebView2SourceChangedEventHandler
// Assembly: WebView2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6399528E-A51C-4F53-9554-F4718EFA3992
// Assembly location: O:\webview2\V9579\WebView2.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Diga.WebView2.Interop
{
  [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
  [Guid("8FEDD1A7-3A33-416F-AF81-881EEB001433")]
  [ComImport]
  public interface ICoreWebView2SourceChangedEventHandler
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void Invoke([MarshalAs(UnmanagedType.Interface), In] ICoreWebView2 webview, [MarshalAs(UnmanagedType.Interface), In] ICoreWebView2SourceChangedEventArgs args);
  }
}
