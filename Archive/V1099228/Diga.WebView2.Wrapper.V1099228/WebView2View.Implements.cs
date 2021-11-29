using System.Runtime.InteropServices.ComTypes;
using Diga.WebView2.Interop;

namespace Diga.WebView2.Wrapper
{
    public partial class WebView2View : ICoreWebView2_6
    {
        private ICoreWebView2_6 _WebView;
        private ICoreWebView2 WebView_0 => this._WebView;
        private ICoreWebView2_2 WebView_2 => this._WebView;
        private ICoreWebView2_3 WebView_3 => this._WebView;
        private ICoreWebView2_4 WebView_4 => this._WebView;
        private ICoreWebView2_5 WebView_5 => this._WebView;
        private ICoreWebView2_6 WebView_6 => this._WebView;

        void ICoreWebView2.add_NavigationStarting(ICoreWebView2NavigationStartingEventHandler eventHandler,
            out EventRegistrationToken token)
        {
            this.WebView_0.add_NavigationStarting(eventHandler, out token);
        }

        void ICoreWebView2_6.remove_NavigationStarting(EventRegistrationToken token)
        {
            this.WebView_6.remove_NavigationStarting(token);
        }

        void ICoreWebView2_6.add_ContentLoading(ICoreWebView2ContentLoadingEventHandler eventHandler, out EventRegistrationToken token)
        {
            this.WebView_6.add_ContentLoading(eventHandler , out token);
        }

        void ICoreWebView2_6.remove_ContentLoading(EventRegistrationToken token)
        {
            this.WebView_6.remove_ContentLoading(token);
        }

        void ICoreWebView2_6.add_SourceChanged(ICoreWebView2SourceChangedEventHandler eventHandler, out EventRegistrationToken token)
        {
            this.WebView_6.add_SourceChanged(eventHandler, out token);
        }

        void ICoreWebView2_6.remove_SourceChanged(EventRegistrationToken token)
        {
            this.WebView_6.remove_SourceChanged(token);
        }

        void ICoreWebView2_6.add_HistoryChanged(ICoreWebView2HistoryChangedEventHandler eventHandler, out EventRegistrationToken token)
        {
            this.WebView_6.add_HistoryChanged(eventHandler, out token);
        }

        void ICoreWebView2_6.remove_HistoryChanged(EventRegistrationToken token)
        {
            this.WebView_6.remove_HistoryChanged(token);
        }

        void ICoreWebView2_6.add_NavigationCompleted(ICoreWebView2NavigationCompletedEventHandler eventHandler,
            out EventRegistrationToken token)
        {
            this.WebView_6.add_NavigationCompleted(eventHandler, out token);
        }

        void ICoreWebView2_6.remove_NavigationCompleted(EventRegistrationToken token)
        {
            this.WebView_6.remove_NavigationCompleted(token);
        }

        void ICoreWebView2_6.add_FrameNavigationStarting(ICoreWebView2NavigationStartingEventHandler eventHandler,
            out EventRegistrationToken token)
        {
            this.WebView_6.add_FrameNavigationStarting(eventHandler, out token);
        }

        void ICoreWebView2_6.remove_FrameNavigationStarting(EventRegistrationToken token)
        {
            this.WebView_6.remove_FrameNavigationStarting(token);
        }

        void ICoreWebView2_6.add_FrameNavigationCompleted(ICoreWebView2NavigationCompletedEventHandler eventHandler,
            out EventRegistrationToken token)
        {
            this.WebView_6.add_FrameNavigationCompleted(eventHandler, out token);
        }

        void ICoreWebView2_6.remove_FrameNavigationCompleted(EventRegistrationToken token)
        {
            this.WebView_6.remove_FrameNavigationCompleted(token);
        }

        void ICoreWebView2_6.add_ScriptDialogOpening(ICoreWebView2ScriptDialogOpeningEventHandler eventHandler,
            out EventRegistrationToken token)
        {
            this.WebView_6.add_ScriptDialogOpening(eventHandler, out token);
        }

        void ICoreWebView2_6.remove_ScriptDialogOpening(EventRegistrationToken token)
        {
            this.WebView_6.remove_ScriptDialogOpening(token);
        }

        void ICoreWebView2_6.add_PermissionRequested(ICoreWebView2PermissionRequestedEventHandler eventHandler,
            out EventRegistrationToken token)
        {
            this.WebView_6.add_PermissionRequested(eventHandler, out token);
        }

        void ICoreWebView2_6.remove_PermissionRequested(EventRegistrationToken token)
        {
            this.WebView_6.remove_PermissionRequested(token);
        }

        void ICoreWebView2_6.add_ProcessFailed(ICoreWebView2ProcessFailedEventHandler eventHandler, out EventRegistrationToken token)
        {
            this.WebView_6.add_ProcessFailed(eventHandler, out token);
        }

        void ICoreWebView2_6.remove_ProcessFailed(EventRegistrationToken token)
        {
            this.WebView_6.remove_ProcessFailed(token);
        }

        void ICoreWebView2_6.AddScriptToExecuteOnDocumentCreated(string javaScript,
            ICoreWebView2AddScriptToExecuteOnDocumentCreatedCompletedHandler handler)
        {
            this.WebView_6.AddScriptToExecuteOnDocumentCreated(javaScript, handler);
        }

        void ICoreWebView2_6.add_NavigationStarting(ICoreWebView2NavigationStartingEventHandler eventHandler, out EventRegistrationToken token)
        {
            this.WebView_6.add_NavigationStarting(eventHandler, out token);
        }

        void ICoreWebView2_5.remove_NavigationStarting(EventRegistrationToken token)
        {
            this.WebView_5.remove_NavigationStarting(token);
        }

        void ICoreWebView2_5.add_ContentLoading(ICoreWebView2ContentLoadingEventHandler eventHandler, out EventRegistrationToken token)
        {
            this.WebView_5.add_ContentLoading(eventHandler, out token);
        }

        void ICoreWebView2_5.remove_ContentLoading(EventRegistrationToken token)
        {
            this.WebView_5.remove_ContentLoading(token);
        }

        void ICoreWebView2_5.add_SourceChanged(ICoreWebView2SourceChangedEventHandler eventHandler, out EventRegistrationToken token)
        {
            this.WebView_5.add_SourceChanged(eventHandler, out token);
        }

        void ICoreWebView2_5.remove_SourceChanged(EventRegistrationToken token)
        {
            this.WebView_5.remove_SourceChanged(token);
        }

        void ICoreWebView2_5.add_HistoryChanged(ICoreWebView2HistoryChangedEventHandler eventHandler, out EventRegistrationToken token)
        {
            this.WebView_5.add_HistoryChanged(eventHandler, out token);
        }

        void ICoreWebView2_5.remove_HistoryChanged(EventRegistrationToken token)
        {
            this.WebView_5.remove_HistoryChanged(token);
        }

        void ICoreWebView2_5.add_NavigationCompleted(ICoreWebView2NavigationCompletedEventHandler eventHandler,
            out EventRegistrationToken token)
        {
            this.WebView_5.add_NavigationCompleted(eventHandler, out token);
        }

        void ICoreWebView2_5.remove_NavigationCompleted(EventRegistrationToken token)
        {
            this.WebView_5.remove_NavigationCompleted(token);
        }

        void ICoreWebView2_5.add_FrameNavigationStarting(ICoreWebView2NavigationStartingEventHandler eventHandler,
            out EventRegistrationToken token)
        {
            this.WebView_5.add_FrameNavigationStarting(eventHandler, out token);
        }

        void ICoreWebView2_5.remove_FrameNavigationStarting(EventRegistrationToken token)
        {
            this.WebView_5.remove_FrameNavigationStarting(token);
        }

        void ICoreWebView2_5.add_FrameNavigationCompleted(ICoreWebView2NavigationCompletedEventHandler eventHandler,
            out EventRegistrationToken token)
        {
            this.WebView_5.add_FrameNavigationCompleted(eventHandler, out token);
        }

        void ICoreWebView2_5.remove_FrameNavigationCompleted(EventRegistrationToken token)
        {
            this.WebView_5.remove_FrameNavigationCompleted(token);
        }

