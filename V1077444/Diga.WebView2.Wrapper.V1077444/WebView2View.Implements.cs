using System.Runtime.InteropServices.ComTypes;
using Diga.WebView2.Interop;

namespace Diga.WebView2.Wrapper
{
    public partial class WebView2View : ICoreWebView2_3
    {
        private ICoreWebView2_3 _WebView;

        void ICoreWebView2.add_NavigationStarting(ICoreWebView2NavigationStartingEventHandler eventHandler,
            out EventRegistrationToken token)
        {
            ((ICoreWebView2) this._WebView).add_NavigationStarting(eventHandler, out token);
        }

        void ICoreWebView2_3.remove_NavigationStarting(EventRegistrationToken token)
        {
            this._WebView.remove_NavigationStarting(token);
        }

        void ICoreWebView2_3.add_ContentLoading(ICoreWebView2ContentLoadingEventHandler eventHandler,
            out EventRegistrationToken token)
        {
            this._WebView.add_ContentLoading(eventHandler, out token);
        }

        void ICoreWebView2_3.remove_ContentLoading(EventRegistrationToken token)
        {
            this._WebView.remove_ContentLoading(token);
        }

        void ICoreWebView2_3.add_SourceChanged(ICoreWebView2SourceChangedEventHandler eventHandler,
            out EventRegistrationToken token)
        {
            this._WebView.add_SourceChanged(eventHandler, out token);
        }

        void ICoreWebView2_3.remove_SourceChanged(EventRegistrationToken token)
        {
            this._WebView.remove_SourceChanged(token);
        }

        void ICoreWebView2_3.add_HistoryChanged(ICoreWebView2HistoryChangedEventHandler eventHandler,
            out EventRegistrationToken token)
        {
            this._WebView.add_HistoryChanged(eventHandler, out token);
        }

        void ICoreWebView2_3.remove_HistoryChanged(EventRegistrationToken token)
        {
            this._WebView.remove_HistoryChanged(token);
        }

        void ICoreWebView2_3.add_NavigationCompleted(ICoreWebView2NavigationCompletedEventHandler eventHandler,
            out EventRegistrationToken token)
        {
            this._WebView.add_NavigationCompleted(eventHandler, out token);
        }

        void ICoreWebView2_3.remove_NavigationCompleted(EventRegistrationToken token)
        {
            this._WebView.remove_NavigationCompleted(token);
        }

        void ICoreWebView2_3.add_FrameNavigationStarting(ICoreWebView2NavigationStartingEventHandler eventHandler,
            out EventRegistrationToken token)
        {
            this._WebView.add_FrameNavigationStarting(eventHandler, out token);
        }

        void ICoreWebView2_3.remove_FrameNavigationStarting(EventRegistrationToken token)
        {
            this._WebView.remove_FrameNavigationStarting(token);
        }

        void ICoreWebView2_3.add_FrameNavigationCompleted(ICoreWebView2NavigationCompletedEventHandler eventHandler,
            out EventRegistrationToken token)
        {
            this._WebView.add_FrameNavigationCompleted(eventHandler, out token);
        }

        void ICoreWebView2_3.remove_FrameNavigationCompleted(EventRegistrationToken token)
        {
            this._WebView.remove_FrameNavigationCompleted(token);
        }

        void ICoreWebView2_3.add_ScriptDialogOpening(ICoreWebView2ScriptDialogOpeningEventHandler eventHandler,
            out EventRegistrationToken token)
        {
            this._WebView.add_ScriptDialogOpening(eventHandler, out token);
        }

        void ICoreWebView2_3.remove_ScriptDialogOpening(EventRegistrationToken token)
        {
            this._WebView.remove_ScriptDialogOpening(token);
        }

        void ICoreWebView2_3.add_PermissionRequested(ICoreWebView2PermissionRequestedEventHandler eventHandler,
            out EventRegistrationToken token)
        {
            this._WebView.add_PermissionRequested(eventHandler, out token);
        }

        void ICoreWebView2_3.remove_PermissionRequested(EventRegistrationToken token)
        {
            this._WebView.remove_PermissionRequested(token);
        }

        void ICoreWebView2_3.add_ProcessFailed(ICoreWebView2ProcessFailedEventHandler eventHandler,
            out EventRegistrationToken token)
        {
            this._WebView.add_ProcessFailed(eventHandler, out token);
        }

