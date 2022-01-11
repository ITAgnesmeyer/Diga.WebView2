// Decompiled with JetBrains decompiler
// Type: Diga.WebView2.Interop.ICoreWebView2_9
// Assembly: Diga.WebView2.Interop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 03E6B0A7-E6B7-472F-A8B3-541AB2D8627C
// Assembly location: O:\webview2\V10107254\Diga.WebView2.Interop.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;

namespace Diga.WebView2.Interop
{
  [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
  [Guid("4D7B2EAB-9FDC-468D-B998-A9260B5ED651")]
  [ComImport]
  public interface ICoreWebView2_9 : ICoreWebView2_8
  {
    [DispId(1610678272)]
    new ICoreWebView2Settings Settings { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

    [DispId(1610678273)]
    new string Source { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.LPWStr)] get; }

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    new void Navigate([MarshalAs(UnmanagedType.LPWStr), In] string uri);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    new void NavigateToString([MarshalAs(UnmanagedType.LPWStr), In] string htmlContent);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    new void add_NavigationStarting(
      [MarshalAs(UnmanagedType.Interface), In] ICoreWebView2NavigationStartingEventHandler eventHandler,
      out EventRegistrationToken token);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    new void remove_NavigationStarting([In] EventRegistrationToken token);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    new void add_ContentLoading(
      [MarshalAs(UnmanagedType.Interface), In] ICoreWebView2ContentLoadingEventHandler eventHandler,
      out EventRegistrationToken token);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    new void remove_ContentLoading([In] EventRegistrationToken token);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    new void add_SourceChanged(
      [MarshalAs(UnmanagedType.Interface), In] ICoreWebView2SourceChangedEventHandler eventHandler,
      out EventRegistrationToken token);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    new void remove_SourceChanged([In] EventRegistrationToken token);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    new void add_HistoryChanged(
      [MarshalAs(UnmanagedType.Interface), In] ICoreWebView2HistoryChangedEventHandler eventHandler,
      out EventRegistrationToken token);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    new void remove_HistoryChanged([In] EventRegistrationToken token);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    new void add_NavigationCompleted(
      [MarshalAs(UnmanagedType.Interface), In] ICoreWebView2NavigationCompletedEventHandler eventHandler,
      out EventRegistrationToken token);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    new void remove_NavigationCompleted([In] EventRegistrationToken token);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    new void add_FrameNavigationStarting(
      [MarshalAs(UnmanagedType.Interface), In] ICoreWebView2NavigationStartingEventHandler eventHandler,
      out EventRegistrationToken token);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    new void remove_FrameNavigationStarting([In] EventRegistrationToken token);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    new void add_FrameNavigationCompleted(
      [MarshalAs(UnmanagedType.Interface), In] ICoreWebView2NavigationCompletedEventHandler eventHandler,
      out EventRegistrationToken token);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    new void remove_FrameNavigationCompleted([In] EventRegistrationToken token);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    new void add_ScriptDialogOpening(
      [MarshalAs(UnmanagedType.Interface), In] ICoreWebView2ScriptDialogOpeningEventHandler eventHandler,
      out EventRegistrationToken token);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    new void remove_ScriptDialogOpening([In] EventRegistrationToken token);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    new void add_PermissionRequested(
      [MarshalAs(UnmanagedType.Interface), In] ICoreWebView2PermissionRequestedEventHandler eventHandler,
      out EventRegistrationToken token);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    new void remove_PermissionRequested([In] EventRegistrationToken token);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    new void add_ProcessFailed(
      [MarshalAs(UnmanagedType.Interface), In] ICoreWebView2ProcessFailedEventHandler eventHandler,
      out EventRegistrationToken token);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    new void remove_ProcessFailed([In] EventRegistrationToken token);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    new void AddScriptToExecuteOnDocumentCreated(
      [MarshalAs(UnmanagedType.LPWStr), In] string javaScript,
      [MarshalAs(UnmanagedType.Interface), In] ICoreWebView2AddScriptToExecuteOnDocumentCreatedCompletedHandler handler);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    new void RemoveScriptToExecuteOnDocumentCreated([MarshalAs(UnmanagedType.LPWStr), In] string id);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    new void ExecuteScript([MarshalAs(UnmanagedType.LPWStr), In] string javaScript, [MarshalAs(UnmanagedType.Interface), In] ICoreWebView2ExecuteScriptCompletedHandler handler);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    new void CapturePreview(
      [In] COREWEBVIEW2_CAPTURE_PREVIEW_IMAGE_FORMAT imageFormat,
      [MarshalAs(UnmanagedType.Interface), In] IStream imageStream,
      [MarshalAs(UnmanagedType.Interface), In] ICoreWebView2CapturePreviewCompletedHandler handler);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    new void Reload();

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    new void PostWebMessageAsJson([MarshalAs(UnmanagedType.LPWStr), In] string webMessageAsJson);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    new void PostWebMessageAsString([MarshalAs(UnmanagedType.LPWStr), In] string webMessageAsString);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    new void add_WebMessageReceived(
      [MarshalAs(UnmanagedType.Interface), In] ICoreWebView2WebMessageReceivedEventHandler handler,
      out EventRegistrationToken token);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    new void remove_WebMessageReceived([In] EventRegistrationToken token);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    new void CallDevToolsProtocolMethod(
      [MarshalAs(UnmanagedType.LPWStr), In] string methodName,
      [MarshalAs(UnmanagedType.LPWStr), In] string parametersAsJson,
      [MarshalAs(UnmanagedType.Interface), In] ICoreWebView2CallDevToolsProtocolMethodCompletedHandler handler);

    [DispId(1610678306)]
    new uint BrowserProcessId { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

    [DispId(1610678307)]
    new int CanGoBack { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

    [DispId(1610678308)]
    new int CanGoForward { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    new void GoBack();

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    new void GoForward();

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.Interface)]
    new ICoreWebView2DevToolsProtocolEventReceiver GetDevToolsProtocolEventReceiver(
      [MarshalAs(UnmanagedType.LPWStr), In] string eventName);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    new void Stop();

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    new void add_NewWindowRequested(
      [MarshalAs(UnmanagedType.Interface), In] ICoreWebView2NewWindowRequestedEventHandler eventHandler,
      out EventRegistrationToken token);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    new void remove_NewWindowRequested([In] EventRegistrationToken token);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    new void add_DocumentTitleChanged(
      [MarshalAs(UnmanagedType.Interface), In] ICoreWebView2DocumentTitleChangedEventHandler eventHandler,
      out EventRegistrationToken token);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    new void remove_DocumentTitleChanged([In] EventRegistrationToken token);

    [DispId(1610678317)]
    new string DocumentTitle { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.LPWStr)] get; }

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    new void AddHostObjectToScript([MarshalAs(UnmanagedType.LPWStr), In] string name, [ In] ref object @object);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    new void RemoveHostObjectFromScript([MarshalAs(UnmanagedType.LPWStr), In] string name);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    new void OpenDevToolsWindow();

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    new void add_ContainsFullScreenElementChanged(
      [MarshalAs(UnmanagedType.Interface), In] ICoreWebView2ContainsFullScreenElementChangedEventHandler eventHandler,
      out EventRegistrationToken token);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    new void remove_ContainsFullScreenElementChanged([In] EventRegistrationToken token);

