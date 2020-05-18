// Decompiled with JetBrains decompiler
// Type: WebView2.IWebView2WebView5
// Assembly: WebView2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5F0D75F7-60BF-43BB-8231-ACD9063B7411
// Assembly location: O:\macos\WebView2.dll

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;

namespace Diga.WebView2.Interop
{
    [Guid("E55144F5-A16F-43D8-9580-1E5227152EDF")]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    [ComImport]
    public interface IWebView2WebView5 : IWebView2WebView4
    {
        [DispId(1610678272)]
        new IWebView2Settings Settings { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

        [DispId(1610678273)]
        new string Source { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.LPWStr)] get; }

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        new void Navigate([MarshalAs(UnmanagedType.LPWStr), In] string uri);

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        new void MoveFocus([In] WEBVIEW2_MOVE_FOCUS_REASON reason);

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        new void NavigateToString([MarshalAs(UnmanagedType.LPWStr), In] string htmlContent);

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        new void add_NavigationStarting(
          [MarshalAs(UnmanagedType.Interface), In] IWebView2NavigationStartingEventHandler eventHandler,
          out EventRegistrationToken token);

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        new void remove_NavigationStarting([In] EventRegistrationToken token);

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        new void add_DocumentStateChanged(
          [MarshalAs(UnmanagedType.Interface), In] IWebView2DocumentStateChangedEventHandler eventHandler,
          out EventRegistrationToken token);

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        new void remove_DocumentStateChanged([In] EventRegistrationToken token);

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        new void add_NavigationCompleted(
          [MarshalAs(UnmanagedType.Interface), In] IWebView2NavigationCompletedEventHandler eventHandler,
          out EventRegistrationToken token);

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        new void remove_NavigationCompleted([In] EventRegistrationToken token);

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        new void add_FrameNavigationStarting(
          [MarshalAs(UnmanagedType.Interface), In] IWebView2NavigationStartingEventHandler eventHandler,
          out EventRegistrationToken token);

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        new void remove_FrameNavigationStarting([In] EventRegistrationToken token);

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        new void add_MoveFocusRequested(
          [MarshalAs(UnmanagedType.Interface), In] IWebView2MoveFocusRequestedEventHandler eventHandler,
          out EventRegistrationToken token);

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        new void remove_MoveFocusRequested([In] EventRegistrationToken token);

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        new void add_GotFocus(
          [MarshalAs(UnmanagedType.Interface), In] IWebView2FocusChangedEventHandler eventHandler,
          out EventRegistrationToken token);

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        new void remove_GotFocus([In] EventRegistrationToken token);

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        new void add_LostFocus(
          [MarshalAs(UnmanagedType.Interface), In] IWebView2FocusChangedEventHandler eventHandler,
          out EventRegistrationToken token);

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        new void remove_LostFocus([In] EventRegistrationToken token);

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        new void add_WebResourceRequested_deprecated(
          [MarshalAs(UnmanagedType.LPWStr), In] ref string urlFilter,
          [In] ref WEBVIEW2_WEB_RESOURCE_CONTEXT resourceContextFilter,
          [ComAliasName("WebView2.ULONG_PTR"), In] ulong filterLength,
          [MarshalAs(UnmanagedType.Interface), In] IWebView2WebResourceRequestedEventHandler eventHandler,
          out EventRegistrationToken token);

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        new void remove_WebResourceRequested([In] EventRegistrationToken token);

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        new void add_ScriptDialogOpening(
          [MarshalAs(UnmanagedType.Interface), In] IWebView2ScriptDialogOpeningEventHandler eventHandler,
          out EventRegistrationToken token);

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        new void remove_ScriptDialogOpening([In] EventRegistrationToken token);

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        new void add_ZoomFactorChanged(
          [MarshalAs(UnmanagedType.Interface), In] IWebView2ZoomFactorChangedEventHandler eventHandler,
          out EventRegistrationToken token);

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        new void remove_ZoomFactorChanged([In] EventRegistrationToken token);

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        new void add_PermissionRequested(
          [MarshalAs(UnmanagedType.Interface), In] IWebView2PermissionRequestedEventHandler eventHandler,
          out EventRegistrationToken token);

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        new void remove_PermissionRequested([In] EventRegistrationToken token);

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        new void add_ProcessFailed(
          [MarshalAs(UnmanagedType.Interface), In] IWebView2ProcessFailedEventHandler eventHandler,
          out EventRegistrationToken token);

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        new void remove_ProcessFailed([In] EventRegistrationToken token);

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        new void AddScriptToExecuteOnDocumentCreated(
          [MarshalAs(UnmanagedType.LPWStr), In] string javaScript,
          [MarshalAs(UnmanagedType.Interface), In] IWebView2AddScriptToExecuteOnDocumentCreatedCompletedHandler handler);

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        new void RemoveScriptToExecuteOnDocumentCreated([MarshalAs(UnmanagedType.LPWStr), In] string id);

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        new void ExecuteScript([MarshalAs(UnmanagedType.LPWStr), In] string javaScript, [MarshalAs(UnmanagedType.Interface), In] IWebView2ExecuteScriptCompletedHandler handler);

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        new void CapturePreview(
          [In] WEBVIEW2_CAPTURE_PREVIEW_IMAGE_FORMAT imageFormat,
          [MarshalAs(UnmanagedType.Interface), In] IStream imageStream,
          [MarshalAs(UnmanagedType.Interface), In] IWebView2CapturePreviewCompletedHandler handler);

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        new void Reload();

