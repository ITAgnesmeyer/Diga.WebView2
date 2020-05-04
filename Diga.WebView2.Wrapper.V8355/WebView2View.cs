using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.EventArguments;
using Diga.WebView2.Wrapper.Handler;
using Diga.WebView2.Wrapper.Types;
using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Threading.Tasks;
using Diga.WebView2.Wrapper.Delegates;

namespace Diga.WebView2.Wrapper
{
    public partial class WebView2View : IWebView2WebView5, IDisposable
    {
        private IWebView2WebView5 _WebView;
        public event EventHandler<NavigationStartingEventArgs> NavigationStarting;
        public event EventHandler<ContentLoadingEventArgs> ContentLoading;
        public event EventHandler<ExecuteScriptCompletedEventArgs> ExecuteScriptCompleted;
        public event EventHandler<SourceChangedEventArgs> SourceChanged;
        public event EventHandler<WebView2EventArgs> HistoryChanged;
        public event EventHandler<NavigationCompletedEventArgs> NavigationCompleted;
        public event EventHandler<AcceleratorKeyPressedEventArgs> AcceleratorKeyPressed;
        public event EventHandler<WebView2EventArgs> ContainsFullScreenElementChanged;
        public event EventHandler<DocumentStateChangedEventArgs> DocumentStateChanged;
        public event EventHandler<WebView2EventArgs> DocumentTitleChanged;
        public event EventHandler<NavigationStartingEventArgs> FrameNavigationStarting;
        public event EventHandler<WebView2EventArgs> GotFocus;
        public event EventHandler<WebView2EventArgs> LostFocus;
        public event EventHandler<MoveFocusRequestedEventArgs> MoveFocusRequested;
        public event EventHandler<NewWindowRequestedEventArgs> NewWindowRequested;
        public event EventHandler<PermissionRequestedEventArgs> PermissionRequested;
        public event EventHandler<ProcessFailedEventArgs> ProcessFailed;
        public event EventHandler<ScriptDialogOpeningEventArgs> ScriptDialogOpening;
        public event EventHandler<WebMessageReceivedEventArgs> WebMessageReceived;
        public event EventHandler<WebResourceRequestedEventArgs> WebResourceRequested;
        public event EventHandler<WebView2EventArgs> ZoomFactorChanged;
        public event EventHandler<AddScriptToExecuteOnDocumentCreatedCompletedEventArgs> ScriptToExecuteOnDocumentCreatedCompleted;
        public WebView2View(IWebView2WebView5 webView)
        {
            this._WebView = webView;
            RegisterEvents();
        }

       

        private IWebView2WebView5 ToInterface()
        {
            return this;
        }

        private void RegisterEvents()
        {
            IWebView2WebView5 v5 = this.ToInterface();

            AcceleratorKeyPressedEventHandler acceleratorKeyPressedEventHandler =
                new AcceleratorKeyPressedEventHandler();
            acceleratorKeyPressedEventHandler.AcceleratorKeyPressed += OnAcceleratorKeyPressedIntern;
            v5.add_AcceleratorKeyPressed(acceleratorKeyPressedEventHandler, out this._AcceleratorKeyPressedToken);
            
            ContainsFullScreenElementChangedEventHandler containsFullScreenElementChangedHandler =
                new ContainsFullScreenElementChangedEventHandler();
            containsFullScreenElementChangedHandler.ContainsFullScreenElementChanged +=
                OnContainsFullScreenElementChangedIntern;
            v5.add_ContainsFullScreenElementChanged(containsFullScreenElementChangedHandler,
                out this._ContainsFullScreenElementChangedHandlerToken);
            
            DocumentStateChangedEventHandler documentStateChangedHandler = new DocumentStateChangedEventHandler();
            documentStateChangedHandler.DocumentStateChanged += OnDocumentStateChangedIntern;
            v5.add_DocumentStateChanged(documentStateChangedHandler, out this._DocumentStateChangedHandlerToken);
            
            DocumentTitleChangedHanlder documentTitleChangedHandler = new DocumentTitleChangedHanlder();
            documentTitleChangedHandler.DocumentTitleChanged += OnDocumentTitleChangedIntern;
            v5.add_DocumentTitleChanged(documentTitleChangedHandler, out this._DocumentTitleChangedToken);
            
            NavigationStartingEventHandler frameNavigationStarting = new NavigationStartingEventHandler();
            frameNavigationStarting.NavigationStarting += OnFrameNavigationStartingIntern;
            v5.add_FrameNavigationStarting(frameNavigationStarting, out this._FrameNavigationStartingToken);
            
            FocusChangedEventHandler gotFocusHandler = new FocusChangedEventHandler();
            gotFocusHandler.FocusChanged += OnGotFocusIntern;
            v5.add_GotFocus(gotFocusHandler, out this._GotFocusToken);
            
            FocusChangedEventHandler lostFocusHandler = new FocusChangedEventHandler();
            lostFocusHandler.FocusChanged += OnLostFocusIntern;
            v5.add_LostFocus(lostFocusHandler, out this._LostFocusToken);
            
            MoveFocusRequestedEventHandler moveFocusRequestedHandler = new MoveFocusRequestedEventHandler();
            moveFocusRequestedHandler.MoveFocusRequested += OnMoveFocusRequestedIntern;
            v5.add_MoveFocusRequested(moveFocusRequestedHandler, out this._MoveFocusRequestedToken);
            
            NavigationStartingEventHandler navigationStartingHandler = new NavigationStartingEventHandler();
            navigationStartingHandler.NavigationStarting += OnNavigationStartingIntern;
            v5.add_NavigationStarting(navigationStartingHandler, out this._NavigationStartingToken);
            
            NavigationCompletedEventHandler navigationCompletedHandler = new NavigationCompletedEventHandler();
            navigationCompletedHandler.NavigaionCompleted += OnNavigationCompletedIntern;
            v5.add_NavigationCompleted(navigationCompletedHandler, out this._NavigationCompletedToken);
            
            NewWindowRequestedEventHandler newWindowRequested = new NewWindowRequestedEventHandler();
            newWindowRequested.NewWindowRequested += OnNewWindowRequestedIntern;
            v5.add_NewWindowRequested(newWindowRequested, out this._NewWindowRequestedToken);
            
            PermissionRequestedEventHandler permissionRequestedHandler = new PermissionRequestedEventHandler();
            permissionRequestedHandler.PermissionRequested += OnPermissionRequestedIntern;
            v5.add_PermissionRequested(permissionRequestedHandler, out this._PermissionRequestedHandler);
            
            ProcessFailedEventHandler processFailedHandler = new ProcessFailedEventHandler();
            processFailedHandler.ProcessFailed += OnProcessFailedIntern;
            v5.add_ProcessFailed(processFailedHandler, out this._ProcessFailedToken);
            
            ScriptDialogOpeningEventHandler scriptDialogOpeningHandler = new ScriptDialogOpeningEventHandler();
            scriptDialogOpeningHandler.ScriptDialogOpening += OnScriptDialogOpeningIntern;
            v5.add_ScriptDialogOpening(scriptDialogOpeningHandler, out this._ScriptDialogOpeningToken);
            
            WebMessageReceivedEventHandler webMessageReceivedHandler = new WebMessageReceivedEventHandler();
            webMessageReceivedHandler.WebMessageReceived += OnWebMessageReceivedIntern;
            v5.add_WebMessageReceived(webMessageReceivedHandler, out this._WebMessageReceivedToken);
            
            WebResourceRequestedEventHandler webResourceRequestedHandler = new WebResourceRequestedEventHandler();
            webResourceRequestedHandler.WebResourceRequested += OnWebResourceRequestedIntern;
            v5.add_WebResourceRequested(webResourceRequestedHandler, out this._WebResourceRequestedToken);
            
            ZoomFactorChangedEventHandler zoomFactorEventHandler = new ZoomFactorChangedEventHandler();
            zoomFactorEventHandler.ZoomFactorChanged += OnZoomFactorChangedInternal;
            v5.add_ZoomFactorChanged(zoomFactorEventHandler, out this._ZoomFactorToken);
        }

