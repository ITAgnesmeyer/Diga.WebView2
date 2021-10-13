using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using Diga.WebView2.WinForms;
using Diga.WebView2.Wrapper;
using Diga.WebView2.Wrapper.EventArguments;
using Diga.WebView2.Wrapper.Types;
using MimeTypeExtension;
using SourceChangedEventArgs = Diga.WebView2.Wrapper.EventArguments.SourceChangedEventArgs;



namespace Diga.WebView2.Wpf
{
    /// <summary>
    /// Interaction logic for UserControl1.xaml
    /// </summary>
    public partial class WebView : UserControl
    {
        private WebView2Control _WebViewControl;
        private bool _DefaultContextMenusEnabled;
        private string _Url;
        private bool _DefaultScriptDialogsEnabled = true;
        private bool _DevToolsEnabled = true;

        private bool _RemoteObjectsAllowed = true;
        private bool _IsZoomControlEnabled = true;

        private bool _IsScriptEnabled = true;

        private bool _IsStatusBarEnabled;
        private bool _IsWebMessageEnabled = true;

        private string _HtmlContent;
        public event EventHandler<NavigationStartingEventArgs> NavigationStart;
        public event EventHandler<ContentLoadingEventArgs> ContentLoading;
        public event EventHandler<SourceChangedEventArgs> SourceChanged;
        public event EventHandler<WebView2EventArgs> HistoryChanged;
        public event EventHandler<NavigationCompletedEventArgs> NavigationCompleted;
        public event EventHandler<WebResourceRequestedEventArgs> WebResourceRequested;
        public event EventHandler<AcceleratorKeyPressedEventArgs> AcceleratorKeyPressed;
        public event EventHandler<WebView2EventArgs> WebViewGotFocus;
        public event EventHandler<WebView2EventArgs> WebViewLostFocus;
        public event EventHandler<MoveFocusRequestedEventArgs> MoveFocusRequested;
        public event EventHandler<WebView2EventArgs> ZoomFactorChanged;
        public event EventHandler<WebView2EventArgs> DocumentTitleChanged;
        public event EventHandler<WebView2EventArgs> ContainsFullScreenElementChanged;
        public event EventHandler<NewWindowRequestedEventArgs> NewWindowRequested;
        public event EventHandler<PermissionRequestedEventArgs> PermissionRequested;
        public event EventHandler<NavigationCompletedEventArgs> FrameNavigationCompleted;
        public event EventHandler<NavigationStartingEventArgs> FrameNavigationStarting;
        public event EventHandler<ExecuteScriptCompletedEventArgs> ExecuteScriptCompleted;
        public event EventHandler<ProcessFailedEventArgs> ProcessFailed;
        public event EventHandler<ScriptDialogOpeningEventArgs> ScriptDialogOpening;
        public event EventHandler<WebMessageReceivedEventArgs> WebMessageReceived;
        public event EventHandler<AddScriptToExecuteOnDocumentCreatedCompletedEventArgs>
            ScriptToExecuteOnDocumentCreatedCompleted;
        public event EventHandler<EnvironmentCompletedHandlerArgs> BeforeEnvironmentCompleted;
        public event EventHandler<DownloadStartingEventArgs> DownloadStarting;
        public event EventHandler<FrameCreatedEventArgs> FrameCreated;
        public event EventHandler<WebView2EventArgs> RasterizationScaleChanged;

        public event EventHandler<DOMContentLoadedEventArgs> DOMContentLoaded;
        public event EventHandler<WebResourceResponseReceivedEventArgs> WebResourceResponseReceived;

        public event EventHandler WebViewCreated;

        public event EventHandler BeforeWebViewDestroy;

        public event EventHandler<WebView2EventArgs> WindowCloseRequested;
        public string MonitoringFolder { get; set; }
        public string MonitoringUrl { get; set; }
        public bool EnableMonitoring { get; set; }
        public WebView()
        {
            InitializeComponent();
        }
        public string HtmlContent
        {
            get => _HtmlContent;
            set => this.NavigateToString(value);
        }

