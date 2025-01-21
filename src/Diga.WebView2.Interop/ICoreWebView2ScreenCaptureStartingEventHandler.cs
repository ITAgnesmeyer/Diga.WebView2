// Decompiled with JetBrains decompiler
// Type: Diga.WebView2.Interop.ICoreWebView2ScreenCaptureStartingEventHandler
// Assembly: Diga.WebView2.Interop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8715E134-1EF7-438C-8A44-036439A229BA
// Assembly location: D:\temp\webview2\Microsoft.Web.WebView2.1.0.2957.106\Diga.WebView2.Interop.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;


namespace Diga.WebView2.Interop
{
  [Guid("E24FF05A-1DB5-59D9-89F3-3C864268DB4A")]
  [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
  [ComImport]
  public interface ICoreWebView2ScreenCaptureStartingEventHandler
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void Invoke([MarshalAs(UnmanagedType.Interface), In] ICoreWebView2 sender, [MarshalAs(UnmanagedType.Interface), In] ICoreWebView2ScreenCaptureStartingEventArgs args);
  }
}
