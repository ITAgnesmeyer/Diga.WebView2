// Decompiled with JetBrains decompiler
// Type: Diga.WebView2.Interop.ICoreWebView2Environment14
// Assembly: Diga.WebView2.Interop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 84D13381-11FC-4303-9DB0-23B921C377B0
// Assembly location: D:\temp\webview2\microsoft.web.webview2.1.0.2849.39\Diga.WebView2.Interop.dll

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;

namespace Diga.WebView2.Interop
{
    [Guid("A5E9FAD9-C875-59DA-9BD7-473AA5CA1CEF")]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    [ComImport]
    public interface ICoreWebView2Environment14 : ICoreWebView2Environment13
    {
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        new void CreateCoreWebView2Controller(
          IntPtr ParentWindow,
          [MarshalAs(UnmanagedType.Interface)] ICoreWebView2CreateCoreWebView2ControllerCompletedHandler handler);

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        [return: MarshalAs(UnmanagedType.Interface)]
        new ICoreWebView2WebResourceResponse CreateWebResourceResponse(
      [MarshalAs(UnmanagedType.Interface), In] IStream Content,
      [In] int StatusCode,
      [MarshalAs(UnmanagedType.LPWStr), In] string ReasonPhrase,
      [MarshalAs(UnmanagedType.LPWStr), In] string Headers);

        [DispId(1610678274)]
        new string BrowserVersionString { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)][return: MarshalAs(UnmanagedType.LPWStr)] get; }

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        new void add_NewBrowserVersionAvailable(
          [MarshalAs(UnmanagedType.Interface), In] ICoreWebView2NewBrowserVersionAvailableEventHandler eventHandler,
          out EventRegistrationToken token);

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        new void remove_NewBrowserVersionAvailable([In] EventRegistrationToken token);

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        [return: MarshalAs(UnmanagedType.Interface)]
        new ICoreWebView2WebResourceRequest CreateWebResourceRequest(
          [MarshalAs(UnmanagedType.LPWStr), In] string uri,
          [MarshalAs(UnmanagedType.LPWStr), In] string Method,
          [MarshalAs(UnmanagedType.Interface), In] IStream postData,
          [MarshalAs(UnmanagedType.LPWStr), In] string Headers);

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        new void CreateCoreWebView2CompositionController(
     IntPtr ParentWindow,
     [MarshalAs(UnmanagedType.Interface)] ICoreWebView2CreateCoreWebView2CompositionControllerCompletedHandler handler);

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        [return: MarshalAs(UnmanagedType.Interface)]
        new ICoreWebView2PointerInfo CreateCoreWebView2PointerInfo();

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        [return: MarshalAs(UnmanagedType.IUnknown)]
        new object GetAutomationProviderForWindow(IntPtr hwnd);

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        new void add_BrowserProcessExited(
          [MarshalAs(UnmanagedType.Interface), In] ICoreWebView2BrowserProcessExitedEventHandler eventHandler,
          out EventRegistrationToken token);

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        new void remove_BrowserProcessExited([In] EventRegistrationToken token);

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        [return: MarshalAs(UnmanagedType.Interface)]
        new ICoreWebView2PrintSettings CreatePrintSettings();

        [DispId(1611071488)]
        new string UserDataFolder { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)][return: MarshalAs(UnmanagedType.LPWStr)] get; }

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        new void add_ProcessInfosChanged(
          [MarshalAs(UnmanagedType.Interface), In] ICoreWebView2ProcessInfosChangedEventHandler eventHandler,
          out EventRegistrationToken token);

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        new void remove_ProcessInfosChanged([In] EventRegistrationToken token);

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        [return: MarshalAs(UnmanagedType.Interface)]
        new ICoreWebView2ProcessInfoCollection GetProcessInfos();

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        [return: MarshalAs(UnmanagedType.Interface)]
        new ICoreWebView2ContextMenuItem CreateContextMenuItem(
          [MarshalAs(UnmanagedType.LPWStr), In] string Label,
          [MarshalAs(UnmanagedType.Interface), In] IStream iconStream,
          [In] COREWEBVIEW2_CONTEXT_MENU_ITEM_KIND Kind);

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        [return: MarshalAs(UnmanagedType.Interface)]
        new ICoreWebView2ControllerOptions CreateCoreWebView2ControllerOptions();

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        new void CreateCoreWebView2ControllerWithOptions(
          IntPtr ParentWindow,
          [MarshalAs(UnmanagedType.Interface), In] ICoreWebView2ControllerOptions options,
          [MarshalAs(UnmanagedType.Interface), In] ICoreWebView2CreateCoreWebView2ControllerCompletedHandler handler);

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        new void CreateCoreWebView2CompositionControllerWithOptions(
          IntPtr ParentWindow,
          [MarshalAs(UnmanagedType.Interface), In] ICoreWebView2ControllerOptions options,
          [MarshalAs(UnmanagedType.Interface), In] ICoreWebView2CreateCoreWebView2CompositionControllerCompletedHandler handler);

        [DispId(1611333632)]
        new string FailureReportFolderPath { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)][return: MarshalAs(UnmanagedType.LPWStr)] get; }

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        [return: MarshalAs(UnmanagedType.Interface)]
        new ICoreWebView2SharedBuffer CreateSharedBuffer([In] ulong Size);

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        new void GetProcessExtendedInfos(
          [MarshalAs(UnmanagedType.Interface), In] ICoreWebView2GetProcessExtendedInfosCompletedHandler handler);

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        [return: MarshalAs(UnmanagedType.Interface)]
        ICoreWebView2FileSystemHandle CreateWebFileSystemFileHandle(
          [MarshalAs(UnmanagedType.LPWStr), In] string Path,
          [In] COREWEBVIEW2_FILE_SYSTEM_HANDLE_PERMISSION Permission);

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        [return: MarshalAs(UnmanagedType.Interface)]
        ICoreWebView2FileSystemHandle CreateWebFileSystemDirectoryHandle(
          [MarshalAs(UnmanagedType.LPWStr), In] string Path,
          [In] COREWEBVIEW2_FILE_SYSTEM_HANDLE_PERMISSION Permission);

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        [return: MarshalAs(UnmanagedType.Interface)]
        ICoreWebView2ObjectCollection CreateObjectCollection([In] uint length, [MarshalAs(UnmanagedType.IUnknown), In] ref object items);
    }
}
