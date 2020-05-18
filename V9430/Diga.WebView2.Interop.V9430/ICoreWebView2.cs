// Decompiled with JetBrains decompiler
// Type: WebView2.ICoreWebView2
// Assembly: WebView2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 390039CF-BF77-421E-8AE4-CC8FD0DF2A08
// Assembly location: O:\dev\webview2-interop-master\Src\WebView2.dll

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;

namespace Diga.WebView2.Interop
{
    [Guid("5CC5293D-AF6F-41D4-9619-44BD31BA4C93")]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    [ComImport]
    public interface ICoreWebView2
    {
        [DispId(1610678272)]
        ICoreWebView2Settings Settings { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

        [DispId(1610678273)]
        string Source { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.LPWStr)] get; }

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void Navigate([MarshalAs(UnmanagedType.LPWStr), In] string uri);

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void NavigateToString([MarshalAs(UnmanagedType.LPWStr), In] string htmlContent);

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void add_NavigationStarting(
          [MarshalAs(UnmanagedType.Interface), In] ICoreWebView2NavigationStartingEventHandler eventHandler,
          out EventRegistrationToken token);

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void remove_NavigationStarting([In] EventRegistrationToken token);

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void add_ContentLoading(
          [MarshalAs(UnmanagedType.Interface), In] ICoreWebView2ContentLoadingEventHandler eventHandler,
          out EventRegistrationToken token);

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void remove_ContentLoading([In] EventRegistrationToken token);

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void add_SourceChanged(
          [MarshalAs(UnmanagedType.Interface), In] ICoreWebView2SourceChangedEventHandler eventHandler,
          out EventRegistrationToken token);

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void remove_SourceChanged([In] EventRegistrationToken token);

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void add_HistoryChanged(
          [MarshalAs(UnmanagedType.Interface), In] ICoreWebView2HistoryChangedEventHandler eventHandler,
          out EventRegistrationToken token);

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void remove_HistoryChanged([In] EventRegistrationToken token);

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void add_NavigationCompleted(
          [MarshalAs(UnmanagedType.Interface), In] ICoreWebView2NavigationCompletedEventHandler eventHandler,
          out EventRegistrationToken token);

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void remove_NavigationCompleted([In] EventRegistrationToken token);

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void add_FrameNavigationStarting(
          [MarshalAs(UnmanagedType.Interface), In] ICoreWebView2NavigationStartingEventHandler eventHandler,
          out EventRegistrationToken token);

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void remove_FrameNavigationStarting([In] EventRegistrationToken token);

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void add_ScriptDialogOpening(
          [MarshalAs(UnmanagedType.Interface), In] ICoreWebView2ScriptDialogOpeningEventHandler eventHandler,
          out EventRegistrationToken token);

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void remove_ScriptDialogOpening([In] EventRegistrationToken token);

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void add_PermissionRequested(
          [MarshalAs(UnmanagedType.Interface), In] ICoreWebView2PermissionRequestedEventHandler eventHandler,
          out EventRegistrationToken token);

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void remove_PermissionRequested([In] EventRegistrationToken token);

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void add_ProcessFailed(
          [MarshalAs(UnmanagedType.Interface), In] ICoreWebView2ProcessFailedEventHandler eventHandler,
          out EventRegistrationToken token);

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void remove_ProcessFailed([In] EventRegistrationToken token);

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void AddScriptToExecuteOnDocumentCreated(
          [MarshalAs(UnmanagedType.LPWStr), In] string javaScript,
          [MarshalAs(UnmanagedType.Interface), In] ICoreWebView2AddScriptToExecuteOnDocumentCreatedCompletedHandler handler);

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void RemoveScriptToExecuteOnDocumentCreated([MarshalAs(UnmanagedType.LPWStr), In] string id);

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void ExecuteScript([MarshalAs(UnmanagedType.LPWStr), In] string javaScript, [MarshalAs(UnmanagedType.Interface), In] ICoreWebView2ExecuteScriptCompletedHandler handler);

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void CapturePreview(
          [In] CORE_WEBVIEW2_CAPTURE_PREVIEW_IMAGE_FORMAT imageFormat,
          [MarshalAs(UnmanagedType.Interface), In] IStream imageStream,
          [MarshalAs(UnmanagedType.Interface), In] ICoreWebView2CapturePreviewCompletedHandler handler);

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void Reload();

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void PostWebMessageAsJson([MarshalAs(UnmanagedType.LPWStr), In] string webMessageAsJson);

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void PostWebMessageAsString([MarshalAs(UnmanagedType.LPWStr), In] string webMessageAsString);

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void add_WebMessageReceived(
          [MarshalAs(UnmanagedType.Interface), In] ICoreWebView2WebMessageReceivedEventHandler handler,
          out EventRegistrationToken token);

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void remove_WebMessageReceived([In] EventRegistrationToken token);

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void CallDevToolsProtocolMethod(
          [MarshalAs(UnmanagedType.LPWStr), In] string methodName,
          [MarshalAs(UnmanagedType.LPWStr), In] string parametersAsJson,
          [MarshalAs(UnmanagedType.Interface), In] ICoreWebView2CallDevToolsProtocolMethodCompletedHandler handler);