        void ICoreWebView2_3.remove_ProcessFailed(EventRegistrationToken token)
        {
            this._WebView.remove_ProcessFailed(token);
        }

        void ICoreWebView2_3.AddScriptToExecuteOnDocumentCreated(string javaScript,
            ICoreWebView2AddScriptToExecuteOnDocumentCreatedCompletedHandler handler)
        {
            this._WebView.AddScriptToExecuteOnDocumentCreated(javaScript, handler);
        }

        void ICoreWebView2_3.add_NavigationStarting(ICoreWebView2NavigationStartingEventHandler eventHandler,
            out EventRegistrationToken token)
        {
            this._WebView.add_NavigationStarting(eventHandler, out token);
        }

        void ICoreWebView2_2.remove_NavigationStarting(EventRegistrationToken token)
        {
            ((ICoreWebView2_2) this._WebView).remove_NavigationStarting(token);
        }

        void ICoreWebView2_2.add_ContentLoading(ICoreWebView2ContentLoadingEventHandler eventHandler,
            out EventRegistrationToken token)
        {
            ((ICoreWebView2_2) this._WebView).add_ContentLoading(eventHandler, out token);
        }

        void ICoreWebView2_2.remove_ContentLoading(EventRegistrationToken token)
        {
            ((ICoreWebView2_2) this._WebView).remove_ContentLoading(token);
        }

        void ICoreWebView2_2.add_SourceChanged(ICoreWebView2SourceChangedEventHandler eventHandler,
            out EventRegistrationToken token)
        {
            ((ICoreWebView2_2) this._WebView).add_SourceChanged(eventHandler, out token);
        }

        void ICoreWebView2_2.remove_SourceChanged(EventRegistrationToken token)
        {
            ((ICoreWebView2_2) this._WebView).remove_SourceChanged(token);
        }

        void ICoreWebView2_2.add_HistoryChanged(ICoreWebView2HistoryChangedEventHandler eventHandler,
            out EventRegistrationToken token)
        {
            ((ICoreWebView2_2) this._WebView).add_HistoryChanged(eventHandler, out token);
        }

        void ICoreWebView2_2.remove_HistoryChanged(EventRegistrationToken token)
        {
            ((ICoreWebView2_2) this._WebView).remove_HistoryChanged(token);
        }

        void ICoreWebView2_2.add_NavigationCompleted(ICoreWebView2NavigationCompletedEventHandler eventHandler,
            out EventRegistrationToken token)
        {
            ((ICoreWebView2_2) this._WebView).add_NavigationCompleted(eventHandler, out token);
        }

        void ICoreWebView2_2.remove_NavigationCompleted(EventRegistrationToken token)
        {
            ((ICoreWebView2_2) this._WebView).remove_NavigationCompleted(token);
        }

        void ICoreWebView2_2.add_FrameNavigationStarting(ICoreWebView2NavigationStartingEventHandler eventHandler,
            out EventRegistrationToken token)
        {
            ((ICoreWebView2_2) this._WebView).add_FrameNavigationStarting(eventHandler, out token);
        }

        void ICoreWebView2_2.remove_FrameNavigationStarting(EventRegistrationToken token)
        {
            ((ICoreWebView2_2) this._WebView).remove_FrameNavigationStarting(token);
        }

        void ICoreWebView2_2.add_FrameNavigationCompleted(ICoreWebView2NavigationCompletedEventHandler eventHandler,
            out EventRegistrationToken token)
        {
            ((ICoreWebView2_2) this._WebView).add_FrameNavigationCompleted(eventHandler, out token);
        }

        void ICoreWebView2_2.remove_FrameNavigationCompleted(EventRegistrationToken token)
        {
            ((ICoreWebView2_2) this._WebView).remove_FrameNavigationCompleted(token);
        }

        void ICoreWebView2_2.add_ScriptDialogOpening(ICoreWebView2ScriptDialogOpeningEventHandler eventHandler,
            out EventRegistrationToken token)
        {
            ((ICoreWebView2_2) this._WebView).add_ScriptDialogOpening(eventHandler, out token);
        }

        void ICoreWebView2_2.remove_ScriptDialogOpening(EventRegistrationToken token)
        {
            ((ICoreWebView2_2) this._WebView).remove_ScriptDialogOpening(token);
        }

