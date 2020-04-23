using System;
using System.ComponentModel;
using System.Windows.Forms;

using Diga.WebView2.Wrapper;
using Diga.WebView2.Wrapper.EventArguments;
using Diga.WebView2.Wrapper.Handler;

namespace Diga.WebView2.WinForms
{
    public partial class WebView : UserControl
    {
        private WebView2Control _WebViewControl;
        private bool _DefaultContextMenusEnabled;
        private string _Url;
        private bool _DefaultScriptDialogsEnabled = true;
        private bool _DevToolsEnabled = true;
#if !VS8355
        private bool _RemoteObjectsAllowed = true;
        private bool _IsZoomControlEnabled = true;
#endif
        private bool _IsScriptEnabled = true;

        private bool _IsStatusBarEnabled;
        private bool _IsWebMessageEnabled = true;

        private string _HtmlContent;
        public event EventHandler<NavigationStartingEventArgs> NavigationStart;
        public event EventHandler<ContentLoadingEventArgs> ContentLoading;
        public event EventHandler<SourceChangedEventArgs> SourceChanged;
        public event EventHandler<WebView2EventArgs> HistoryChanged;
        public event EventHandler<NavigationCompletedEventArgs> NavigationCompleted;
#if VS8355
        public event EventHandler<AcceleratorKeyPressedEventArgs> AcceleratorKeyPressed;
        public event EventHandler<WebView2EventArgs> ContainsFullScreenElementChanged;
        public event EventHandler<DocumentStateChangedEventArgs> DocumentStateChanged;
        public event EventHandler<WebView2EventArgs> DocumentTitleChanged;
        public event EventHandler<NavigationStartingEventArgs> FrameNavigationStarting;
        public event EventHandler<WebView2EventArgs> WebViewGotFocus;
        public event EventHandler<WebView2EventArgs> WebViewLostFocus;
        public event EventHandler<MoveFocusRequestedEventArgs> MoveFocusRequested;
        public event EventHandler<NewWindowRequestedEventArgs> NewWindowRequested;
        public event EventHandler<PermissionRequestedEventArgs> PermissionRequested;
        public event EventHandler<ProcessFailedEventArgs> ProcessFailed;
        public event EventHandler<ScriptDialogOpeningEventArgs> ScriptDialogOpening;
        public event EventHandler<WebMessageReceivedEventArgs> WebMessageReceived;
        public event EventHandler<WebResourceRequestedEventArgs> WebResourceRequested;
        public event EventHandler<WebView2EventArgs> ZoomFactorChanged;
        public event EventHandler<AddScriptToExecuteOnDocumentCreatedCompletedEventArgs>
            ScriptToExecuteOnDocumentCreatedCompleted;
        public event EventHandler<ExecuteScriptCompletedEventArgs> ExecuteScriptCompleted;
#endif

