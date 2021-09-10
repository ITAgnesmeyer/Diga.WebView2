// Decompiled with JetBrains decompiler
// Type: Diga.WebView2.Interop.ICoreWebView2CompositionController
// Assembly: Diga.WebView2.Interop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: AAF9543A-0FE1-46E7-BB2C-D24EA0535C0F
// Assembly location: O:\webview2\v1077444\Diga.WebView2.Interop.dll

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Diga.WebView2.Interop
{
  [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
  [Guid("3DF9B733-B9AE-4A15-86B4-EB9EE9826469")]
  [ComConversionLoss]
  [ComImport]
  public interface ICoreWebView2CompositionController
  {
    [DispId(1610678272)]
    object RootVisualTarget { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.IUnknown)] get; [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: MarshalAs(UnmanagedType.IUnknown), In] set; }

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void SendMouseInput(
      [In] COREWEBVIEW2_MOUSE_EVENT_KIND eventKind,
      [In] COREWEBVIEW2_MOUSE_EVENT_VIRTUAL_KEYS virtualKeys,
      [In] uint mouseData,
      [In] tagPOINT point);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void SendPointerInput(
      [In] COREWEBVIEW2_POINTER_EVENT_KIND eventKind,
      [MarshalAs(UnmanagedType.Interface), In] ICoreWebView2PointerInfo pointerInfo);

    [ComAliasName("Diga.WebView2.Interop.wireHICON")]
    [DispId(1610678276)]
    IntPtr Cursor { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: ComAliasName("Diga.WebView2.Interop.wireHICON")] get; }

    [DispId(1610678277)]
    uint SystemCursorId { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void add_CursorChanged(
      [MarshalAs(UnmanagedType.Interface), In] ICoreWebView2CursorChangedEventHandler eventHandler,
      out EventRegistrationToken token);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void remove_CursorChanged([In] EventRegistrationToken token);
  }
}
