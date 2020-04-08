using System;
using System.ComponentModel;
using System.Windows.Forms;
using Diga.WebView2.Wrapper;
using Diga.WebView2.Wrapper.EventArguments;

namespace Diga.WebView2.WinForms
{
    public partial class WebView : UserControl
    {
        private WebView2Control _WebWindow;
        private bool _DefaultContextMenusEnabled;
        private string _Url;
        private bool _DefaultScriptDialogsEnabled = true;
        private bool _DevToolsEnabled = true;
        private bool _RemoteObjectsAllowed = true;
        private bool _IsScriptEnabled = true;

        private bool _IsStatusBarEnabled;
        private bool _IsWebMessageEnabled = true;
        private bool _IsZoomControlEnabled = true;
        private string _HtmlContent;
        public event EventHandler<NavigationStartingEventArgs> NavigationStart;
        public event EventHandler<ContentLoadingEventArgs> ContentLoading;
        public event EventHandler<SourceChangedEventArgs> SourceChanged;
        public event EventHandler<WebView2EventArgs> HistoryChanged;
        public event EventHandler<NavigationCompletedEventArgs> NavigationCompleted;
        public string HtmlContent
        {
            get => _HtmlContent;
            set
            {

                this.NavigateToString(value);

            }
        }
        public bool IsZoomControlEnabled
        {
            get { return _IsZoomControlEnabled; }
            set
            {
                _IsZoomControlEnabled = value;
                if (this.IsCreated)
                {
                    this._WebWindow.Settings.IsZoomControlEnabled = new BOOL(value);
                }
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
                    this._WebWindow.Settings.IsWebMessageEnabled = new BOOL(value);
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
                    this._WebWindow.Settings.IsStatusBarEnabled = new BOOL(value);
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
                    this._WebWindow.Settings.IsScriptEnabled = new BOOL(value);
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
                    this._WebWindow.Settings.AreRemoteObjectsAllowed = new BOOL(value);
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
                    this._WebWindow.Settings.AreDevToolsEnabled = new BOOL(value);
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
                    this._WebWindow.Settings.AreDefaultScriptDialogsEnabled = new BOOL(value);
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
                    this._WebWindow.Settings.AreDefaultContextMenusEnabled = new BOOL(value);
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
                    return this._WebWindow.Source;
                }

                return "";
            }
        }


        private void OnWebWindowBeforeCreate(object sender, BeforeCreateEventArgs e)
        {
            e.Settings.AreDefaultContextMenusEnabled = new BOOL(this._DefaultContextMenusEnabled);
            e.Settings.AreDefaultScriptDialogsEnabled = new BOOL(this._DefaultScriptDialogsEnabled);
            e.Settings.AreDevToolsEnabled = new BOOL(this._DevToolsEnabled);
            e.Settings.AreRemoteObjectsAllowed = new BOOL(this._RemoteObjectsAllowed);
            e.Settings.IsScriptEnabled = new BOOL(this._IsScriptEnabled);
            e.Settings.IsStatusBarEnabled = new BOOL(this._IsStatusBarEnabled);
            e.Settings.IsWebMessageEnabled = new BOOL(this._IsWebMessageEnabled);
            e.Settings.IsZoomControlEnabled = new BOOL(this._IsZoomControlEnabled);
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
                    this._WebWindow.Navigate(this._Url);
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
                    this._WebWindow.NavigateToString(_HtmlContent);
                }
                catch (Exception e)
                {
                    MessageBox.Show(this, e.Message, "Navigation Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            if(!this.IsCreated) return;
            if (this._WebWindow.CanGoBack)
                this._WebWindow.GoBack();
        }

        public void GoForward()
        {
            if(!this.IsCreated) return;
            if (this._WebWindow.CanGoForward)
                this._WebWindow.GoForward();
        }
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

                _WebWindow = new WebView2Control(this.Handle);
                _WebWindow.Created += OnWebWindowCreated;
                _WebWindow.BeforeCreate += OnWebWindowBeforeCreate;
                _WebWindow.NavigateStart += OnNavigationStartIntern;
                _WebWindow.ContentLoading += OnContentLoadingIntern;
                _WebWindow.SourceChanged += OnSourceChangedIntern;
                _WebWindow.HistoryChanged+=OnHistoryChangedIntern;
                _WebWindow.NavigationCompleted += OnNavigationCompletedIntern;


            }
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
                this._WebWindow.DockToParent();
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
    }
}