        void ICoreWebView2_2.add_PermissionRequested(ICoreWebView2PermissionRequestedEventHandler eventHandler,
            out EventRegistrationToken token)
        {
            ((ICoreWebView2_2) this._WebView).add_PermissionRequested(eventHandler, out token);
        }

        void ICoreWebView2_2.remove_PermissionRequested(EventRegistrationToken token)
        {
            ((ICoreWebView2_2) this._WebView).remove_PermissionRequested(token);
        }

        void ICoreWebView2_2.add_ProcessFailed(ICoreWebView2ProcessFailedEventHandler eventHandler,
            out EventRegistrationToken token)
        {
            ((ICoreWebView2_2) this._WebView).add_ProcessFailed(eventHandler, out token);
        }

        void ICoreWebView2_2.remove_ProcessFailed(EventRegistrationToken token)
        {
            ((ICoreWebView2_2) this._WebView).remove_ProcessFailed(token);
        }

        void ICoreWebView2_2.AddScriptToExecuteOnDocumentCreated(string javaScript,
            ICoreWebView2AddScriptToExecuteOnDocumentCreatedCompletedHandler handler)
        {
            ((ICoreWebView2_2) this._WebView).AddScriptToExecuteOnDocumentCreated(javaScript, handler);
        }

        void ICoreWebView2_2.add_NavigationStarting(ICoreWebView2NavigationStartingEventHandler eventHandler,
            out EventRegistrationToken token)
        {
            ((ICoreWebView2_2) this._WebView).add_NavigationStarting(eventHandler, out token);
        }

        void ICoreWebView2.remove_NavigationStarting(EventRegistrationToken token)
        {
            ((ICoreWebView2) this._WebView).remove_NavigationStarting(token);
        }

        void ICoreWebView2.add_ContentLoading(ICoreWebView2ContentLoadingEventHandler eventHandler,
            out EventRegistrationToken token)
        {
            ((ICoreWebView2) this._WebView).add_ContentLoading(eventHandler, out token);
        }

        void ICoreWebView2.remove_ContentLoading(EventRegistrationToken token)
        {
            ((ICoreWebView2) this._WebView).remove_ContentLoading(token);
        }

        void ICoreWebView2.add_SourceChanged(ICoreWebView2SourceChangedEventHandler eventHandler,
            out EventRegistrationToken token)
        {
            ((ICoreWebView2) this._WebView).add_SourceChanged(eventHandler, out token);
        }

        void ICoreWebView2.remove_SourceChanged(EventRegistrationToken token)
        {
            ((ICoreWebView2) this._WebView).remove_SourceChanged(token);
        }

        void ICoreWebView2.add_HistoryChanged(ICoreWebView2HistoryChangedEventHandler eventHandler,
            out EventRegistrationToken token)
        {
            ((ICoreWebView2) this._WebView).add_HistoryChanged(eventHandler, out token);
        }

        void ICoreWebView2.remove_HistoryChanged(EventRegistrationToken token)
        {
            ((ICoreWebView2) this._WebView).remove_HistoryChanged(token);
        }

        void ICoreWebView2.add_NavigationCompleted(ICoreWebView2NavigationCompletedEventHandler eventHandler,
            out EventRegistrationToken token)
        {
            ((ICoreWebView2) this._WebView).add_NavigationCompleted(eventHandler, out token);
        }

        void ICoreWebView2.remove_NavigationCompleted(EventRegistrationToken token)
        {
            ((ICoreWebView2) this._WebView).remove_NavigationCompleted(token);
        }

        void ICoreWebView2.add_FrameNavigationStarting(ICoreWebView2NavigationStartingEventHandler eventHandler,
            out EventRegistrationToken token)
        {
            ((ICoreWebView2) this._WebView).add_FrameNavigationStarting(eventHandler, out token);
        }

        void ICoreWebView2.remove_FrameNavigationStarting(EventRegistrationToken token)
        {
            ((ICoreWebView2) this._WebView).remove_FrameNavigationStarting(token);
        }

        void ICoreWebView2.add_FrameNavigationCompleted(ICoreWebView2NavigationCompletedEventHandler eventHandler,
            out EventRegistrationToken token)
        {
            ((ICoreWebView2) this._WebView).add_FrameNavigationCompleted(eventHandler, out token);
        }

