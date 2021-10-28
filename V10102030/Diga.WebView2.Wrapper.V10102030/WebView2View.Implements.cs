using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using Diga.WebView2.Interop;

namespace Diga.WebView2.Wrapper
{
    public partial class WebView2View : ICoreWebView2_7
    {
        private ICoreWebView2_7 _WebView;

        ICoreWebView2Settings ICoreWebView2_7.Settings => _WebView.Settings;

        public void add_NavigationStarting([In, MarshalAs(UnmanagedType.Interface)] ICoreWebView2NavigationStartingEventHandler eventHandler, out EventRegistrationToken token)
        {
            _WebView.add_NavigationStarting(eventHandler, out token);
        }

        public void remove_NavigationStarting([In] EventRegistrationToken token)
        {
            _WebView.remove_NavigationStarting(token);
        }

        public void add_ContentLoading([In, MarshalAs(UnmanagedType.Interface)] ICoreWebView2ContentLoadingEventHandler eventHandler, out EventRegistrationToken token)
        {
            _WebView.add_ContentLoading(eventHandler, out token);
        }

        public void remove_ContentLoading([In] EventRegistrationToken token)
        {
            _WebView.remove_ContentLoading(token);
        }

        public void add_SourceChanged([In, MarshalAs(UnmanagedType.Interface)] ICoreWebView2SourceChangedEventHandler eventHandler, out EventRegistrationToken token)
        {
            _WebView.add_SourceChanged(eventHandler, out token);
        }

        public void remove_SourceChanged([In] EventRegistrationToken token)
        {
            _WebView.remove_SourceChanged(token);
        }

        public void add_HistoryChanged([In, MarshalAs(UnmanagedType.Interface)] ICoreWebView2HistoryChangedEventHandler eventHandler, out EventRegistrationToken token)
        {
            _WebView.add_HistoryChanged(eventHandler, out token);
        }

        public void remove_HistoryChanged([In] EventRegistrationToken token)
        {
            _WebView.remove_HistoryChanged(token);
        }

        public void add_NavigationCompleted([In, MarshalAs(UnmanagedType.Interface)] ICoreWebView2NavigationCompletedEventHandler eventHandler, out EventRegistrationToken token)
        {
            _WebView.add_NavigationCompleted(eventHandler, out token);
        }

        public void remove_NavigationCompleted([In] EventRegistrationToken token)
        {
            _WebView.remove_NavigationCompleted(token);
        }

        public void add_FrameNavigationStarting([In, MarshalAs(UnmanagedType.Interface)] ICoreWebView2NavigationStartingEventHandler eventHandler, out EventRegistrationToken token)
        {
            _WebView.add_FrameNavigationStarting(eventHandler, out token);
        }

        public void remove_FrameNavigationStarting([In] EventRegistrationToken token)
        {
            _WebView.remove_FrameNavigationStarting(token);
        }

        public void add_FrameNavigationCompleted([In, MarshalAs(UnmanagedType.Interface)] ICoreWebView2NavigationCompletedEventHandler eventHandler, out EventRegistrationToken token)
        {
            _WebView.add_FrameNavigationCompleted(eventHandler, out token);
        }

        public void remove_FrameNavigationCompleted([In] EventRegistrationToken token)
        {
            _WebView.remove_FrameNavigationCompleted(token);
        }

        public void add_ScriptDialogOpening([In, MarshalAs(UnmanagedType.Interface)] ICoreWebView2ScriptDialogOpeningEventHandler eventHandler, out EventRegistrationToken token)
        {
            _WebView.add_ScriptDialogOpening(eventHandler, out token);
        }

        public void remove_ScriptDialogOpening([In] EventRegistrationToken token)
        {
            _WebView.remove_ScriptDialogOpening(token);
        }

        public void add_PermissionRequested([In, MarshalAs(UnmanagedType.Interface)] ICoreWebView2PermissionRequestedEventHandler eventHandler, out EventRegistrationToken token)
        {
            _WebView.add_PermissionRequested(eventHandler, out token);
        }

        public void remove_PermissionRequested([In] EventRegistrationToken token)
        {
            _WebView.remove_PermissionRequested(token);
        }

        public void add_ProcessFailed([In, MarshalAs(UnmanagedType.Interface)] ICoreWebView2ProcessFailedEventHandler eventHandler, out EventRegistrationToken token)
        {
            _WebView.add_ProcessFailed(eventHandler, out token);
        }

        public void remove_ProcessFailed([In] EventRegistrationToken token)
        {
            _WebView.remove_ProcessFailed(token);
        }

