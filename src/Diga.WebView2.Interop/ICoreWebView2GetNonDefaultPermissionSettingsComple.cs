﻿// Decompiled with JetBrains decompiler
// Type: Diga.WebView2.Interop.ICoreWebView2GetNonDefaultPermissionSettingsCompletedHandler
// Assembly: Diga.WebView2.Interop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 1241A3C3-E886-4508-B746-7F7141E4C294
// Assembly location: O:\webview2\microsoft.web.webview2.1.0.1722.45\Diga.WebView2.Interop.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Diga.WebView2.Interop
{
  [Guid("38274481-A15C-4563-94CF-990EDC9AEB95")]
  [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
  [ComImport]
  public interface ICoreWebView2GetNonDefaultPermissionSettingsCompletedHandler
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void Invoke(
      [MarshalAs(UnmanagedType.Error), In] int errorCode,
      [MarshalAs(UnmanagedType.Interface), In] ICoreWebView2PermissionSettingCollectionView collectionView);
  }
}