        [DispId(1610678306)]
        new tagRECT Bounds { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

        [DispId(1610678308)]
        new double ZoomFactor { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

        [DispId(1610678310)]
        new int IsVisible { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        new void PostWebMessageAsJson([MarshalAs(UnmanagedType.LPWStr), In] string webMessageAsJson);

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        new void PostWebMessageAsString([MarshalAs(UnmanagedType.LPWStr), In] string webMessageAsString);

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        new void add_WebMessageReceived(
          [MarshalAs(UnmanagedType.Interface), In] IWebView2WebMessageReceivedEventHandler handler,
          out EventRegistrationToken token);

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        new void remove_WebMessageReceived([In] EventRegistrationToken token);

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        new void Close();

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        new void CallDevToolsProtocolMethod(
          [MarshalAs(UnmanagedType.LPWStr), In] string methodName,
          [MarshalAs(UnmanagedType.LPWStr), In] string parametersAsJson,
          [MarshalAs(UnmanagedType.Interface), In] IWebView2CallDevToolsProtocolMethodCompletedHandler handler);

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        new void add_DevToolsProtocolEventReceived(
          [MarshalAs(UnmanagedType.LPWStr), In] string eventName,
          [MarshalAs(UnmanagedType.Interface), In] IWebView2DevToolsProtocolEventReceivedEventHandler handler,
          out EventRegistrationToken token);

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        new void remove_DevToolsProtocolEventReceived([MarshalAs(UnmanagedType.LPWStr), In] string eventName, [In] EventRegistrationToken token);

        [DispId(1610678320)]
        new uint BrowserProcessId { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

        [DispId(1610678321)]
        new int CanGoBack { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

        [DispId(1610678322)]
        new int CanGoForward { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        new void GoBack();

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        new void GoForward();

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        new void Stop();

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        new void add_NewWindowRequested(
          [MarshalAs(UnmanagedType.Interface), In] IWebView2NewWindowRequestedEventHandler eventHandler,
          out EventRegistrationToken token);

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        new void remove_NewWindowRequested([In] EventRegistrationToken token);

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        new void add_DocumentTitleChanged(
          [MarshalAs(UnmanagedType.Interface), In] IWebView2DocumentTitleChangedEventHandler eventHandler,
          out EventRegistrationToken token);

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        new void remove_DocumentTitleChanged([In] EventRegistrationToken token);

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        new void DocumentTitle([MarshalAs(UnmanagedType.LPWStr)] out string title);

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        new void AddRemoteObject([MarshalAs(UnmanagedType.LPWStr), In] string name, [MarshalAs(UnmanagedType.Struct), In] ref object @object);
        //new void AddRemoteObject([MarshalAs(UnmanagedType.LPWStr), In] string name, [In][MarshalAs(UnmanagedType.IDispatch)] object obj);

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        new void RemoveRemoteObject([MarshalAs(UnmanagedType.LPWStr), In] string name);

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        new void OpenDevToolsWindow();

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        new void add_AcceleratorKeyPressed(
          [MarshalAs(UnmanagedType.Interface), In] IWebView2AcceleratorKeyPressedEventHandler eventHandler,
          out EventRegistrationToken token);

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        new void remove_AcceleratorKeyPressed([In] EventRegistrationToken token);

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void add_ContainsFullScreenElementChanged(
          [MarshalAs(UnmanagedType.Interface), In] IWebView2ContainsFullScreenElementChangedEventHandler eventHandler,
          out EventRegistrationToken token);

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void remove_ContainsFullScreenElementChanged([In] EventRegistrationToken token);

        [DispId(1610874882)]
        int ContainsFullScreenElement { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void add_WebResourceRequested(
          [MarshalAs(UnmanagedType.Interface), In] IWebView2WebResourceRequestedEventHandler eventHandler,
          out EventRegistrationToken token);

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void AddWebResourceRequestedFilter([MarshalAs(UnmanagedType.LPWStr), In] string uri, [In] WEBVIEW2_WEB_RESOURCE_CONTEXT resourceContext);

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void RemoveWebResourceRequestedFilter([MarshalAs(UnmanagedType.LPWStr), In] string uri, [In] WEBVIEW2_WEB_RESOURCE_CONTEXT resourceContext);
    }
}
