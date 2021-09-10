// Decompiled with JetBrains decompiler
// Type: WebView2Experimental.ICoreWebView2ExperimentalEnvironment
// Assembly: WebView2Experimental, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 2FA7ABB2-ECD1-41D1-96C7-3EF46A31C524
// Assembly location: O:\webview2\V9515\WebView2Experimental.dll

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Diga.WebView2.Interop.Experimental
{
  [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
  [Guid("4987AF47-81DE-4833-B0A5-980CAEFB6EEE")]
  [ComImport]
  public interface ICoreWebView2ExperimentalEnvironment
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void CreateCoreWebView2CompositionController(
      IntPtr parentWindow,
      [MarshalAs(UnmanagedType.Interface)] ICoreWebView2ExperimentalCreateCoreWebView2CompositionControllerCompletedHandler handler);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.Interface)]
    ICoreWebView2ExperimentalPointerInfo CreateCoreWebView2PointerInfo();

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.IUnknown)]
    object GetProviderForHwnd(IntPtr hwnd);
  }
}