        void ICoreWebView2_5.add_ScriptDialogOpening(ICoreWebView2ScriptDialogOpeningEventHandler eventHandler,
            out EventRegistrationToken token)
        {
            this.WebView_5.add_ScriptDialogOpening(eventHandler, out token);
        }

        void ICoreWebView2_5.remove_ScriptDialogOpening(EventRegistrationToken token)
        {
            this.WebView_5.remove_ScriptDialogOpening(token);
        }

        void ICoreWebView2_5.add_PermissionRequested(ICoreWebView2PermissionRequestedEventHandler eventHandler,
            out EventRegistrationToken token)
        {
            this.WebView_5.add_PermissionRequested(eventHandler, out token);
        }

        void ICoreWebView2_5.remove_PermissionRequested(EventRegistrationToken token)
        {
            this.WebView_5.remove_PermissionRequested(token);
        }

        void ICoreWebView2_5.add_ProcessFailed(ICoreWebView2ProcessFailedEventHandler eventHandler, out EventRegistrationToken token)
        {
            this.WebView_5.add_ProcessFailed(eventHandler, out token);
        }

        void ICoreWebView2_5.remove_ProcessFailed(EventRegistrationToken token)
        {
            this.WebView_5.remove_ProcessFailed(token);
        }

        void ICoreWebView2_5.AddScriptToExecuteOnDocumentCreated(string javaScript,
            ICoreWebView2AddScriptToExecuteOnDocumentCreatedCompletedHandler handler)
        {
            this.WebView_5.AddScriptToExecuteOnDocumentCreated(javaScript, handler);
        }

        void ICoreWebView2_5.add_NavigationStarting(ICoreWebView2NavigationStartingEventHandler eventHandler, out EventRegistrationToken token)
        {
            this.WebView_5.add_NavigationStarting(eventHandler, out token);
        }

        void ICoreWebView2_4.remove_NavigationStarting(EventRegistrationToken token)
        {
            this.WebView_4.remove_NavigationStarting(token);
        }

        void ICoreWebView2_4.add_ContentLoading(ICoreWebView2ContentLoadingEventHandler eventHandler, out EventRegistrationToken token)
        {
            this.WebView_4.add_ContentLoading(eventHandler , out token);
        }

        void ICoreWebView2_4.remove_ContentLoading(EventRegistrationToken token)
        {
            this.WebView_4.remove_ContentLoading(token);
        }

        void ICoreWebView2_4.add_SourceChanged(ICoreWebView2SourceChangedEventHandler eventHandler, out EventRegistrationToken token)
        {
            this.WebView_4.add_SourceChanged(eventHandler , out token);
        }

        void ICoreWebView2_4.remove_SourceChanged(EventRegistrationToken token)
        {
            this.WebView_4.remove_SourceChanged(token);
        }

        void ICoreWebView2_4.add_HistoryChanged(ICoreWebView2HistoryChangedEventHandler eventHandler, out EventRegistrationToken token)
        {
            this.WebView_4.add_HistoryChanged(eventHandler , out token);
        }

        void ICoreWebView2_4.remove_HistoryChanged(EventRegistrationToken token)
        {
            this.WebView_4.remove_HistoryChanged(token);
        }

        void ICoreWebView2_4.add_NavigationCompleted(ICoreWebView2NavigationCompletedEventHandler eventHandler,
            out EventRegistrationToken token)
        {
            this.WebView_4.add_NavigationCompleted(eventHandler , out token);
        }

        void ICoreWebView2_4.remove_NavigationCompleted(EventRegistrationToken token)
        {
            this.WebView_4.remove_NavigationCompleted(token);
        }

        void ICoreWebView2_4.add_FrameNavigationStarting(ICoreWebView2NavigationStartingEventHandler eventHandler,
            out EventRegistrationToken token)
        {
            this.WebView_4.add_FrameNavigationStarting(eventHandler , out token);
        }

        void ICoreWebView2_4.remove_FrameNavigationStarting(EventRegistrationToken token)
        {
            this.WebView_4.remove_FrameNavigationStarting(token);
        }

        void ICoreWebView2_4.add_FrameNavigationCompleted(ICoreWebView2NavigationCompletedEventHandler eventHandler,
            out EventRegistrationToken token)
        {
            this.WebView_4.add_FrameNavigationCompleted(eventHandler , out token);
        }

        void ICoreWebView2_4.remove_FrameNavigationCompleted(EventRegistrationToken token)
        {
            this.WebView_4.remove_FrameNavigationCompleted(token);
        }

        void ICoreWebView2_4.add_ScriptDialogOpening(ICoreWebView2ScriptDialogOpeningEventHandler eventHandler,
            out EventRegistrationToken token)
        {
            this.WebView_4.add_ScriptDialogOpening(eventHandler , out token);
        }

        void ICoreWebView2_4.remove_ScriptDialogOpening(EventRegistrationToken token)
        {
            this.WebView_4.remove_ScriptDialogOpening(token);
        }

        void ICoreWebView2_4.add_PermissionRequested(ICoreWebView2PermissionRequestedEventHandler eventHandler,
            out EventRegistrationToken token)
        {
            this.WebView_4.add_PermissionRequested(eventHandler , out token);
        }

        void ICoreWebView2_4.remove_PermissionRequested(EventRegistrationToken token)
        {
            this.WebView_4.remove_PermissionRequested(token);
        }

        void ICoreWebView2_4.add_ProcessFailed(ICoreWebView2ProcessFailedEventHandler eventHandler, out EventRegistrationToken token)
        {
            this.WebView_4.add_ProcessFailed(eventHandler , out token);
        }

        void ICoreWebView2_4.remove_ProcessFailed(EventRegistrationToken token)
        {
            this.WebView_4.remove_ProcessFailed(token);
        }

        void ICoreWebView2_4.AddScriptToExecuteOnDocumentCreated(string javaScript,
            ICoreWebView2AddScriptToExecuteOnDocumentCreatedCompletedHandler handler)
        {
            this.WebView_4.AddScriptToExecuteOnDocumentCreated(javaScript, handler);
        }

        void ICoreWebView2_4.add_NavigationStarting(ICoreWebView2NavigationStartingEventHandler eventHandler, out EventRegistrationToken token)
        {
            this.WebView_4.add_NavigationStarting(eventHandler , out token);
        }

        void ICoreWebView2_3.remove_NavigationStarting(EventRegistrationToken token)
        {
            this.WebView_3.remove_NavigationStarting(token);
        }

        void ICoreWebView2_3.add_ContentLoading(ICoreWebView2ContentLoadingEventHandler eventHandler,
            out EventRegistrationToken token)
        {
            this.WebView_3.add_ContentLoading(eventHandler, out token);
        }

        void ICoreWebView2_3.remove_ContentLoading(EventRegistrationToken token)
        {
            this.WebView_3.remove_ContentLoading(token);
        }

        void ICoreWebView2_3.add_SourceChanged(ICoreWebView2SourceChangedEventHandler eventHandler,
            out EventRegistrationToken token)
        {
            this.WebView_3.add_SourceChanged(eventHandler, out token);
        }

        void ICoreWebView2_3.remove_SourceChanged(EventRegistrationToken token)
        {
            this.WebView_3.remove_SourceChanged(token);
        }

        void ICoreWebView2_3.add_HistoryChanged(ICoreWebView2HistoryChangedEventHandler eventHandler,
            out EventRegistrationToken token)
        {
            this.WebView_3.add_HistoryChanged(eventHandler, out token);
        }

        void ICoreWebView2_3.remove_HistoryChanged(EventRegistrationToken token)
        {
            this.WebView_3.remove_HistoryChanged(token);
        }

        void ICoreWebView2_3.add_NavigationCompleted(ICoreWebView2NavigationCompletedEventHandler eventHandler,
            out EventRegistrationToken token)
        {
            this.WebView_3.add_NavigationCompleted(eventHandler, out token);
        }

        void ICoreWebView2_3.remove_NavigationCompleted(EventRegistrationToken token)
        {
            this.WebView_3.remove_NavigationCompleted(token);
        }