        public string HtmlContent
        {
            get => _HtmlContent;
            set
            {

                this.NavigateToString(value);

            }
        }
#if !VS8355
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
#endif
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
#if !VS8355
        public bool RemoteObjectsAllowed
        {
            get => _RemoteObjectsAllowed;

            set
            {
                _RemoteObjectsAllowed = value;
                if (this.IsCreated)
                {
                    this._WebViewControl.Settings.AreRemoteObjectsAllowed = new CBOOL(value);
                }
            }
        }
#endif
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
        public WebView()
        {
            InitializeComponent();
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


        private void OnWebWindowBeforeCreate(object sender, BeforeCreateEventArgs e)
        {
            e.Settings.AreDefaultContextMenusEnabled = new CBOOL(this._DefaultContextMenusEnabled);
            e.Settings.AreDefaultScriptDialogsEnabled = new CBOOL(this._DefaultScriptDialogsEnabled);
            e.Settings.AreDevToolsEnabled = new CBOOL(this._DevToolsEnabled);
#if !VS8355
            e.Settings.AreRemoteObjectsAllowed = new CBOOL(this._RemoteObjectsAllowed);
#endif
            e.Settings.IsScriptEnabled = new CBOOL(this._IsScriptEnabled);
            e.Settings.IsStatusBarEnabled = new CBOOL(this._IsStatusBarEnabled);
            e.Settings.IsWebMessageEnabled = new CBOOL(this._IsWebMessageEnabled);
#if !VS8355
            e.Settings.IsZoomControlEnabled = new CBOOL(this._IsZoomControlEnabled);
#endif
        }

        private void OnWebWindowCreated(object sender, EventArgs e)
        {
            this.IsCreated = true;
            if (!string.IsNullOrEmpty(this._Url))
                this.Navigate(this.Url);
            if (!string.IsNullOrEmpty(this._HtmlContent))
                this.NavigateToString(this._HtmlContent);

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
                    MessageBox.Show(this, e.Message, "Navigation Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

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
                    MessageBox.Show(owner: this, e.Message, "Navigation Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

#if VS8355

        public void AddScriptToExecuteOnDocumentCreated(string javaScript)
        {
            if(!this.IsCreated) return;
            this._WebViewControl.AddScriptToExecuteOnDocumentCreated(javaScript);
            
        }

        public void PostWebMessageAsJson(string webMessageAsJson)
        {
            this._WebViewControl.PostWebMessageAsJson(webMessageAsJson);
            
        }

        public void PostWebMessageAsString(string webMessageAsString)
        {
            this._WebViewControl.PostWebMessageAsString(webMessageAsString);
        }

        public void AddRemoteObject(string name, ref object @object)
        {
            this._WebViewControl.AddRemoteObject(name, ref @object);
        }

        public void RemoveRemoteObject(string name)
        {
            this._WebViewControl.RemoveRemoteObject(name);
        }

        public void ExecuteScript(string javaScript)
        {
            this._WebViewControl.ExecuteScript(javaScript);
        }

        public string DocumentTitle
        {
            get => this._WebViewControl.DocumentTitle;

        }
#endif

        private bool IsInDesignMode()
        {
            if (LicenseManager.UsageMode == System.ComponentModel.LicenseUsageMode.Designtime)
                return true;
            else
            {
                Control ctrl = this;

                while (ctrl != null)
                {
                    if (ctrl.Site != null && ctrl.Site.DesignMode)
                        return true;
                    ctrl = ctrl.Parent;
                }

                return System.Diagnostics.Process.GetCurrentProcess().ProcessName == "devenv";
            }
        }

        private void WebView_Load(object sender, EventArgs e)
        {
            if (this.IsInDesignMode() == false)
            {

                this._WebViewControl = new WebView2Control(this.Handle);
                this._WebViewControl.Created += OnWebWindowCreated;
                this._WebViewControl.BeforeCreate += OnWebWindowBeforeCreate;
                this._WebViewControl.NavigateStart += OnNavigationStartIntern;
#if VS8355

                this._WebViewControl.AcceleratorKeyPressed += OnAcceleratorKeyPressedIntern;
                this._WebViewControl.ContainsFullScreenElementChanged += OnContainsFullScreenElementChangedIntern;
                this._WebViewControl.DocumentStateChanged += OnDocumentStateChangedIntern;
                this._WebViewControl.DocumentTitleChanged += OnDocumentTitleChangedIntern;
                this._WebViewControl.FrameNavigationStarting += OnFrameNavigationStartingIntern;
                this._WebViewControl.GotFocus += OnGotFocusIntern;
                this._WebViewControl.LostFocus += OnLostFocusIntern;
                this._WebViewControl.MoveFocusRequested += OnMoveFocusRequestedIntern;
                this._WebViewControl.NewWindowRequested += OnNewWindowRequestedIntern;
                this._WebViewControl.PermissionRequested += OnPermissionRequestedIntern;
                this._WebViewControl.ProcessFailed += OnProcessFailedIntern;
                this._WebViewControl.ScriptDialogOpening += OnScriptDialogOpeningIntern;
                this._WebViewControl.WebMessageReceived += OnWebMessageReceivedIntern;
                this._WebViewControl.WebResourceRequested += OnWebResourceRequestedIntern;
                this._WebViewControl.ZoomFactorChanged += OnZoomFactorChangedIntern;
                this._WebViewControl.ScriptToExecuteOnDocumentCreatedCompleted += ScriptToExecuteOnDocumentCreatedCompletedIntern;
                this._WebViewControl.ExecuteScriptCompleted += OnExecuteScriptCompletedIntern;
#endif

                this._WebViewControl.ContentLoading += OnContentLoadingIntern;
                this._WebViewControl.SourceChanged += OnSourceChangedIntern;
                this._WebViewControl.HistoryChanged += OnHistoryChangedIntern;
                this._WebViewControl.NavigationCompleted += OnNavigationCompletedIntern;


            }
        }

        


#if VS8355

        private void OnExecuteScriptCompletedIntern(object sender, ExecuteScriptCompletedEventArgs e)
        {
            OnExecuteScriptCompleted(e);
        }
        private void ScriptToExecuteOnDocumentCreatedCompletedIntern(object sender, AddScriptToExecuteOnDocumentCreatedCompletedEventArgs e)
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

            OnWebViewLostFocus(e);
        }
        private void OnGotFocusIntern(object sender, WebView2EventArgs e)
        {
            OnWebViewGotFocus(e);
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
#endif
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
#if VS8355

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

        
        protected virtual void OnScriptToExecuteOnDocumentCreatedCompleted(AddScriptToExecuteOnDocumentCreatedCompletedEventArgs e)
        {
            ScriptToExecuteOnDocumentCreatedCompleted?.Invoke(this, e);
        }
        protected virtual void OnExecuteScriptCompleted(ExecuteScriptCompletedEventArgs e)
        {
            ExecuteScriptCompleted?.Invoke(this, e);
        }
#endif


       
    }
}
