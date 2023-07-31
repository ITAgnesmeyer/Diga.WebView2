// Decompiled with JetBrains decompiler
// Type: Diga.WebView2.Interop.ICoreWebView2CompositionController3
// Assembly: Diga.WebView2.Interop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: ED88F383-EEB9-472A-9573-53250CD6B18B
// Assembly location: O:\webview2\Microsoft.Web.WebView2.1.0.1370.28\Diga.WebView2.Interop.dll

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;

namespace Diga.WebView2.Interop
{
  [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
  [Guid("9570570E-4D76-4361-9EE1-F04D0DBDFB1E")]
  [ComImport]
  public interface ICoreWebView2CompositionController3 : ICoreWebView2CompositionController2
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
    uint DragEnter([MarshalAs(UnmanagedType.Interface), In] IDataObject dataObject, [In] uint keyState, [In] tagPOINT point);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void DragLeave();

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    uint DragOver([In] uint keyState, [In] tagPOINT point);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    uint Drop([MarshalAs(UnmanagedType.Interface), In] IDataObject dataObject, [In] uint keyState, [In] tagPOINT point);
  }
}