        private void OnZoomFactorChangedInternal(object sender, WebView2EventArgs e)
        {
            OnZoomFactorChanged(e);
        }

        private void OnWebResourceRequestedIntern(object sender, WebResourceRequestedEventArgs e)
        {
            OnWebResourceRequested(e);
        }

        private void OnWebMessageReceivedIntern(object sender, WebMessageReceivedEventArgs e)
        {
            OnWebMessageReceived(e);
        }

        private void OnScriptDialogOpeningIntern(object sender, ScriptDialogOpeningEventArgs e)
        {
            OnScriptDialogOpening(e);
        }

        private void OnProcessFailedIntern(object sender, ProcessFailedEventArgs e)
        {
            OnProcessFailed(e);
        }

        private void OnPermissionRequestedIntern(object sender, PermissionRequestedEventArgs e)
        {
            OnPermissionRequested(e);
        }

        private void OnNewWindowRequestedIntern(object sender, NewWindowRequestedEventArgs e)
        {
            OnNewWindowRequested(e);
        }

        private void OnMoveFocusRequestedIntern(object sender, MoveFocusRequestedEventArgs e)
        {
            OnMoveFocusRequested(e);
        }

        private void OnLostFocusIntern(object sender, WebView2EventArgs e)
        {
            OnLostFocus(e);
        }

        private void OnGotFocusIntern(object sender, WebView2EventArgs e)
        {
            OnGotFocus(e);
        }

        private void OnFrameNavigationStartingIntern(object sender, NavigationStartingEventArgs e)
        {
            OnFrameNavigationStarting(e);
        }

        private void OnDocumentTitleChangedIntern(object sender, WebView2EventArgs e)
        {
            OnDocumentTitleChanged(e);
        }

        private void OnDocumentStateChangedIntern(object sender, DocumentStateChangedEventArgs e)
        {
            OnDocumentStateChanged(e);
        }

        private void OnContainsFullScreenElementChangedIntern(object sender, WebView2EventArgs e)
        {
            OnContainsFullScreenElementChanged(e);
        }

