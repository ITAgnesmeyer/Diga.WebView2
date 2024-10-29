// Decompiled with JetBrains decompiler
// Type: Diga.WebView2.Interop.ICoreWebView2CompositionController4
// Assembly: Diga.WebView2.Interop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 84D13381-11FC-4303-9DB0-23B921C377B0
// Assembly location: D:\temp\webview2\microsoft.web.webview2.1.0.2849.39\Diga.WebView2.Interop.dll

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;

namespace Diga.WebView2.Interop
{
  [Guid("7C367B9B-3D2B-450F-9E58-D61A20F486AA")]
  [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
  [ComImport]
  public interface ICoreWebView2CompositionController4 : ICoreWebView2CompositionController3
  {
    [DispId(1610678272)]
    new object RootVisualTarget { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.IUnknown)] get; [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: MarshalAs(UnmanagedType.IUnknown), In] set; }

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    new void SendMouseInput(
      [In] COREWEBVIEW2_MOUSE_EVENT_KIND eventKind,
      [In] COREWEBVIEW2_MOUSE_EVENT_VIRTUAL_KEYS virtualKeys,
      [In] uint mouseData,
      [In] tagPOINT point);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    new void SendPointerInput(
      [In] COREWEBVIEW2_POINTER_EVENT_KIND eventKind,
      [MarshalAs(UnmanagedType.Interface), In] ICoreWebView2PointerInfo pointerInfo);

    [ComAliasName("Diga.WebView2.Interop.wireHICON")]
    [DispId(1610678276)]
    new IntPtr Cursor { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: ComAliasName("Diga.WebView2.Interop.wireHICON")] get; }

    [DispId(1610678277)]
    new uint SystemCursorId { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    new void add_CursorChanged(
      [MarshalAs(UnmanagedType.Interface), In] ICoreWebView2CursorChangedEventHandler eventHandler,
      out EventRegistrationToken token);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    new void remove_CursorChanged([In] EventRegistrationToken token);

    [DispId(1610743808)]
    new object AutomationProvider { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.IUnknown)] get; }

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    new uint DragEnter([MarshalAs(UnmanagedType.Interface), In] IDataObject dataObject, [In] uint keyState, [In] tagPOINT point);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    new void DragLeave();

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    new uint DragOver([In] uint keyState, [In] tagPOINT point);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    new uint Drop([MarshalAs(UnmanagedType.Interface), In] IDataObject dataObject, [In] uint keyState, [In] tagPOINT point);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    COREWEBVIEW2_NON_CLIENT_REGION_KIND GetNonClientRegionAtPoint([In] tagPOINT point);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.Interface)]
    ICoreWebView2RegionRectCollectionView QueryNonClientRegion(
      [In] COREWEBVIEW2_NON_CLIENT_REGION_KIND Kind);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void add_NonClientRegionChanged(
      [MarshalAs(UnmanagedType.Interface), In] ICoreWebView2NonClientRegionChangedEventHandler eventHandler,
      out EventRegistrationToken token);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void remove_NonClientRegionChanged([In] EventRegistrationToken token);
  }
}
