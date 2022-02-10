// Decompiled with JetBrains decompiler
// Type: Diga.WebView2.Interop.ICoreWebView2FrameNavigationCompletedEventHandler
// Assembly: Diga.WebView2.Interop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: B1615030-5202-42C2-A0A8-1F7B8FE362ED
// Assembly location: O:\webview2\V10110844\Diga.WebView2.Interop.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Diga.WebView2.Interop
{
  [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
  [Guid("609302AD-0E36-4F9A-A210-6A45272842A9")]
  [ComImport]
  public interface ICoreWebView2FrameNavigationCompletedEventHandler
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void Invoke([MarshalAs(UnmanagedType.Interface), In] ICoreWebView2Frame sender, [MarshalAs(UnmanagedType.Interface), In] ICoreWebView2NavigationCompletedEventArgs args);
  }
}
