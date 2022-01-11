// Decompiled with JetBrains decompiler
// Type: Diga.WebView2.Interop.ICoreWebView2IsDefaultDownloadDialogOpenChangedEventHandler
// Assembly: Diga.WebView2.Interop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 03E6B0A7-E6B7-472F-A8B3-541AB2D8627C
// Assembly location: O:\webview2\V10107254\Diga.WebView2.Interop.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Diga.WebView2.Interop
{
  [Guid("3117DA26-AE13-438D-BD46-EDBEB2C4CE81")]
  [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
  [ComImport]
  public interface ICoreWebView2IsDefaultDownloadDialogOpenChangedEventHandler
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void Invoke([MarshalAs(UnmanagedType.Interface), In] ICoreWebView2 sender, [MarshalAs(UnmanagedType.IUnknown), In] object args);
  }
}