        void ICoreWebView2.remove_FrameNavigationCompleted(EventRegistrationToken token)
        {
            ((ICoreWebView2) this._WebView).remove_FrameNavigationCompleted(token);
        }

        void ICoreWebView2.add_ScriptDialogOpening(ICoreWebView2ScriptDialogOpeningEventHandler eventHandler,
            out EventRegistrationToken token)
        {
            ((ICoreWebView2) this._WebView).add_ScriptDialogOpening(eventHandler, out token);
        }

        void ICoreWebView2.remove_ScriptDialogOpening(EventRegistrationToken token)
        {
            ((ICoreWebView2) this._WebView).remove_ScriptDialogOpening(token);
        }

        void ICoreWebView2.add_PermissionRequested(ICoreWebView2PermissionRequestedEventHandler eventHandler,
            out EventRegistrationToken token)
        {
            ((ICoreWebView2) this._WebView).add_PermissionRequested(eventHandler, out token);
        }

        void ICoreWebView2.remove_PermissionRequested(EventRegistrationToken token)
        {
            ((ICoreWebView2) this._WebView).remove_PermissionRequested(token);
        }

        void ICoreWebView2.add_ProcessFailed(ICoreWebView2ProcessFailedEventHandler eventHandler,
            out EventRegistrationToken token)
        {
            ((ICoreWebView2) this._WebView).add_ProcessFailed(eventHandler, out token);
        }

        void ICoreWebView2.remove_ProcessFailed(EventRegistrationToken token)
        {
            ((ICoreWebView2) this._WebView).remove_ProcessFailed(token);
        }

        void ICoreWebView2.AddScriptToExecuteOnDocumentCreated(string javaScript,
            ICoreWebView2AddScriptToExecuteOnDocumentCreatedCompletedHandler handler)
        {
            ((ICoreWebView2) this._WebView).AddScriptToExecuteOnDocumentCreated(javaScript, handler);
        }

        void ICoreWebView2.ExecuteScript(string javaScript, ICoreWebView2ExecuteScriptCompletedHandler handler)
        {
            ((ICoreWebView2) this._WebView).ExecuteScript(javaScript, handler);
        }

        void ICoreWebView2_3.CapturePreview(COREWEBVIEW2_CAPTURE_PREVIEW_IMAGE_FORMAT imageFormat, IStream imageStream,
            ICoreWebView2CapturePreviewCompletedHandler handler)
        {
            this._WebView.CapturePreview(imageFormat, imageStream, handler);
        }

        void ICoreWebView2_3.ExecuteScript(string javaScript, ICoreWebView2ExecuteScriptCompletedHandler handler)
        {
            this._WebView.ExecuteScript(javaScript, handler);
        }

        void ICoreWebView2_2.CapturePreview(COREWEBVIEW2_CAPTURE_PREVIEW_IMAGE_FORMAT imageFormat, IStream imageStream,
            ICoreWebView2CapturePreviewCompletedHandler handler)
        {
            ((ICoreWebView2_2) this._WebView).CapturePreview(imageFormat, imageStream, handler);
        }

        void ICoreWebView2_2.ExecuteScript(string javaScript, ICoreWebView2ExecuteScriptCompletedHandler handler)
        {
            ((ICoreWebView2_2) this._WebView).ExecuteScript(javaScript, handler);
        }

        void ICoreWebView2.CapturePreview(COREWEBVIEW2_CAPTURE_PREVIEW_IMAGE_FORMAT imageFormat, IStream imageStream,
            ICoreWebView2CapturePreviewCompletedHandler handler)
        {
            ((ICoreWebView2) this._WebView).CapturePreview(imageFormat, imageStream, handler);
        }

        void ICoreWebView2.add_WebMessageReceived(ICoreWebView2WebMessageReceivedEventHandler handler,
            out EventRegistrationToken token)
        {
            ((ICoreWebView2) this._WebView).add_WebMessageReceived(handler, out token);
        }

        void ICoreWebView2_3.remove_WebMessageReceived(EventRegistrationToken token)
        {
            this._WebView.remove_WebMessageReceived(token);
        }