        [DispId(1610678304)]
        uint BrowserProcessId { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

        [DispId(1610678305)]
        int CanGoBack { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

        [DispId(1610678306)]
        int CanGoForward { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void GoBack();

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void GoForward();

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        [return: MarshalAs(UnmanagedType.Interface)]
        ICoreWebView2DevToolsProtocolEventReceiver GetDevToolsProtocolEventReceiver(
          [MarshalAs(UnmanagedType.LPWStr), In] string eventName);

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void Stop();

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void add_NewWindowRequested(
          [MarshalAs(UnmanagedType.Interface), In] ICoreWebView2NewWindowRequestedEventHandler eventHandler,
          out EventRegistrationToken token);

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void remove_NewWindowRequested([In] EventRegistrationToken token);

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void add_DocumentTitleChanged(
          [MarshalAs(UnmanagedType.Interface), In] ICoreWebView2DocumentTitleChangedEventHandler eventHandler,
          out EventRegistrationToken token);

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void remove_DocumentTitleChanged([In] EventRegistrationToken token);

        [DispId(1610678315)]
        string DocumentTitle { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.LPWStr)] get; }

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void AddRemoteObject([MarshalAs(UnmanagedType.LPWStr), In] string name, [MarshalAs(UnmanagedType.Struct), In] ref object @object);

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void RemoveRemoteObject([MarshalAs(UnmanagedType.LPWStr), In] string name);

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void OpenDevToolsWindow();

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void add_ContainsFullScreenElementChanged(
          [MarshalAs(UnmanagedType.Interface), In] ICoreWebView2ContainsFullScreenElementChangedEventHandler eventHandler,
          out EventRegistrationToken token);

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void remove_ContainsFullScreenElementChanged([In] EventRegistrationToken token);

        [DispId(1610678321)]
        int ContainsFullScreenElement { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void add_WebResourceRequested(
          [MarshalAs(UnmanagedType.Interface), In] ICoreWebView2WebResourceRequestedEventHandler eventHandler,
          out EventRegistrationToken token);

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void remove_WebResourceRequested([In] EventRegistrationToken token);

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void AddWebResourceRequestedFilter(
          [MarshalAs(UnmanagedType.LPWStr), In] string uri,
          [In] CORE_WEBVIEW2_WEB_RESOURCE_CONTEXT ResourceContext);

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void RemoveWebResourceRequestedFilter(
          [MarshalAs(UnmanagedType.LPWStr), In] string uri,
          [In] CORE_WEBVIEW2_WEB_RESOURCE_CONTEXT ResourceContext);

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void add_WindowCloseRequested(
          [MarshalAs(UnmanagedType.Interface), In] ICoreWebView2WindowCloseRequestedEventHandler eventHandler,
          out EventRegistrationToken token);

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void remove_WindowCloseRequested([In] EventRegistrationToken token);
    }
}
