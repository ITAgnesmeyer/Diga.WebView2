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
        public event EventHandler<WebResourceRequestedEventArgs> WebResourceRequested;
        public event EventHandler<WebView2EventArgs> ContainsFullScreenElementChanged;
        public event EventHandler<AcceleratorKeyPressedEventArgs> AcceleratorKeyPressed;
        public event EventHandler<WebView2EventArgs> GotFocus;
        public event EventHandler<WebView2EventArgs> LostFocus;
        public event EventHandler<MoveFocusRequestedEventArgs> MoveFocusRequested;
        public event EventHandler<WebView2EventArgs> ZoomFactorChanged;
        public event EventHandler<WebView2EventArgs> DocumentTitleChanged;
        public event EventHandler<NewWindowRequestedEventArgs> NewWindowRequested;
        public event EventHandler<PermissionRequestedEventArgs> PermissionRequested;
        public event EventHandler<NavigationStartingEventArgs> FrameNavigationStarting;
        public event EventHandler<ExecuteScriptCompletedEventArgs> ExecuteScriptCompleted;
        public event EventHandler<ProcessFailedEventArgs> ProcessFailed;
        public event EventHandler<ScriptDialogOpeningEventArgs> ScriptDialogOpening;
        public event EventHandler<WebMessageReceivedEventArgs> WebMessageReceived;
        public event EventHandler<WebView2EventArgs> WindowCloseRequested;
        public event EventHandler<AddScriptToExecuteOnDocumentCreatedCompletedEventArgs>
            ScriptToExecuteOnDocumentCreatedCompleted;
       
        private WebView2Settings _Settings;
        private string _BrowserInfo;
        private WebView2Environment Environment { get; set; }
        public WebView2Control(IntPtr parentHandle) : this(parentHandle, string.Empty, string.Empty, string.Empty)
        {

        }
        public WebView2Control(IntPtr parentHandle, string browserExecutableFolder, string userDataFolder, string additionalBrowserArguments)
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
            
            Native.GetCoreWebView2BrowserVersionInfo(this.BrowserExecutableFolder, out string browserInfo);
            this._BrowserInfo = browserInfo;

            Native.CreateCoreWebView2EnvironmentWithDetails(this.BrowserExecutableFolder, this.UserDataFolder, this.AdditionalBrowserArguments, handler);
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

        private void OnBeforeEnvironmentCompleted(object sender, EnvironmentCompletedHandlerArgs e)
        {

        }

        private void OnHostCompleted(object sender, CoreWebView2HostCompletedArgs e)
        {
            this.Host = new WebView2Host( e.Host);
            this.Host.AcceleratorKeyPressed += OnAcceleratorKeyPressedIntern;
            this.Host.GotFocus += OnGotFocusIntern;
            this.Host.LostFocus += OnLostFocusIntern;
            this.Host.MoveFocusRequested += OnMoveFocusRequestedIntern;
            this.Host.ZoomFactorChanged += OnZoomFactorChangedIntern;
            this.WebView = new WebView2View( e.WebView);
            this.WebView.NavigationStarting += OnNavigateStartIntern;
            this.WebView.ContentLoading += OnContentLoadingIntern;
            this.WebView.SourceChanged += OnSourceChangedInternal;
            this.WebView.HistoryChanged += OnHistoryChangedInternal;
            this.WebView.NavigationCompleted+= OnNavigationCompletedIntern;
            this.WebView.WebResourceRequested += OnWebResourceRequestedIntern;
            this.WebView.ContainsFullScreenElementChanged += OnContainsFullScreenElementChangedIntern;
            this.WebView.DocumentTitleChanged += OnDocumentTitleChangedIntern;
            this.WebView.NewWindowRequested += OnNewWindowRequestedIntern;
            this.WebView.PermissionRequested += OnPermissionRequestedIntern;
            this.WebView.FrameNavigationStarting += OnFrameNavigationStartingIntern;
            this.WebView.ExecuteScriptCompleted += OnExecuteScriptCompletedIntern;
            this.WebView.ProcessFailed += OnProcessFailedIntern;
            this.WebView.ScriptDialogOpening += OnScriptDialogOpeningIntern;
            this.WebView.WebMessageReceived += OnWebMessageReceivedIntern;
            this.WebView.WindowCloseRequested += OnWindowCloseRequestedIntern;
            this.WebView.ScriptToExecuteOnDocumentCreated += OnScriptToExecuteOnDocumentCreatedIntern;
            
            this._Settings = new WebView2Settings(this.WebView.Settings);
            OnCreated();
        }

        private void OnZoomFactorChangedIntern(object sender, WebView2EventArgs e)
        {

            OnZoomFactorChanged(e);
        }

        private void OnScriptToExecuteOnDocumentCreatedIntern(object sender, AddScriptToExecuteOnDocumentCreatedCompletedEventArgs e)
        {
            OnScriptToExecuteOnDocumentCreatedCompleted(e);
        }

        private void OnWindowCloseRequestedIntern(object sender, WebView2EventArgs e)
        {
            OnWindowCloseRequested(e);
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

        private void OnExecuteScriptCompletedIntern(object sender, ExecuteScriptCompletedEventArgs e)
        {
            OnExecuteScriptCompleted(e);

        }

        private void OnFrameNavigationStartingIntern(object sender, NavigationStartingEventArgs e)
        {
            OnFrameNavigationStarting(e);
        }

        private void OnPermissionRequestedIntern(object sender, PermissionRequestedEventArgs e)
        {
            OnPermissionRequested(e);
        }

        private void OnNewWindowRequestedIntern(object sender, NewWindowRequestedEventArgs e)
        {
            OnNewWindowRequested(e);
        }

        private void OnDocumentTitleChangedIntern(object sender, WebView2EventArgs e)
        {
            OnDocumentTitleChanged(e);
        }

        private void OnContainsFullScreenElementChangedIntern(object sender, WebView2EventArgs e)
        {
            OnContainsFullScreenElementChanged(e);
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

        private void OnAcceleratorKeyPressedIntern(object sender, AcceleratorKeyPressedEventArgs e)
        {
            OnAcceleratorKeyPressed(e);
        }

        private void OnWebResourceRequestedIntern(object sender, WebResourceRequestedEventArgs e)
        {
            OnWebResourceRequested(e);
        }

        private void OnNavigationCompletedIntern(object sender, NavigationCompletedEventArgs e)
        {
            OnNavigationCompleted(e);
        }

        private void OnHistoryChangedInternal(object sender, WebView2EventArgs e)
        {
            OnHistoryChanged(e);
        }

        private void OnSourceChangedInternal(object sender, SourceChangedEventArgs e)
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

        private WebView2View WebView
        {
            get;
            set;
        }

        private WebView2Host Host { get; set; }

        public void DockToParent()
        {
            tagRECT rect;
            Native.GetClientRect(this.ParentHandle, out rect);
            this.Host.Bounds = rect;
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

        public void Dispose()
        {
            this.Host?.Close();
            this.Host?.Dispose();
            

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

        protected virtual void OnWebResourceRequested(WebResourceRequestedEventArgs e)
        {
            WebResourceRequested?.Invoke(this, e);
        }

        public WebResourceResponse GetResponseStream(Stream stream, int statusCode, string statusText, string headers,
            string contentType)
        {
            ManagedIStream mStream = new ManagedIStream(stream);


            var responseInterface =
                this.Environment.CreateWebResourceResponse(mStream, statusCode, statusText, headers);
            WebResourceResponse wrapper = new WebResourceResponse(responseInterface);
            return wrapper;
        }

        public void OpenDevToolsWindow()
        {
            this.WebView.OpenDevToolsWindow();
        }


        protected virtual void OnAcceleratorKeyPressed(AcceleratorKeyPressedEventArgs e)
        {
            AcceleratorKeyPressed?.Invoke(this, e);
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

        protected virtual void OnZoomFactorChanged(WebView2EventArgs e)
        {
            ZoomFactorChanged?.Invoke(this, e);
        }

        protected virtual void OnContainsFullScreenElementChanged(WebView2EventArgs e)
        {
            ContainsFullScreenElementChanged?.Invoke(this, e);
        }

        protected virtual void OnDocumentTitleChanged(WebView2EventArgs e)
        {
            DocumentTitleChanged?.Invoke(this, e);
        }

        protected virtual void OnNewWindowRequested(NewWindowRequestedEventArgs e)
        {
            NewWindowRequested?.Invoke(this, e);
        }

        protected virtual void OnPermissionRequested(PermissionRequestedEventArgs e)
        {
            PermissionRequested?.Invoke(this, e);
        }

        protected virtual void OnFrameNavigationStarting(NavigationStartingEventArgs e)
        {
            FrameNavigationStarting?.Invoke(this, e);
        }

        protected virtual void OnExecuteScriptCompleted(ExecuteScriptCompletedEventArgs e)
        {
            ExecuteScriptCompleted?.Invoke(this, e);
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

        protected virtual void OnWindowCloseRequested(WebView2EventArgs e)
        {
            WindowCloseRequested?.Invoke(this, e);
        }

        public void AddScriptToExecuteOnDocumentCreated(string javaScript)
        {
            this.WebView.AddScriptToExecuteOnDocumentCreated(javaScript);
        }

        public void PostWebMessageAsJson(string webMessageAsJson)
        {
            this.WebView.PostWebMessageAsJson(webMessageAsJson);
        }

        public void PostWebMessageAsString(string webMessageAsString)
        {
            this.WebView.PostWebMessageAsString(webMessageAsString);
        }

        public void AddRemoteObject(string name, object obj)
        {
            this.WebView.AddRemoteObject(name, obj);
        }

        public void RemoveRemoteObject(string name)
        {
            this.WebView.RemoveRemoteObject(name);
        }

        public void ExecuteScript(string javaScript)
        {
            this.WebView.ExecuteScript(javaScript);
        }

        public void InvokeScript(string javaScript, Action<int, string> actionToInvoke)
        {
            this.WebView.InvokeScript(javaScript, actionToInvoke);
        }

        protected virtual void OnScriptToExecuteOnDocumentCreatedCompleted(AddScriptToExecuteOnDocumentCreatedCompletedEventArgs e)
        {
            ScriptToExecuteOnDocumentCreatedCompleted?.Invoke(this, e);
        }
    }
}