        public bool IsZoomControlEnabled
        {
            get => _IsZoomControlEnabled;
            set
            {
                _IsZoomControlEnabled = value;
                if (this.IsCreated)
                {
                    this._WebViewControl.Settings.IsZoomControlEnabled = new CBOOL(value);
                }
            }
        }

        private bool _AreBrowserAcceleratorKeysEnabled = true;
        private bool _IsGeneralAutoFillEnabled;
        private bool _IsPasswordAutosaveEnabled;

        public bool IsPasswordAutosaveEnabled
        {
            get => this._IsPasswordAutosaveEnabled;
            set
            {
                this._IsPasswordAutosaveEnabled = value;
                if (this.IsCreated)
                {
                    this._WebViewControl.Settings.IsPasswordAutosaveEnabled = new CBOOL(value);
                }
            }
        }

        public bool IsGeneralAutoFillEnabled
        {
            get => this._IsGeneralAutoFillEnabled;
            set
            {
                this._IsGeneralAutoFillEnabled = value;
                if (this.IsCreated)
                {
                    this._WebViewControl.Settings.IsGeneralAutofillEnabled = new CBOOL(value);
                }
            }
        }

        public bool AreBrowserAcceleratorKeysEnabled
        {
            get => this._AreBrowserAcceleratorKeysEnabled;
            set
            {
                this._AreBrowserAcceleratorKeysEnabled = value;
                if (this.IsCreated)
                    this._WebViewControl.Settings.AreBrowserAcceleratorKeysEnabled = new CBOOL(value);
            }
        }

        public bool IsWebMessageEnabled
        {
            get => _IsWebMessageEnabled;
            set
            {
                _IsWebMessageEnabled = value;
                if (this.IsCreated)
                {
                    this._WebViewControl.Settings.IsWebMessageEnabled = new CBOOL(value);
                }
            }
        }

        public bool IsStatusBarEnabled
        {
            get => _IsStatusBarEnabled;
            set
            {
                _IsStatusBarEnabled = value;
                if (this.IsCreated)
                {
                    this._WebViewControl.Settings.IsStatusBarEnabled = new CBOOL(value);
                }
            }
        }

        public bool IsScriptEnabled
        {
            get => _IsScriptEnabled;
            set
            {
                _IsScriptEnabled = value;
                if (this.IsCreated)
                {
                    this._WebViewControl.Settings.IsScriptEnabled = new CBOOL(value);
                }
            }
        }

        public bool RemoteObjectsAllowed
        {
            get => _RemoteObjectsAllowed;

            set
            {
                _RemoteObjectsAllowed = value;
                if (this.IsCreated)
                {
                    this._WebViewControl.Settings.AreHostObjectsAllowed = new CBOOL(value);
                }
            }
        }
        [Browsable(false)]
        public bool IsCreated { get; set; }

        public bool DevToolsEnabled
        {
            get => _DevToolsEnabled;
            set
            {
                _DevToolsEnabled = value;
                if (this.IsCreated)
                {
                    this._WebViewControl.Settings.AreDevToolsEnabled = new CBOOL(value);
                }
            }
        }
        public bool DefaultScriptDialogsEnabled
        {
            get => _DefaultScriptDialogsEnabled;
            set
            {
                _DefaultScriptDialogsEnabled = value;
                if (this.IsCreated)
                {
                    this._WebViewControl.Settings.AreDefaultScriptDialogsEnabled = new CBOOL(value);
                }
            }
        }
        public bool DefaultContextMenusEnabled
        {
            get => _DefaultContextMenusEnabled;
            set
            {
                _DefaultContextMenusEnabled = value;
                if (this.IsCreated)
                {
                    this._WebViewControl.Settings.AreDefaultContextMenusEnabled = new CBOOL(value);
                }
            }
        }
        public string Source
        {
            get
            {
                if (this.IsCreated)
                {
                    return this._WebViewControl.Source;
                }

                return "";
            }
        }