        void ICoreWebView2_3.CallDevToolsProtocolMethod(string methodName, string parametersAsJson,
            ICoreWebView2CallDevToolsProtocolMethodCompletedHandler handler)
        {
            this._WebView.CallDevToolsProtocolMethod(methodName, parametersAsJson, handler);
        }

        void ICoreWebView2_3.add_WebMessageReceived(ICoreWebView2WebMessageReceivedEventHandler handler,
            out EventRegistrationToken token)
        {
            this._WebView.add_WebMessageReceived(handler, out token);
        }

        void ICoreWebView2_2.remove_WebMessageReceived(EventRegistrationToken token)
        {
            ((ICoreWebView2_2) this._WebView).remove_WebMessageReceived(token);
        }

        void ICoreWebView2_2.CallDevToolsProtocolMethod(string methodName, string parametersAsJson,
            ICoreWebView2CallDevToolsProtocolMethodCompletedHandler handler)
        {
            ((ICoreWebView2_2) this._WebView).CallDevToolsProtocolMethod(methodName, parametersAsJson, handler);
        }

        void ICoreWebView2_2.add_WebMessageReceived(ICoreWebView2WebMessageReceivedEventHandler handler,
            out EventRegistrationToken token)
        {
            ((ICoreWebView2_2) this._WebView).add_WebMessageReceived(handler, out token);
        }

        void ICoreWebView2.remove_WebMessageReceived(EventRegistrationToken token)
        {
            ((ICoreWebView2) this._WebView).remove_WebMessageReceived(token);
        }

        void ICoreWebView2.CallDevToolsProtocolMethod(string methodName, string parametersAsJson,
            ICoreWebView2CallDevToolsProtocolMethodCompletedHandler handler)
        {
            ((ICoreWebView2) this._WebView).CallDevToolsProtocolMethod(methodName, parametersAsJson, handler);
        }

        ICoreWebView2DevToolsProtocolEventReceiver ICoreWebView2.GetDevToolsProtocolEventReceiver(string eventName)
        {
            return ((ICoreWebView2) this._WebView).GetDevToolsProtocolEventReceiver(eventName);
        }

        ICoreWebView2DevToolsProtocolEventReceiver ICoreWebView2_2.GetDevToolsProtocolEventReceiver(string eventName)
        {
            return ((ICoreWebView2_2) this._WebView).GetDevToolsProtocolEventReceiver(eventName);
        }

        ICoreWebView2DevToolsProtocolEventReceiver ICoreWebView2_3.GetDevToolsProtocolEventReceiver(string eventName)
        {
            return this._WebView.GetDevToolsProtocolEventReceiver(eventName);
        }

        void ICoreWebView2.add_NewWindowRequested(ICoreWebView2NewWindowRequestedEventHandler eventHandler,
            out EventRegistrationToken token)
        {
            ((ICoreWebView2) this._WebView).add_NewWindowRequested(eventHandler, out token);
        }

        void ICoreWebView2_3.remove_NewWindowRequested(EventRegistrationToken token)
        {
            this._WebView.remove_NewWindowRequested(token);
        }

        void ICoreWebView2_3.add_DocumentTitleChanged(ICoreWebView2DocumentTitleChangedEventHandler eventHandler,
            out EventRegistrationToken token)
        {
            this._WebView.add_DocumentTitleChanged(eventHandler, out token);
        }

        void ICoreWebView2_3.remove_DocumentTitleChanged(EventRegistrationToken token)
        {
            this._WebView.remove_DocumentTitleChanged(token);
        }

        void ICoreWebView2_3.add_NewWindowRequested(ICoreWebView2NewWindowRequestedEventHandler eventHandler,
            out EventRegistrationToken token)
        {
            this._WebView.add_NewWindowRequested(eventHandler, out token);
        }

        void ICoreWebView2_2.remove_NewWindowRequested(EventRegistrationToken token)
        {
            ((ICoreWebView2_2) this._WebView).remove_NewWindowRequested(token);
        }

        void ICoreWebView2_2.add_DocumentTitleChanged(ICoreWebView2DocumentTitleChangedEventHandler eventHandler,
            out EventRegistrationToken token)
        {
            ((ICoreWebView2_2) this._WebView).add_DocumentTitleChanged(eventHandler, out token);
        }

        void ICoreWebView2_2.remove_DocumentTitleChanged(EventRegistrationToken token)
        {
            ((ICoreWebView2_2) this._WebView).remove_DocumentTitleChanged(token);
        }

