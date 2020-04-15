using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.EventArguments;
using Diga.WebView2.Wrapper.Handler;
using System;

namespace Diga.WebView2.Wrapper
{
    public class WebView2View : IWebView2WebView5, IDisposable
    {
        private IWebView2WebView5 _WebView;
        public event EventHandler<NavigationStartingEventArgs> NavigationStarting;
        public event EventHandler<ContentLoadingEventArgs> ContentLoading;
        public event EventHandler<ExecuteScriptCompletedEventArgs> ExecuteScriptCompleted;
        public event EventHandler<SourceChangedEventArgs> SourceChanged;
        public event EventHandler<WebView2EventArgs> HistoryChanged;
        public event EventHandler<NavigationCompletedEventArgs> NavigationCompleted;
        public WebView2View(IWebView2WebView5 webView)
        {
            this._WebView = webView;
            RegisterEvents();
        }

        private void RegisterEvents()
        {
            NavigationStartingEventHandler navigationStartingHandler = new NavigationStartingEventHandler();
            navigationStartingHandler.NavigationStarting += OnNavigationStartingIntern;
            ((IWebView2WebView5) this).add_NavigationStarting(navigationStartingHandler, out this._NavigationStartingToken);

            //ContentLoadingEventHandler contentLoadingHandler = new ContentLoadingEventHandler();
            //contentLoadingHandler.ContentLoading += OnContentLoadingIntern;
            //((IWebView2WebView5) this).add_ContentLoading(contentLoadingHandler, out this._ContentLoadingToken);

            //SourceChangedEventHandler sourceChangedHandler = new SourceChangedEventHandler();
            //sourceChangedHandler.SourceChanged += OnSourceChangedIntern;
            //((IWebView2WebView5) this).add_SourceChanged(sourceChangedHandler, out this._SourceChangedToken);

            //HistoryChangedEventHandler historyChangedHandler = new HistoryChangedEventHandler();
            //historyChangedHandler.HistoryChanged += OnHistoryChangedIntern;
            //((IWebView2WebView5) this).add_HistoryChanged(historyChangedHandler, out this._HistoryChangeToken);

            NavigationCompletedEventHandler navigationCompletedHandler = new NavigationCompletedEventHandler();
            navigationCompletedHandler.NavigaionCompleted+=OnNavigationCompletedIntern;
            ((IWebView2WebView5) this).add_NavigationCompleted(navigationCompletedHandler,
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
            ((IWebView2WebView5)this).remove_NavigationStarting(this._NavigationStartingToken);
            //((IWebView2WebView5)this).remove_ContentLoading(this._ContentLoadingToken);
            //((IWebView2WebView5)this).remove_SourceChanged(this._SourceChangedToken);
            //((IWebView2WebView5) this).remove_HistoryChanged(this._HistoryChangeToken);
            ((IWebView2WebView5) this).remove_NavigationCompleted(this._NavigationCompletedToken);
        }

        private EventRegistrationToken _NavigationStartingToken;
        //private EventRegistrationToken _ContentLoadingToken;
        //private EventRegistrationToken _SourceChangedToken;
        //private EventRegistrationToken _HistoryChangeToken;
        private EventRegistrationToken _NavigationCompletedToken;

        private void OnNavigationStartingIntern(object sender, NavigationStartingEventArgs e)
        {
            OnNavigationStarting(e);
        }

        IWebView2Settings IWebView2WebView5.Settings => this._WebView.Settings;
        public WebView2Settings Settings => new WebView2Settings((IWebView2Settings2)((IWebView2WebView5)this).Settings);

        string IWebView2WebView5.Source => this._WebView.Source;
        public string Source => ((IWebView2WebView5)this).Source;

        void IWebView2WebView5.Navigate(string uri)
        {
            this._WebView.Navigate(uri);
        }

        public void Navigate(string uri)
        {
            ((IWebView2WebView5)this).Navigate(uri);
        }

        void IWebView2WebView5.NavigateToString(string htmlContent)
        {
            this._WebView.NavigateToString(htmlContent);
        }

        public void NavigateToString(string htmlContent)
        {
            ((IWebView2WebView5)this).NavigateToString(htmlContent);
        }

        void IWebView2WebView5.add_NavigationStarting(IWebView2NavigationStartingEventHandler eventHandler, out EventRegistrationToken token)
        {
            this._WebView.add_NavigationStarting(eventHandler, out token);
        }

        void IWebView2WebView5.remove_NavigationStarting(EventRegistrationToken token)
        {
            this._WebView.remove_NavigationStarting(token);
        }

        internal void Close()
        {
            this._WebView.Close();
        }

        //void IWebView2WebView5.add_ContentLoading(IWebView2ContentLoadingEventHandler eventHandler, out EventRegistrationToken token)
        //{
        //    this._WebView.add_ContentLoading(eventHandler, out token);
        //}


        void IWebView2WebView5.add_NavigationCompleted(IWebView2NavigationCompletedEventHandler eventHandler,
            out EventRegistrationToken token)
        {
            this._WebView.add_NavigationCompleted(eventHandler, out token);
        }

        void IWebView2WebView5.remove_NavigationCompleted(EventRegistrationToken token)
        {
            this._WebView.remove_NavigationCompleted(token);
        }

        void IWebView2WebView5.add_FrameNavigationStarting(IWebView2NavigationStartingEventHandler eventHandler,
            out EventRegistrationToken token)
        {
            this._WebView.add_FrameNavigationStarting(eventHandler, out token);
        }

        void IWebView2WebView5.remove_FrameNavigationStarting(EventRegistrationToken token)
        {
            this._WebView.remove_FrameNavigationStarting(token);
        }

        void IWebView2WebView5.add_ScriptDialogOpening(IWebView2ScriptDialogOpeningEventHandler eventHandler,
            out EventRegistrationToken token)
        {
            this._WebView.add_ScriptDialogOpening(eventHandler, out token);
        }

        void IWebView2WebView5.remove_ScriptDialogOpening(EventRegistrationToken token)
        {
            this._WebView.remove_ScriptDialogOpening(token);
        }

        void IWebView2WebView5.add_PermissionRequested(IWebView2PermissionRequestedEventHandler eventHandler,
            out EventRegistrationToken token)
        {
            this._WebView.add_PermissionRequested(eventHandler, out token);
        }

        void IWebView2WebView5.remove_PermissionRequested(EventRegistrationToken token)
        {
            this._WebView.remove_PermissionRequested(token);
        }

        void IWebView2WebView5.add_ProcessFailed(IWebView2ProcessFailedEventHandler eventHandler, out EventRegistrationToken token)
        {
            this._WebView.add_ProcessFailed(eventHandler, out token);
        }

        void IWebView2WebView5.remove_ProcessFailed(EventRegistrationToken token)
        {
            this._WebView.remove_ProcessFailed(token);
        }

        void IWebView2WebView5.AddScriptToExecuteOnDocumentCreated(string javaScript,
            IWebView2AddScriptToExecuteOnDocumentCreatedCompletedHandler handler)
        {
            this._WebView.AddScriptToExecuteOnDocumentCreated(javaScript, handler);
        }

        public void AddScriptToExecuteOnDocumentCreated(string javaScript)
        {
            AddScriptToExecuteOnDocumentCreatedCompletedHandler handler =
                new AddScriptToExecuteOnDocumentCreatedCompletedHandler();
            handler.ScriptExecuted += OnScriptToExecuteOnDocumentCreatedIntern;
            ((IWebView2WebView5)this).AddScriptToExecuteOnDocumentCreated(javaScript, handler);
        }

        private void OnScriptToExecuteOnDocumentCreatedIntern(object sender, AddScriptToExecuteOnDocumentCreatedCompletedEventArgs e)
        {

        }

        void IWebView2WebView5.RemoveScriptToExecuteOnDocumentCreated(string id)
        {
            this._WebView.RemoveScriptToExecuteOnDocumentCreated(id);
        }

        public void RemoveScriptToExecuteOnDocumentCreated(string id)
        {
            ((IWebView2WebView5)this).RemoveScriptToExecuteOnDocumentCreated(id);
        }

        void IWebView2WebView5.ExecuteScript(string javaScript, IWebView2ExecuteScriptCompletedHandler handler)
        {
            this._WebView.ExecuteScript(javaScript, handler);
        }

        public void ExecuteScript(string javaScript)
        {
            ExecuteScriptCompletedHandler handler = new ExecuteScriptCompletedHandler();
            handler.ScriptCompleted += OnExecuteScriptCompletedIntern;
            ((IWebView2WebView5)this).ExecuteScript(javaScript, handler);
        }

        private void OnExecuteScriptCompletedIntern(object sender, ExecuteScriptCompletedEventArgs e)
        {
            OnExecuteScriptCompleted(e);
        }

        

        void IWebView2WebView5.Reload()
        {
            this._WebView.Reload();
        }

        public void Reload()
        {
            ((IWebView2WebView5)this).Reload();
        }
        void IWebView2WebView5.PostWebMessageAsJson(string webMessageAsJson)
        {
            this._WebView.PostWebMessageAsJson(webMessageAsJson);
        }

        public void PostWebMessageAsJson(string webMessageAsJson)
        {
            ((IWebView2WebView5)this).PostWebMessageAsJson(webMessageAsJson);
        }

        void IWebView2WebView5.PostWebMessageAsString(string webMessageAsString)
        {
            this._WebView.PostWebMessageAsString(webMessageAsString);
        }

        public void PostWebMessageAsString(string webMessageAsString)
        {
            ((IWebView2WebView5)this).PostWebMessageAsString(webMessageAsString);
        }

        void IWebView2WebView5.add_WebMessageReceived(IWebView2WebMessageReceivedEventHandler handler, out EventRegistrationToken token)
        {
            this._WebView.add_WebMessageReceived(handler, out token);
        }

        void IWebView2WebView5.remove_WebMessageReceived(EventRegistrationToken token)
        {
            this._WebView.remove_WebMessageReceived(token);
        }

        void IWebView2WebView5.CallDevToolsProtocolMethod(string methodName, string parametersAsJson,
            IWebView2CallDevToolsProtocolMethodCompletedHandler handler)
        {
            this._WebView.CallDevToolsProtocolMethod(methodName, parametersAsJson, handler);
        }


        uint IWebView2WebView5.BrowserProcessId => this._WebView.BrowserProcessId;

        public uint BrowserProcessId => ((IWebView2WebView5)this).BrowserProcessId;

        int IWebView2WebView5.CanGoBack => this._WebView.CanGoBack;
        public bool CanGoBack => ((IWebView2WebView5)this).CanGoBack == 1;
        int IWebView2WebView5.CanGoForward => this._WebView.CanGoForward;
        public bool CanGoForward => (((IWebView2WebView5)this).CanGoForward) == 1;
        void IWebView2WebView5.GoBack()
        {
            this._WebView.GoBack();
        }

        public void GoBack()
        {
            ((IWebView2WebView5)this).GoBack();
        }
        void IWebView2WebView5.GoForward()
        {
            this._WebView.GoForward();
        }

        public void GoForward()
        {
            ((IWebView2WebView5)this).GoForward();
        }
       

        void IWebView2WebView5.Stop()
        {
            this._WebView.Stop();
        }

        public void Stop()
        {
            ((IWebView2WebView5)this).Stop();
        }
        void IWebView2WebView5.add_NewWindowRequested(IWebView2NewWindowRequestedEventHandler eventHandler, out EventRegistrationToken token)
        {
            this._WebView.add_NewWindowRequested(eventHandler, out token);
        }

        void IWebView2WebView5.remove_NewWindowRequested(EventRegistrationToken token)
        {
            this._WebView.remove_NewWindowRequested(token);
        }

        void IWebView2WebView5.add_DocumentTitleChanged(IWebView2DocumentTitleChangedEventHandler eventHandler,
            out EventRegistrationToken token)
        {
            this._WebView.add_DocumentTitleChanged(eventHandler, out token);
        }

        void IWebView2WebView5.remove_DocumentTitleChanged(EventRegistrationToken token)
        {
            this._WebView.remove_DocumentTitleChanged(token);
        }

        
        void IWebView2WebView5.AddRemoteObject(string name, ref object @object)
        {
            this._WebView.AddRemoteObject(name, ref @object);
        }

        public void AddRemoteObject(string name, ref object @object)
        {
            ((IWebView2WebView5)this).AddRemoteObject(name, ref @object);
        }
        void IWebView2WebView5.RemoveRemoteObject(string name)
        {
            this._WebView.RemoveRemoteObject(name);
        }

        public void RemoveRemoteObject(string name)
        {
            ((IWebView2WebView5)this).RemoveRemoteObject(name);
        }
        void IWebView2WebView5.OpenDevToolsWindow()
        {
            this._WebView.OpenDevToolsWindow();
        }

        public void OpenDevToolsWindow()
        {
            ((IWebView2WebView5)this).OpenDevToolsWindow();
        }
        void IWebView2WebView5.add_ContainsFullScreenElementChanged(IWebView2ContainsFullScreenElementChangedEventHandler eventHandler,
            out EventRegistrationToken token)
        {
            this._WebView.add_ContainsFullScreenElementChanged(eventHandler, out token);
        }

        void IWebView2WebView5.remove_ContainsFullScreenElementChanged(EventRegistrationToken token)
        {
            this._WebView.remove_ContainsFullScreenElementChanged(token);
        }

        int IWebView2WebView5.ContainsFullScreenElement => this._WebView.ContainsFullScreenElement;
        public bool ContainsFullScreenElement => new BOOL(((IWebView2WebView5)this).ContainsFullScreenElement);
        void IWebView2WebView5.add_WebResourceRequested(IWebView2WebResourceRequestedEventHandler eventHandler,
            out EventRegistrationToken token)
        {
            this._WebView.add_WebResourceRequested(eventHandler, out token);
        }

        void IWebView2WebView5.remove_WebResourceRequested(EventRegistrationToken token)
        {
            this._WebView.remove_WebResourceRequested(token);
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

        void IWebView2WebView5.MoveFocus(WEBVIEW2_MOVE_FOCUS_REASON reason)
        {
            this._WebView.MoveFocus(reason);
        }

        void IWebView2WebView5.add_DocumentStateChanged(IWebView2DocumentStateChangedEventHandler eventHandler, out EventRegistrationToken token)
        {
            this._WebView.add_DocumentStateChanged(eventHandler, out token);
        }

        void IWebView2WebView5.remove_DocumentStateChanged(EventRegistrationToken token)
        {
            this._WebView.remove_DocumentStateChanged(token);
        }

        void IWebView2WebView5.add_MoveFocusRequested(IWebView2MoveFocusRequestedEventHandler eventHandler, out EventRegistrationToken token)
        {
            this._WebView.add_MoveFocusRequested(eventHandler, out token);
        }

        void IWebView2WebView5.remove_MoveFocusRequested(EventRegistrationToken token)
        {
            this._WebView.remove_MoveFocusRequested(token);
        }

        void IWebView2WebView5.add_GotFocus(IWebView2FocusChangedEventHandler eventHandler, out EventRegistrationToken token)
        {
            this._WebView.add_GotFocus(eventHandler, out token);
        }

        void IWebView2WebView5.remove_GotFocus(EventRegistrationToken token)
        {
            this._WebView.remove_GotFocus(token);
        }

        void IWebView2WebView5.add_LostFocus(IWebView2FocusChangedEventHandler eventHandler, out EventRegistrationToken token)
        {
            this._WebView.add_LostFocus(eventHandler, out token);
        }

        void IWebView2WebView5.remove_LostFocus(EventRegistrationToken token)
        {
            this._WebView.remove_LostFocus(token);
        }

        void IWebView2WebView5.add_WebResourceRequested_deprecated(ref string urlFilter, ref WEBVIEW2_WEB_RESOURCE_CONTEXT resourceContextFilter, ulong filterLength, IWebView2WebResourceRequestedEventHandler eventHandler, out EventRegistrationToken token)
        {
            this._WebView.add_WebResourceRequested_deprecated(urlFilter, ref resourceContextFilter, filterLength,
                eventHandler, out token);
        }

        void IWebView2WebView5.add_ZoomFactorChanged(IWebView2ZoomFactorChangedEventHandler eventHandler, out EventRegistrationToken token)
        {
            this._WebView.add_ZoomFactorChanged(eventHandler, out token);
        }

        void IWebView2WebView5.remove_ZoomFactorChanged(EventRegistrationToken token)
        {
            this._WebView.remove_ZoomFactorChanged(token);
        }

        void IWebView2WebView5.CapturePreview(WEBVIEW2_CAPTURE_PREVIEW_IMAGE_FORMAT imageFormat, IStream imageStream, IWebView2CapturePreviewCompletedHandler handler)
        {
            this._WebView.CapturePreview(imageFormat, imageStream, handler);
        }

        tagRECT IWebView2WebView5.Bounds { get => this._WebView.Bounds; set => this._WebView.Bounds = value; }
        double IWebView2WebView5.ZoomFactor { get => this._WebView.ZoomFactor; set => this._WebView.ZoomFactor = value; }
        int IWebView2WebView5.IsVisible { get => this._WebView.IsVisible; set => this._WebView.IsVisible= value; }

        void IWebView2WebView5.Close()
        {
            this._WebView.Close();
        }

        void IWebView2WebView5.add_DevToolsProtocolEventReceived(string eventName, IWebView2DevToolsProtocolEventReceivedEventHandler handler, out EventRegistrationToken token)
        {
            this._WebView.add_DevToolsProtocolEventReceived(eventName, handler, out token);
        }

        void IWebView2WebView5.remove_DevToolsProtocolEventReceived(string eventName, EventRegistrationToken token)
        {
            this._WebView.remove_DevToolsProtocolEventReceived(eventName, token);
        }

        void IWebView2WebView5.DocumentTitle(out string title)
        {
            this._WebView.DocumentTitle(out title);
        }

        void IWebView2WebView5.add_AcceleratorKeyPressed(IWebView2AcceleratorKeyPressedEventHandler eventHandler, out EventRegistrationToken token)
        {
            this._WebView.add_AcceleratorKeyPressed(eventHandler, out token);
        }

        void IWebView2WebView5.remove_AcceleratorKeyPressed(EventRegistrationToken token)
        {
            this._WebView.remove_AcceleratorKeyPressed(token);
        }

        void IWebView2WebView5.AddWebResourceRequestedFilter(string uri, WEBVIEW2_WEB_RESOURCE_CONTEXT resourceContext)
        {
            this._WebView.AddWebResourceRequestedFilter(uri, resourceContext);
        }

        void IWebView2WebView5.RemoveWebResourceRequestedFilter(string uri, WEBVIEW2_WEB_RESOURCE_CONTEXT resourceContext)
        {
            this._WebView.RemoveWebResourceRequestedFilter(uri, resourceContext);
        }

        IWebView2Settings IWebView2WebView4.Settings => this._WebView.Settings;

        string IWebView2WebView4.Source => this._WebView.Source;

        void IWebView2WebView4.Navigate(string uri)
        {
            this._WebView.Navigate(uri);
        }

        void IWebView2WebView4.MoveFocus(WEBVIEW2_MOVE_FOCUS_REASON reason)
        {
            this._WebView.MoveFocus(reason);
        }

        void IWebView2WebView4.NavigateToString(string htmlContent)
        {
            this._WebView.NavigateToString(htmlContent);
        }

        void IWebView2WebView4.add_NavigationStarting(IWebView2NavigationStartingEventHandler eventHandler, out EventRegistrationToken token)
        {
            this._WebView.add_NavigationStarting(eventHandler, out token);
        }

        void IWebView2WebView4.remove_NavigationStarting(EventRegistrationToken token)
        {
            this._WebView.remove_NavigationStarting(token);
        }

        void IWebView2WebView4.add_DocumentStateChanged(IWebView2DocumentStateChangedEventHandler eventHandler, out EventRegistrationToken token)
        {
            this._WebView.add_DocumentStateChanged(eventHandler, out token);
        }

        void IWebView2WebView4.remove_DocumentStateChanged(EventRegistrationToken token)
        {
            this._WebView.remove_DocumentStateChanged(token);
        }

        void IWebView2WebView4.add_NavigationCompleted(IWebView2NavigationCompletedEventHandler eventHandler, out EventRegistrationToken token)
        {
            this._WebView.add_NavigationCompleted(eventHandler, out token);
        }

        void IWebView2WebView4.remove_NavigationCompleted(EventRegistrationToken token)
        {
            this._WebView.remove_NavigationCompleted(token);
        }

        void IWebView2WebView4.add_FrameNavigationStarting(IWebView2NavigationStartingEventHandler eventHandler, out EventRegistrationToken token)
        {
            this._WebView.add_FrameNavigationStarting(eventHandler, out token);
        }

        void IWebView2WebView4.remove_FrameNavigationStarting(EventRegistrationToken token)
        {
            this._WebView.remove_FrameNavigationStarting(token);
        }

        void IWebView2WebView4.add_MoveFocusRequested(IWebView2MoveFocusRequestedEventHandler eventHandler, out EventRegistrationToken token)
        {
            this._WebView.add_MoveFocusRequested(eventHandler, out token);
        }

        void IWebView2WebView4.remove_MoveFocusRequested(EventRegistrationToken token)
        {
            this._WebView.remove_MoveFocusRequested(token);
        }

        void IWebView2WebView4.add_GotFocus(IWebView2FocusChangedEventHandler eventHandler, out EventRegistrationToken token)
        {
            this._WebView.add_GotFocus(eventHandler, out token);
        }

        void IWebView2WebView4.remove_GotFocus(EventRegistrationToken token)
        {
            this._WebView.remove_GotFocus(token);
        }

        void IWebView2WebView4.add_LostFocus(IWebView2FocusChangedEventHandler eventHandler, out EventRegistrationToken token)
        {
            this._WebView.add_LostFocus(eventHandler, out token);
        }

        void IWebView2WebView4.remove_LostFocus(EventRegistrationToken token)
        {
            this._WebView.remove_LostFocus(token);
        }

        void IWebView2WebView4.add_WebResourceRequested_deprecated(ref string urlFilter, ref WEBVIEW2_WEB_RESOURCE_CONTEXT resourceContextFilter, ulong filterLength, IWebView2WebResourceRequestedEventHandler eventHandler, out EventRegistrationToken token)
        {
            this._WebView.add_WebResourceRequested_deprecated(ref urlFilter, resourceContextFilter, filterLength,
                eventHandler, out token);
        }

        void IWebView2WebView4.remove_WebResourceRequested(EventRegistrationToken token)
        {
            this._WebView.remove_WebResourceRequested(token);
        }

        void IWebView2WebView4.add_ScriptDialogOpening(IWebView2ScriptDialogOpeningEventHandler eventHandler, out EventRegistrationToken token)
        {
            this._WebView.add_ScriptDialogOpening(eventHandler, out token);
        }

        void IWebView2WebView4.remove_ScriptDialogOpening(EventRegistrationToken token)
        {
            this._WebView.remove_ScriptDialogOpening(token);
        }

        void IWebView2WebView4.add_ZoomFactorChanged(IWebView2ZoomFactorChangedEventHandler eventHandler, out EventRegistrationToken token)
        {
            this._WebView.add_ZoomFactorChanged(eventHandler, out token);
        }

        void IWebView2WebView4.remove_ZoomFactorChanged(EventRegistrationToken token)
        {
            this._WebView.remove_ZoomFactorChanged(token);
        }

        void IWebView2WebView4.add_PermissionRequested(IWebView2PermissionRequestedEventHandler eventHandler, out EventRegistrationToken token)
        {
            this._WebView.add_PermissionRequested(eventHandler, out token);
        }

        void IWebView2WebView4.remove_PermissionRequested(EventRegistrationToken token)
        {
           this._WebView.remove_PermissionRequested(token);
        }

        void IWebView2WebView4.add_ProcessFailed(IWebView2ProcessFailedEventHandler eventHandler, out EventRegistrationToken token)
        {
            this._WebView.add_ProcessFailed(eventHandler, out token);
        }

        void IWebView2WebView4.remove_ProcessFailed(EventRegistrationToken token)
        {
            this._WebView.remove_ProcessFailed(token);
        }

        void IWebView2WebView4.AddScriptToExecuteOnDocumentCreated(string javaScript, IWebView2AddScriptToExecuteOnDocumentCreatedCompletedHandler handler)
        {
            this._WebView.AddScriptToExecuteOnDocumentCreated(javaScript, handler);
        }

        void IWebView2WebView4.RemoveScriptToExecuteOnDocumentCreated(string id)
        {
            this._WebView.RemoveScriptToExecuteOnDocumentCreated(id);
        }

        void IWebView2WebView4.ExecuteScript(string javaScript, IWebView2ExecuteScriptCompletedHandler handler)
        {
            this._WebView.ExecuteScript(javaScript, handler);
        }

        void IWebView2WebView4.CapturePreview(WEBVIEW2_CAPTURE_PREVIEW_IMAGE_FORMAT imageFormat, IStream imageStream, IWebView2CapturePreviewCompletedHandler handler)
        {
            this._WebView.CapturePreview(imageFormat, imageStream, handler);
        }

        void IWebView2WebView4.Reload()
        {
            this._WebView.Reload();
        }

        tagRECT IWebView2WebView4.Bounds { get =>this._WebView.Bounds; set => this._WebView.Bounds = value; }
        double IWebView2WebView4.ZoomFactor { get => this._WebView.ZoomFactor; set => this._WebView.ZoomFactor = value; }
        int IWebView2WebView4.IsVisible { get => this._WebView.IsVisible; set => this._WebView.IsVisible = value; }

        void IWebView2WebView4.PostWebMessageAsJson(string webMessageAsJson)
        {
            this._WebView.PostWebMessageAsJson(webMessageAsJson);
        }

        void IWebView2WebView4.PostWebMessageAsString(string webMessageAsString)
        {
            this._WebView.PostWebMessageAsString(webMessageAsString);
        }

        void IWebView2WebView4.add_WebMessageReceived(IWebView2WebMessageReceivedEventHandler handler, out EventRegistrationToken token)
        {
            this._WebView.add_WebMessageReceived(handler, out token);
        }

        void IWebView2WebView4.remove_WebMessageReceived(EventRegistrationToken token)
        {
            this._WebView.remove_WebMessageReceived(token);
        }

        void IWebView2WebView4.Close()
        {
            this._WebView.Close();
        }

        void IWebView2WebView4.CallDevToolsProtocolMethod(string methodName, string parametersAsJson, IWebView2CallDevToolsProtocolMethodCompletedHandler handler)
        {
            this._WebView.CallDevToolsProtocolMethod(methodName, parametersAsJson, handler);
        }

        void IWebView2WebView4.add_DevToolsProtocolEventReceived(string eventName, IWebView2DevToolsProtocolEventReceivedEventHandler handler, out EventRegistrationToken token)
        {
            this._WebView.add_DevToolsProtocolEventReceived(eventName, handler, out token);
        }

        void IWebView2WebView4.remove_DevToolsProtocolEventReceived(string eventName, EventRegistrationToken token)
        {
            this._WebView.remove_DevToolsProtocolEventReceived(eventName, token);
        }

        uint IWebView2WebView4.BrowserProcessId => this._WebView.BrowserProcessId;

        int IWebView2WebView4.CanGoBack => this._WebView.CanGoBack;

        int IWebView2WebView4.CanGoForward => this._WebView.CanGoForward;

        void IWebView2WebView4.GoBack()
        {
            this._WebView.GoBack();
        }

        void IWebView2WebView4.GoForward()
        {
            this._WebView.GoForward();
        }

        void IWebView2WebView4.Stop()
        {
            this._WebView.Stop();
        }

        void IWebView2WebView4.add_NewWindowRequested(IWebView2NewWindowRequestedEventHandler eventHandler, out EventRegistrationToken token)
        {
            this._WebView.add_NewWindowRequested(eventHandler, out token);
        }

        void IWebView2WebView4.remove_NewWindowRequested(EventRegistrationToken token)
        {
            this._WebView.remove_NewWindowRequested(token);
        }

        void IWebView2WebView4.add_DocumentTitleChanged(IWebView2DocumentTitleChangedEventHandler eventHandler, out EventRegistrationToken token)
        {
            this._WebView.add_DocumentTitleChanged(eventHandler, out token);
        }

        void IWebView2WebView4.remove_DocumentTitleChanged(EventRegistrationToken token)
        {
            this._WebView.remove_DocumentTitleChanged(token);
        }

        void IWebView2WebView4.DocumentTitle(out string title)
        {
            this._WebView.DocumentTitle(out title);
        }

        void IWebView2WebView4.AddRemoteObject(string name, ref object @object)
        {
            this._WebView.AddRemoteObject(name, ref @object);
        }

        void IWebView2WebView4.RemoveRemoteObject(string name)
        {
            this._WebView.RemoveRemoteObject(name);
        }

        void IWebView2WebView4.OpenDevToolsWindow()
        {
            this._WebView.OpenDevToolsWindow();
        }

        void IWebView2WebView4.add_AcceleratorKeyPressed(IWebView2AcceleratorKeyPressedEventHandler eventHandler, out EventRegistrationToken token)
        {
            this._WebView.add_AcceleratorKeyPressed(eventHandler, out token);
        }

        void IWebView2WebView4.remove_AcceleratorKeyPressed(EventRegistrationToken token)
        {
            this._WebView.remove_AcceleratorKeyPressed(token);
        }

        IWebView2Settings IWebView2WebView3.Settings => this._WebView.Settings;

        string IWebView2WebView3.Source => this._WebView.Source;

        void IWebView2WebView3.Navigate(string uri)
        {
            this._WebView.Navigate(uri);
        }

        void IWebView2WebView3.MoveFocus(WEBVIEW2_MOVE_FOCUS_REASON reason)
        {
            this._WebView.MoveFocus(reason);
        }

        void IWebView2WebView3.NavigateToString(string htmlContent)
        {
            this._WebView.NavigateToString(htmlContent);
        }

        void IWebView2WebView3.add_NavigationStarting(IWebView2NavigationStartingEventHandler eventHandler, out EventRegistrationToken token)
        {
            this._WebView.add_NavigationStarting(eventHandler, out token);
        }

        void IWebView2WebView3.remove_NavigationStarting(EventRegistrationToken token)
        {
            this._WebView.remove_NavigationStarting(token);
        }

        void IWebView2WebView3.add_DocumentStateChanged(IWebView2DocumentStateChangedEventHandler eventHandler, out EventRegistrationToken token)
        {
            this._WebView.add_DocumentStateChanged(eventHandler, out token);
        }

        void IWebView2WebView3.remove_DocumentStateChanged(EventRegistrationToken token)
        {
            this._WebView.remove_DocumentStateChanged(token);
        }

        void IWebView2WebView3.add_NavigationCompleted(IWebView2NavigationCompletedEventHandler eventHandler, out EventRegistrationToken token)
        {
            this._WebView.add_NavigationCompleted(eventHandler, out token);
        }

        void IWebView2WebView3.remove_NavigationCompleted(EventRegistrationToken token)
        {
            this._WebView.remove_NavigationCompleted(token);
        }

        void IWebView2WebView3.add_FrameNavigationStarting(IWebView2NavigationStartingEventHandler eventHandler, out EventRegistrationToken token)
        {
            this._WebView.add_FrameNavigationStarting(eventHandler, out token);
        }

        void IWebView2WebView3.remove_FrameNavigationStarting(EventRegistrationToken token)
        {
            this._WebView.remove_FrameNavigationStarting(token);
        }

        void IWebView2WebView3.add_MoveFocusRequested(IWebView2MoveFocusRequestedEventHandler eventHandler, out EventRegistrationToken token)
        {
            this._WebView.add_MoveFocusRequested(eventHandler, out token);
        }

        void IWebView2WebView3.remove_MoveFocusRequested(EventRegistrationToken token)
        {
            this._WebView.remove_MoveFocusRequested(token);
        }

        void IWebView2WebView3.add_GotFocus(IWebView2FocusChangedEventHandler eventHandler, out EventRegistrationToken token)
        {
            this._WebView.add_GotFocus(eventHandler, out token);
        }

        void IWebView2WebView3.remove_GotFocus(EventRegistrationToken token)
        {
            this._WebView.remove_GotFocus(token);
        }

        void IWebView2WebView3.add_LostFocus(IWebView2FocusChangedEventHandler eventHandler, out EventRegistrationToken token)
        {
            this._WebView.add_LostFocus(eventHandler, out token);
        }

        void IWebView2WebView3.remove_LostFocus(EventRegistrationToken token)
        {
            this._WebView.remove_LostFocus(token);
        }

        void IWebView2WebView3.add_WebResourceRequested_deprecated(ref string urlFilter, ref WEBVIEW2_WEB_RESOURCE_CONTEXT resourceContextFilter, ulong filterLength, IWebView2WebResourceRequestedEventHandler eventHandler, out EventRegistrationToken token)
        {
            this._WebView.add_WebResourceRequested_deprecated(ref urlFilter, ref resourceContextFilter, filterLength,
                eventHandler, out token);
        }

        void IWebView2WebView3.remove_WebResourceRequested(EventRegistrationToken token)
        {
            this._WebView.remove_WebResourceRequested(token);
        }

        void IWebView2WebView3.add_ScriptDialogOpening(IWebView2ScriptDialogOpeningEventHandler eventHandler, out EventRegistrationToken token)
        {
            this._WebView.add_ScriptDialogOpening(eventHandler, out token);
        }

        void IWebView2WebView3.remove_ScriptDialogOpening(EventRegistrationToken token)
        {
            this._WebView.remove_ScriptDialogOpening(token);
        }

        void IWebView2WebView3.add_ZoomFactorChanged(IWebView2ZoomFactorChangedEventHandler eventHandler, out EventRegistrationToken token)
        {
            this._WebView.add_ZoomFactorChanged(eventHandler, out token);
        }

        void IWebView2WebView3.remove_ZoomFactorChanged(EventRegistrationToken token)
        {
            this._WebView.remove_ZoomFactorChanged(token);
        }

        void IWebView2WebView3.add_PermissionRequested(IWebView2PermissionRequestedEventHandler eventHandler, out EventRegistrationToken token)
        {
            this._WebView.add_PermissionRequested(eventHandler, out token);
        }

        void IWebView2WebView3.remove_PermissionRequested(EventRegistrationToken token)
        {
            this._WebView.remove_PermissionRequested(token);
        }

        void IWebView2WebView3.add_ProcessFailed(IWebView2ProcessFailedEventHandler eventHandler, out EventRegistrationToken token)
        {
            this._WebView.add_ProcessFailed(eventHandler, out token);
        }

        void IWebView2WebView3.remove_ProcessFailed(EventRegistrationToken token)
        {
            this._WebView.remove_ProcessFailed(token);
        }

        void IWebView2WebView3.AddScriptToExecuteOnDocumentCreated(string javaScript, IWebView2AddScriptToExecuteOnDocumentCreatedCompletedHandler handler)
        {
            this._WebView.AddScriptToExecuteOnDocumentCreated(javaScript, handler);
        }

        void IWebView2WebView3.RemoveScriptToExecuteOnDocumentCreated(string id)
        {
            this._WebView.RemoveScriptToExecuteOnDocumentCreated(id);
        }

        void IWebView2WebView3.ExecuteScript(string javaScript, IWebView2ExecuteScriptCompletedHandler handler)
        {
            this._WebView.ExecuteScript(javaScript, handler);
        }

        void IWebView2WebView3.CapturePreview(WEBVIEW2_CAPTURE_PREVIEW_IMAGE_FORMAT imageFormat, IStream imageStream, IWebView2CapturePreviewCompletedHandler handler)
        {
            this._WebView.CapturePreview(imageFormat, imageStream, handler);
        }

        void IWebView2WebView3.Reload()
        {
            this._WebView.Reload();
        }

        tagRECT IWebView2WebView3.Bounds { get => this._WebView.Bounds; set => this._WebView.Bounds = value; }
        double IWebView2WebView3.ZoomFactor { get => this._WebView.ZoomFactor; set => throw new NotImplementedException(); }
        int IWebView2WebView3.IsVisible { get => this._WebView.IsVisible; set => this._WebView.IsVisible=value; }

        void IWebView2WebView3.PostWebMessageAsJson(string webMessageAsJson)
        {
            this._WebView.PostWebMessageAsJson(webMessageAsJson);
        }

        void IWebView2WebView3.PostWebMessageAsString(string webMessageAsString)
        {
            this._WebView.PostWebMessageAsString(webMessageAsString);
        }

        void IWebView2WebView3.add_WebMessageReceived(IWebView2WebMessageReceivedEventHandler handler, out EventRegistrationToken token)
        {
            this._WebView.add_WebMessageReceived(handler, out token);
        }

        void IWebView2WebView3.remove_WebMessageReceived(EventRegistrationToken token)
        {
            this._WebView.remove_WebMessageReceived(token);
        }

        void IWebView2WebView3.Close()
        {
            this._WebView.Close();
        }

        void IWebView2WebView3.CallDevToolsProtocolMethod(string methodName, string parametersAsJson, IWebView2CallDevToolsProtocolMethodCompletedHandler handler)
        {
            this._WebView.CallDevToolsProtocolMethod(methodName, parametersAsJson, handler);
        }

        void IWebView2WebView3.add_DevToolsProtocolEventReceived(string eventName, IWebView2DevToolsProtocolEventReceivedEventHandler handler, out EventRegistrationToken token)
        {
            this._WebView.add_DevToolsProtocolEventReceived(eventName, handler, out token);
        }

        void IWebView2WebView3.remove_DevToolsProtocolEventReceived(string eventName, EventRegistrationToken token)
        {
            this._WebView.remove_DevToolsProtocolEventReceived(eventName, token);
        }

        uint IWebView2WebView3.BrowserProcessId => this._WebView.BrowserProcessId;

        int IWebView2WebView3.CanGoBack => this._WebView.CanGoBack;

        int IWebView2WebView3.CanGoForward => this._WebView.CanGoForward;

        void IWebView2WebView3.GoBack()
        {
            this._WebView.GoBack();
        }

        void IWebView2WebView3.GoForward()
        {
            this._WebView.GoForward();
        }

        void IWebView2WebView3.Stop()
        {
            this._WebView.Stop();
        }

        void IWebView2WebView3.add_NewWindowRequested(IWebView2NewWindowRequestedEventHandler eventHandler, out EventRegistrationToken token)
        {
            this._WebView.add_NewWindowRequested(eventHandler, out token);
        }

        void IWebView2WebView3.remove_NewWindowRequested(EventRegistrationToken token)
        {
            this._WebView.remove_NewWindowRequested(token);
        }

        void IWebView2WebView3.add_DocumentTitleChanged(IWebView2DocumentTitleChangedEventHandler eventHandler, out EventRegistrationToken token)
        {
            this._WebView.add_DocumentTitleChanged(eventHandler, out token);
        }

        void IWebView2WebView3.remove_DocumentTitleChanged(EventRegistrationToken token)
        {
           this._WebView.remove_DocumentTitleChanged(token);
        }

        void IWebView2WebView3.DocumentTitle(out string title)
        {
            this._WebView.DocumentTitle(out title);
        }

        IWebView2Settings IWebView2WebView.Settings => this._WebView.Settings;

        string IWebView2WebView.Source => throw new NotImplementedException();

        void IWebView2WebView.Navigate(string uri)
        {
            this._WebView.Navigate(uri);
        }

        void IWebView2WebView.MoveFocus(WEBVIEW2_MOVE_FOCUS_REASON reason)
        {
            this._WebView.MoveFocus(reason);
        }

        void IWebView2WebView.NavigateToString(string htmlContent)
        {
            this._WebView.NavigateToString(htmlContent);
        }

        void IWebView2WebView.add_NavigationStarting(IWebView2NavigationStartingEventHandler eventHandler, out EventRegistrationToken token)
        {
            this._WebView.add_NavigationStarting(eventHandler, out token);
        }

        void IWebView2WebView.remove_NavigationStarting(EventRegistrationToken token)
        {
            this._WebView.remove_NavigationStarting(token);
        }

        void IWebView2WebView.add_DocumentStateChanged(IWebView2DocumentStateChangedEventHandler eventHandler, out EventRegistrationToken token)
        {
            this._WebView.add_DocumentStateChanged(eventHandler, out token);
        }

        void IWebView2WebView.remove_DocumentStateChanged(EventRegistrationToken token)
        {
            this._WebView.remove_DocumentStateChanged(token);
        }

        void IWebView2WebView.add_NavigationCompleted(IWebView2NavigationCompletedEventHandler eventHandler, out EventRegistrationToken token)
        {
            this._WebView.add_NavigationCompleted(eventHandler, out token);
        }

        void IWebView2WebView.remove_NavigationCompleted(EventRegistrationToken token)
        {
            this._WebView.remove_NavigationCompleted(token);
        }

        void IWebView2WebView.add_FrameNavigationStarting(IWebView2NavigationStartingEventHandler eventHandler, out EventRegistrationToken token)
        {
            this._WebView.add_FrameNavigationStarting(eventHandler, out token);
        }

        void IWebView2WebView.remove_FrameNavigationStarting(EventRegistrationToken token)
        {
            this._WebView.remove_FrameNavigationStarting(token);
        }

        void IWebView2WebView.add_MoveFocusRequested(IWebView2MoveFocusRequestedEventHandler eventHandler, out EventRegistrationToken token)
        {
            this._WebView.add_MoveFocusRequested(eventHandler, out token);
        }

        void IWebView2WebView.remove_MoveFocusRequested(EventRegistrationToken token)
        {
            this._WebView.remove_MoveFocusRequested(token);
        }

        void IWebView2WebView.add_GotFocus(IWebView2FocusChangedEventHandler eventHandler, out EventRegistrationToken token)
        {
            this._WebView.add_GotFocus(eventHandler, out token);
        }

        void IWebView2WebView.remove_GotFocus(EventRegistrationToken token)
        {
            this._WebView.remove_GotFocus(token);
        }

        void IWebView2WebView.add_LostFocus(IWebView2FocusChangedEventHandler eventHandler, out EventRegistrationToken token)
        {
           this._WebView.add_LostFocus(eventHandler, out token);
        }

        void IWebView2WebView.remove_LostFocus(EventRegistrationToken token)
        {
            this._WebView.remove_LostFocus(token);
        }

        void IWebView2WebView.add_WebResourceRequested_deprecated(ref string urlFilter, ref WEBVIEW2_WEB_RESOURCE_CONTEXT resourceContextFilter, ulong filterLength, IWebView2WebResourceRequestedEventHandler eventHandler, out EventRegistrationToken token)
        {
            this._WebView.add_WebResourceRequested_deprecated(ref urlFilter, ref resourceContextFilter, filterLength,
                eventHandler, out token);
        }

        void IWebView2WebView.remove_WebResourceRequested(EventRegistrationToken token)
        {
            this._WebView.remove_WebResourceRequested(token);
        }

        void IWebView2WebView.add_ScriptDialogOpening(IWebView2ScriptDialogOpeningEventHandler eventHandler, out EventRegistrationToken token)
        {
            this._WebView.add_ScriptDialogOpening(eventHandler, out token);
        }

        void IWebView2WebView.remove_ScriptDialogOpening(EventRegistrationToken token)
        {
            this._WebView.remove_ScriptDialogOpening(token);
        }

        void IWebView2WebView.add_ZoomFactorChanged(IWebView2ZoomFactorChangedEventHandler eventHandler, out EventRegistrationToken token)
        {
            this._WebView.add_ZoomFactorChanged(eventHandler, out token);
        }

        void IWebView2WebView.remove_ZoomFactorChanged(EventRegistrationToken token)
        {
            this._WebView.remove_ZoomFactorChanged(token);
        }

        void IWebView2WebView.add_PermissionRequested(IWebView2PermissionRequestedEventHandler eventHandler, out EventRegistrationToken token)
        {
            this._WebView.add_PermissionRequested(eventHandler, out token);
        }

        void IWebView2WebView.remove_PermissionRequested(EventRegistrationToken token)
        {
           this._WebView.remove_PermissionRequested(token);
        }

        void IWebView2WebView.add_ProcessFailed(IWebView2ProcessFailedEventHandler eventHandler, out EventRegistrationToken token)
        {
            this._WebView.add_ProcessFailed(eventHandler, out token);
        }

        void IWebView2WebView.remove_ProcessFailed(EventRegistrationToken token)
        {
            this._WebView.remove_ProcessFailed(token);
        }

        void IWebView2WebView.AddScriptToExecuteOnDocumentCreated(string javaScript, IWebView2AddScriptToExecuteOnDocumentCreatedCompletedHandler handler)
        {
            this._WebView.AddScriptToExecuteOnDocumentCreated(javaScript, handler);
        }

        void IWebView2WebView.RemoveScriptToExecuteOnDocumentCreated(string id)
        {
            this._WebView.RemoveScriptToExecuteOnDocumentCreated(id);
        }

        void IWebView2WebView.ExecuteScript(string javaScript, IWebView2ExecuteScriptCompletedHandler handler)
        {
            this._WebView.ExecuteScript(javaScript, handler);
        }

        void IWebView2WebView.CapturePreview(WEBVIEW2_CAPTURE_PREVIEW_IMAGE_FORMAT imageFormat, IStream imageStream, IWebView2CapturePreviewCompletedHandler handler)
        {
            this._WebView.CapturePreview(imageFormat, imageStream, handler);
        }

        void IWebView2WebView.Reload()
        {
            this._WebView.Reload();
        }

        tagRECT IWebView2WebView.Bounds { get => this._WebView.Bounds; set => this._WebView.Bounds = value; }

        public tagRECT Bounds
        {
            get => ((IWebView2WebView) this).Bounds;
            set => ((IWebView2WebView) this).Bounds = value;
        }

        double IWebView2WebView.ZoomFactor { get => this._WebView.ZoomFactor; set => this._WebView.ZoomFactor = value; }
        int IWebView2WebView.IsVisible { get => this._WebView.IsVisible; set => this._WebView.IsVisible = value; }

        void IWebView2WebView.PostWebMessageAsJson(string webMessageAsJson)
        {
            this._WebView.PostWebMessageAsJson(webMessageAsJson);
        }

        void IWebView2WebView.PostWebMessageAsString(string webMessageAsString)
        {
            this._WebView.PostWebMessageAsString(webMessageAsString);
        }

        void IWebView2WebView.add_WebMessageReceived(IWebView2WebMessageReceivedEventHandler handler, out EventRegistrationToken token)
        {
            this._WebView.add_WebMessageReceived(handler, out token);
        }

        void IWebView2WebView.remove_WebMessageReceived(EventRegistrationToken token)
        {
            this._WebView.remove_WebMessageReceived(token);
        }

        void IWebView2WebView.Close()
        {
            this._WebView.Close();
        }

        void IWebView2WebView.CallDevToolsProtocolMethod(string methodName, string parametersAsJson, IWebView2CallDevToolsProtocolMethodCompletedHandler handler)
        {
            this._WebView.CallDevToolsProtocolMethod(methodName, parametersAsJson, handler);
        }

        void IWebView2WebView.add_DevToolsProtocolEventReceived(string eventName, IWebView2DevToolsProtocolEventReceivedEventHandler handler, out EventRegistrationToken token)
        {
            this._WebView.add_DevToolsProtocolEventReceived(eventName, handler, out token);
        }

        void IWebView2WebView.remove_DevToolsProtocolEventReceived(string eventName, EventRegistrationToken token)
        {
            this._WebView.remove_DevToolsProtocolEventReceived(eventName, token);
        }

        uint IWebView2WebView.BrowserProcessId => this._WebView.BrowserProcessId;

        int IWebView2WebView.CanGoBack => this._WebView.CanGoBack;

        int IWebView2WebView.CanGoForward => this._WebView.CanGoForward;

        public string DocumentTitle
        {
            get
            {
                this._WebView.DocumentTitle(out var title);
                return title;

            }
        }

        void IWebView2WebView.GoBack()
        {
            this._WebView.GoBack();
        }

        void IWebView2WebView.GoForward()
        {
            this._WebView.GoForward();
        }
    }
}