        void ICoreWebView2_3.add_FrameNavigationStarting(ICoreWebView2NavigationStartingEventHandler eventHandler,
            out EventRegistrationToken token)
        {
            this.WebView_3.add_FrameNavigationStarting(eventHandler, out token);
        }

        void ICoreWebView2_3.remove_FrameNavigationStarting(EventRegistrationToken token)
        {
            this.WebView_3.remove_FrameNavigationStarting(token);
        }

        void ICoreWebView2_3.add_FrameNavigationCompleted(ICoreWebView2NavigationCompletedEventHandler eventHandler,
            out EventRegistrationToken token)
        {
            this.WebView_3.add_FrameNavigationCompleted(eventHandler, out token);
        }

        void ICoreWebView2_3.remove_FrameNavigationCompleted(EventRegistrationToken token)
        {
            this.WebView_3.remove_FrameNavigationCompleted(token);
        }

        void ICoreWebView2_3.add_ScriptDialogOpening(ICoreWebView2ScriptDialogOpeningEventHandler eventHandler,
            out EventRegistrationToken token)
        {
            this.WebView_3.add_ScriptDialogOpening(eventHandler, out token);
        }

        void ICoreWebView2_3.remove_ScriptDialogOpening(EventRegistrationToken token)
        {
            this._WebView.remove_ScriptDialogOpening(token);
        }

        void ICoreWebView2_3.add_PermissionRequested(ICoreWebView2PermissionRequestedEventHandler eventHandler,
            out EventRegistrationToken token)
        {
            this.WebView_3.add_PermissionRequested(eventHandler, out token);
        }

        void ICoreWebView2_3.remove_PermissionRequested(EventRegistrationToken token)
        {
            this.WebView_3.remove_PermissionRequested(token);
        }

        void ICoreWebView2_3.add_ProcessFailed(ICoreWebView2ProcessFailedEventHandler eventHandler,
            out EventRegistrationToken token)
        {
            this.WebView_3.add_ProcessFailed(eventHandler, out token);
        }

        void ICoreWebView2_3.remove_ProcessFailed(EventRegistrationToken token)
        {
            this.WebView_3.remove_ProcessFailed(token);
        }

        void ICoreWebView2_3.AddScriptToExecuteOnDocumentCreated(string javaScript,
            ICoreWebView2AddScriptToExecuteOnDocumentCreatedCompletedHandler handler)
        {
            this.WebView_3.AddScriptToExecuteOnDocumentCreated(javaScript, handler);
        }

        void ICoreWebView2_3.add_NavigationStarting(ICoreWebView2NavigationStartingEventHandler eventHandler,
            out EventRegistrationToken token)
        {
            this.WebView_3.add_NavigationStarting(eventHandler, out token);
        }

        void ICoreWebView2_2.remove_NavigationStarting(EventRegistrationToken token)
        {
            this.WebView_2.remove_NavigationStarting(token);
        }

        void ICoreWebView2_2.add_ContentLoading(ICoreWebView2ContentLoadingEventHandler eventHandler,
            out EventRegistrationToken token)
        {
            this.WebView_2.add_ContentLoading(eventHandler, out token);
        }

        void ICoreWebView2_2.remove_ContentLoading(EventRegistrationToken token)
        {
            this.WebView_2.remove_ContentLoading(token);
        }

        void ICoreWebView2_2.add_SourceChanged(ICoreWebView2SourceChangedEventHandler eventHandler,
            out EventRegistrationToken token)
        {
            this.WebView_2.add_SourceChanged(eventHandler, out token);
        }

        void ICoreWebView2_2.remove_SourceChanged(EventRegistrationToken token)
        {
            this.WebView_2.remove_SourceChanged(token);
        }

        void ICoreWebView2_2.add_HistoryChanged(ICoreWebView2HistoryChangedEventHandler eventHandler,
            out EventRegistrationToken token)
        {
            this.WebView_2.add_HistoryChanged(eventHandler, out token);
        }

        void ICoreWebView2_2.remove_HistoryChanged(EventRegistrationToken token)
        {
            this.WebView_2.remove_HistoryChanged(token);
        }

        void ICoreWebView2_2.add_NavigationCompleted(ICoreWebView2NavigationCompletedEventHandler eventHandler,
            out EventRegistrationToken token)
        {
            this.WebView_2.add_NavigationCompleted(eventHandler, out token);
        }

        void ICoreWebView2_2.remove_NavigationCompleted(EventRegistrationToken token)
        {
            this.WebView_2.remove_NavigationCompleted(token);
        }

        void ICoreWebView2_2.add_FrameNavigationStarting(ICoreWebView2NavigationStartingEventHandler eventHandler,
            out EventRegistrationToken token)
        {
            this.WebView_2.add_FrameNavigationStarting(eventHandler, out token);
        }

        void ICoreWebView2_2.remove_FrameNavigationStarting(EventRegistrationToken token)
        {
            this.WebView_2.remove_FrameNavigationStarting(token);
        }

        void ICoreWebView2_2.add_FrameNavigationCompleted(ICoreWebView2NavigationCompletedEventHandler eventHandler,
            out EventRegistrationToken token)
        {
            this.WebView_2.add_FrameNavigationCompleted(eventHandler, out token);
        }

        void ICoreWebView2_2.remove_FrameNavigationCompleted(EventRegistrationToken token)
        {
            this.WebView_2.remove_FrameNavigationCompleted(token);
        }

        void ICoreWebView2_2.add_ScriptDialogOpening(ICoreWebView2ScriptDialogOpeningEventHandler eventHandler,
            out EventRegistrationToken token)
        {
            this.WebView_2.add_ScriptDialogOpening(eventHandler, out token);
        }

        void ICoreWebView2_2.remove_ScriptDialogOpening(EventRegistrationToken token)
        {
            this.WebView_2.remove_ScriptDialogOpening(token);
        }

        void ICoreWebView2_2.add_PermissionRequested(ICoreWebView2PermissionRequestedEventHandler eventHandler,
            out EventRegistrationToken token)
        {
            this.WebView_2.add_PermissionRequested(eventHandler, out token);
        }

        void ICoreWebView2_2.remove_PermissionRequested(EventRegistrationToken token)
        {
            this.WebView_2.remove_PermissionRequested(token);
        }

        void ICoreWebView2_2.add_ProcessFailed(ICoreWebView2ProcessFailedEventHandler eventHandler,
            out EventRegistrationToken token)
        {
            this.WebView_2.add_ProcessFailed(eventHandler, out token);
        }

        void ICoreWebView2_2.remove_ProcessFailed(EventRegistrationToken token)
        {
            this.WebView_2.remove_ProcessFailed(token);
        }

        void ICoreWebView2_2.AddScriptToExecuteOnDocumentCreated(string javaScript,
            ICoreWebView2AddScriptToExecuteOnDocumentCreatedCompletedHandler handler)
        {
            this.WebView_0.AddScriptToExecuteOnDocumentCreated(javaScript, handler);
        }

        void ICoreWebView2_2.add_NavigationStarting(ICoreWebView2NavigationStartingEventHandler eventHandler,
            out EventRegistrationToken token)
        {
            this.WebView_2.add_NavigationStarting(eventHandler, out token);
        }

        void ICoreWebView2.remove_NavigationStarting(EventRegistrationToken token)
        {
            this.WebView_0.remove_NavigationStarting(token);
        }

        void ICoreWebView2.add_ContentLoading(ICoreWebView2ContentLoadingEventHandler eventHandler,
            out EventRegistrationToken token)
        {
            this.WebView_2.add_ContentLoading(eventHandler, out token);
        }

        void ICoreWebView2.remove_ContentLoading(EventRegistrationToken token)
        {
            this.WebView_2.remove_ContentLoading(token);
        }

        void ICoreWebView2.add_SourceChanged(ICoreWebView2SourceChangedEventHandler eventHandler,
            out EventRegistrationToken token)
        {
            this.WebView_2.add_SourceChanged(eventHandler, out token);
        }

        void ICoreWebView2.remove_SourceChanged(EventRegistrationToken token)
        {
            this.WebView_0.remove_SourceChanged(token);
        }

        void ICoreWebView2.add_HistoryChanged(ICoreWebView2HistoryChangedEventHandler eventHandler,
            out EventRegistrationToken token)
        {
            this.WebView_0.add_HistoryChanged(eventHandler, out token);
        }