        void ICoreWebView2_2.add_NewWindowRequested(ICoreWebView2NewWindowRequestedEventHandler eventHandler,
            out EventRegistrationToken token)
        {
            ((ICoreWebView2_2) this._WebView).add_NewWindowRequested(eventHandler, out token);
        }

        void ICoreWebView2.remove_NewWindowRequested(EventRegistrationToken token)
        {
            ((ICoreWebView2) this._WebView).remove_NewWindowRequested(token);
        }

        void ICoreWebView2.add_DocumentTitleChanged(ICoreWebView2DocumentTitleChangedEventHandler eventHandler,
            out EventRegistrationToken token)
        {
            ((ICoreWebView2) this._WebView).add_DocumentTitleChanged(eventHandler, out token);
        }

        void ICoreWebView2.remove_DocumentTitleChanged(EventRegistrationToken token)
        {
            ((ICoreWebView2) this._WebView).remove_DocumentTitleChanged(token);
        }

        void ICoreWebView2.AddHostObjectToScript(string name, ref object @object)
        {
            ((ICoreWebView2) this._WebView).AddHostObjectToScript(name, ref @object);
        }

        void ICoreWebView2_3.RemoveHostObjectFromScript(string name)
        {
            this._WebView.RemoveHostObjectFromScript(name);
        }

        void ICoreWebView2_3.AddHostObjectToScript(string name, ref object @object)
        {
            this._WebView.AddHostObjectToScript(name, ref @object);
        }

        void ICoreWebView2_2.RemoveHostObjectFromScript(string name)
        {
            ((ICoreWebView2_2) this._WebView).RemoveHostObjectFromScript(name);
        }

        void ICoreWebView2_2.AddHostObjectToScript(string name, ref object @object)
        {
            ((ICoreWebView2_2) this._WebView).AddHostObjectToScript(name, ref @object);
        }

        void ICoreWebView2.RemoveHostObjectFromScript(string name)
        {
            ((ICoreWebView2) this._WebView).RemoveHostObjectFromScript(name);
        }

        void ICoreWebView2.add_ContainsFullScreenElementChanged(
            ICoreWebView2ContainsFullScreenElementChangedEventHandler eventHandler, out EventRegistrationToken token)
        {
            ((ICoreWebView2) this._WebView).add_ContainsFullScreenElementChanged(eventHandler, out token);
        }

        void ICoreWebView2_3.remove_ContainsFullScreenElementChanged(EventRegistrationToken token)
        {
            this._WebView.remove_ContainsFullScreenElementChanged(token);
        }

        void ICoreWebView2_3.add_ContainsFullScreenElementChanged(
            ICoreWebView2ContainsFullScreenElementChangedEventHandler eventHandler, out EventRegistrationToken token)
        {
            this._WebView.add_ContainsFullScreenElementChanged(eventHandler, out token);
        }

        void ICoreWebView2_2.remove_ContainsFullScreenElementChanged(EventRegistrationToken token)
        {
            ((ICoreWebView2_2) this._WebView).remove_ContainsFullScreenElementChanged(token);
        }

        void ICoreWebView2_2.add_ContainsFullScreenElementChanged(
            ICoreWebView2ContainsFullScreenElementChangedEventHandler eventHandler, out EventRegistrationToken token)
        {
            ((ICoreWebView2_2) this._WebView).add_ContainsFullScreenElementChanged(eventHandler, out token);
        }

        void ICoreWebView2.remove_ContainsFullScreenElementChanged(EventRegistrationToken token)
        {
            ((ICoreWebView2) this._WebView).remove_ContainsFullScreenElementChanged(token);
        }

        void ICoreWebView2.add_WebResourceRequested(ICoreWebView2WebResourceRequestedEventHandler eventHandler,
            out EventRegistrationToken token)
        {
            ((ICoreWebView2) this._WebView).add_WebResourceRequested(eventHandler, out token);
        }

        void ICoreWebView2_3.remove_WebResourceRequested(EventRegistrationToken token)
        {
            this._WebView.remove_WebResourceRequested(token);
        }

        void ICoreWebView2_3.AddWebResourceRequestedFilter(string uri,
            COREWEBVIEW2_WEB_RESOURCE_CONTEXT ResourceContext)
        {
            this._WebView.AddWebResourceRequestedFilter(uri, ResourceContext);
        }

