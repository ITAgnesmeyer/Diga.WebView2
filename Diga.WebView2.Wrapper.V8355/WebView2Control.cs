using System;
using System.IO;
using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.EventArguments;
using Diga.WebView2.Wrapper.Handler;


namespace Diga.WebView2.Wrapper
{
    public class WebView2Control : IDisposable
    {
        public event EventHandler Created;
        public event EventHandler<BeforeCreateEventArgs> BeforeCreate;
        public event EventHandler<NavigationStartingEventArgs> NavigateStart;
        public event EventHandler<ContentLoadingEventArgs> ContentLoading;
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
        public event EventHandler<ExecuteScriptCompletedEventArgs> ExecuteScriptCompleted;

        public event EventHandler<AddScriptToExecuteOnDocumentCreatedCompletedEventArgs>
            ScriptToExecuteOnDocumentCreatedCompleted;

        private WebView2Settings _Settings;
        private string _BrowserInfo;

        public WebView2Control(IntPtr parentHandle) : this(parentHandle, string.Empty, string.Empty, string.Empty)
        {
        }

        public WebView2Control(IntPtr parentHandle, string browserExecutableFolder, string userDataFolder,
            string additionalBrowserArguments)
        {
            this.ParentHandle = parentHandle;
            this.BrowserExecutableFolder = browserExecutableFolder;
            this.UserDataFolder = userDataFolder;
            this.AdditionalBrowserArguments = additionalBrowserArguments;
            CreateWebView();
        }

        private IntPtr ParentHandle { get; set; }
        public string BrowserExecutableFolder { get; }
        public string UserDataFolder { get; }
        public string AdditionalBrowserArguments { get; }

        private void CreateWebView()
        {
            var handler = new EnvironmentCompletedHandler(this.ParentHandle);
            handler.HostCompleted += OnHostCompleted;
            handler.BeforeEnvironmentCompleted += OnBeforeEnvironmentCompleted;
            handler.AfterEnvironmentCompleted += OnAfterEnvironmentCompleted;
            handler.PrepareHostCreate += OnBeforeHostCreate;
            string browserInfo;
            Native.GetWebView2BrowserVersionInfo(this.BrowserExecutableFolder, out browserInfo);
            this._BrowserInfo = browserInfo;
            Native.CreateWebView2EnvironmentWithDetails(this.BrowserExecutableFolder, this.UserDataFolder,
                this.AdditionalBrowserArguments, handler);
            //handler.HostCompleted-=OnHostCompleted;
            //handler.BeforeEnvironmentCompleted-=OnBeforeEnvironmentCompleted;
            //handler.AfterEnvironmentCompleted-=OnAfterEnvironmentCompleted;
            //handler.PrepareHostCreate-= OnBeforeHostCreate;
        }

        public string BrowserInfo => this._BrowserInfo;

        private void OnBeforeHostCreate(object sender, BeforeHostCreateEventArgs e)
        {
            OnBeforeCreate(new BeforeCreateEventArgs(e.Settings));
        }

        private void OnAfterEnvironmentCompleted(object sender, EnvironmentCompletedHandlerArgs e)
        {
            this.Environment = e.Environment;
        }

        private WebViewEnvironment Environment { get; set; }

        private void OnBeforeEnvironmentCompleted(object sender, EnvironmentCompletedHandlerArgs e)
        {
        }

        public WebResourceResponse GetResponseStream(Stream stream, int statusCode, string statusText, string headers,
            string contentType)
        {
            ManagedIStream mStream = new ManagedIStream(stream);
            IWebView2WebResourceResponse responseInterface = null;

            this.Environment.CreateWebResourceResponse(mStream, 200, statusText, headers, ref responseInterface);
            WebResourceResponse wrapper = new WebResourceResponse(responseInterface);
            return wrapper;
        }

