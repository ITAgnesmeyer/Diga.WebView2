using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.EventArguments;
using Diga.WebView2.Wrapper.Handler;
using System;

namespace Diga.WebView2.Wrapper
{
    public class WebView2View : ICoreWebView2, IDisposable
    {
        private ICoreWebView2 _WebView;
        public event EventHandler<NavigationStartingEventArgs> NavigationStarting;
        public event EventHandler<ContentLoadingEventArgs> ContentLoading;
        public event EventHandler<ExecuteScriptCompletedEventArgs> ExecuteScriptCompleted;
        public event EventHandler<SourceChangedEventArgs> SourceChanged;
        public event EventHandler<WebView2EventArgs> HistoryChanged;
        public event EventHandler<NavigationCompletedEventArgs> NavigationCompleted;
        public WebView2View(ICoreWebView2 webView)
        {
            this._WebView = webView;
            RegisterEvents();
        }

        private void RegisterEvents()
        {
            NavigationStartingEventHandler navigationStartingHandler = new NavigationStartingEventHandler();
            navigationStartingHandler.NavigationStarting += OnNavigationStartingIntern;
            ((ICoreWebView2) this).add_NavigationStarting(navigationStartingHandler, out this._NavigationStartingToken);

            ContentLoadingEventHandler contentLoadingHandler = new ContentLoadingEventHandler();
            contentLoadingHandler.ContentLoading += OnContentLoadingIntern;
            ((ICoreWebView2) this).add_ContentLoading(contentLoadingHandler, out this._ContentLoadingToken);

            SourceChangedEventHandler sourceChangedHandler = new SourceChangedEventHandler();
            sourceChangedHandler.SourceChanged += OnSourceChangedIntern;
            ((ICoreWebView2) this).add_SourceChanged(sourceChangedHandler, out this._SourceChangedToken);

            HistoryChangedEventHandler historyChangedHandler = new HistoryChangedEventHandler();
            historyChangedHandler.HistoryChanged += OnHistoryChangedIntern;
            ((ICoreWebView2) this).add_HistoryChanged(historyChangedHandler, out this._HistoryChangeToken);

            NavigationCompletedEventHandler navigationCompletedHandler = new NavigationCompletedEventHandler();
            navigationCompletedHandler.NavigaionCompleted+=OnNavigationCompletedIntern;
            ((ICoreWebView2) this).add_NavigationCompleted(navigationCompletedHandler,
                out this._NavigationCompletedToken);
        }

        private void OnNavigationCompletedIntern(object sender, NavigationCompletedEventArgs e)
        {
            OnNavigationCompleted(e);
        }

        private void OnHistoryChangedIntern(object sender, WebView2EventArgs e)
        {
            OnHistoryChanged(e);
        }

        private void OnSourceChangedIntern(object sender, SourceChangedEventArgs e)
        {
            OnSourceChanged(e);
        }

        private void OnContentLoadingIntern(object sender, ContentLoadingEventArgs e)
        {
            OnContentLoading(e);
        }

        public void UnregisterEvents()
        {
            ((ICoreWebView2)this).remove_NavigationStarting(this._NavigationStartingToken);
            ((ICoreWebView2)this).remove_ContentLoading(this._ContentLoadingToken);
            ((ICoreWebView2)this).remove_SourceChanged(this._SourceChangedToken);
            ((ICoreWebView2) this).remove_HistoryChanged(this._HistoryChangeToken);
            ((ICoreWebView2) this).remove_NavigationCompleted(this._NavigationCompletedToken);
        }

        private EventRegistrationToken _NavigationStartingToken;
        private EventRegistrationToken _ContentLoadingToken;
        private EventRegistrationToken _SourceChangedToken;
        private EventRegistrationToken _HistoryChangeToken;
        private EventRegistrationToken _NavigationCompletedToken;

        private void OnNavigationStartingIntern(object sender, NavigationStartingEventArgs e)
        {
            OnNavigationStarting(e);
        }

        ICoreWebView2Settings ICoreWebView2.Settings => this._WebView.Settings;
        public WebView2Settings Settings => new WebView2Settings(((ICoreWebView2)this).Settings);

        string ICoreWebView2.Source => this._WebView.Source;
        public string Source => ((ICoreWebView2)this).Source;

        void ICoreWebView2.Navigate(string uri)
        {
            this._WebView.Navigate(uri);
        }

        public void Navigate(string uri)
        {
            ((ICoreWebView2)this).Navigate(uri);
        }

        void ICoreWebView2.NavigateToString(string htmlContent)
        {
            this._WebView.NavigateToString(htmlContent);
        }

        public void NavigateToString(string htmlContent)
        {
            ((ICoreWebView2)this).NavigateToString(htmlContent);
        }