        void ICoreWebView2.remove_HistoryChanged(EventRegistrationToken token)
        {
            this.WebView_0.remove_HistoryChanged(token);
        }

        void ICoreWebView2.add_NavigationCompleted(ICoreWebView2NavigationCompletedEventHandler eventHandler,
            out EventRegistrationToken token)
        {
            this.WebView_0.add_NavigationCompleted(eventHandler, out token);
        }

        void ICoreWebView2.remove_NavigationCompleted(EventRegistrationToken token)
        {
            this.WebView_0.remove_NavigationCompleted(token);
        }

        void ICoreWebView2.add_FrameNavigationStarting(ICoreWebView2NavigationStartingEventHandler eventHandler,
            out EventRegistrationToken token)
        {
            this.WebView_0.add_FrameNavigationStarting(eventHandler, out token);
        }

        void ICoreWebView2.remove_FrameNavigationStarting(EventRegistrationToken token)
        {
            this.WebView_0.remove_FrameNavigationStarting(token);
        }

        void ICoreWebView2.add_FrameNavigationCompleted(ICoreWebView2NavigationCompletedEventHandler eventHandler,
            out EventRegistrationToken token)
        {
            this.WebView_0.add_FrameNavigationCompleted(eventHandler, out token);
        }

        void ICoreWebView2.remove_FrameNavigationCompleted(EventRegistrationToken token)
        {
            this.WebView_0.remove_FrameNavigationCompleted(token);
        }

        void ICoreWebView2.add_ScriptDialogOpening(ICoreWebView2ScriptDialogOpeningEventHandler eventHandler,
            out EventRegistrationToken token)
        {
            this.WebView_0.add_ScriptDialogOpening(eventHandler, out token);
        }

        void ICoreWebView2.remove_ScriptDialogOpening(EventRegistrationToken token)
        {
            this.WebView_0.remove_ScriptDialogOpening(token);
        }

        void ICoreWebView2.add_PermissionRequested(ICoreWebView2PermissionRequestedEventHandler eventHandler,
            out EventRegistrationToken token)
        {
            this.WebView_0.add_PermissionRequested(eventHandler, out token);
        }

        void ICoreWebView2.remove_PermissionRequested(EventRegistrationToken token)
        {
            this.WebView_0.remove_PermissionRequested(token);
        }

        void ICoreWebView2.add_ProcessFailed(ICoreWebView2ProcessFailedEventHandler eventHandler,
            out EventRegistrationToken token)
        {
            this.WebView_2.add_ProcessFailed(eventHandler, out token);
        }

        void ICoreWebView2.remove_ProcessFailed(EventRegistrationToken token)
        {
            this.WebView_0.remove_ProcessFailed(token);
        }

        void ICoreWebView2.AddScriptToExecuteOnDocumentCreated(string javaScript,
            ICoreWebView2AddScriptToExecuteOnDocumentCreatedCompletedHandler handler)
        {
            this.WebView_0.AddScriptToExecuteOnDocumentCreated(javaScript, handler);
        }

        void ICoreWebView2.ExecuteScript(string javaScript, ICoreWebView2ExecuteScriptCompletedHandler handler)
        {
            this.WebView_0.ExecuteScript(javaScript, handler);
        }

        void ICoreWebView2_6.CapturePreview(COREWEBVIEW2_CAPTURE_PREVIEW_IMAGE_FORMAT imageFormat, IStream imageStream,
            ICoreWebView2CapturePreviewCompletedHandler handler)
        {
            this.WebView_6.CapturePreview(imageFormat, imageStream, handler);
        }

        void ICoreWebView2_6.ExecuteScript(string javaScript, ICoreWebView2ExecuteScriptCompletedHandler handler)
        {
            this.WebView_6.ExecuteScript(javaScript, handler);
        }

        void ICoreWebView2_5.CapturePreview(COREWEBVIEW2_CAPTURE_PREVIEW_IMAGE_FORMAT imageFormat, IStream imageStream,
            ICoreWebView2CapturePreviewCompletedHandler handler)
        {
            this.WebView_5.CapturePreview(imageFormat, imageStream, handler);
        }

        void ICoreWebView2_5.ExecuteScript(string javaScript, ICoreWebView2ExecuteScriptCompletedHandler handler)
        {
            this.WebView_5.ExecuteScript(javaScript, handler);
        }

        void ICoreWebView2_4.CapturePreview(COREWEBVIEW2_CAPTURE_PREVIEW_IMAGE_FORMAT imageFormat, IStream imageStream,
            ICoreWebView2CapturePreviewCompletedHandler handler)
        {
            this.WebView_4.CapturePreview(imageFormat, imageStream, handler);
        }

        void ICoreWebView2_4.ExecuteScript(string javaScript, ICoreWebView2ExecuteScriptCompletedHandler handler)
        {
            this.WebView_4.ExecuteScript(javaScript, handler);
        }

        void ICoreWebView2_3.CapturePreview(COREWEBVIEW2_CAPTURE_PREVIEW_IMAGE_FORMAT imageFormat, IStream imageStream,
            ICoreWebView2CapturePreviewCompletedHandler handler)
        {
            this.WebView_3.CapturePreview(imageFormat, imageStream, handler);
        }

        void ICoreWebView2_3.ExecuteScript(string javaScript, ICoreWebView2ExecuteScriptCompletedHandler handler)
        {
            this.WebView_3.ExecuteScript(javaScript, handler);
        }

        void ICoreWebView2_2.CapturePreview(COREWEBVIEW2_CAPTURE_PREVIEW_IMAGE_FORMAT imageFormat, IStream imageStream,
            ICoreWebView2CapturePreviewCompletedHandler handler)
        {
            this.WebView_2.CapturePreview(imageFormat, imageStream, handler);
        }

        void ICoreWebView2_2.ExecuteScript(string javaScript, ICoreWebView2ExecuteScriptCompletedHandler handler)
        {
            this.WebView_2.ExecuteScript(javaScript, handler);
        }

        void ICoreWebView2.CapturePreview(COREWEBVIEW2_CAPTURE_PREVIEW_IMAGE_FORMAT imageFormat, IStream imageStream,
            ICoreWebView2CapturePreviewCompletedHandler handler)
        {
            this.WebView_0.CapturePreview(imageFormat, imageStream, handler);
        }

        void ICoreWebView2.add_WebMessageReceived(ICoreWebView2WebMessageReceivedEventHandler handler,
            out EventRegistrationToken token)
        {
            this.WebView_0.add_WebMessageReceived(handler, out token);
        }

        void ICoreWebView2_6.remove_WebMessageReceived(EventRegistrationToken token)
        {
            this.WebView_6.remove_WebMessageReceived(token);
        }

        void ICoreWebView2_6.CallDevToolsProtocolMethod(string methodName, string parametersAsJson,
            ICoreWebView2CallDevToolsProtocolMethodCompletedHandler handler)
        {
            this.WebView_6.CallDevToolsProtocolMethod(methodName, parametersAsJson, handler);
        }

        void ICoreWebView2_6.add_WebMessageReceived(ICoreWebView2WebMessageReceivedEventHandler handler, out EventRegistrationToken token)
        {
            this.WebView_6.add_WebMessageReceived(handler, out token);
        }

        void ICoreWebView2_5.remove_WebMessageReceived(EventRegistrationToken token)
        {
            this.WebView_5.remove_WebMessageReceived(token);
        }

        void ICoreWebView2_5.CallDevToolsProtocolMethod(string methodName, string parametersAsJson,
            ICoreWebView2CallDevToolsProtocolMethodCompletedHandler handler)
        {
            this.WebView_5.CallDevToolsProtocolMethod(methodName , parametersAsJson , handler );
        }

        void ICoreWebView2_5.add_WebMessageReceived(ICoreWebView2WebMessageReceivedEventHandler handler, out EventRegistrationToken token)
        {
            this.WebView_5.add_WebMessageReceived(handler, out token);
        }

        void ICoreWebView2_4.remove_WebMessageReceived(EventRegistrationToken token)
        { 
            this.WebView_4.remove_WebMessageReceived(token);
        }