        void ICoreWebView2_3.RemoveWebResourceRequestedFilter(string uri,
            COREWEBVIEW2_WEB_RESOURCE_CONTEXT ResourceContext)
        {
            this._WebView.RemoveWebResourceRequestedFilter(uri, ResourceContext);
        }

        void ICoreWebView2_3.add_WindowCloseRequested(ICoreWebView2WindowCloseRequestedEventHandler eventHandler,
            out EventRegistrationToken token)
        {
            this._WebView.add_WindowCloseRequested(eventHandler, out token);
        }

        void ICoreWebView2_3.remove_WindowCloseRequested(EventRegistrationToken token)
        {
            this._WebView.remove_WindowCloseRequested(token);
        }

        void ICoreWebView2_3.add_WebResourceResponseReceived(
            ICoreWebView2WebResourceResponseReceivedEventHandler eventHandler, out EventRegistrationToken token)
        {
            this._WebView.add_WebResourceResponseReceived(eventHandler, out token);
        }

        void ICoreWebView2_3.remove_WebResourceResponseReceived(EventRegistrationToken token)
        {
            this._WebView.remove_WebResourceResponseReceived(token);
        }

        void ICoreWebView2_3.NavigateWithWebResourceRequest(ICoreWebView2WebResourceRequest Request)
        {
            this._WebView.NavigateWithWebResourceRequest(Request);
        }

        void ICoreWebView2_3.add_DOMContentLoaded(ICoreWebView2DOMContentLoadedEventHandler eventHandler,
            out EventRegistrationToken token)
        {
            this._WebView.add_DOMContentLoaded(eventHandler, out token);
        }

        void ICoreWebView2_3.remove_DOMContentLoaded(EventRegistrationToken token)
        {
            this._WebView.remove_DOMContentLoaded(token);
        }

        void ICoreWebView2_3.add_WebResourceRequested(ICoreWebView2WebResourceRequestedEventHandler eventHandler,
            out EventRegistrationToken token)
        {
            this._WebView.add_WebResourceRequested(eventHandler, out token);
        }

        void ICoreWebView2_2.remove_WebResourceRequested(EventRegistrationToken token)
        {
            ((ICoreWebView2_2) this._WebView).remove_WebResourceRequested(token);
        }

        void ICoreWebView2_2.AddWebResourceRequestedFilter(string uri,
            COREWEBVIEW2_WEB_RESOURCE_CONTEXT ResourceContext)
        {
            ((ICoreWebView2_2) this._WebView).AddWebResourceRequestedFilter(uri, ResourceContext);
        }

        void ICoreWebView2_2.RemoveWebResourceRequestedFilter(string uri,
            COREWEBVIEW2_WEB_RESOURCE_CONTEXT ResourceContext)
        {
            ((ICoreWebView2_2) this._WebView).RemoveWebResourceRequestedFilter(uri, ResourceContext);
        }

        void ICoreWebView2_2.add_WindowCloseRequested(ICoreWebView2WindowCloseRequestedEventHandler eventHandler,
            out EventRegistrationToken token)
        {
            ((ICoreWebView2_2) this._WebView).add_WindowCloseRequested(eventHandler, out token);
        }

        void ICoreWebView2_2.remove_WindowCloseRequested(EventRegistrationToken token)
        {
            ((ICoreWebView2_2) this._WebView).remove_WindowCloseRequested(token);
        }

        void ICoreWebView2_2.add_WebResourceResponseReceived(
            ICoreWebView2WebResourceResponseReceivedEventHandler eventHandler, out EventRegistrationToken token)
        {
            ((ICoreWebView2_2) this._WebView).add_WebResourceResponseReceived(eventHandler, out token);
        }

        void ICoreWebView2_2.remove_WebResourceResponseReceived(EventRegistrationToken token)
        {
            ((ICoreWebView2_2) this._WebView).remove_WebResourceResponseReceived(token);
        }

        void ICoreWebView2_2.NavigateWithWebResourceRequest(ICoreWebView2WebResourceRequest Request)
        {
            ((ICoreWebView2_2) this._WebView).NavigateWithWebResourceRequest(Request);
        }

