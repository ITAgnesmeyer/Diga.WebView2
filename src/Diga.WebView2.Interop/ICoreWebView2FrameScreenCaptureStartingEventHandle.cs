// Decompiled with JetBrains decompiler
// Type: Diga.WebView2.Interop.ICoreWebView2FrameScreenCaptureStartingEventHandler
// Assembly: Diga.WebView2.Interop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8715E134-1EF7-438C-8A44-036439A229BA
// Assembly location: D:\temp\webview2\Microsoft.Web.WebView2.1.0.2957.106\Diga.WebView2.Interop.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;


namespace Diga.WebView2.Interop
{
  [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
  [Guid("A6C1D8AD-BB80-59C5-895B-FBA1698B9309")]
  [ComImport]
  public interface ICoreWebView2FrameScreenCaptureStartingEventHandler
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void Invoke([MarshalAs(UnmanagedType.Interface), In] ICoreWebView2Frame sender, [MarshalAs(UnmanagedType.Interface), In] ICoreWebView2ScreenCaptureStartingEventArgs args);
  }
}