        public void AddScriptToExecuteOnDocumentCreated([In, MarshalAs(UnmanagedType.LPWStr)] string javaScript, [In, MarshalAs(UnmanagedType.Interface)] ICoreWebView2AddScriptToExecuteOnDocumentCreatedCompletedHandler handler)
        {
            _WebView.AddScriptToExecuteOnDocumentCreated(javaScript, handler);
        }

        public void ExecuteScript([In, MarshalAs(UnmanagedType.LPWStr)] string javaScript, [In, MarshalAs(UnmanagedType.Interface)] ICoreWebView2ExecuteScriptCompletedHandler handler)
        {
            _WebView.ExecuteScript(javaScript, handler);
        }

        public void CapturePreview([In] COREWEBVIEW2_CAPTURE_PREVIEW_IMAGE_FORMAT imageFormat, [In, MarshalAs(UnmanagedType.Interface)] IStream imageStream, [In, MarshalAs(UnmanagedType.Interface)] ICoreWebView2CapturePreviewCompletedHandler handler)
        {
            _WebView.CapturePreview(imageFormat, imageStream, handler);
        }

        public void add_WebMessageReceived([In, MarshalAs(UnmanagedType.Interface)] ICoreWebView2WebMessageReceivedEventHandler handler, out EventRegistrationToken token)
        {
            _WebView.add_WebMessageReceived(handler, out token);
        }

        public void remove_WebMessageReceived([In] EventRegistrationToken token)
        {
            _WebView.remove_WebMessageReceived(token);
        }

        public void CallDevToolsProtocolMethod([In, MarshalAs(UnmanagedType.LPWStr)] string methodName, [In, MarshalAs(UnmanagedType.LPWStr)] string parametersAsJson, [In, MarshalAs(UnmanagedType.Interface)] ICoreWebView2CallDevToolsProtocolMethodCompletedHandler handler)
        {
            _WebView.CallDevToolsProtocolMethod(methodName, parametersAsJson, handler);
        }

        int ICoreWebView2_7.CanGoBack => _WebView.CanGoBack;

        int ICoreWebView2_7.CanGoForward => _WebView.CanGoForward;

        [return: MarshalAs(UnmanagedType.Interface)]
        public ICoreWebView2DevToolsProtocolEventReceiver GetDevToolsProtocolEventReceiver([In, MarshalAs(UnmanagedType.LPWStr)] string eventName)
        {
            return _WebView.GetDevToolsProtocolEventReceiver(eventName);
        }

        public void add_NewWindowRequested([In, MarshalAs(UnmanagedType.Interface)] ICoreWebView2NewWindowRequestedEventHandler eventHandler, out EventRegistrationToken token)
        {
            _WebView.add_NewWindowRequested(eventHandler, out token);
        }

        public void remove_NewWindowRequested([In] EventRegistrationToken token)
        {
            _WebView.remove_NewWindowRequested(token);
        }

        public void add_DocumentTitleChanged([In, MarshalAs(UnmanagedType.Interface)] ICoreWebView2DocumentTitleChangedEventHandler eventHandler, out EventRegistrationToken token)
        {
            _WebView.add_DocumentTitleChanged(eventHandler, out token);
        }

        public void remove_DocumentTitleChanged([In] EventRegistrationToken token)
        {
            _WebView.remove_DocumentTitleChanged(token);
        }

        public void AddHostObjectToScript([In, MarshalAs(UnmanagedType.LPWStr)] string name, [In, MarshalAs(UnmanagedType.Struct)] ref object @object)
        {
            _WebView.AddHostObjectToScript(name, ref @object);
        }

        public void RemoveHostObjectFromScript([In, MarshalAs(UnmanagedType.LPWStr)] string name)
        {
            _WebView.RemoveHostObjectFromScript(name);
        }

        public void add_ContainsFullScreenElementChanged([In, MarshalAs(UnmanagedType.Interface)] ICoreWebView2ContainsFullScreenElementChangedEventHandler eventHandler, out EventRegistrationToken token)
        {
            _WebView.add_ContainsFullScreenElementChanged(eventHandler, out token);
        }

        public void remove_ContainsFullScreenElementChanged([In] EventRegistrationToken token)
        {
            _WebView.remove_ContainsFullScreenElementChanged(token);
        }

        int ICoreWebView2_7.ContainsFullScreenElement => _WebView.ContainsFullScreenElement;