        private void OnHostCompleted(object sender, HostCompletedArgs e)
        {
            this.WebView = new WebView2View(e.WebView);

            this.WebView.NavigationStarting += OnNavigateStartIntern;
            this.WebView.ContentLoading += OnContentLoadingIntern;
            this.WebView.SourceChanged += OnSourceChangedIntern;
            this.WebView.HistoryChanged += OnHistoryChangedIntern;
            this.WebView.NavigationCompleted += OnNavigationCompletedIntern;
            this.WebView.AcceleratorKeyPressed += OnAcceleratorKeyPressedIntern;
            this.WebView.ContainsFullScreenElementChanged += OnContainsFullScreenElementChangedIntern;
            this.WebView.DocumentStateChanged += OnDocumentStateChangedIntern;
            this.WebView.DocumentTitleChanged += OnDocumentTitleChangedIntern;
            this.WebView.FrameNavigationStarting += OnFrameNavigationStartingIntern;
            this.WebView.LostFocus += OnLostFocusIntern;
            this.WebView.GotFocus += OnGotFocusIntern;
            this.WebView.NewWindowRequested += OnNewWindowRequestedIntern;
            this.WebView.MoveFocusRequested += OnMoveFocusRequestedIntern;
            this.WebView.PermissionRequested += OnPermissionRequestedIntern;
            this.WebView.ProcessFailed += OnProcessFailedIntern;
            this.WebView.ScriptDialogOpening += OnScriptDialogOpeningIntern;
            this.WebView.ScriptToExecuteOnDocumentCreatedCompleted += OnScriptToExecuteOnDocumentCreatedCompletedIntern;
            this.WebView.WebMessageReceived += OnWebMessageReceivedIntern;
            this.WebView.WebResourceRequested += OnWebResourceRequestedIntern;
            this.WebView.ZoomFactorChanged += OnZoomFactorChangedIntern;
            this.WebView.ExecuteScriptCompleted += OnExecuteScriptCompletedIntern;
            this._Settings = new WebView2Settings(this.WebView.Settings);
            OnCreated();
        }

        private void OnExecuteScriptCompletedIntern(object sender, ExecuteScriptCompletedEventArgs e)
        {
            OnExecuteScriptCompleted(e);
        }

        private void OnScriptToExecuteOnDocumentCreatedCompletedIntern(object sender,
            AddScriptToExecuteOnDocumentCreatedCompletedEventArgs e)
        {
            OnScriptToExecuteOnDocumentCreatedCompleted(e);
        }

        private void OnZoomFactorChangedIntern(object sender, WebView2EventArgs e)
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

        private void OnNavigateStartIntern(object sender, NavigationStartingEventArgs e)
        {
            OnNavigateStart(e);
        }

        private WebView2View WebView { get; set; }


        public void DockToParent()
        {
            tagRECT rect;
            Native.GetClientRect(this.ParentHandle, out rect);
            this.WebView.Bounds = rect;
        }

        public void Navigate(string url)
        {
            this.WebView.Navigate(url);
        }

        public void NavigateToString(string htmlContent)
        {
            this.WebView.NavigateToString(htmlContent);
        }

        public void GoBack()
        {
            this.WebView.GoBack();
        }

        public void GoForward()
        {
            this.WebView.GoForward();
        }

        public void Reload()
        {
            this.WebView.Reload();
        }

        public bool CanGoBack => this.WebView.CanGoBack;
        public bool CanGoForward => this.WebView.CanGoForward;
        public string DocumentTitle => this.WebView.DocumentTitle;
        public WebView2Settings Settings => this._Settings;

        public string Source => this.WebView.Source;

        public void AddScriptToExecuteOnDocumentCreated(string javaScript)
        {
            this.WebView.AddScriptToExecuteOnDocumentCreated(javaScript);
        }

        public void RemoveScriptToExecuteOnDocumentCreated(string id)
        {
            this.WebView.RemoveScriptToExecuteOnDocumentCreated(id);
        }

        public void PostWebMessageAsJson(string webMessageAsJson)
        {
            this.WebView.PostWebMessageAsJson(webMessageAsJson);
        }

        public void PostWebMessageAsString(string webMessageAsString)
        {
            this.WebView.PostWebMessageAsString(webMessageAsString);
        }

        public void AddRemoteObject(string name, ref object @object)
        {
            this.WebView.AddRemoteObject(name, ref @object);
        }

        public void RemoveRemoteObject(string name)
        {
            this.WebView.RemoveRemoteObject(name);
        }

        public void ExecuteScript(string javaScript)
        {
            this.WebView.ExecuteScript(javaScript);
        }
        public void Dispose()
        {
            this.WebView.Close();
        }

        protected virtual void OnCreated()
        {
            Created?.Invoke(this, EventArgs.Empty);
        }

        protected virtual void OnBeforeCreate(BeforeCreateEventArgs e)
        {
            BeforeCreate?.Invoke(this, e);
        }

        protected virtual void OnNavigateStart(NavigationStartingEventArgs e)
        {
            NavigateStart?.Invoke(this, e);
        }

        protected virtual void OnContentLoading(ContentLoadingEventArgs e)
        {
            ContentLoading?.Invoke(this, e);
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

        protected virtual void OnScriptToExecuteOnDocumentCreatedCompleted(
            AddScriptToExecuteOnDocumentCreatedCompletedEventArgs e)
        {
            ScriptToExecuteOnDocumentCreatedCompleted?.Invoke(this, e);
        }

        protected virtual void OnExecuteScriptCompleted(ExecuteScriptCompletedEventArgs e)
        {
            ExecuteScriptCompleted?.Invoke(this, e);
        }
    }
}