        void ICoreWebView2.add_NavigationStarting(ICoreWebView2NavigationStartingEventHandler eventHandler, out EventRegistrationToken token)
        {
            this._WebView.add_NavigationStarting(eventHandler, out token);
        }

        void ICoreWebView2.remove_NavigationStarting(EventRegistrationToken token)
        {
            this._WebView.remove_NavigationStarting(token);
        }

        void ICoreWebView2.add_ContentLoading(ICoreWebView2ContentLoadingEventHandler eventHandler, out EventRegistrationToken token)
        {
            this._WebView.add_ContentLoading(eventHandler, out token);
        }

        void ICoreWebView2.remove_ContentLoading(EventRegistrationToken token)
        {
            this._WebView.remove_ContentLoading(token);
        }

        void ICoreWebView2.add_SourceChanged(ICoreWebView2SourceChangedEventHandler eventHandler, out EventRegistrationToken token)
        {
            this._WebView.add_SourceChanged(eventHandler, out token);
        }

        void ICoreWebView2.remove_SourceChanged(EventRegistrationToken token)
        {
            this._WebView.remove_SourceChanged(token);
        }

        void ICoreWebView2.add_HistoryChanged(ICoreWebView2HistoryChangedEventHandler eventHandler, out EventRegistrationToken token)
        {
            this._WebView.add_HistoryChanged(eventHandler, out token);
        }

        void ICoreWebView2.remove_HistoryChanged(EventRegistrationToken token)
        {
            this._WebView.remove_HistoryChanged(token);
        }

        void ICoreWebView2.add_NavigationCompleted(ICoreWebView2NavigationCompletedEventHandler eventHandler,
            out EventRegistrationToken token)
        {
            this._WebView.add_NavigationCompleted(eventHandler, out token);
        }

        void ICoreWebView2.remove_NavigationCompleted(EventRegistrationToken token)
        {
            this._WebView.remove_NavigationCompleted(token);
        }

        void ICoreWebView2.add_FrameNavigationStarting(ICoreWebView2NavigationStartingEventHandler eventHandler,
            out EventRegistrationToken token)
        {
            this._WebView.add_FrameNavigationStarting(eventHandler, out token);
        }

        void ICoreWebView2.remove_FrameNavigationStarting(EventRegistrationToken token)
        {
            this._WebView.remove_FrameNavigationStarting(token);
        }

        void ICoreWebView2.add_ScriptDialogOpening(ICoreWebView2ScriptDialogOpeningEventHandler eventHandler,
            out EventRegistrationToken token)
        {
            this._WebView.add_ScriptDialogOpening(eventHandler, out token);
        }

        void ICoreWebView2.remove_ScriptDialogOpening(EventRegistrationToken token)
        {
            this._WebView.remove_ScriptDialogOpening(token);
        }

        void ICoreWebView2.add_PermissionRequested(ICoreWebView2PermissionRequestedEventHandler eventHandler,
            out EventRegistrationToken token)
        {
            this._WebView.add_PermissionRequested(eventHandler, out token);
        }

        void ICoreWebView2.remove_PermissionRequested(EventRegistrationToken token)
        {
            this._WebView.remove_PermissionRequested(token);
        }

        void ICoreWebView2.add_ProcessFailed(ICoreWebView2ProcessFailedEventHandler eventHandler, out EventRegistrationToken token)
        {
            this._WebView.add_ProcessFailed(eventHandler, out token);
        }

        void ICoreWebView2.remove_ProcessFailed(EventRegistrationToken token)
        {
            this._WebView.remove_ProcessFailed(token);
        }

        void ICoreWebView2.AddScriptToExecuteOnDocumentCreated(string javaScript,
            ICoreWebView2AddScriptToExecuteOnDocumentCreatedCompletedHandler handler)
        {
            this._WebView.AddScriptToExecuteOnDocumentCreated(javaScript, handler);
        }

        public void AddScriptToExecuteOnDocumentCreated(string javaScript)
        {
            AddScriptToExecuteOnDocumentCreatedCompletedHandler handler =
                new AddScriptToExecuteOnDocumentCreatedCompletedHandler();
            handler.ScriptExecuted += OnScriptToExecuteOnDocumentCreatedIntern;
            ((ICoreWebView2)this).AddScriptToExecuteOnDocumentCreated(javaScript, handler);
        }

        private void OnScriptToExecuteOnDocumentCreatedIntern(object sender, AddScriptToExecuteOnDocumentCreatedCompletedEventArgs e)
        {

        }

        void ICoreWebView2.RemoveScriptToExecuteOnDocumentCreated(string id)
        {
            this._WebView.RemoveScriptToExecuteOnDocumentCreated(id);
        }

