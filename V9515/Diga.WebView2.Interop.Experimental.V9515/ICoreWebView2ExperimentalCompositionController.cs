// Decompiled with JetBrains decompiler
// Type: WebView2Experimental.ICoreWebView2ExperimentalCompositionController
// Assembly: WebView2Experimental, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 2FA7ABB2-ECD1-41D1-96C7-3EF46A31C524
// Assembly location: O:\webview2\V9515\WebView2Experimental.dll

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Diga.WebView2.Interop.Experimental
{
  [ComConversionLoss]
  [Guid("19A479A7-4D44-4796-9D95-3B22269EED7D")]
  [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
  [ComImport]
  public interface ICoreWebView2ExperimentalCompositionController
  {
    [DispId(1610678272)]
    object UIAProvider { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.IUnknown)] get; }

    [DispId(1610678273)]
    object RootVisualTarget { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.IUnknown)] get; [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: MarshalAs(UnmanagedType.IUnknown), In] set; }

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void SendMouseInput(
      [In] COREWEBVIEW2_MOUSE_EVENT_KIND eventKind,
      [In] COREWEBVIEW2_MOUSE_EVENT_VIRTUAL_KEYS virtualKeys,
      [In] uint mouseData,
      [In] tagPOINTEx point);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.Interface)]
    ICoreWebView2ExperimentalPointerInfo CreateCoreWebView2PointerInfoFromPointerId(
      [In] uint PointerId,
      IntPtr parentWindow,
      [In] COREWEBVIEW2_MATRIX_4X4 transform);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void SendPointerInput(
      [In] COREWEBVIEW2_POINTER_EVENT_KIND eventType,
      [MarshalAs(UnmanagedType.Interface), In] ICoreWebView2ExperimentalPointerInfo pointerInfo);

    [ComAliasName("WebView2Experimental.wireHICON")]
    [DispId(1610678278)]
    IntPtr Cursor { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: ComAliasName("WebView2Experimental.wireHICON")] get; }

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void add_CursorChanged(
      [MarshalAs(UnmanagedType.Interface), In] ICoreWebView2ExperimentalCursorChangedEventHandler eventHandler,
      out EventRegistrationTokenEx token);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void remove_CursorChanged([In] EventRegistrationTokenEx token);
  }
}