        public void add_WebResourceRequested([In, MarshalAs(UnmanagedType.Interface)] ICoreWebView2WebResourceRequestedEventHandler eventHandler, out EventRegistrationToken token)
        {
            _WebView.add_WebResourceRequested(eventHandler, out token);
        }

        public void remove_WebResourceRequested([In] EventRegistrationToken token)
        {
            _WebView.remove_WebResourceRequested(token);
        }

        public void AddWebResourceRequestedFilter([In, MarshalAs(UnmanagedType.LPWStr)] string uri, [In] COREWEBVIEW2_WEB_RESOURCE_CONTEXT ResourceContext)
        {
            _WebView.AddWebResourceRequestedFilter(uri, ResourceContext);
        }

        public void RemoveWebResourceRequestedFilter([In, MarshalAs(UnmanagedType.LPWStr)] string uri, [In] COREWEBVIEW2_WEB_RESOURCE_CONTEXT ResourceContext)
        {
            _WebView.RemoveWebResourceRequestedFilter(uri, ResourceContext);
        }

        public void add_WindowCloseRequested([In, MarshalAs(UnmanagedType.Interface)] ICoreWebView2WindowCloseRequestedEventHandler eventHandler, out EventRegistrationToken token)
        {
            _WebView.add_WindowCloseRequested(eventHandler, out token);
        }

        public void remove_WindowCloseRequested([In] EventRegistrationToken token)
        {
            _WebView.remove_WindowCloseRequested(token);
        }

        public void add_WebResourceResponseReceived([In, MarshalAs(UnmanagedType.Interface)] ICoreWebView2WebResourceResponseReceivedEventHandler eventHandler, out EventRegistrationToken token)
        {
            _WebView.add_WebResourceResponseReceived(eventHandler, out token);
        }

        public void remove_WebResourceResponseReceived([In] EventRegistrationToken token)
        {
            _WebView.remove_WebResourceResponseReceived(token);
        }

        public void NavigateWithWebResourceRequest([In, MarshalAs(UnmanagedType.Interface)] ICoreWebView2WebResourceRequest Request)
        {
            _WebView.NavigateWithWebResourceRequest(Request);
        }

        public void add_DOMContentLoaded([In, MarshalAs(UnmanagedType.Interface)] ICoreWebView2DOMContentLoadedEventHandler eventHandler, out EventRegistrationToken token)
        {
            _WebView.add_DOMContentLoaded(eventHandler, out token);
        }

        public void remove_DOMContentLoaded([In] EventRegistrationToken token)
        {
            _WebView.remove_DOMContentLoaded(token);
        }

        ICoreWebView2CookieManager ICoreWebView2_7.CookieManager => _WebView.CookieManager;

        public ICoreWebView2Environment Environment => _WebView.Environment;

        public void TrySuspend([In, MarshalAs(UnmanagedType.Interface)] ICoreWebView2TrySuspendCompletedHandler handler)
        {
            _WebView.TrySuspend(handler);
        }

        public void Resume()
        {
            _WebView.Resume();
        }

        public int IsSuspended => _WebView.IsSuspended;

        public void SetVirtualHostNameToFolderMapping([In, MarshalAs(UnmanagedType.LPWStr)] string hostName, [In, MarshalAs(UnmanagedType.LPWStr)] string folderPath, [In] COREWEBVIEW2_HOST_RESOURCE_ACCESS_KIND accessKind)
        {
            _WebView.SetVirtualHostNameToFolderMapping(hostName, folderPath, accessKind);
        }

        public void ClearVirtualHostNameToFolderMapping([In, MarshalAs(UnmanagedType.LPWStr)] string hostName)
        {
            _WebView.ClearVirtualHostNameToFolderMapping(hostName);
        }

        public void add_FrameCreated([In, MarshalAs(UnmanagedType.Interface)] ICoreWebView2FrameCreatedEventHandler eventHandler, out EventRegistrationToken token)
        {
            _WebView.add_FrameCreated(eventHandler, out token);
        }

        public void remove_FrameCreated([In] EventRegistrationToken token)
        {
            _WebView.remove_FrameCreated(token);
        }

        public void add_DownloadStarting([In, MarshalAs(UnmanagedType.Interface)] ICoreWebView2DownloadStartingEventHandler eventHandler, out EventRegistrationToken token)
        {
            _WebView.add_DownloadStarting(eventHandler, out token);
        }

        public void remove_DownloadStarting([In] EventRegistrationToken token)
        {
            _WebView.remove_DownloadStarting(token);
        }