        public void RemoveScriptToExecuteOnDocumentCreated(string id)
        {
            ((ICoreWebView2)this).RemoveScriptToExecuteOnDocumentCreated(id);
        }

        void ICoreWebView2.ExecuteScript(string javaScript, ICoreWebView2ExecuteScriptCompletedHandler handler)
        {
            this._WebView.ExecuteScript(javaScript, handler);
        }

        public void ExecuteScript(string javaScript)
        {
            ExecuteScriptCompletedHandler handler = new ExecuteScriptCompletedHandler();
            handler.ScriptCompleted += OnExecuteScriptCompletedIntern;
            ((ICoreWebView2)this).ExecuteScript(javaScript, handler);
        }

        private void OnExecuteScriptCompletedIntern(object sender, ExecuteScriptCompletedEventArgs e)
        {
            OnExecuteScriptCompleted(e);
        }

        void ICoreWebView2.CapturePreview(CORE_WEBVIEW2_CAPTURE_PREVIEW_IMAGE_FORMAT imageFormat, IStream imageStream,
            ICoreWebView2CapturePreviewCompletedHandler handler)
        {
            this._WebView.CapturePreview(imageFormat, imageStream, handler);
        }

        void ICoreWebView2.Reload()
        {
            this._WebView.Reload();
        }

        public void Reload()
        {
            ((ICoreWebView2)this).Reload();
        }
        void ICoreWebView2.PostWebMessageAsJson(string webMessageAsJson)
        {
            this._WebView.PostWebMessageAsJson(webMessageAsJson);
        }

        public void PostWebMessageAsJson(string webMessageAsJson)
        {
            ((ICoreWebView2)this).PostWebMessageAsJson(webMessageAsJson);
        }

        void ICoreWebView2.PostWebMessageAsString(string webMessageAsString)
        {
            this._WebView.PostWebMessageAsString(webMessageAsString);
        }

        public void PostWebMessageAsString(string webMessageAsString)
        {
            ((ICoreWebView2)this).PostWebMessageAsString(webMessageAsString);
        }

        void ICoreWebView2.add_WebMessageReceived(ICoreWebView2WebMessageReceivedEventHandler handler, out EventRegistrationToken token)
        {
            this._WebView.add_WebMessageReceived(handler, out token);
        }

        void ICoreWebView2.remove_WebMessageReceived(EventRegistrationToken token)
        {
            this._WebView.remove_WebMessageReceived(token);
        }

        void ICoreWebView2.CallDevToolsProtocolMethod(string methodName, string parametersAsJson,
            ICoreWebView2CallDevToolsProtocolMethodCompletedHandler handler)
        {
            this._WebView.CallDevToolsProtocolMethod(methodName, parametersAsJson, handler);
        }


        uint ICoreWebView2.BrowserProcessId => this._WebView.BrowserProcessId;

        public uint BrowserProcessId => ((ICoreWebView2)this).BrowserProcessId;

        int ICoreWebView2.CanGoBack => this._WebView.CanGoBack;
        public bool CanGoBack => ((ICoreWebView2)this).CanGoBack == 1;
        int ICoreWebView2.CanGoForward => this._WebView.CanGoForward;
        public bool CanGoForward => (((ICoreWebView2)this).CanGoForward) == 1;
        void ICoreWebView2.GoBack()
        {
            this._WebView.GoBack();
        }

        public void GoBack()
        {
            ((ICoreWebView2)this).GoBack();
        }
        void ICoreWebView2.GoForward()
        {
            this._WebView.GoForward();
        }

        public void GoForward()
        {
            ((ICoreWebView2)this).GoForward();
        }
        ICoreWebView2DevToolsProtocolEventReceiver ICoreWebView2.GetDevToolsProtocolEventReceiver(string eventName)
        {
            return this._WebView.GetDevToolsProtocolEventReceiver(eventName);
        }

        void ICoreWebView2.Stop()
        {
            this._WebView.Stop();
        }

        public void Stop()
        {
            ((ICoreWebView2)this).Stop();
        }
        void ICoreWebView2.add_NewWindowRequested(ICoreWebView2NewWindowRequestedEventHandler eventHandler, out EventRegistrationToken token)
        {
            this._WebView.add_NewWindowRequested(eventHandler, out token);
        }

        void ICoreWebView2.remove_NewWindowRequested(EventRegistrationToken token)
        {
            this._WebView.remove_NewWindowRequested(token);
        }

        void ICoreWebView2.add_DocumentTitleChanged(ICoreWebView2DocumentTitleChangedEventHandler eventHandler,
            out EventRegistrationToken token)
        {
            this._WebView.add_DocumentTitleChanged(eventHandler, out token);
        }