        void ICoreWebView2_4.CallDevToolsProtocolMethod(string methodName, string parametersAsJson,
            ICoreWebView2CallDevToolsProtocolMethodCompletedHandler handler)
        {
            this.WebView_4.CallDevToolsProtocolMethod(methodName, parametersAsJson, handler);
        }

        void ICoreWebView2_4.add_WebMessageReceived(ICoreWebView2WebMessageReceivedEventHandler handler, out EventRegistrationToken token)
        {
            this.WebView_4.add_WebMessageReceived(handler, out token);
        }

        void ICoreWebView2_3.remove_WebMessageReceived(EventRegistrationToken token)
        {
            this.WebView_3.remove_WebMessageReceived(token);
        }

        void ICoreWebView2_3.CallDevToolsProtocolMethod(string methodName, string parametersAsJson,
            ICoreWebView2CallDevToolsProtocolMethodCompletedHandler handler)
        {
            this.WebView_3.CallDevToolsProtocolMethod(methodName, parametersAsJson, handler);
        }

        void ICoreWebView2_3.add_WebMessageReceived(ICoreWebView2WebMessageReceivedEventHandler handler,
            out EventRegistrationToken token)
        {
            this.WebView_3.add_WebMessageReceived(handler, out token);
        }

        void ICoreWebView2_2.remove_WebMessageReceived(EventRegistrationToken token)
        {
            this.WebView_2.remove_WebMessageReceived(token);
        }

        void ICoreWebView2_2.CallDevToolsProtocolMethod(string methodName, string parametersAsJson,
            ICoreWebView2CallDevToolsProtocolMethodCompletedHandler handler)
        {
            this.WebView_2.CallDevToolsProtocolMethod(methodName, parametersAsJson, handler);
        }

        void ICoreWebView2_2.add_WebMessageReceived(ICoreWebView2WebMessageReceivedEventHandler handler,
            out EventRegistrationToken token)
        {
            this.WebView_2.add_WebMessageReceived(handler, out token);
        }

        void ICoreWebView2.remove_WebMessageReceived(EventRegistrationToken token)
        {
            this.WebView_0.remove_WebMessageReceived(token);
        }

        void ICoreWebView2.CallDevToolsProtocolMethod(string methodName, string parametersAsJson,
            ICoreWebView2CallDevToolsProtocolMethodCompletedHandler handler)
        {
            this.WebView_0.CallDevToolsProtocolMethod(methodName, parametersAsJson, handler);
        }

        ICoreWebView2DevToolsProtocolEventReceiver ICoreWebView2.GetDevToolsProtocolEventReceiver(string eventName)
        {
            return this.WebView_0.GetDevToolsProtocolEventReceiver(eventName);
        }

        ICoreWebView2DevToolsProtocolEventReceiver ICoreWebView2_2.GetDevToolsProtocolEventReceiver(string eventName)
        {
            return this.WebView_2.GetDevToolsProtocolEventReceiver(eventName);
        }

        ICoreWebView2DevToolsProtocolEventReceiver ICoreWebView2_3.GetDevToolsProtocolEventReceiver(string eventName)
        {
            return this.WebView_3.GetDevToolsProtocolEventReceiver(eventName);
        }

        ICoreWebView2DevToolsProtocolEventReceiver ICoreWebView2_4.GetDevToolsProtocolEventReceiver(string eventName)
        {
            return this.WebView_4.GetDevToolsProtocolEventReceiver(eventName);
        }

        ICoreWebView2DevToolsProtocolEventReceiver ICoreWebView2_5.GetDevToolsProtocolEventReceiver(string eventName)
        {
            return this.WebView_5.GetDevToolsProtocolEventReceiver(eventName);
        }

        ICoreWebView2DevToolsProtocolEventReceiver ICoreWebView2_6.GetDevToolsProtocolEventReceiver(string eventName)
        {
            return this.WebView_6.GetDevToolsProtocolEventReceiver(eventName);
        }

        void ICoreWebView2.add_NewWindowRequested(ICoreWebView2NewWindowRequestedEventHandler eventHandler,
            out EventRegistrationToken token)
        {
            this.WebView_0.add_NewWindowRequested(eventHandler, out token);
        }

        void ICoreWebView2_6.remove_NewWindowRequested(EventRegistrationToken token)
        {
            this.WebView_6.remove_NewWindowRequested(token);
        }

        void ICoreWebView2_6.add_DocumentTitleChanged(ICoreWebView2DocumentTitleChangedEventHandler eventHandler,
            out EventRegistrationToken token)
        {
            this.WebView_6.add_DocumentTitleChanged(eventHandler, out token);
        }

        void ICoreWebView2_6.remove_DocumentTitleChanged(EventRegistrationToken token)
        {
            this.WebView_6.remove_DocumentTitleChanged(token);
        }

        void ICoreWebView2_6.add_NewWindowRequested(ICoreWebView2NewWindowRequestedEventHandler eventHandler, out EventRegistrationToken token)
        {
            this.WebView_6.add_NewWindowRequested(eventHandler, out token);
        }

        void ICoreWebView2_5.remove_NewWindowRequested(EventRegistrationToken token)
        {
            this.WebView_5.remove_NewWindowRequested( token);
        }

        void ICoreWebView2_5.add_DocumentTitleChanged(ICoreWebView2DocumentTitleChangedEventHandler eventHandler,
            out EventRegistrationToken token)
        {
            this.WebView_5.add_DocumentTitleChanged(eventHandler, out token);
        }

        void ICoreWebView2_5.remove_DocumentTitleChanged(EventRegistrationToken token)
        {
            this.WebView_5.remove_DocumentTitleChanged( token);
        }

        void ICoreWebView2_5.add_NewWindowRequested(ICoreWebView2NewWindowRequestedEventHandler eventHandler, out EventRegistrationToken token)
        {
            this.WebView_5.add_NewWindowRequested(eventHandler, out token);
        }

        void ICoreWebView2_4.remove_NewWindowRequested(EventRegistrationToken token)
        {
            this.WebView_4.remove_NewWindowRequested(token);
        }

        void ICoreWebView2_4.add_DocumentTitleChanged(ICoreWebView2DocumentTitleChangedEventHandler eventHandler,
            out EventRegistrationToken token)
        {
            this.WebView_4.add_DocumentTitleChanged(eventHandler, out token);
        }

        void ICoreWebView2_4.remove_DocumentTitleChanged(EventRegistrationToken token)
        {
            this.WebView_4.remove_DocumentTitleChanged(token);
        }

        void ICoreWebView2_4.add_NewWindowRequested(ICoreWebView2NewWindowRequestedEventHandler eventHandler, out EventRegistrationToken token)
        {
            this.WebView_4.add_NewWindowRequested(eventHandler, out token);
        }

        void ICoreWebView2_3.remove_NewWindowRequested(EventRegistrationToken token)
        {
            this.WebView_3.remove_NewWindowRequested(token);
        }

        void ICoreWebView2_3.add_DocumentTitleChanged(ICoreWebView2DocumentTitleChangedEventHandler eventHandler,
            out EventRegistrationToken token)
        {
            this.WebView_3.add_DocumentTitleChanged(eventHandler, out token);
        }

        void ICoreWebView2_3.remove_DocumentTitleChanged(EventRegistrationToken token)
        {
            this.WebView_3.remove_DocumentTitleChanged(token);
        }

        void ICoreWebView2_3.add_NewWindowRequested(ICoreWebView2NewWindowRequestedEventHandler eventHandler,
            out EventRegistrationToken token)
        {
            this.WebView_3.add_NewWindowRequested(eventHandler, out token);
        }

        void ICoreWebView2_2.remove_NewWindowRequested(EventRegistrationToken token)
        {
            this.WebView_2.remove_NewWindowRequested(token);
        }

        void ICoreWebView2_2.add_DocumentTitleChanged(ICoreWebView2DocumentTitleChangedEventHandler eventHandler,
            out EventRegistrationToken token)
        {
            this.WebView_2.add_DocumentTitleChanged(eventHandler, out token);
        }

        void ICoreWebView2_2.remove_DocumentTitleChanged(EventRegistrationToken token)
        {
            this.WebView_2.remove_DocumentTitleChanged(token);
        }

