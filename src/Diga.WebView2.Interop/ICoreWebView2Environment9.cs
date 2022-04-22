// Decompiled with JetBrains decompiler
// Type: Diga.WebView2.Interop.ICoreWebView2Environment9
// Assembly: Diga.WebView2.Interop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EA95D0FC-77DE-40CE-8C3C-89517DF28E5B
// Assembly location: O:\webview2\V10118539\Diga.WebView2.Interop.dll

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;

namespace Diga.WebView2.Interop
{
  [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
  [Guid("F06F41BF-4B5A-49D8-B9F6-FA16CD29F274")]
  [ComImport]
  public interface ICoreWebView2Environment9 : ICoreWebView2Environment8
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
    new string BrowserVersionString { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.LPWStr)] get; }

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
    object GetAutomationProviderForWindow(IntPtr hwnd);

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
    new string UserDataFolder { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.LPWStr)] get; }

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
    ICoreWebView2ContextMenuItem CreateContextMenuItem(
      [MarshalAs(UnmanagedType.LPWStr), In] string Label,
      [MarshalAs(UnmanagedType.Interface), In] IStream iconStream,
      [In] COREWEBVIEW2_CONTEXT_MENU_ITEM_KIND Kind);
  }
}
