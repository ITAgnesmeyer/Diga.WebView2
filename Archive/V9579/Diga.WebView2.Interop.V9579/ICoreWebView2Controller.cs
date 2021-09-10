// Decompiled with JetBrains decompiler
// Type: WebView2.ICoreWebView2Controller
// Assembly: WebView2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6399528E-A51C-4F53-9554-F4718EFA3992
// Assembly location: O:\webview2\V9579\WebView2.dll

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Diga.WebView2.Interop
{
  [ComConversionLoss]
  [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
  [Guid("7CCC5C7F-8351-4572-9077-9C1C80913835")]
  [ComImport]
  public interface ICoreWebView2Controller
  {
    [DispId(1610678272)]
    int IsVisible { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

    [DispId(1610678274)]
    tagRECT Bounds { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

    [DispId(1610678276)]
    double ZoomFactor { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void add_ZoomFactorChanged(
      [MarshalAs(UnmanagedType.Interface), In] ICoreWebView2ZoomFactorChangedEventHandler eventHandler,
      out EventRegistrationToken token);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void remove_ZoomFactorChanged([In] EventRegistrationToken token);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void SetBoundsAndZoomFactor([In] tagRECT Bounds, [In] double ZoomFactor);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void MoveFocus([In] COREWEBVIEW2_MOVE_FOCUS_REASON reason);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void add_MoveFocusRequested(
      [MarshalAs(UnmanagedType.Interface), In] ICoreWebView2MoveFocusRequestedEventHandler eventHandler,
      out EventRegistrationToken token);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void remove_MoveFocusRequested([In] EventRegistrationToken token);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void add_GotFocus(
      [MarshalAs(UnmanagedType.Interface), In] ICoreWebView2FocusChangedEventHandler eventHandler,
      out EventRegistrationToken token);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void remove_GotFocus([In] EventRegistrationToken token);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void add_LostFocus(
      [MarshalAs(UnmanagedType.Interface), In] ICoreWebView2FocusChangedEventHandler eventHandler,
      out EventRegistrationToken token);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void remove_LostFocus([In] EventRegistrationToken token);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void add_AcceleratorKeyPressed(
      [MarshalAs(UnmanagedType.Interface), In] ICoreWebView2AcceleratorKeyPressedEventHandler eventHandler,
      out EventRegistrationToken token);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void remove_AcceleratorKeyPressed([In] EventRegistrationToken token);

    [DispId(1610678290)]
    [ComAliasName("WebView2.wireHWND")]
    IntPtr ParentWindow { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: ComAliasName("WebView2.wireHWND")] get; [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: ComAliasName("WebView2.wireHWND"), In] set; }

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void NotifyParentWindowPositionChanged();

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void Close();

    [DispId(1610678294)]
    ICoreWebView2 CoreWebView2 { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }
  }
}
