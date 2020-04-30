﻿// Decompiled with JetBrains decompiler
// Type: Diga.WebView2.Interop.ICoreWebView2PermissionRequestedEventArgs
// Assembly: WebView2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: B5F140DB-135D-4E8A-B1A2-1275CE2FD56A
// Assembly location: O:\webview2\webview2packages\V9488\WebView2.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Diga.WebView2.Interop
{
  [Guid("774B5EA1-3FAD-435C-B1FC-A77D1ACD5EAF")]
  [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
  [ComImport]
  public interface ICoreWebView2PermissionRequestedEventArgs
  {
    [DispId(1610678272)]
    string uri { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.LPWStr)] get; }

    [DispId(1610678273)]
    COREWEBVIEW2_PERMISSION_KIND PermissionKind { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

    [DispId(1610678274)]
    int IsUserInitiated { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

    [DispId(1610678275)]
    COREWEBVIEW2_PERMISSION_STATE State { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.Interface)]
    ICoreWebView2Deferral GetDeferral();
  }
}