        private void OnAcceleratorKeyPressedIntern(object sender, AcceleratorKeyPressedEventArgs e)
        {
            OnAcceleratorKeyPressed(e);
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

        private void UnregisterEvents()
        {
            this.ToInterface().remove_NavigationStarting(this._NavigationStartingToken);
            //this.ToV5().remove_ContentLoading(this._ContentLoadingToken);
            //this.ToV5().remove_SourceChanged(this._SourceChangedToken);
            //((IWebView2WebView5) this).remove_HistoryChanged(this._HistoryChangeToken);
            this.ToInterface().remove_NavigationCompleted(this._NavigationCompletedToken);
            this.ToInterface().remove_AcceleratorKeyPressed(this._AcceleratorKeyPressedToken);
            this.ToInterface().remove_ContainsFullScreenElementChanged(this._ContainsFullScreenElementChangedHandlerToken);
            this.ToInterface().remove_DocumentStateChanged(this._DocumentStateChangedHandlerToken);
            this.ToInterface().remove_DocumentTitleChanged(this._DocumentTitleChangedToken);
            this.ToInterface().remove_FrameNavigationStarting(this._FrameNavigationStartingToken);
            this.ToInterface().remove_GotFocus(this._GotFocusToken);
            this.ToInterface().remove_LostFocus(this._LostFocusToken);
            this.ToInterface().remove_MoveFocusRequested(this._MoveFocusRequestedToken);
            this.ToInterface().remove_NewWindowRequested(this._NewWindowRequestedToken);
            this.ToInterface().remove_PermissionRequested(this._PermissionRequestedHandler);
            this.ToInterface().remove_ProcessFailed(this._ProcessFailedToken);
            this.ToInterface().remove_ScriptDialogOpening(this._ScriptDialogOpeningToken);
            this.ToInterface().remove_WebMessageReceived(this._WebMessageReceivedToken);
            this.ToInterface().remove_WebResourceRequested(this._WebResourceRequestedToken);
            this.ToInterface().remove_ZoomFactorChanged(this._ZoomFactorToken);
        }

        private EventRegistrationToken _NavigationStartingToken;

        //private EventRegistrationToken _ContentLoadingToken;
        //private EventRegistrationToken _SourceChangedToken;
        //private EventRegistrationToken _HistoryChangeToken;
        private EventRegistrationToken _NavigationCompletedToken;
        private EventRegistrationToken _AcceleratorKeyPressedToken;
        private EventRegistrationToken _ContainsFullScreenElementChangedHandlerToken;
        private EventRegistrationToken _DocumentStateChangedHandlerToken;
        private EventRegistrationToken _DocumentTitleChangedToken;
        private EventRegistrationToken _FrameNavigationStartingToken;
        private EventRegistrationToken _GotFocusToken;
        private EventRegistrationToken _LostFocusToken;
        private EventRegistrationToken _MoveFocusRequestedToken;
        private EventRegistrationToken _NewWindowRequestedToken;
        private EventRegistrationToken _PermissionRequestedHandler;
        private EventRegistrationToken _ProcessFailedToken;
        private EventRegistrationToken _ScriptDialogOpeningToken;
        private EventRegistrationToken _WebMessageReceivedToken;
        private EventRegistrationToken _WebResourceRequestedToken;
        private EventRegistrationToken _ZoomFactorToken;

        private void OnNavigationStartingIntern(object sender, NavigationStartingEventArgs e)
        {
            OnNavigationStarting(e);
        }

        public string Source => this.ToInterface().Source;

        public void Navigate(string uri)
        {
            this._WebView.Navigate(uri);
        }

        public void NavigateToString(string htmlContent)
        {
            this.ToInterface().NavigateToString(htmlContent);
        }

        internal void Close()
        {
            this._WebView.Close();
        }

        public void AddScriptToExecuteOnDocumentCreated(string javaScript)
        {
            AddScriptToExecuteOnDocumentCreatedCompletedHandler handler =
                new AddScriptToExecuteOnDocumentCreatedCompletedHandler();
            handler.ScriptExecuted += OnScriptToExecuteOnDocumentCreatedIntern;
            this.ToInterface().AddScriptToExecuteOnDocumentCreated(javaScript, handler);
        }

        private void OnScriptToExecuteOnDocumentCreatedIntern(object sender,
            AddScriptToExecuteOnDocumentCreatedCompletedEventArgs e)
        {
            OnScriptToExecuteOnDocumentCreatedCompleted(e);
        }

        public void RemoveScriptToExecuteOnDocumentCreated(string id)
        {
            this.ToInterface().RemoveScriptToExecuteOnDocumentCreated(id);
        }

        public void ExecuteScript(string javaScript)
        {
            ExecuteScriptCompletedHandler handler = new ExecuteScriptCompletedHandler();
            handler.ScriptCompleted += OnExecuteScriptCompletedIntern;
            this.ToInterface().ExecuteScript(javaScript, handler);
        }


        public string InvokeScript(string javaScript, Action<string,int, string> actionToInvoke)
        {
            ExecuteScriptCompletedHandler handler = new ExecuteScriptCompletedHandler();
            handler.ActionToInvoke = actionToInvoke;
            this.ToInterface().ExecuteScript(javaScript, handler);
            return handler.Id;
        }

        public void Reload()
        {
            this.ToInterface().Reload();
        }

        public void PostWebMessageAsJson(string webMessageAsJson)
        {
            this.ToInterface().PostWebMessageAsJson(webMessageAsJson);
        }

        public void PostWebMessageAsString(string webMessageAsString)
        {
            this.ToInterface().PostWebMessageAsString(webMessageAsString);
        }

        public uint BrowserProcessId => this.ToInterface().BrowserProcessId;
        public bool CanGoBack => new CBOOL(this.ToInterface().CanGoBack);
        public bool CanGoForward => new CBOOL(this.ToInterface().CanGoForward);

        public void GoBack()
        {
            this.ToInterface().GoBack();
        }

        public void GoForward()
        {
            this.ToInterface().GoForward();
        }

        public void Stop()
        {
            this.ToInterface().Stop();
        }

        public void AddRemoteObject(string name, object @object)
        {
            this.ToInterface().AddRemoteObject(name, @object);
        }

        public void RemoveRemoteObject(string name)
        {
            this.ToInterface().RemoveRemoteObject(name);
        }


       

        public void OpenDevToolsWindow()
        {
            this.ToInterface().OpenDevToolsWindow();
        }

        public bool ContainsFullScreenElement => new CBOOL(this.ToInterface().ContainsFullScreenElement);

       

        public void Dispose()
        {
            UnregisterEvents();
        }

        protected virtual void OnNavigationStarting(NavigationStartingEventArgs e)
        {
            NavigationStarting?.Invoke(this, e);
        }
        private void OnExecuteScriptCompletedIntern(object sender, ExecuteScriptCompletedEventArgs e)
        {
            OnExecuteScriptCompleted(e);
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

        public void AddWebResourceRequestedFilter(string uri, WebResourceContext resourceContext)
        {
            this.ToInterface().AddWebResourceRequestedFilter(uri, (WEBVIEW2_WEB_RESOURCE_CONTEXT) resourceContext);
        }

        public void RemoveWebResourceRequestedFilter(string uri, WebResourceContext resourceContext)
        {
            this.ToInterface().RemoveWebResourceRequestedFilter(uri, (WEBVIEW2_WEB_RESOURCE_CONTEXT) resourceContext);
        }

        public tagRECT Bounds
        {
            get => ((IWebView2WebView) this).Bounds;
            set => ((IWebView2WebView) this).Bounds = value;
        }

        public async Task CapturePreviewAsync(Stream stream, ImageFormat imageFormat)
        {
            ManagedIStream ms = new ManagedIStream(stream);
            StreamWrapper sw = new StreamWrapper(ms);
            var source = new TaskCompletionSource<int>();
            CapturePreviewCompletedDelegate handler = new CapturePreviewCompletedDelegate(source);
            this.ToInterface().CapturePreview((WEBVIEW2_CAPTURE_PREVIEW_IMAGE_FORMAT) imageFormat, sw, handler);
            int hr = await source.Task;
            if (hr != HRESULT.S_OK)
            {
                throw Marshal.GetExceptionForHR(hr);
            }
            

        }

        public string DocumentTitle
        {
            get
            {
                this._WebView.DocumentTitle(out var title);
                return title;
            }
        }

        protected virtual void OnAcceleratorKeyPressed(AcceleratorKeyPressedEventArgs e)
        {
            AcceleratorKeyPressed?.Invoke(this, e);
        }

        protected virtual void OnContainsFullScreenElementChanged(WebView2EventArgs e)
        {
            ContainsFullScreenElementChanged?.Invoke(this, e);
        }

        protected virtual void OnDocumentStateChanged(DocumentStateChangedEventArgs e)
        {
            DocumentStateChanged?.Invoke(this, e);
        }

        protected virtual void OnDocumentTitleChanged(WebView2EventArgs e)
        {
            DocumentTitleChanged?.Invoke(this, e);
        }

        protected virtual void OnFrameNavigationStarting(NavigationStartingEventArgs e)
        {
            FrameNavigationStarting?.Invoke(this, e);
        }

        protected virtual void OnGotFocus(WebView2EventArgs e)
        {
            GotFocus?.Invoke(this, e);
        }

        protected virtual void OnLostFocus(WebView2EventArgs e)
        {
            LostFocus?.Invoke(this, e);
        }

        protected virtual void OnMoveFocusRequested(MoveFocusRequestedEventArgs e)
        {
            MoveFocusRequested?.Invoke(this, e);
        }

        protected virtual void OnNewWindowRequested(NewWindowRequestedEventArgs e)
        {
            NewWindowRequested?.Invoke(this, e);
        }

        protected virtual void OnPermissionRequested(PermissionRequestedEventArgs e)
        {
            PermissionRequested?.Invoke(this, e);
        }

        protected virtual void OnProcessFailed(ProcessFailedEventArgs e)
        {
            ProcessFailed?.Invoke(this, e);
        }

        protected virtual void OnScriptDialogOpening(ScriptDialogOpeningEventArgs e)
        {
            ScriptDialogOpening?.Invoke(this, e);
        }

        protected virtual void OnWebMessageReceived(WebMessageReceivedEventArgs e)
        {
            WebMessageReceived?.Invoke(this, e);
        }

        protected virtual void OnWebResourceRequested(WebResourceRequestedEventArgs e)
        {
            WebResourceRequested?.Invoke(this, e);
        }

        protected virtual void OnZoomFactorChanged(WebView2EventArgs e)
        {
            ZoomFactorChanged?.Invoke(this, e);
        }

        protected virtual void OnScriptToExecuteOnDocumentCreatedCompleted(AddScriptToExecuteOnDocumentCreatedCompletedEventArgs e)
        {
            ScriptToExecuteOnDocumentCreatedCompleted?.Invoke(this, e);
        }
    }

    public partial class WebView2View
    {
        IWebView2Settings IWebView2WebView5.Settings => this._WebView.Settings;
        public WebView2Settings Settings => new WebView2Settings((IWebView2Settings2) this.ToInterface().Settings);
        string IWebView2WebView5.Source => this._WebView.Source;

        void IWebView2WebView5.Navigate(string uri)
        {
            this._WebView.Navigate(uri);
        }

        void IWebView2WebView5.NavigateToString(string htmlContent)
        {
            this._WebView.NavigateToString(htmlContent);
        }

        void IWebView2WebView5.add_NavigationStarting(IWebView2NavigationStartingEventHandler eventHandler,
            out EventRegistrationToken token)
        {
            this._WebView.add_NavigationStarting(eventHandler, out token);
        }

        void IWebView2WebView5.remove_NavigationStarting(EventRegistrationToken token)
        {
            this._WebView.remove_NavigationStarting(token);
        }

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

        void IWebView2WebView5.add_ProcessFailed(IWebView2ProcessFailedEventHandler eventHandler,
            out EventRegistrationToken token)
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

        void IWebView2WebView5.RemoveScriptToExecuteOnDocumentCreated(string id)
        {
            this._WebView.RemoveScriptToExecuteOnDocumentCreated(id);
        }

        void IWebView2WebView5.ExecuteScript(string javaScript, IWebView2ExecuteScriptCompletedHandler handler)
        {
            this._WebView.ExecuteScript(javaScript, handler);
        }

        void IWebView2WebView5.Reload()
        {
            this._WebView.Reload();
        }

        void IWebView2WebView5.PostWebMessageAsJson(string webMessageAsJson)
        {
            this._WebView.PostWebMessageAsJson(webMessageAsJson);
        }

        void IWebView2WebView5.PostWebMessageAsString(string webMessageAsString)
        {
            this._WebView.PostWebMessageAsString(webMessageAsString);
        }

        void IWebView2WebView5.add_WebMessageReceived(IWebView2WebMessageReceivedEventHandler handler,
            out EventRegistrationToken token)
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
        int IWebView2WebView5.CanGoBack => this._WebView.CanGoBack;
        int IWebView2WebView5.CanGoForward => this._WebView.CanGoForward;

        void IWebView2WebView5.GoBack()
        {
            this._WebView.GoBack();
        }

        void IWebView2WebView5.GoForward()
        {
            this._WebView.GoForward();
        }

        void IWebView2WebView5.Stop()
        {
            this._WebView.Stop();
        }

        void IWebView2WebView5.add_NewWindowRequested(IWebView2NewWindowRequestedEventHandler eventHandler,
            out EventRegistrationToken token)
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

        void IWebView2WebView5.AddRemoteObject(string name, object @object)
        {
            this._WebView.AddRemoteObject(name, @object);
        }

        void IWebView2WebView5.RemoveRemoteObject(string name)
        {
            this._WebView.RemoveRemoteObject(name);
        }

        void IWebView2WebView5.OpenDevToolsWindow()
        {
            this._WebView.OpenDevToolsWindow();
        }

        void IWebView2WebView5.add_ContainsFullScreenElementChanged(
            IWebView2ContainsFullScreenElementChangedEventHandler eventHandler, out EventRegistrationToken token)
        {
            this._WebView.add_ContainsFullScreenElementChanged(eventHandler, out token);
        }

        void IWebView2WebView5.remove_ContainsFullScreenElementChanged(EventRegistrationToken token)
        {
            this._WebView.remove_ContainsFullScreenElementChanged(token);
        }

        int IWebView2WebView5.ContainsFullScreenElement => this._WebView.ContainsFullScreenElement;

        void IWebView2WebView5.add_WebResourceRequested(IWebView2WebResourceRequestedEventHandler eventHandler,
            out EventRegistrationToken token)
        {
            this._WebView.add_WebResourceRequested(eventHandler, out token);
        }

        void IWebView2WebView5.remove_WebResourceRequested(EventRegistrationToken token)
        {
            this._WebView.remove_WebResourceRequested(token);
        }

        void IWebView2WebView5.MoveFocus(WEBVIEW2_MOVE_FOCUS_REASON reason)
        {
            this._WebView.MoveFocus(reason);
        }

        void IWebView2WebView5.add_DocumentStateChanged(IWebView2DocumentStateChangedEventHandler eventHandler,
            out EventRegistrationToken token)
        {
            this._WebView.add_DocumentStateChanged(eventHandler, out token);
        }

        void IWebView2WebView5.remove_DocumentStateChanged(EventRegistrationToken token)
        {
            this._WebView.remove_DocumentStateChanged(token);
        }

        void IWebView2WebView5.add_MoveFocusRequested(IWebView2MoveFocusRequestedEventHandler eventHandler,
            out EventRegistrationToken token)
        {
            this._WebView.add_MoveFocusRequested(eventHandler, out token);
        }

        void IWebView2WebView5.remove_MoveFocusRequested(EventRegistrationToken token)
        {
            this._WebView.remove_MoveFocusRequested(token);
        }

        void IWebView2WebView5.add_GotFocus(IWebView2FocusChangedEventHandler eventHandler,
            out EventRegistrationToken token)
        {
            this._WebView.add_GotFocus(eventHandler, out token);
        }

        void IWebView2WebView5.remove_GotFocus(EventRegistrationToken token)
        {
            this._WebView.remove_GotFocus(token);
        }

        void IWebView2WebView5.add_LostFocus(IWebView2FocusChangedEventHandler eventHandler,
            out EventRegistrationToken token)
        {
            this._WebView.add_LostFocus(eventHandler, out token);
        }

        void IWebView2WebView5.remove_LostFocus(EventRegistrationToken token)
        {
            this._WebView.remove_LostFocus(token);
        }

        void IWebView2WebView5.add_WebResourceRequested_deprecated(ref string urlFilter,
            ref WEBVIEW2_WEB_RESOURCE_CONTEXT resourceContextFilter, ulong filterLength,
            IWebView2WebResourceRequestedEventHandler eventHandler, out EventRegistrationToken token)
        {
            this._WebView.add_WebResourceRequested_deprecated(urlFilter, ref resourceContextFilter, filterLength,
                eventHandler, out token);
        }

        void IWebView2WebView5.add_ZoomFactorChanged(IWebView2ZoomFactorChangedEventHandler eventHandler,
            out EventRegistrationToken token)
        {
            this._WebView.add_ZoomFactorChanged(eventHandler, out token);
        }

        void IWebView2WebView5.remove_ZoomFactorChanged(EventRegistrationToken token)
        {
            this._WebView.remove_ZoomFactorChanged(token);
        }

        void IWebView2WebView5.CapturePreview(WEBVIEW2_CAPTURE_PREVIEW_IMAGE_FORMAT imageFormat, IStream imageStream,
            IWebView2CapturePreviewCompletedHandler handler)
        {
            this._WebView.CapturePreview(imageFormat, imageStream, handler);
        }

        tagRECT IWebView2WebView5.Bounds
        {
            get => this._WebView.Bounds;
            set => this._WebView.Bounds = value;
        }

        double IWebView2WebView5.ZoomFactor
        {
            get => this._WebView.ZoomFactor;
            set => this._WebView.ZoomFactor = value;
        }

        int IWebView2WebView5.IsVisible
        {
            get => this._WebView.IsVisible;
            set => this._WebView.IsVisible = value;
        }

        void IWebView2WebView5.Close()
        {
            this._WebView.Close();
        }

        void IWebView2WebView5.add_DevToolsProtocolEventReceived(string eventName,
            IWebView2DevToolsProtocolEventReceivedEventHandler handler, out EventRegistrationToken token)
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

        void IWebView2WebView5.add_AcceleratorKeyPressed(IWebView2AcceleratorKeyPressedEventHandler eventHandler,
            out EventRegistrationToken token)
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

        void IWebView2WebView5.RemoveWebResourceRequestedFilter(string uri,
            WEBVIEW2_WEB_RESOURCE_CONTEXT resourceContext)
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

        void IWebView2WebView4.add_NavigationStarting(IWebView2NavigationStartingEventHandler eventHandler,
            out EventRegistrationToken token)
        {
            this._WebView.add_NavigationStarting(eventHandler, out token);
        }

        void IWebView2WebView4.remove_NavigationStarting(EventRegistrationToken token)
        {
            this._WebView.remove_NavigationStarting(token);
        }

        void IWebView2WebView4.add_DocumentStateChanged(IWebView2DocumentStateChangedEventHandler eventHandler,
            out EventRegistrationToken token)
        {
            this._WebView.add_DocumentStateChanged(eventHandler, out token);
        }

        void IWebView2WebView4.remove_DocumentStateChanged(EventRegistrationToken token)
        {
            this._WebView.remove_DocumentStateChanged(token);
        }

        void IWebView2WebView4.add_NavigationCompleted(IWebView2NavigationCompletedEventHandler eventHandler,
            out EventRegistrationToken token)
        {
            this._WebView.add_NavigationCompleted(eventHandler, out token);
        }

        void IWebView2WebView4.remove_NavigationCompleted(EventRegistrationToken token)
        {
            this._WebView.remove_NavigationCompleted(token);
        }

        void IWebView2WebView4.add_FrameNavigationStarting(IWebView2NavigationStartingEventHandler eventHandler,
            out EventRegistrationToken token)
        {
            this._WebView.add_FrameNavigationStarting(eventHandler, out token);
        }

        void IWebView2WebView4.remove_FrameNavigationStarting(EventRegistrationToken token)
        {
            this._WebView.remove_FrameNavigationStarting(token);
        }

        void IWebView2WebView4.add_MoveFocusRequested(IWebView2MoveFocusRequestedEventHandler eventHandler,
            out EventRegistrationToken token)
        {
            this._WebView.add_MoveFocusRequested(eventHandler, out token);
        }

        void IWebView2WebView4.remove_MoveFocusRequested(EventRegistrationToken token)
        {
            this._WebView.remove_MoveFocusRequested(token);
        }

        void IWebView2WebView4.add_GotFocus(IWebView2FocusChangedEventHandler eventHandler,
            out EventRegistrationToken token)
        {
            this._WebView.add_GotFocus(eventHandler, out token);
        }

        void IWebView2WebView4.remove_GotFocus(EventRegistrationToken token)
        {
            this._WebView.remove_GotFocus(token);
        }

        void IWebView2WebView4.add_LostFocus(IWebView2FocusChangedEventHandler eventHandler,
            out EventRegistrationToken token)
        {
            this._WebView.add_LostFocus(eventHandler, out token);
        }

        void IWebView2WebView4.remove_LostFocus(EventRegistrationToken token)
        {
            this._WebView.remove_LostFocus(token);
        }

        void IWebView2WebView4.add_WebResourceRequested_deprecated(ref string urlFilter,
            ref WEBVIEW2_WEB_RESOURCE_CONTEXT resourceContextFilter, ulong filterLength,
            IWebView2WebResourceRequestedEventHandler eventHandler, out EventRegistrationToken token)
        {
            this._WebView.add_WebResourceRequested_deprecated(ref urlFilter, resourceContextFilter, filterLength,
                eventHandler, out token);
        }

        void IWebView2WebView4.remove_WebResourceRequested(EventRegistrationToken token)
        {
            this._WebView.remove_WebResourceRequested(token);
        }

        void IWebView2WebView4.add_ScriptDialogOpening(IWebView2ScriptDialogOpeningEventHandler eventHandler,
            out EventRegistrationToken token)
        {
            this._WebView.add_ScriptDialogOpening(eventHandler, out token);
        }

        void IWebView2WebView4.remove_ScriptDialogOpening(EventRegistrationToken token)
        {
            this._WebView.remove_ScriptDialogOpening(token);
        }

        void IWebView2WebView4.add_ZoomFactorChanged(IWebView2ZoomFactorChangedEventHandler eventHandler,
            out EventRegistrationToken token)
        {
            this._WebView.add_ZoomFactorChanged(eventHandler, out token);
        }

        void IWebView2WebView4.remove_ZoomFactorChanged(EventRegistrationToken token)
        {
            this._WebView.remove_ZoomFactorChanged(token);
        }

        void IWebView2WebView4.add_PermissionRequested(IWebView2PermissionRequestedEventHandler eventHandler,
            out EventRegistrationToken token)
        {
            this._WebView.add_PermissionRequested(eventHandler, out token);
        }

        void IWebView2WebView4.remove_PermissionRequested(EventRegistrationToken token)
        {
            this._WebView.remove_PermissionRequested(token);
        }

        void IWebView2WebView4.add_ProcessFailed(IWebView2ProcessFailedEventHandler eventHandler,
            out EventRegistrationToken token)
        {
            this._WebView.add_ProcessFailed(eventHandler, out token);
        }

        void IWebView2WebView4.remove_ProcessFailed(EventRegistrationToken token)
        {
            this._WebView.remove_ProcessFailed(token);
        }

        void IWebView2WebView4.AddScriptToExecuteOnDocumentCreated(string javaScript,
            IWebView2AddScriptToExecuteOnDocumentCreatedCompletedHandler handler)
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

        void IWebView2WebView4.CapturePreview(WEBVIEW2_CAPTURE_PREVIEW_IMAGE_FORMAT imageFormat, IStream imageStream,
            IWebView2CapturePreviewCompletedHandler handler)
        {
            this._WebView.CapturePreview(imageFormat, imageStream, handler);
        }

        void IWebView2WebView4.Reload()
        {
            this._WebView.Reload();
        }

        tagRECT IWebView2WebView4.Bounds
        {
            get => this._WebView.Bounds;
            set => this._WebView.Bounds = value;
        }

        double IWebView2WebView4.ZoomFactor
        {
            get => this._WebView.ZoomFactor;
            set => this._WebView.ZoomFactor = value;
        }

        int IWebView2WebView4.IsVisible
        {
            get => this._WebView.IsVisible;
            set => this._WebView.IsVisible = value;
        }

        void IWebView2WebView4.PostWebMessageAsJson(string webMessageAsJson)
        {
            this._WebView.PostWebMessageAsJson(webMessageAsJson);
        }

        void IWebView2WebView4.PostWebMessageAsString(string webMessageAsString)
        {
            this._WebView.PostWebMessageAsString(webMessageAsString);
        }

        void IWebView2WebView4.add_WebMessageReceived(IWebView2WebMessageReceivedEventHandler handler,
            out EventRegistrationToken token)
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

        void IWebView2WebView4.CallDevToolsProtocolMethod(string methodName, string parametersAsJson,
            IWebView2CallDevToolsProtocolMethodCompletedHandler handler)
        {
            this._WebView.CallDevToolsProtocolMethod(methodName, parametersAsJson, handler);
        }

        void IWebView2WebView4.add_DevToolsProtocolEventReceived(string eventName,
            IWebView2DevToolsProtocolEventReceivedEventHandler handler, out EventRegistrationToken token)
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

        void IWebView2WebView4.add_NewWindowRequested(IWebView2NewWindowRequestedEventHandler eventHandler,
            out EventRegistrationToken token)
        {
            this._WebView.add_NewWindowRequested(eventHandler, out token);
        }

        void IWebView2WebView4.remove_NewWindowRequested(EventRegistrationToken token)
        {
            this._WebView.remove_NewWindowRequested(token);
        }

        void IWebView2WebView4.add_DocumentTitleChanged(IWebView2DocumentTitleChangedEventHandler eventHandler,
            out EventRegistrationToken token)
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

        void IWebView2WebView4.AddRemoteObject(string name,  object @object)
        {
            this._WebView.AddRemoteObject(name, @object);
        }

        void IWebView2WebView4.RemoveRemoteObject(string name)
        {
            this._WebView.RemoveRemoteObject(name);
        }

        void IWebView2WebView4.OpenDevToolsWindow()
        {
            this._WebView.OpenDevToolsWindow();
        }

        void IWebView2WebView4.add_AcceleratorKeyPressed(IWebView2AcceleratorKeyPressedEventHandler eventHandler,
            out EventRegistrationToken token)
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

        void IWebView2WebView3.add_NavigationStarting(IWebView2NavigationStartingEventHandler eventHandler,
            out EventRegistrationToken token)
        {
            this._WebView.add_NavigationStarting(eventHandler, out token);
        }

        void IWebView2WebView3.remove_NavigationStarting(EventRegistrationToken token)
        {
            this._WebView.remove_NavigationStarting(token);
        }

        void IWebView2WebView3.add_DocumentStateChanged(IWebView2DocumentStateChangedEventHandler eventHandler,
            out EventRegistrationToken token)
        {
            this._WebView.add_DocumentStateChanged(eventHandler, out token);
        }

        void IWebView2WebView3.remove_DocumentStateChanged(EventRegistrationToken token)
        {
            this._WebView.remove_DocumentStateChanged(token);
        }

        void IWebView2WebView3.add_NavigationCompleted(IWebView2NavigationCompletedEventHandler eventHandler,
            out EventRegistrationToken token)
        {
            this._WebView.add_NavigationCompleted(eventHandler, out token);
        }

        void IWebView2WebView3.remove_NavigationCompleted(EventRegistrationToken token)
        {
            this._WebView.remove_NavigationCompleted(token);
        }

        void IWebView2WebView3.add_FrameNavigationStarting(IWebView2NavigationStartingEventHandler eventHandler,
            out EventRegistrationToken token)
        {
            this._WebView.add_FrameNavigationStarting(eventHandler, out token);
        }

        void IWebView2WebView3.remove_FrameNavigationStarting(EventRegistrationToken token)
        {
            this._WebView.remove_FrameNavigationStarting(token);
        }

        void IWebView2WebView3.add_MoveFocusRequested(IWebView2MoveFocusRequestedEventHandler eventHandler,
            out EventRegistrationToken token)
        {
            this._WebView.add_MoveFocusRequested(eventHandler, out token);
        }

        void IWebView2WebView3.remove_MoveFocusRequested(EventRegistrationToken token)
        {
            this._WebView.remove_MoveFocusRequested(token);
        }

        void IWebView2WebView3.add_GotFocus(IWebView2FocusChangedEventHandler eventHandler,
            out EventRegistrationToken token)
        {
            this._WebView.add_GotFocus(eventHandler, out token);
        }

        void IWebView2WebView3.remove_GotFocus(EventRegistrationToken token)
        {
            this._WebView.remove_GotFocus(token);
        }

        void IWebView2WebView3.add_LostFocus(IWebView2FocusChangedEventHandler eventHandler,
            out EventRegistrationToken token)
        {
            this._WebView.add_LostFocus(eventHandler, out token);
        }

        void IWebView2WebView3.remove_LostFocus(EventRegistrationToken token)
        {
            this._WebView.remove_LostFocus(token);
        }

        void IWebView2WebView3.add_WebResourceRequested_deprecated(ref string urlFilter,
            ref WEBVIEW2_WEB_RESOURCE_CONTEXT resourceContextFilter, ulong filterLength,
            IWebView2WebResourceRequestedEventHandler eventHandler, out EventRegistrationToken token)
        {
            this._WebView.add_WebResourceRequested_deprecated(ref urlFilter, ref resourceContextFilter, filterLength,
                eventHandler, out token);
        }

        void IWebView2WebView3.remove_WebResourceRequested(EventRegistrationToken token)
        {
            this._WebView.remove_WebResourceRequested(token);
        }

        void IWebView2WebView3.add_ScriptDialogOpening(IWebView2ScriptDialogOpeningEventHandler eventHandler,
            out EventRegistrationToken token)
        {
            this._WebView.add_ScriptDialogOpening(eventHandler, out token);
        }

        void IWebView2WebView3.remove_ScriptDialogOpening(EventRegistrationToken token)
        {
            this._WebView.remove_ScriptDialogOpening(token);
        }

        void IWebView2WebView3.add_ZoomFactorChanged(IWebView2ZoomFactorChangedEventHandler eventHandler,
            out EventRegistrationToken token)
        {
            this._WebView.add_ZoomFactorChanged(eventHandler, out token);
        }

        void IWebView2WebView3.remove_ZoomFactorChanged(EventRegistrationToken token)
        {
            this._WebView.remove_ZoomFactorChanged(token);
        }

        void IWebView2WebView3.add_PermissionRequested(IWebView2PermissionRequestedEventHandler eventHandler,
            out EventRegistrationToken token)
        {
            this._WebView.add_PermissionRequested(eventHandler, out token);
        }

        void IWebView2WebView3.remove_PermissionRequested(EventRegistrationToken token)
        {
            this._WebView.remove_PermissionRequested(token);
        }

        void IWebView2WebView3.add_ProcessFailed(IWebView2ProcessFailedEventHandler eventHandler,
            out EventRegistrationToken token)
        {
            this._WebView.add_ProcessFailed(eventHandler, out token);
        }

        void IWebView2WebView3.remove_ProcessFailed(EventRegistrationToken token)
        {
            this._WebView.remove_ProcessFailed(token);
        }

        void IWebView2WebView3.AddScriptToExecuteOnDocumentCreated(string javaScript,
            IWebView2AddScriptToExecuteOnDocumentCreatedCompletedHandler handler)
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

        void IWebView2WebView3.CapturePreview(WEBVIEW2_CAPTURE_PREVIEW_IMAGE_FORMAT imageFormat, IStream imageStream,
            IWebView2CapturePreviewCompletedHandler handler)
        {
            this._WebView.CapturePreview(imageFormat, imageStream, handler);
        }

        void IWebView2WebView3.Reload()
        {
            this._WebView.Reload();
        }

        tagRECT IWebView2WebView3.Bounds
        {
            get => this._WebView.Bounds;
            set => this._WebView.Bounds = value;
        }

        double IWebView2WebView3.ZoomFactor
        {
            get => this._WebView.ZoomFactor;
            set => this._WebView.ZoomFactor = value;
        }

        int IWebView2WebView3.IsVisible
        {
            get => this._WebView.IsVisible;
            set => this._WebView.IsVisible = value;
        }

        void IWebView2WebView3.PostWebMessageAsJson(string webMessageAsJson)
        {
            this._WebView.PostWebMessageAsJson(webMessageAsJson);
        }

        void IWebView2WebView3.PostWebMessageAsString(string webMessageAsString)
        {
            this._WebView.PostWebMessageAsString(webMessageAsString);
        }

        void IWebView2WebView3.add_WebMessageReceived(IWebView2WebMessageReceivedEventHandler handler,
            out EventRegistrationToken token)
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

        void IWebView2WebView3.CallDevToolsProtocolMethod(string methodName, string parametersAsJson,
            IWebView2CallDevToolsProtocolMethodCompletedHandler handler)
        {
            this._WebView.CallDevToolsProtocolMethod(methodName, parametersAsJson, handler);
        }

        void IWebView2WebView3.add_DevToolsProtocolEventReceived(string eventName,
            IWebView2DevToolsProtocolEventReceivedEventHandler handler, out EventRegistrationToken token)
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

        void IWebView2WebView3.add_NewWindowRequested(IWebView2NewWindowRequestedEventHandler eventHandler,
            out EventRegistrationToken token)
        {
            this._WebView.add_NewWindowRequested(eventHandler, out token);
        }

        void IWebView2WebView3.remove_NewWindowRequested(EventRegistrationToken token)
        {
            this._WebView.remove_NewWindowRequested(token);
        }

        void IWebView2WebView3.add_DocumentTitleChanged(IWebView2DocumentTitleChangedEventHandler eventHandler,
            out EventRegistrationToken token)
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
        string IWebView2WebView.Source => this._WebView.Source;

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

        void IWebView2WebView.add_NavigationStarting(IWebView2NavigationStartingEventHandler eventHandler,
            out EventRegistrationToken token)
        {
            this._WebView.add_NavigationStarting(eventHandler, out token);
        }

        void IWebView2WebView.remove_NavigationStarting(EventRegistrationToken token)
        {
            this._WebView.remove_NavigationStarting(token);
        }

        void IWebView2WebView.add_DocumentStateChanged(IWebView2DocumentStateChangedEventHandler eventHandler,
            out EventRegistrationToken token)
        {
            this._WebView.add_DocumentStateChanged(eventHandler, out token);
        }

        void IWebView2WebView.remove_DocumentStateChanged(EventRegistrationToken token)
        {
            this._WebView.remove_DocumentStateChanged(token);
        }

        void IWebView2WebView.add_NavigationCompleted(IWebView2NavigationCompletedEventHandler eventHandler,
            out EventRegistrationToken token)
        {
            this._WebView.add_NavigationCompleted(eventHandler, out token);
        }

        void IWebView2WebView.remove_NavigationCompleted(EventRegistrationToken token)
        {
            this._WebView.remove_NavigationCompleted(token);
        }

        void IWebView2WebView.add_FrameNavigationStarting(IWebView2NavigationStartingEventHandler eventHandler,
            out EventRegistrationToken token)
        {
            this._WebView.add_FrameNavigationStarting(eventHandler, out token);
        }

        void IWebView2WebView.remove_FrameNavigationStarting(EventRegistrationToken token)
        {
            this._WebView.remove_FrameNavigationStarting(token);
        }

        void IWebView2WebView.add_MoveFocusRequested(IWebView2MoveFocusRequestedEventHandler eventHandler,
            out EventRegistrationToken token)
        {
            this._WebView.add_MoveFocusRequested(eventHandler, out token);
        }

        void IWebView2WebView.remove_MoveFocusRequested(EventRegistrationToken token)
        {
            this._WebView.remove_MoveFocusRequested(token);
        }

        void IWebView2WebView.add_GotFocus(IWebView2FocusChangedEventHandler eventHandler,
            out EventRegistrationToken token)
        {
            this._WebView.add_GotFocus(eventHandler, out token);
        }

        void IWebView2WebView.remove_GotFocus(EventRegistrationToken token)
        {
            this._WebView.remove_GotFocus(token);
        }

        void IWebView2WebView.add_LostFocus(IWebView2FocusChangedEventHandler eventHandler,
            out EventRegistrationToken token)
        {
            this._WebView.add_LostFocus(eventHandler, out token);
        }

        void IWebView2WebView.remove_LostFocus(EventRegistrationToken token)
        {
            this._WebView.remove_LostFocus(token);
        }

        void IWebView2WebView.add_WebResourceRequested_deprecated(ref string urlFilter,
            ref WEBVIEW2_WEB_RESOURCE_CONTEXT resourceContextFilter, ulong filterLength,
            IWebView2WebResourceRequestedEventHandler eventHandler, out EventRegistrationToken token)
        {
            this._WebView.add_WebResourceRequested_deprecated(ref urlFilter, ref resourceContextFilter, filterLength,
                eventHandler, out token);
        }

        void IWebView2WebView.remove_WebResourceRequested(EventRegistrationToken token)
        {
            this._WebView.remove_WebResourceRequested(token);
        }

        void IWebView2WebView.add_ScriptDialogOpening(IWebView2ScriptDialogOpeningEventHandler eventHandler,
            out EventRegistrationToken token)
        {
            this._WebView.add_ScriptDialogOpening(eventHandler, out token);
        }

        void IWebView2WebView.remove_ScriptDialogOpening(EventRegistrationToken token)
        {
            this._WebView.remove_ScriptDialogOpening(token);
        }

        void IWebView2WebView.add_ZoomFactorChanged(IWebView2ZoomFactorChangedEventHandler eventHandler,
            out EventRegistrationToken token)
        {
            this._WebView.add_ZoomFactorChanged(eventHandler, out token);
        }

        void IWebView2WebView.remove_ZoomFactorChanged(EventRegistrationToken token)
        {
            this._WebView.remove_ZoomFactorChanged(token);
        }

        void IWebView2WebView.add_PermissionRequested(IWebView2PermissionRequestedEventHandler eventHandler,
            out EventRegistrationToken token)
        {
            this._WebView.add_PermissionRequested(eventHandler, out token);
        }

        void IWebView2WebView.remove_PermissionRequested(EventRegistrationToken token)
        {
            this._WebView.remove_PermissionRequested(token);
        }

        void IWebView2WebView.add_ProcessFailed(IWebView2ProcessFailedEventHandler eventHandler,
            out EventRegistrationToken token)
        {
            this._WebView.add_ProcessFailed(eventHandler, out token);
        }

        void IWebView2WebView.remove_ProcessFailed(EventRegistrationToken token)
        {
            this._WebView.remove_ProcessFailed(token);
        }

        void IWebView2WebView.AddScriptToExecuteOnDocumentCreated(string javaScript,
            IWebView2AddScriptToExecuteOnDocumentCreatedCompletedHandler handler)
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

        void IWebView2WebView.CapturePreview(WEBVIEW2_CAPTURE_PREVIEW_IMAGE_FORMAT imageFormat, IStream imageStream,
            IWebView2CapturePreviewCompletedHandler handler)
        {
            this._WebView.CapturePreview(imageFormat, imageStream, handler);
        }

        void IWebView2WebView.Reload()
        {
            this._WebView.Reload();
        }

        tagRECT IWebView2WebView.Bounds
        {
            get => this._WebView.Bounds;
            set => this._WebView.Bounds = value;
        }

        double IWebView2WebView.ZoomFactor
        {
            get => this._WebView.ZoomFactor;
            set => this._WebView.ZoomFactor = value;
        }

        int IWebView2WebView.IsVisible
        {
            get => this._WebView.IsVisible;
            set => this._WebView.IsVisible = value;
        }

        void IWebView2WebView.PostWebMessageAsJson(string webMessageAsJson)
        {
            this._WebView.PostWebMessageAsJson(webMessageAsJson);
        }

        void IWebView2WebView.PostWebMessageAsString(string webMessageAsString)
        {
            this._WebView.PostWebMessageAsString(webMessageAsString);
        }

        void IWebView2WebView.add_WebMessageReceived(IWebView2WebMessageReceivedEventHandler handler,
            out EventRegistrationToken token)
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

        void IWebView2WebView.CallDevToolsProtocolMethod(string methodName, string parametersAsJson,
            IWebView2CallDevToolsProtocolMethodCompletedHandler handler)
        {
            this._WebView.CallDevToolsProtocolMethod(methodName, parametersAsJson, handler);
        }

        void IWebView2WebView.add_DevToolsProtocolEventReceived(string eventName,
            IWebView2DevToolsProtocolEventReceivedEventHandler handler, out EventRegistrationToken token)
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

        void IWebView2WebView.GoBack()
        {
            this._WebView.GoBack();
        }

        void IWebView2WebView.GoForward()
        {
            this._WebView.GoForward();
        }

        public async Task<string> ExecuteScriptAsync(string javaScript)
        {
            if (this._WebView == null)
                throw new InvalidOperationException("Script control not Created!");
            var source = new TaskCompletionSource<(int,string)>();
            var executeScriptDelegate = new ExecuteScriptCompletedDelegate(source);
            this._WebView.ExecuteScript(javaScript, executeScriptDelegate);
            
            (int errorCode, string resultObjectAsJson) result = await source.Task;
            HRESULT resultCode =result.errorCode;
            if (resultCode != HRESULT.S_OK)
                throw Marshal.GetExceptionForHR(resultCode);
            return result.resultObjectAsJson;
        }
    }
}