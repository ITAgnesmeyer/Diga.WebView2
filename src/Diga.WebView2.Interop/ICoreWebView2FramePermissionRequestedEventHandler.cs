// Decompiled with JetBrains decompiler
// Type: Diga.WebView2.Interop.ICoreWebView2FramePermissionRequestedEventHandler
// Assembly: Diga.WebView2.Interop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EA95D0FC-77DE-40CE-8C3C-89517DF28E5B
// Assembly location: O:\webview2\V10118539\Diga.WebView2.Interop.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Diga.WebView2.Interop
{
  [Guid("845D0EDD-8BD8-429B-9915-4821789F23E9")]
  [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
  [ComImport]
  public interface ICoreWebView2FramePermissionRequestedEventHandler
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void Invoke([MarshalAs(UnmanagedType.Interface), In] ICoreWebView2Frame sender, [MarshalAs(UnmanagedType.Interface), In] ICoreWebView2PermissionRequestedEventArgs2 args);
  }
}