        void ICoreWebView2.remove_DocumentTitleChanged(EventRegistrationToken token)
        {
            this._WebView.remove_DocumentTitleChanged(token);
        }

        string ICoreWebView2.DocumentTitle => this._WebView.DocumentTitle;
        public string DocumentTitle => ((ICoreWebView2)this).DocumentTitle;
        void ICoreWebView2.AddRemoteObject(string name, ref object @object)
        {
            this._WebView.AddRemoteObject(name, ref @object);
        }

        public void AddRemoteObject(string name, ref object @object)
        {
            ((ICoreWebView2)this).AddRemoteObject(name, ref @object);
        }
        void ICoreWebView2.RemoveRemoteObject(string name)
        {
            this._WebView.RemoveRemoteObject(name);
        }

        public void RemoveRemoteObject(string name)
        {
            ((ICoreWebView2)this).RemoveRemoteObject(name);
        }
        void ICoreWebView2.OpenDevToolsWindow()
        {
            this._WebView.OpenDevToolsWindow();
        }

        public void OpenDevToolsWindow()
        {
            ((ICoreWebView2)this).OpenDevToolsWindow();
        }
        void ICoreWebView2.add_ContainsFullScreenElementChanged(ICoreWebView2ContainsFullScreenElementChangedEventHandler eventHandler,
            out EventRegistrationToken token)
        {
            this._WebView.add_ContainsFullScreenElementChanged(eventHandler, out token);
        }

        void ICoreWebView2.remove_ContainsFullScreenElementChanged(EventRegistrationToken token)
        {
            this._WebView.remove_ContainsFullScreenElementChanged(token);
        }

        int ICoreWebView2.ContainsFullScreenElement => this._WebView.ContainsFullScreenElement;
        public bool ContainsFullScreenElement => new BOOL(((ICoreWebView2)this).ContainsFullScreenElement);
        void ICoreWebView2.add_WebResourceRequested(ICoreWebView2WebResourceRequestedEventHandler eventHandler,
            out EventRegistrationToken token)
        {
            this._WebView.add_WebResourceRequested(eventHandler, out token);
        }

        void ICoreWebView2.remove_WebResourceRequested(EventRegistrationToken token)
        {
            this._WebView.remove_WebResourceRequested(token);
        }

        void ICoreWebView2.AddWebResourceRequestedFilter(string uri, CORE_WEBVIEW2_WEB_RESOURCE_CONTEXT resourceContext)
        {
            this._WebView.AddWebResourceRequestedFilter(uri, resourceContext);
        }

        public void AddWebResourceRequestedFilter(string uri, ResourceContext context)
        {
            ((ICoreWebView2)this).AddWebResourceRequestedFilter(uri, (CORE_WEBVIEW2_WEB_RESOURCE_CONTEXT)context);
        }

        void ICoreWebView2.RemoveWebResourceRequestedFilter(string uri, CORE_WEBVIEW2_WEB_RESOURCE_CONTEXT resourceContext)
        {
            this._WebView.RemoveWebResourceRequestedFilter(uri, resourceContext);
        }

        public void RemoveWebResourceRequestedFilter(string uri, ResourceContext context)
        {
            ((ICoreWebView2)this).RemoveWebResourceRequestedFilter(uri, (CORE_WEBVIEW2_WEB_RESOURCE_CONTEXT)context);
        }

        void ICoreWebView2.add_WindowCloseRequested(ICoreWebView2WindowCloseRequestedEventHandler eventHandler,
            out EventRegistrationToken token)
        {
            this._WebView.add_WindowCloseRequested(eventHandler, out token);
        }

        void ICoreWebView2.remove_WindowCloseRequested(EventRegistrationToken token)
        {
            this._WebView.remove_WindowCloseRequested(token);
        }

        protected virtual void OnNavigationStarting(NavigationStartingEventArgs e)
        {
            NavigationStarting?.Invoke(this, e);
        }

        public void Dispose()
        {
            UnregisterEvents();
        }

        protected virtual void OnContentLoading(ContentLoadingEventArgs e)
        {
            ContentLoading?.Invoke(this, e);
        }

        protected virtual void OnExecuteScriptCompleted(ExecuteScriptCompletedEventArgs e)
        {
            ExecuteScriptCompleted?.Invoke(this, e);
        }

        protected virtual void OnSourceChanged(SourceChangedEventArgs e)
        {
            SourceChanged?.Invoke(this, e);
        }

        protected virtual void OnHistoryChanged(WebView2EventArgs e)
        {
            HistoryChanged?.Invoke(this, e);
        }

        protected virtual void OnNavigationCompleted(NavigationCompletedEventArgs e)
        {
            NavigationCompleted?.Invoke(this, e);
        }
    }
}