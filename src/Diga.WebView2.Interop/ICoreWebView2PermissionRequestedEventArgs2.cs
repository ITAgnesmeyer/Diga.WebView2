// Decompiled with JetBrains decompiler
// Type: Diga.WebView2.Interop.ICoreWebView2PermissionRequestedEventArgs2
// Assembly: Diga.WebView2.Interop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EA95D0FC-77DE-40CE-8C3C-89517DF28E5B
// Assembly location: O:\webview2\V10118539\Diga.WebView2.Interop.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Diga.WebView2.Interop
{
  [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
  [Guid("74D7127F-9DE6-4200-8734-42D6FB4FF741")]
  [ComImport]
  public interface ICoreWebView2PermissionRequestedEventArgs2 : 
    ICoreWebView2PermissionRequestedEventArgs
  {
    [DispId(1610678272)]
    new string uri { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.LPWStr)] get; }

    [DispId(1610678273)]
    new COREWEBVIEW2_PERMISSION_KIND PermissionKind { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

    [DispId(1610678274)]
    new int IsUserInitiated { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

    [DispId(1610678275)]
    new COREWEBVIEW2_PERMISSION_STATE State { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.Interface)]
    new ICoreWebView2Deferral GetDeferral();

    [DispId(1610743808)]
    int Handled { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }
  }
}