        public CookieManager GetCookieManager
        {
            get
            {
                if (this.IsCreated)
                    return this._WebViewControl.GetCookieManager;
                return null;

            }


        }

        public async Task<System.Drawing.Image> CapturePreviewAsImageAsync(ImageFormat imageFormat)
        {
            using (var stream = new MemoryStream())
            {
                await this._WebViewControl.CapturePreviewAsync(stream, imageFormat);
                var retImage = System.Drawing.Image.FromStream(stream);
                return retImage;
            }
        }
        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {

         
        }
        public void Navigate(string url)
        {
            this._Url = url;
            if (this.IsCreated && !string.IsNullOrEmpty(this.Url))
            {
                try
                {
                    this._WebViewControl.Navigate(this._Url);
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message, "Navigation Error!", MessageBoxButton.OK, MessageBoxImage.Error);

                }

            }

        }
        public void NavigateToString(string htmlContent)
        {
            _HtmlContent = htmlContent;
            if (this.IsCreated && !string.IsNullOrEmpty(this._HtmlContent))
            {
                try
                {
                    this._WebViewControl.NavigateToString(_HtmlContent);
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message, "Navigation Error!", MessageBoxButton.OK, MessageBoxImage.Error);
                }

            }
        }
        public string Url
        {
            get => _Url;
            set
            {
                _Url = value;
                if (this.IsCreated)
                {
                    this.Navigate(value);
                }
            }
        }

        public void GoBack()
        {
            if (!this.IsCreated) return;
            if (this._WebViewControl.CanGoBack)
                this._WebViewControl.GoBack();
        }

        public void GoForward()
        {
            if (!this.IsCreated) return;
            if (this._WebViewControl.CanGoForward)
                this._WebViewControl.GoForward();


        }

        public void AddScriptToExecuteOnDocumentCreated(string javaScript)
        {
            if (!this.IsCreated) return;
            this._WebViewControl.AddScriptToExecuteOnDocumentCreated(javaScript);

        }
        public void SendMessage(string message)
        {
            this._WebViewControl.PostWebMessageAsString(message);
        }
        public void PostWebMessageAsJson(string webMessageAsJson)
        {
            this._WebViewControl.PostWebMessageAsJson(webMessageAsJson);

        }

        public void PostWebMessageAsString(string webMessageAsString)
        {
            this._WebViewControl.PostWebMessageAsString(webMessageAsString);
        }

        public void AddRemoteObject(string name, object @object)
        {
            if (!this.IsCreated) return;
            this._WebViewControl.AddRemoteObject(name, @object);
        }
        public void Reload()
        {
            this._WebViewControl.Reload();
        }
        public void RemoveRemoteObject(string name)
        {
            this._WebViewControl.RemoveRemoteObject(name);
        }

        public void ExecuteScript(string javaScript)
        {
            this._WebViewControl.ExecuteScript(javaScript);
        }

        public async Task<string> ExecuteScriptAsync(string javaScript)
        {
            return await this._WebViewControl.ExecuteScriptAsync(javaScript);
        }



        public string InvokeScript(string javaScript)
        {

            string result = this._WebViewControl.InvokeScript(javaScript, (id, errorCode, jsonResult) =>
            {
                Debug.Print(id);

            });

            return result;
        }
        [Browsable(false)]
        public string DocumentTitle
        {
            get => this._WebViewControl.DocumentTitle;

        }


        public void OpenDevToolsWindow()
        {
            this._WebViewControl.OpenDevToolsWindow();
        }
        private void OnRasterizationScaleChangedIntern(object sender, WebView2EventArgs e)
        {
            OnRasterizationScaleChanged(e);
        }

        private void OnFrameCreatedIntern(object sender, FrameCreatedEventArgs e)
        {
            OnFrameCreated(e);
        }

        private void OnDownalodStartingIntern(object sender, DownloadStartingEventArgs e)
        {
            OnDownloadStarting(e);
        }

        private void WebResourceResponseReceivedIntern(object sender, WebResourceResponseReceivedEventArgs e)
        {
            OnWebResourceResponseReceived(e);
        }

        private void OnDOMContentLoadedIntern(object sender, DOMContentLoadedEventArgs e)
        {
            OnDomContentLoaded(e);
        }

        private void OnNewBrowserVersionAvailableIntern(object sender, WebView2EventArgs e)
        {

        }

        private void OnFrameNavigationCompletedIntern(object sender, NavigationCompletedEventArgs e)
        {
            OnFrameNavigationCompleted(e);
        }


        private void OnMoveFocusRequestedIntern(object sender, MoveFocusRequestedEventArgs e)
        {
            OnMoveFocusRequested(e);
        }

        private void OnLostFocusIntern(object sender, WebView2EventArgs e)
        {

            OnWebViewLostFocus(e);
        }
        private void OnGotFocusIntern(object sender, WebView2EventArgs e)
        {
            OnWebViewGotFocus(e);
        }

        private void OnZoomFactorChangedIntern(object sender, WebView2EventArgs e)
        {
            OnZoomFactorChanged(e);
        }

        private void OnPermissionRequestedIntern(object sender, PermissionRequestedEventArgs e)
        {
            OnPermissionRequested(e);
        }
        private void OnNewWindowRequestedIntern(object sender, NewWindowRequestedEventArgs e)
        {
            OnNewWindowRequested(e);
        }

        private void OnExecuteScriptCompletedIntern(object sender, ExecuteScriptCompletedEventArgs e)
        {
            OnExecuteScriptCompleted(e);
        }
        private void OnWebMessageReceivedIntern(object sender, WebMessageReceivedEventArgs e)
        {
            OnWebMessageReceived(e);
        }
        private void ScriptToExecuteOnDocumentCreatedCompletedIntern(object sender, AddScriptToExecuteOnDocumentCreatedCompletedEventArgs e)
        {
            OnScriptToExecuteOnDocumentCreatedCompleted(e);
        }

        private void OnWindowCloseRequestedIntern(object sender, WebView2EventArgs e)
        {
            OnWindowCloseRequested(e);
        }


        private void OnScriptDialogOpeningIntern(object sender, ScriptDialogOpeningEventArgs e)
        {
            OnScriptDialogOpening(e);
        }
        private void OnProcessFailedIntern(object sender, ProcessFailedEventArgs e)
        {
            OnProcessFailed(e);
        }
        private void OnFrameNavigationStartingIntern(object sender, NavigationStartingEventArgs e)
        {
            OnFrameNavigationStarting(e);
        }
        private void OnDocumentTitleChangedIntern(object sender, WebView2EventArgs e)
        {
            OnDocumentTitleChanged(e);
        }
        private void OnContainsFullScreenElementChangedIntern(object sender, WebView2EventArgs e)
        {
            OnContainsFullScreenElementChanged(e);
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

        private void OnNavigationStartIntern(object sender, NavigationStartingEventArgs e)
        {
            OnNavigationStart(e);
        }

        private void WebView_Resize(object sender, EventArgs e)
        {
            if (this.IsCreated)
            {
                this._WebViewControl.DockToParent();
            }
        }

        protected virtual void OnNavigationStart(NavigationStartingEventArgs e)
        {
            NavigationStart?.Invoke(this, e);
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
        protected virtual void OnDocumentTitleChanged(WebView2EventArgs e)
        {
            DocumentTitleChanged?.Invoke(this, e);
        }
        protected virtual void OnFrameNavigationStarting(NavigationStartingEventArgs e)
        {
            FrameNavigationStarting?.Invoke(this, e);
        }
        protected virtual void OnScriptDialogOpening(ScriptDialogOpeningEventArgs e)
        {
            ScriptDialogOpening?.Invoke(this, e);
        }

        protected virtual void OnWindowCloseRequested(WebView2EventArgs e)
        {
            WindowCloseRequested?.Invoke(this, e);
        }

        protected virtual void OnScriptToExecuteOnDocumentCreatedCompleted(AddScriptToExecuteOnDocumentCreatedCompletedEventArgs e)
        {
            ScriptToExecuteOnDocumentCreatedCompleted?.Invoke(this, e);
        }
        protected virtual void OnWebMessageReceived(WebMessageReceivedEventArgs e)
        {
            WebMessageReceived?.Invoke(this, e);
        }
        protected virtual void OnProcessFailed(ProcessFailedEventArgs e)
        {
            ProcessFailed?.Invoke(this, e);
        }
        protected virtual void OnExecuteScriptCompleted(ExecuteScriptCompletedEventArgs e)
        {
            ExecuteScriptCompleted?.Invoke(this, e);
        }
        protected virtual void OnNewWindowRequested(NewWindowRequestedEventArgs e)
        {
            NewWindowRequested?.Invoke(this, e);
        }
        protected virtual void OnPermissionRequested(PermissionRequestedEventArgs e)
        {
            PermissionRequested?.Invoke(this, e);
        }


        protected virtual void OnZoomFactorChanged(WebView2EventArgs e)
        {
            ZoomFactorChanged?.Invoke(this, e);
        }

        public WebResourceResponse CreateResponse(ResponseInfo responseInfo)
        {
            WebResourceResponse response = null;
            if (this.IsCreated)
            {
                response = this._WebViewControl.GetResponseStream(responseInfo.Stream, responseInfo.StatusCode,
                    responseInfo.StatusText, responseInfo.HeaderToString(), responseInfo.ContentType);
            }

            return response;
        }
        private bool GetFileStream(string url, out ResponseInfo responseInfo)
        {
            if (!url.StartsWith(this.MonitoringUrl))
            {
                responseInfo = null;
                return false;
            }

            string baseDirectory = this.MonitoringFolder;
            string file = url.Replace(this.MonitoringUrl, "");
            if (string.IsNullOrEmpty(file))
                file = "index.html";
            file = file.Replace("/", "\\");
            file = System.IO.Path.Combine(baseDirectory, file);
            FileInfo fileInfo = new FileInfo(file);
            if (!fileInfo.Exists)
            {
                responseInfo = new ResponseInfo("<h1>Server Error</h1><h5>file not found:" + file + "</h5>");
                responseInfo.Header.Add("content-type", "text/html; charset=utf-8");
                responseInfo.ContentType = "content-type: text/html; charset=utf-8";
                responseInfo.StatusCode = 404;
                responseInfo.StatusText = "Not Found";

                return false;
            }

            string contentType = fileInfo.MimeTypeOrDefault();
            if (contentType == "document")
                Debug.Print(contentType);
            try
            {
                byte[] bytes = File.ReadAllBytes(file);
                responseInfo = new ResponseInfo(bytes);
                string utf8Extension = GetUtf8IfNeeded(contentType);

                responseInfo.Header.Add("content-type", contentType + utf8Extension);

                responseInfo.ContentType = "content-type: " + contentType + utf8Extension;
                responseInfo.StatusCode = 200;
                responseInfo.StatusText = "OK";
                return true;
            }
            catch (Exception e)
            {
                string message = "Error:" + e.Message;
                responseInfo = new ResponseInfo(message);
                responseInfo.Header.Add("content-type", "text/html; charset=utf-8");
                responseInfo.ContentType = "content-type; charset=utf-8";
                responseInfo.StatusCode = 500;
                responseInfo.StatusText = "Internal Server Error";
                return true;
            }


        }

        private string GetUtf8IfNeeded(string contentType)
        {
            if (string.IsNullOrEmpty(contentType))
                return "";

            bool needUtf8 = false;

            switch (contentType)
            {
                case "application/x-javascript":
                case "text/html":
                case "text/css":
                case "application/javascript":
                case "application/json":
                    needUtf8 = true;
                    break;
            }

            if (needUtf8)
                return "; charset=utf-8";
            return "";
        }

        protected virtual void OnWebResourceRequested(WebResourceRequestedEventArgs e)
        {
            if (this.EnableMonitoring)
            {
                if (GetFileStream(e.Request.Uri, out var responseInfo))
                {
                    var response = this.CreateResponse(responseInfo);
                    e.Response = response;
                }
            }

            WebResourceRequested?.Invoke(this, e);
        }

        protected virtual void OnWebViewGotFocus(WebView2EventArgs e)
        {
            WebViewGotFocus?.Invoke(this, e);
        }
        protected virtual void OnWebViewLostFocus(WebView2EventArgs e)
        {
            WebViewLostFocus?.Invoke(this, e);
        }
        protected virtual void OnMoveFocusRequested(MoveFocusRequestedEventArgs e)
        {
            MoveFocusRequested?.Invoke(this, e);
        }
        public string BrowserVersion => this._WebViewControl.BrowserInfo;

        protected virtual void OnWebViewCreated()
        {
            WebViewCreated?.Invoke(this, EventArgs.Empty);
        }

        protected virtual void OnFrameNavigationCompleted(NavigationCompletedEventArgs e)
        {
            FrameNavigationCompleted?.Invoke(this, e);
        }
        protected virtual void OnBeforeWebViewDestroy()
        {
            BeforeWebViewDestroy?.Invoke(this, EventArgs.Empty);
        }

        protected virtual void OnDomContentLoaded(DOMContentLoadedEventArgs e)
        {
            DOMContentLoaded?.Invoke(this, e);
        }

        protected virtual void OnWebResourceResponseReceived(WebResourceResponseReceivedEventArgs e)
        {
            WebResourceResponseReceived?.Invoke(this, e);
        }

        protected virtual void OnBeforeEnvironmentCompleted(EnvironmentCompletedHandlerArgs e)
        {
            BeforeEnvironmentCompleted?.Invoke(this, e);
        }

        protected virtual void OnDownloadStarting(DownloadStartingEventArgs e)
        {
            DownloadStarting?.Invoke(this, e);
        }

        protected virtual void OnFrameCreated(FrameCreatedEventArgs e)
        {
            FrameCreated?.Invoke(this, e);
        }

        protected virtual void OnRasterizationScaleChanged(WebView2EventArgs e)
        {
            RasterizationScaleChanged?.Invoke(this, e);
        }

        private void OnWebWindowBeforeCreate(object sender, BeforeCreateEventArgs e)
        {
            e.Settings.AreBrowserAcceleratorKeysEnabled = new CBOOL(this._AreBrowserAcceleratorKeysEnabled);
            e.Settings.AreDefaultContextMenusEnabled = new CBOOL(this._DefaultContextMenusEnabled);
            e.Settings.AreDefaultScriptDialogsEnabled = new CBOOL(this._DefaultScriptDialogsEnabled);
            e.Settings.AreDevToolsEnabled = new CBOOL(this._DevToolsEnabled);
            e.Settings.AreHostObjectsAllowed = new CBOOL(this._RemoteObjectsAllowed);
            e.Settings.IsGeneralAutofillEnabled = new CBOOL(this._IsGeneralAutoFillEnabled);
            e.Settings.IsPasswordAutosaveEnabled = new CBOOL(this._IsPasswordAutosaveEnabled);
            e.Settings.IsScriptEnabled = new CBOOL(this._IsScriptEnabled);
            e.Settings.IsStatusBarEnabled = new CBOOL(this._IsStatusBarEnabled);
            e.Settings.IsWebMessageEnabled = new CBOOL(this._IsWebMessageEnabled);
            e.Settings.IsZoomControlEnabled = new CBOOL(this._IsZoomControlEnabled);
        }

        private void OnWebWindowCreated(object sender, EventArgs e)
        {
            this.IsCreated = true;
            this.AddScriptToExecuteOnDocumentCreated(
                "window.external = { sendMessage: function(message) { window.chrome.webview.postMessage(message); }, receiveMessage: function(callback) { window.chrome.webview.addEventListener('message', function(e) { callback(e.data); }); } };");
            if (!string.IsNullOrEmpty(this._Url))
                this.Navigate(this.Url);
            if (!string.IsNullOrEmpty(this._HtmlContent))
                this.NavigateToString(this._HtmlContent);

            OnWebViewCreated();
        }
        private void UserControl_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            if (this.IsCreated)
            {
                this._WebViewControl.DockToParent();
            }
            
        }

        private void ViewHwnd_Loaded(object sender, RoutedEventArgs e)
        {
            var h = this.ViewHwnd.Handle;
            
            if (h.Handle  == IntPtr.Zero )
                return;
            this._WebViewControl = new WebView2Control(h.Handle);
            this._WebViewControl.Created += OnWebWindowCreated;
            this._WebViewControl.BeforeCreate += OnWebWindowBeforeCreate;
            this._WebViewControl.NavigateStart += OnNavigationStartIntern;
            this._WebViewControl.AcceleratorKeyPressed += OnAcceleratorKeyPressedIntern;
            this._WebViewControl.GotFocus += OnGotFocusIntern;
            this._WebViewControl.LostFocus += OnLostFocusIntern;
            this._WebViewControl.MoveFocusRequested += OnMoveFocusRequestedIntern;
            this._WebViewControl.ZoomFactorChanged += OnZoomFactorChangedIntern;
            this._WebViewControl.ContainsFullScreenElementChanged += OnContainsFullScreenElementChangedIntern;

            this._WebViewControl.NewWindowRequested += OnNewWindowRequestedIntern;
            this._WebViewControl.PermissionRequested += OnPermissionRequestedIntern;
            this._WebViewControl.DocumentTitleChanged += OnDocumentTitleChangedIntern;
            this._WebViewControl.FrameNavigationCompleted += OnFrameNavigationCompletedIntern;
            this._WebViewControl.FrameNavigationStarting += OnFrameNavigationStartingIntern;
            this._WebViewControl.ProcessFailed += OnProcessFailedIntern;
            this._WebViewControl.ScriptDialogOpening += OnScriptDialogOpeningIntern;
            this._WebViewControl.WebMessageReceived += OnWebMessageReceivedIntern;
            this._WebViewControl.ScriptToExecuteOnDocumentCreatedCompleted += ScriptToExecuteOnDocumentCreatedCompletedIntern;

            this._WebViewControl.WindowCloseRequested += OnWindowCloseRequestedIntern;
            this._WebViewControl.ExecuteScriptCompleted += OnExecuteScriptCompletedIntern;
            this._WebViewControl.WebResourceRequested += OnWebResourceRequestedIntern;
            this._WebViewControl.ContentLoading += OnContentLoadingIntern;
            this._WebViewControl.SourceChanged += OnSourceChangedIntern;
            this._WebViewControl.HistoryChanged += OnHistoryChangedIntern;
            this._WebViewControl.NavigationCompleted += OnNavigationCompletedIntern;
            this._WebViewControl.NewBrowserVersionAvailable += OnNewBrowserVersionAvailableIntern;
            this._WebViewControl.DOMContentLoaded += OnDOMContentLoadedIntern;
            this._WebViewControl.WebResourceResponseReceived += WebResourceResponseReceivedIntern;
            this._WebViewControl.DownloadStarting += OnDownalodStartingIntern;
            this._WebViewControl.FrameCreated += OnFrameCreatedIntern;
            this._WebViewControl.RasterizationScaleChanged += OnRasterizationScaleChangedIntern;
        }

        private void ViewHwnd_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            
        }

        private void ViewHwnd_Resize(object sender, EventArgs e)
        {
            if (this.IsCreated)
            {
                this._WebViewControl.DockToParent();
            }
        }

        private void ViewHwnd_Destroy(object sender, EventArgs e)
        {
            this._WebViewControl.CleanupControls();
        }
    }
}