        void ICoreWebView2_2.add_DOMContentLoaded(ICoreWebView2DOMContentLoadedEventHandler eventHandler,
            out EventRegistrationToken token)
        {
            ((ICoreWebView2_2) this._WebView).add_DOMContentLoaded(eventHandler, out token);
        }

        void ICoreWebView2_2.remove_DOMContentLoaded(EventRegistrationToken token)
        {
            ((ICoreWebView2_2) this._WebView).remove_DOMContentLoaded(token);
        }

        public ICoreWebView2CookieManager CookieManager => ((ICoreWebView2_2) this._WebView).CookieManager;

        public ICoreWebView2Environment Environment => ((ICoreWebView2_2) this._WebView).Environment;

        public void TrySuspend(ICoreWebView2TrySuspendCompletedHandler handler)
        {
            this._WebView.TrySuspend(handler);
        }

        public void Resume()
        {
            this._WebView.Resume();
        }

        public int IsSuspended => this._WebView.IsSuspended;

        public void SetVirtualHostNameToFolderMapping(string hostName, string folderPath,
            COREWEBVIEW2_HOST_RESOURCE_ACCESS_KIND accessKind)
        {
            this._WebView.SetVirtualHostNameToFolderMapping(hostName, folderPath, accessKind);
        }

        public void ClearVirtualHostNameToFolderMapping(string hostName)
        {
            this._WebView.ClearVirtualHostNameToFolderMapping(hostName);
        }

        void ICoreWebView2_2.add_WebResourceRequested(ICoreWebView2WebResourceRequestedEventHandler eventHandler,
            out EventRegistrationToken token)
        {
            ((ICoreWebView2_2) this._WebView).add_WebResourceRequested(eventHandler, out token);
        }

        void ICoreWebView2.remove_WebResourceRequested(EventRegistrationToken token)
        {
            ((ICoreWebView2) this._WebView).remove_WebResourceRequested(token);
        }

        void ICoreWebView2.AddWebResourceRequestedFilter(string uri, COREWEBVIEW2_WEB_RESOURCE_CONTEXT ResourceContext)
        {
            ((ICoreWebView2) this._WebView).AddWebResourceRequestedFilter(uri, ResourceContext);
        }

        void ICoreWebView2.RemoveWebResourceRequestedFilter(string uri,
            COREWEBVIEW2_WEB_RESOURCE_CONTEXT ResourceContext)
        {
            ((ICoreWebView2) this._WebView).RemoveWebResourceRequestedFilter(uri, ResourceContext);
        }

        void ICoreWebView2.add_WindowCloseRequested(ICoreWebView2WindowCloseRequestedEventHandler eventHandler,
            out EventRegistrationToken token)
        {
            ((ICoreWebView2) this._WebView).add_WindowCloseRequested(eventHandler, out token);
        }

        void ICoreWebView2.remove_WindowCloseRequested(EventRegistrationToken token)
        {
            ((ICoreWebView2) this._WebView).remove_WindowCloseRequested(token);
        }

        ICoreWebView2Settings ICoreWebView2_3.Settings => _WebView.Settings;

        int ICoreWebView2_3.CanGoBack => _WebView.CanGoBack;

        int ICoreWebView2_3.CanGoForward => _WebView.CanGoForward;

        int ICoreWebView2_3.ContainsFullScreenElement => _WebView.ContainsFullScreenElement;

        ICoreWebView2Settings ICoreWebView2_2.Settings => ((ICoreWebView2_2) _WebView).Settings;

        int ICoreWebView2_2.CanGoBack => ((ICoreWebView2_2) _WebView).CanGoBack;

        int ICoreWebView2_2.CanGoForward => ((ICoreWebView2_2) _WebView).CanGoForward;

        int ICoreWebView2_2.ContainsFullScreenElement => ((ICoreWebView2_2) _WebView).ContainsFullScreenElement;

        ICoreWebView2Settings ICoreWebView2.Settings => ((ICoreWebView2) _WebView).Settings;

        int ICoreWebView2.CanGoBack => ((ICoreWebView2) _WebView).CanGoBack;

        int ICoreWebView2.CanGoForward => ((ICoreWebView2) _WebView).CanGoForward;

        int ICoreWebView2.ContainsFullScreenElement => ((ICoreWebView2) _WebView).ContainsFullScreenElement;
    }
}