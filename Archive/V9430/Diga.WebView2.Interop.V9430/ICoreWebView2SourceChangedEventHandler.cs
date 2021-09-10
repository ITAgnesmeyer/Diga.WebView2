// Decompiled with JetBrains decompiler
// Type: WebView2.ICoreWebView2SourceChangedEventHandler
// Assembly: WebView2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 390039CF-BF77-421E-8AE4-CC8FD0DF2A08
// Assembly location: O:\dev\webview2-interop-master\Src\WebView2.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Diga.WebView2.Interop
{
  [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
  [Guid("E345159A-B573-41AB-A4F7-F94CB238AF45")]
  [ComImport]
  public interface ICoreWebView2SourceChangedEventHandler
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void Invoke([MarshalAs(UnmanagedType.Interface), In] ICoreWebView2 webview, [MarshalAs(UnmanagedType.Interface), In] ICoreWebView2SourceChangedEventArgs args);
  }
}
