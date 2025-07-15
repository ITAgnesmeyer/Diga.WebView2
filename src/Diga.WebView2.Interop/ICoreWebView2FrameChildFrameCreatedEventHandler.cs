// Decompiled with JetBrains decompiler
// Type: Diga.WebView2.Interop.ICoreWebView2FrameChildFrameCreatedEventHandler
// Assembly: Diga.WebView2.Interop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: B58873C5-7732-4F0F-96EB-A45D9CAFD84E
// Assembly location: D:\tmp\Microsoft.Web.WebView2.1.0.3351.48\Diga.WebView2.Interop.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;


namespace Diga.WebView2.Interop
{
  [Guid("569E40E7-46B7-563D-83AE-1073155664D7")]
  [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
  [ComImport]
  public interface ICoreWebView2FrameChildFrameCreatedEventHandler
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void Invoke([MarshalAs(UnmanagedType.Interface), In] ICoreWebView2Frame sender, [MarshalAs(UnmanagedType.Interface), In] ICoreWebView2FrameCreatedEventArgs args);
  }
}