        void ICoreWebView2_2.add_NewWindowRequested(ICoreWebView2NewWindowRequestedEventHandler eventHandler,
            out EventRegistrationToken token)
        {
            this.WebView_2.add_NewWindowRequested(eventHandler, out token);
        }

        void ICoreWebView2.remove_NewWindowRequested(EventRegistrationToken token)
        {
            this.WebView_0.remove_NewWindowRequested(token);
        }

        void ICoreWebView2.add_DocumentTitleChanged(ICoreWebView2DocumentTitleChangedEventHandler eventHandler,
            out EventRegistrationToken token)
        {
            this.WebView_0.add_DocumentTitleChanged(eventHandler, out token);
        }

        void ICoreWebView2.remove_DocumentTitleChanged(EventRegistrationToken token)
        {
            this.WebView_0.remove_DocumentTitleChanged(token);
        }

        void ICoreWebView2.AddHostObjectToScript(string name, ref object @object)
        {
            this.WebView_0.AddHostObjectToScript(name, ref @object);
        }

        void ICoreWebView2_6.RemoveHostObjectFromScript(string name)
        {
            this.WebView_6.RemoveHostObjectFromScript(name);
        }

        void ICoreWebView2_6.AddHostObjectToScript(string name, ref object @object)
        {
            this.WebView_6.AddHostObjectToScript(name, ref @object);
        }

        void ICoreWebView2_5.RemoveHostObjectFromScript(string name)
        {
            this.WebView_5.RemoveHostObjectFromScript(name);
        }

        void ICoreWebView2_5.AddHostObjectToScript(string name, ref object @object)
        {
            this.WebView_5.AddHostObjectToScript(name, ref @object);
        }

        void ICoreWebView2_4.RemoveHostObjectFromScript(string name)
        {
            this.WebView_4.RemoveHostObjectFromScript(name);
        }

        void ICoreWebView2_4.AddHostObjectToScript(string name, ref object @object)
        {
           this.WebView_4.AddHostObjectToScript(name, ref @object);
        }

        void ICoreWebView2_3.RemoveHostObjectFromScript(string name)
        {
            this.WebView_3.RemoveHostObjectFromScript(name);
        }

        void ICoreWebView2_3.AddHostObjectToScript(string name, ref object @object)
        {
            this.WebView_3.AddHostObjectToScript(name, ref @object);
        }

        void ICoreWebView2_2.RemoveHostObjectFromScript(string name)
        {
            this.WebView_2.RemoveHostObjectFromScript(name);
        }

        void ICoreWebView2_2.AddHostObjectToScript(string name, ref object @object)
        {
            this.WebView_2.AddHostObjectToScript(name, ref @object);
        }

        void ICoreWebView2.RemoveHostObjectFromScript(string name)
        {
            this.WebView_0.RemoveHostObjectFromScript(name);
        }

        void ICoreWebView2.add_ContainsFullScreenElementChanged(
            ICoreWebView2ContainsFullScreenElementChangedEventHandler eventHandler, out EventRegistrationToken token)
        {
            this.WebView_0.add_ContainsFullScreenElementChanged(eventHandler, out token);
        }

        void ICoreWebView2_6.remove_ContainsFullScreenElementChanged(EventRegistrationToken token)
        {
            this.WebView_6.remove_ContainsFullScreenElementChanged(token);
        }

        void ICoreWebView2_6.add_ContainsFullScreenElementChanged(ICoreWebView2ContainsFullScreenElementChangedEventHandler eventHandler,
            out EventRegistrationToken token)
        {
            this.WebView_6.add_ContainsFullScreenElementChanged(eventHandler, out token);
        }

        void ICoreWebView2_5.remove_ContainsFullScreenElementChanged(EventRegistrationToken token)
        {
            this.WebView_5.remove_ContainsFullScreenElementChanged(token);
        }

        void ICoreWebView2_5.add_ContainsFullScreenElementChanged(ICoreWebView2ContainsFullScreenElementChangedEventHandler eventHandler,
            out EventRegistrationToken token)
        {
            this.WebView_5.add_ContainsFullScreenElementChanged(eventHandler, out token);
        }

        void ICoreWebView2_4.remove_ContainsFullScreenElementChanged(EventRegistrationToken token)
        {
            this.WebView_4.remove_ContainsFullScreenElementChanged(token);
        }

        void ICoreWebView2_4.add_ContainsFullScreenElementChanged(ICoreWebView2ContainsFullScreenElementChangedEventHandler eventHandler,
            out EventRegistrationToken token)
        {
            this._WebView.add_ContainsFullScreenElementChanged(eventHandler, out token);
        }

        void ICoreWebView2_3.remove_ContainsFullScreenElementChanged(EventRegistrationToken token)
        {
            this.WebView_3.remove_ContainsFullScreenElementChanged(token);
        }

        void ICoreWebView2_3.add_ContainsFullScreenElementChanged(
            ICoreWebView2ContainsFullScreenElementChangedEventHandler eventHandler, out EventRegistrationToken token)
        {
            this.WebView_3.add_ContainsFullScreenElementChanged(eventHandler, out token);
        }

        void ICoreWebView2_2.remove_ContainsFullScreenElementChanged(EventRegistrationToken token)
        {
            this.WebView_2.remove_ContainsFullScreenElementChanged(token);
        }

        void ICoreWebView2_2.add_ContainsFullScreenElementChanged(
            ICoreWebView2ContainsFullScreenElementChangedEventHandler eventHandler, out EventRegistrationToken token)
        {
            this.WebView_2.add_ContainsFullScreenElementChanged(eventHandler, out token);
        }

        void ICoreWebView2.remove_ContainsFullScreenElementChanged(EventRegistrationToken token)
        {
            this.WebView_2.remove_ContainsFullScreenElementChanged(token);
        }

        void ICoreWebView2.add_WebResourceRequested(ICoreWebView2WebResourceRequestedEventHandler eventHandler,
            out EventRegistrationToken token)
        {
            this.WebView_0.add_WebResourceRequested(eventHandler, out token);
        }

        void ICoreWebView2_6.remove_WebResourceRequested(EventRegistrationToken token)
        {
            this.WebView_6.remove_WebResourceRequested(token);
        }

        void ICoreWebView2_6.add_WebResourceRequested(ICoreWebView2WebResourceRequestedEventHandler eventHandler,
            out EventRegistrationToken token)
        {
            this.WebView_6.add_WebResourceRequested(eventHandler, out token);
        }

        void ICoreWebView2_5.remove_WebResourceRequested(EventRegistrationToken token)
        {
            this.WebView_5.remove_WebResourceRequested(token);
        }

        void ICoreWebView2_5.add_WebResourceRequested(ICoreWebView2WebResourceRequestedEventHandler eventHandler,
            out EventRegistrationToken token)
        {
            this.WebView_5.add_WebResourceRequested(eventHandler, out token);
        }

        void ICoreWebView2_4.remove_WebResourceRequested(EventRegistrationToken token)
        {
           this._WebView.remove_WebResourceRequested(token);
        }

        void ICoreWebView2_4.add_WebResourceRequested(ICoreWebView2WebResourceRequestedEventHandler eventHandler,
            out EventRegistrationToken token)
        {
            this._WebView.add_WebResourceRequested(eventHandler, out token);
        }

        void ICoreWebView2_3.remove_WebResourceRequested(EventRegistrationToken token)
        {
            this.WebView_3.remove_WebResourceRequested(token);
        }

        void ICoreWebView2_3.AddWebResourceRequestedFilter(string uri,
            COREWEBVIEW2_WEB_RESOURCE_CONTEXT ResourceContext)
        {
            this.WebView_3.AddWebResourceRequestedFilter(uri, ResourceContext);
        }

        void ICoreWebView2_3.RemoveWebResourceRequestedFilter(string uri,
            COREWEBVIEW2_WEB_RESOURCE_CONTEXT ResourceContext)
        {
            this.WebView_3.RemoveWebResourceRequestedFilter(uri, ResourceContext);
        }