    [DispId(1610678323)]
    new int ContainsFullScreenElement { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    new void add_WebResourceRequested(
      [MarshalAs(UnmanagedType.Interface), In] ICoreWebView2WebResourceRequestedEventHandler eventHandler,
      out EventRegistrationToken token);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    new void remove_WebResourceRequested([In] EventRegistrationToken token);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    new void AddWebResourceRequestedFilter(
      [MarshalAs(UnmanagedType.LPWStr), In] string uri,
      [In] COREWEBVIEW2_WEB_RESOURCE_CONTEXT ResourceContext);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    new void RemoveWebResourceRequestedFilter(
      [MarshalAs(UnmanagedType.LPWStr), In] string uri,
      [In] COREWEBVIEW2_WEB_RESOURCE_CONTEXT ResourceContext);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    new void add_WindowCloseRequested(
      [MarshalAs(UnmanagedType.Interface), In] ICoreWebView2WindowCloseRequestedEventHandler eventHandler,
      out EventRegistrationToken token);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    new void remove_WindowCloseRequested([In] EventRegistrationToken token);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    new void add_WebResourceResponseReceived(
      [MarshalAs(UnmanagedType.Interface), In] ICoreWebView2WebResourceResponseReceivedEventHandler eventHandler,
      out EventRegistrationToken token);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    new void remove_WebResourceResponseReceived([In] EventRegistrationToken token);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    new void NavigateWithWebResourceRequest([MarshalAs(UnmanagedType.Interface), In] ICoreWebView2WebResourceRequest Request);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    new void add_DOMContentLoaded(
      [MarshalAs(UnmanagedType.Interface), In] ICoreWebView2DOMContentLoadedEventHandler eventHandler,
      out EventRegistrationToken token);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    new void remove_DOMContentLoaded([In] EventRegistrationToken token);

    [DispId(1610743813)]
    new ICoreWebView2CookieManager CookieManager { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

    [DispId(1610743814)]
    new ICoreWebView2Environment Environment { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    new void TrySuspend([MarshalAs(UnmanagedType.Interface), In] ICoreWebView2TrySuspendCompletedHandler handler);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    new void Resume();

    [DispId(1610809346)]
    new int IsSuspended { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    new void SetVirtualHostNameToFolderMapping(
      [MarshalAs(UnmanagedType.LPWStr), In] string hostName,
      [MarshalAs(UnmanagedType.LPWStr), In] string folderPath,
      [In] COREWEBVIEW2_HOST_RESOURCE_ACCESS_KIND accessKind);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    new void ClearVirtualHostNameToFolderMapping([MarshalAs(UnmanagedType.LPWStr), In] string hostName);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    new void add_FrameCreated(
      [MarshalAs(UnmanagedType.Interface), In] ICoreWebView2FrameCreatedEventHandler eventHandler,
      out EventRegistrationToken token);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    new void remove_FrameCreated([In] EventRegistrationToken token);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    new void add_DownloadStarting(
      [MarshalAs(UnmanagedType.Interface), In] ICoreWebView2DownloadStartingEventHandler eventHandler,
      out EventRegistrationToken token);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    new void remove_DownloadStarting([In] EventRegistrationToken token);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    new void add_ClientCertificateRequested(
      [MarshalAs(UnmanagedType.Interface), In] ICoreWebView2ClientCertificateRequestedEventHandler eventHandler,
      out EventRegistrationToken token);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    new void remove_ClientCertificateRequested([In] EventRegistrationToken token);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    new void OpenTaskManagerWindow();

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    new void PrintToPdf(
      [MarshalAs(UnmanagedType.LPWStr), In] string ResultFilePath,
      [MarshalAs(UnmanagedType.Interface), In] ICoreWebView2PrintSettings printSettings,
      [MarshalAs(UnmanagedType.Interface), In] ICoreWebView2PrintToPdfCompletedHandler handler);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    new void add_IsMutedChanged(
      [MarshalAs(UnmanagedType.Interface), In] ICoreWebView2IsMutedChangedEventHandler eventHandler,
      out EventRegistrationToken token);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    new void remove_IsMutedChanged([In] EventRegistrationToken token);

    [DispId(1611137026)]
    new int IsMuted { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    new void add_IsDocumentPlayingAudioChanged(
      [MarshalAs(UnmanagedType.Interface), In] ICoreWebView2IsDocumentPlayingAudioChangedEventHandler eventHandler,
      out EventRegistrationToken token);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    new void remove_IsDocumentPlayingAudioChanged([In] EventRegistrationToken token);

    [DispId(1611137030)]
    new int IsDocumentPlayingAudio { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void add_IsDefaultDownloadDialogOpenChanged(
      [MarshalAs(UnmanagedType.Interface), In] ICoreWebView2IsDefaultDownloadDialogOpenChangedEventHandler handler,
      out EventRegistrationToken token);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void remove_IsDefaultDownloadDialogOpenChanged([In] EventRegistrationToken token);

    [DispId(1611202562)]
    int IsDefaultDownloadDialogOpen { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void OpenDefaultDownloadDialog();

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void CloseDefaultDownloadDialog();

    [DispId(1611202565)]
    COREWEBVIEW2_DEFAULT_DOWNLOAD_DIALOG_CORNER_ALIGNMENT DefaultDownloadDialogCornerAlignment { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

    [DispId(1611202567)]
    tagPOINT DefaultDownloadDialogMargin { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }
  }
}