        public void add_ClientCertificateRequested([In, MarshalAs(UnmanagedType.Interface)] ICoreWebView2ClientCertificateRequestedEventHandler eventHandler, out EventRegistrationToken token)
        {
            _WebView.add_ClientCertificateRequested(eventHandler, out token);
        }

        public void remove_ClientCertificateRequested([In] EventRegistrationToken token)
        {
            _WebView.remove_ClientCertificateRequested(token);
        }

        public void PrintToPdf([In, MarshalAs(UnmanagedType.LPWStr)] string ResultFilePath, [In, MarshalAs(UnmanagedType.Interface)] ICoreWebView2PrintSettings printSettings, [In, MarshalAs(UnmanagedType.Interface)] ICoreWebView2PrintToPdfCompletedHandler handler)
        {
            _WebView.PrintToPdf(ResultFilePath, printSettings, handler);
        }

        ICoreWebView2Settings ICoreWebView2_6.Settings => ((ICoreWebView2_6)_WebView).Settings;

        int ICoreWebView2_6.CanGoBack => ((ICoreWebView2_6)_WebView).CanGoBack;

        int ICoreWebView2_6.CanGoForward => ((ICoreWebView2_6)_WebView).CanGoForward;

        int ICoreWebView2_6.ContainsFullScreenElement => ((ICoreWebView2_6)_WebView).ContainsFullScreenElement;

        ICoreWebView2CookieManager ICoreWebView2_6.CookieManager => ((ICoreWebView2_6)_WebView).CookieManager;

        ICoreWebView2Settings ICoreWebView2_5.Settings => ((ICoreWebView2_5)_WebView).Settings;

        int ICoreWebView2_5.CanGoBack => ((ICoreWebView2_5)_WebView).CanGoBack;

        int ICoreWebView2_5.CanGoForward => ((ICoreWebView2_5)_WebView).CanGoForward;

        int ICoreWebView2_5.ContainsFullScreenElement => ((ICoreWebView2_5)_WebView).ContainsFullScreenElement;

        ICoreWebView2CookieManager ICoreWebView2_5.CookieManager => ((ICoreWebView2_5)_WebView).CookieManager;

        ICoreWebView2Settings ICoreWebView2_4.Settings => ((ICoreWebView2_4)_WebView).Settings;

        int ICoreWebView2_4.CanGoBack => ((ICoreWebView2_4)_WebView).CanGoBack;

        int ICoreWebView2_4.CanGoForward => ((ICoreWebView2_4)_WebView).CanGoForward;

        int ICoreWebView2_4.ContainsFullScreenElement => ((ICoreWebView2_4)_WebView).ContainsFullScreenElement;

        ICoreWebView2CookieManager ICoreWebView2_4.CookieManager => ((ICoreWebView2_4)_WebView).CookieManager;

        ICoreWebView2Settings ICoreWebView2_3.Settings => ((ICoreWebView2_3)_WebView).Settings;

        int ICoreWebView2_3.CanGoBack => ((ICoreWebView2_3)_WebView).CanGoBack;

        int ICoreWebView2_3.CanGoForward => ((ICoreWebView2_3)_WebView).CanGoForward;

        int ICoreWebView2_3.ContainsFullScreenElement => ((ICoreWebView2_3)_WebView).ContainsFullScreenElement;

        ICoreWebView2CookieManager ICoreWebView2_3.CookieManager => ((ICoreWebView2_3)_WebView).CookieManager;

        ICoreWebView2Settings ICoreWebView2_2.Settings => ((ICoreWebView2_2)_WebView).Settings;

        int ICoreWebView2_2.CanGoBack => ((ICoreWebView2_2)_WebView).CanGoBack;

        int ICoreWebView2_2.CanGoForward => ((ICoreWebView2_2)_WebView).CanGoForward;

        int ICoreWebView2_2.ContainsFullScreenElement => ((ICoreWebView2_2)_WebView).ContainsFullScreenElement;

        ICoreWebView2CookieManager ICoreWebView2_2.CookieManager => ((ICoreWebView2_2)_WebView).CookieManager;

        ICoreWebView2Settings ICoreWebView2.Settings => ((ICoreWebView2)_WebView).Settings;

        int ICoreWebView2.CanGoBack => ((ICoreWebView2)_WebView).CanGoBack;

        int ICoreWebView2.CanGoForward => ((ICoreWebView2)_WebView).CanGoForward;

        int ICoreWebView2.ContainsFullScreenElement => ((ICoreWebView2)_WebView).ContainsFullScreenElement;
    }
}