        void ICoreWebView2_6.add_WindowCloseRequested(ICoreWebView2WindowCloseRequestedEventHandler eventHandler,
            out EventRegistrationToken token)
        {
            this.WebView_6.add_WindowCloseRequested(eventHandler, out token);
        }

        void ICoreWebView2_6.remove_WindowCloseRequested(EventRegistrationToken token)
        {
            this.WebView_6.remove_WindowCloseRequested(token);
        }

        void ICoreWebView2_6.add_WebResourceResponseReceived(ICoreWebView2WebResourceResponseReceivedEventHandler eventHandler,
            out EventRegistrationToken token)
        {
            this.WebView_6 .add_WebResourceResponseReceived(eventHandler, out token);
        }

        void ICoreWebView2_6.remove_WebResourceResponseReceived(EventRegistrationToken token)
        {
            this.WebView_6 .remove_WebResourceResponseReceived(token);
        }

        void ICoreWebView2_6.NavigateWithWebResourceRequest(ICoreWebView2WebResourceRequest Request)
        {
            this.WebView_6.NavigateWithWebResourceRequest(Request);
        }

        void ICoreWebView2_6.add_DOMContentLoaded(ICoreWebView2DOMContentLoadedEventHandler eventHandler, out EventRegistrationToken token)
        {
            this.WebView_6.add_DOMContentLoaded(eventHandler, out token);
        }

        void ICoreWebView2_6.remove_DOMContentLoaded(EventRegistrationToken token)
        {
            this.WebView_6.remove_DOMContentLoaded(token);
        }

        void ICoreWebView2_5.add_WindowCloseRequested(ICoreWebView2WindowCloseRequestedEventHandler eventHandler,
            out EventRegistrationToken token)
        {
            this.WebView_5.add_WindowCloseRequested(eventHandler, out token);
        }

        void ICoreWebView2_5.remove_WindowCloseRequested(EventRegistrationToken token)
        {
            this.WebView_5.remove_WindowCloseRequested(token);
        }

        void ICoreWebView2_5.add_WebResourceResponseReceived(ICoreWebView2WebResourceResponseReceivedEventHandler eventHandler,
            out EventRegistrationToken token)
        {
            this.WebView_5.add_WebResourceResponseReceived(eventHandler, out token);
        }

        void ICoreWebView2_5.remove_WebResourceResponseReceived(EventRegistrationToken token)
        {
            this.WebView_5.remove_WebResourceResponseReceived(token);
        }

        void ICoreWebView2_5.NavigateWithWebResourceRequest(ICoreWebView2WebResourceRequest Request)
        {
            this.WebView_5.NavigateWithWebResourceRequest(Request);
        }

        void ICoreWebView2_5.add_DOMContentLoaded(ICoreWebView2DOMContentLoadedEventHandler eventHandler, out EventRegistrationToken token)
        {
            this.WebView_5.add_DOMContentLoaded(eventHandler, out token);
        }

        void ICoreWebView2_5.remove_DOMContentLoaded(EventRegistrationToken token)
        {
            this.WebView_5.remove_DOMContentLoaded(token);
        }

        void ICoreWebView2_4.add_WindowCloseRequested(ICoreWebView2WindowCloseRequestedEventHandler eventHandler,
            out EventRegistrationToken token)
        {
            this.WebView_4.add_WindowCloseRequested(eventHandler, out token);
        }

        void ICoreWebView2_4.remove_WindowCloseRequested(EventRegistrationToken token)
        {
            this.WebView_4.remove_WindowCloseRequested(token);
        }

        void ICoreWebView2_4.add_WebResourceResponseReceived(ICoreWebView2WebResourceResponseReceivedEventHandler eventHandler,
            out EventRegistrationToken token)
        {
            this.WebView_4.add_WebResourceResponseReceived(eventHandler, out token);
        }

        void ICoreWebView2_4.remove_WebResourceResponseReceived(EventRegistrationToken token)
        {
            this.WebView_4.remove_WebResourceResponseReceived(token);
        }

        void ICoreWebView2_4.NavigateWithWebResourceRequest(ICoreWebView2WebResourceRequest Request)
        {
            this.WebView_4.NavigateWithWebResourceRequest(Request);
        }

        void ICoreWebView2_4.add_DOMContentLoaded(ICoreWebView2DOMContentLoadedEventHandler eventHandler, out EventRegistrationToken token)
        {
            this.WebView_4.add_DOMContentLoaded(eventHandler, out token);
        }

        void ICoreWebView2_4.remove_DOMContentLoaded(EventRegistrationToken token)
        {
            this.WebView_4.remove_DOMContentLoaded(token);
        }

        void ICoreWebView2_3.add_WindowCloseRequested(ICoreWebView2WindowCloseRequestedEventHandler eventHandler,
            out EventRegistrationToken token)
        {
            this.WebView_3.add_WindowCloseRequested(eventHandler, out token);
        }

        void ICoreWebView2_3.remove_WindowCloseRequested(EventRegistrationToken token)
        {
            this.WebView_3.remove_WindowCloseRequested(token);
        }

        void ICoreWebView2_3.add_WebResourceResponseReceived(
            ICoreWebView2WebResourceResponseReceivedEventHandler eventHandler, out EventRegistrationToken token)
        {
            this._WebView.add_WebResourceResponseReceived(eventHandler, out token);
        }

        void ICoreWebView2_3.remove_WebResourceResponseReceived(EventRegistrationToken token)
        {
            this.WebView_3.remove_WebResourceResponseReceived(token);
        }

        void ICoreWebView2_3.NavigateWithWebResourceRequest(ICoreWebView2WebResourceRequest Request)
        {
            this.WebView_3.NavigateWithWebResourceRequest(Request);
        }

        void ICoreWebView2_3.add_DOMContentLoaded(ICoreWebView2DOMContentLoadedEventHandler eventHandler,
            out EventRegistrationToken token)
        {
            this.WebView_3.add_DOMContentLoaded(eventHandler, out token);
        }

        void ICoreWebView2_3.remove_DOMContentLoaded(EventRegistrationToken token)
        {
            this.WebView_3.remove_DOMContentLoaded(token);
        }

        void ICoreWebView2_3.add_WebResourceRequested(ICoreWebView2WebResourceRequestedEventHandler eventHandler,
            out EventRegistrationToken token)
        {
            this.WebView_3.add_WebResourceRequested(eventHandler, out token);
        }

        void ICoreWebView2_2.remove_WebResourceRequested(EventRegistrationToken token)
        {
            this.WebView_2.remove_WebResourceRequested(token);
        }

        void ICoreWebView2_2.AddWebResourceRequestedFilter(string uri,
            COREWEBVIEW2_WEB_RESOURCE_CONTEXT ResourceContext)
        {
            this.WebView_2.AddWebResourceRequestedFilter(uri, ResourceContext);
        }

        void ICoreWebView2_2.RemoveWebResourceRequestedFilter(string uri,
            COREWEBVIEW2_WEB_RESOURCE_CONTEXT ResourceContext)
        {
            this.WebView_2.RemoveWebResourceRequestedFilter(uri, ResourceContext);
        }

        void ICoreWebView2_2.add_WindowCloseRequested(ICoreWebView2WindowCloseRequestedEventHandler eventHandler,
            out EventRegistrationToken token)
        {
            this.WebView_2.add_WindowCloseRequested(eventHandler, out token);
        }

        void ICoreWebView2_2.remove_WindowCloseRequested(EventRegistrationToken token)
        {
            this.WebView_2.remove_WindowCloseRequested(token);
        }

        void ICoreWebView2_2.add_WebResourceResponseReceived(
            ICoreWebView2WebResourceResponseReceivedEventHandler eventHandler, out EventRegistrationToken token)
        {
            this.WebView_2.add_WebResourceResponseReceived(eventHandler, out token);
        }

        void ICoreWebView2_2.remove_WebResourceResponseReceived(EventRegistrationToken token)
        {
            this.WebView_2.remove_WebResourceResponseReceived(token);
        }

        void ICoreWebView2_2.NavigateWithWebResourceRequest(ICoreWebView2WebResourceRequest Request)
        {
            this.WebView_2.NavigateWithWebResourceRequest(Request);
        }

