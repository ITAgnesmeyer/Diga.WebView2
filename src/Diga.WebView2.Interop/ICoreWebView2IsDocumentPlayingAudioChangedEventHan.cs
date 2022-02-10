// Decompiled with JetBrains decompiler
// Type: Diga.WebView2.Interop.ICoreWebView2IsDocumentPlayingAudioChangedEventHandler
// Assembly: Diga.WebView2.Interop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 03E6B0A7-E6B7-472F-A8B3-541AB2D8627C
// Assembly location: O:\webview2\V10107254\Diga.WebView2.Interop.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Diga.WebView2.Interop
{
  [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
  [Guid("5DEF109A-2F4B-49FA-B7F6-11C39E513328")]
  [ComImport]
  public interface ICoreWebView2IsDocumentPlayingAudioChangedEventHandler
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void Invoke([MarshalAs(UnmanagedType.Interface), In] ICoreWebView2 sender, [MarshalAs(UnmanagedType.IUnknown), In] object args);
  }
}