        void ICoreWebView2_2.add_DOMContentLoaded(ICoreWebView2DOMContentLoadedEventHandler eventHandler,
            out EventRegistrationToken token)
        {
            this.WebView_2.add_DOMContentLoaded(eventHandler, out token);
        }

        void ICoreWebView2_2.remove_DOMContentLoaded(EventRegistrationToken token)
        {
            this.WebView_2.remove_DOMContentLoaded(token);
        }

        public ICoreWebView2CookieManager CookieManager => this.WebView_2.CookieManager;

        public ICoreWebView2Environment Environment => this.WebView_2.Environment;

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

        void ICoreWebView2_6.add_FrameCreated(ICoreWebView2FrameCreatedEventHandler eventHandler, out EventRegistrationToken token)
        {
            this.WebView_6.add_FrameCreated(eventHandler , out token);
        }

        void ICoreWebView2_6.remove_FrameCreated(EventRegistrationToken token)
        {
            this.WebView_6.remove_FrameCreated(token);
        }

        void ICoreWebView2_6.add_DownloadStarting(ICoreWebView2DownloadStartingEventHandler eventHandler, out EventRegistrationToken token)
        {
            this.WebView_6.add_DownloadStarting(eventHandler , out token);
        }

        void ICoreWebView2_6.remove_DownloadStarting(EventRegistrationToken token)
        {
            this.WebView_6.remove_DownloadStarting(token);
        }

        void ICoreWebView2_6.add_ClientCertificateRequested(ICoreWebView2ClientCertificateRequestedEventHandler eventHandler,
            out EventRegistrationToken token)
        {
            this.WebView_6.add_ClientCertificateRequested(eventHandler , out token);
        }

        void ICoreWebView2_6.remove_ClientCertificateRequested(EventRegistrationToken token)
        {
           this.WebView_6.remove_ClientCertificateRequested(token);
        }

        void ICoreWebView2_6.OpenTaskManagerWindow()
        {
            this.WebView_6.OpenTaskManagerWindow();
        }

        void ICoreWebView2_5.add_FrameCreated(ICoreWebView2FrameCreatedEventHandler eventHandler, out EventRegistrationToken token)
        {
            this.WebView_5.add_FrameCreated(eventHandler, out token);
        }

        void ICoreWebView2_5.remove_FrameCreated(EventRegistrationToken token)
        {
            this.WebView_5.remove_FrameCreated(token);
        }

        void ICoreWebView2_5.add_DownloadStarting(ICoreWebView2DownloadStartingEventHandler eventHandler, out EventRegistrationToken token)
        {
            this.WebView_5.add_DownloadStarting(eventHandler, out token);
        }

        void ICoreWebView2_5.remove_DownloadStarting(EventRegistrationToken token)
        {
            this.WebView_5.remove_DownloadStarting(token);
        }

        void ICoreWebView2_5.add_ClientCertificateRequested(ICoreWebView2ClientCertificateRequestedEventHandler eventHandler,
            out EventRegistrationToken token)
        {
            this.WebView_5.add_ClientCertificateRequested(eventHandler, out token);
        }

        void ICoreWebView2_5.remove_ClientCertificateRequested(EventRegistrationToken token)
        {
            this.WebView_5.remove_ClientCertificateRequested(token);
        }

        void ICoreWebView2_4.add_FrameCreated(ICoreWebView2FrameCreatedEventHandler eventHandler, out EventRegistrationToken token)
        {
            this.WebView_4.add_FrameCreated(eventHandler, out token);
        }

        void ICoreWebView2_4.remove_FrameCreated(EventRegistrationToken token)
        {
            this.WebView_4.remove_FrameCreated(token);
        }

        void ICoreWebView2_4.add_DownloadStarting(ICoreWebView2DownloadStartingEventHandler eventHandler, out EventRegistrationToken token)
        {
            this.WebView_4.add_DownloadStarting(eventHandler, out token);
        }

        void ICoreWebView2_4.remove_DownloadStarting(EventRegistrationToken token)
        {
            this.WebView_4.remove_DownloadStarting(token);
        }

        void ICoreWebView2_2.add_WebResourceRequested(ICoreWebView2WebResourceRequestedEventHandler eventHandler,
            out EventRegistrationToken token)
        {
            this.WebView_2.add_WebResourceRequested(eventHandler, out token);
        }

        void ICoreWebView2.remove_WebResourceRequested(EventRegistrationToken token)
        {
            this.WebView_2.remove_WebResourceRequested(token);
        }

        public void AddWebResourceRequestedFilter(string uri, COREWEBVIEW2_WEB_RESOURCE_CONTEXT resourceContext)
        {
            this.ToInterface().AddWebResourceRequestedFilter(uri, resourceContext);
        }
        void ICoreWebView2.AddWebResourceRequestedFilter(string uri, COREWEBVIEW2_WEB_RESOURCE_CONTEXT ResourceContext)
        {
            this.WebView_2.AddWebResourceRequestedFilter(uri, ResourceContext);
        }

        public void RemoveWebResourceRequestedFilter(string uri,
            COREWEBVIEW2_WEB_RESOURCE_CONTEXT ResourceContext)
        {
            this.ToInterface().RemoveWebResourceRequestedFilter(uri, ResourceContext);
        }
        void ICoreWebView2.RemoveWebResourceRequestedFilter(string uri,
            COREWEBVIEW2_WEB_RESOURCE_CONTEXT ResourceContext)
        {
            this.WebView_2.RemoveWebResourceRequestedFilter(uri, ResourceContext);
        }

        void ICoreWebView2.add_WindowCloseRequested(ICoreWebView2WindowCloseRequestedEventHandler eventHandler,
            out EventRegistrationToken token)
        {
            this.WebView_0.add_WindowCloseRequested(eventHandler, out token);
        }

        void ICoreWebView2.remove_WindowCloseRequested(EventRegistrationToken token)
        {
            this.WebView_0.remove_WindowCloseRequested(token);
        }

        ICoreWebView2Settings ICoreWebView2_3.Settings => this.WebView_3.Settings;

        int ICoreWebView2_3.CanGoBack => this.WebView_3.CanGoBack;

        int ICoreWebView2_3.CanGoForward => this.WebView_3.CanGoForward;

        int ICoreWebView2_3.ContainsFullScreenElement => this.WebView_3.ContainsFullScreenElement;

        ICoreWebView2Settings ICoreWebView2_2.Settings => this.WebView_2.Settings;

        int ICoreWebView2_2.CanGoBack => this.WebView_2.CanGoBack;

        int ICoreWebView2_2.CanGoForward => this.WebView_2.CanGoForward;

        int ICoreWebView2_2.ContainsFullScreenElement => this.WebView_2.ContainsFullScreenElement;

        ICoreWebView2Settings ICoreWebView2.Settings => this.WebView_0.Settings;

        int ICoreWebView2.CanGoBack => this.WebView_0.CanGoBack;

        int ICoreWebView2.CanGoForward => this.WebView_0.CanGoForward;

        int ICoreWebView2.ContainsFullScreenElement => this.WebView_0.ContainsFullScreenElement;

        ICoreWebView2Settings ICoreWebView2_4.Settings => this._WebView.Settings;

        int ICoreWebView2_4.CanGoBack => this.WebView_4.CanGoBack;

        int ICoreWebView2_4.CanGoForward => this.WebView_4.CanGoForward;

        int ICoreWebView2_4.ContainsFullScreenElement => this.WebView_4.ContainsFullScreenElement;

        ICoreWebView2Settings ICoreWebView2_6.Settings => this.WebView_6.Settings;

        int ICoreWebView2_6.CanGoBack => this.WebView_6.CanGoBack;

        int ICoreWebView2_6.CanGoForward => this.WebView_6.CanGoForward;

        int ICoreWebView2_6.ContainsFullScreenElement => this.WebView_6.ContainsFullScreenElement;

        ICoreWebView2Settings ICoreWebView2_5.Settings => this.WebView_5.Settings;

        int ICoreWebView2_5.CanGoBack => this.WebView_5.CanGoBack;

        int ICoreWebView2_5.CanGoForward => this.WebView_5.CanGoForward;

        int ICoreWebView2_5.ContainsFullScreenElement => this.WebView_5.ContainsFullScreenElement;
    }
}