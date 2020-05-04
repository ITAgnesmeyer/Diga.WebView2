using System;
using System.ComponentModel;
using System.Windows.Forms;
using Diga.WebView2.Wrapper;
using Diga.WebView2.Wrapper.EventArguments;
using Diga.WebView2.Wrapper.Types;

namespace WebView2WrapperWinFormsTest
{
    public partial class TestControl : UserControl
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
        public string HtmlContent
        {
            get=>_HtmlContent;
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
                    //this._WebWindow.Settings.IsZoomControlEnabled = new CBOOL(value);
                }
            }
        }

        public bool IsWebMessageEnabled
        {
            get { return _IsWebMessageEnabled; }
            set
            {
                _IsWebMessageEnabled = value;
                if (this.IsCreated)
                {
                    this._WebWindow.Settings.IsWebMessageEnabled = new CBOOL(value);
                }
            }
        }

        public bool IsStatusBarEnabled
        {
            get { return _IsStatusBarEnabled; }
            set
            {
                _IsStatusBarEnabled = value;
                if (this.IsCreated)
                {
                    this._WebWindow.Settings.IsStatusBarEnabled = new CBOOL(value);
                }
            }
        }

        public bool IsScriptEnabled
        {
            get { return _IsScriptEnabled; }
            set
            {
                _IsScriptEnabled = value;
                if (this.IsCreated)
                {
                    this._WebWindow.Settings.IsScriptEnabled = new CBOOL(value);
                }
            }
        }
        public bool RemoteObjectsAllowed
        {
            get
            {
                return _RemoteObjectsAllowed;
            }

            set
            {
                _RemoteObjectsAllowed = value;
                if (this.IsCreated)
                {
                    //this._WebWindow.Settings.AreRemoteObjectsAllowed = new CBOOL(value);
                }
            }
        }
        [Browsable(false)]
        public bool IsCreated { get; set; }

        public bool DevToolsEnabled
        {
            get
            {
                return _DevToolsEnabled;
            }
            set
            {
                _DevToolsEnabled = value;
                if (this.IsCreated)
                {
                    this._WebWindow.Settings.AreDevToolsEnabled = new CBOOL(value);
                }
            }
        }

        public bool DefaultScriptDialogsEnabled
        {
            get { return _DefaultScriptDialogsEnabled; }
            set
            {
                _DefaultScriptDialogsEnabled = value;
                if (this.IsCreated)
                {
                    this._WebWindow.Settings.AreDefaultScriptDialogsEnabled = new CBOOL(value);
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
                    this._WebWindow.Settings.AreDefaultContextMenusEnabled = new CBOOL(value);
                }
            }
        }
        public TestControl()
        {
            InitializeComponent();
        }

        private void TestControl_Load(object sender, EventArgs e)
        {
            if (this.IsInDesignMode() == false)
            {
               
                    _WebWindow = new WebView2Control(this.Handle);
                    _WebWindow.Created += OnWebWindowCreated;
                    _WebWindow.BeforeCreate += OnWebWindowBeforeCreate;

               
            }
        }

        private void OnWebWindowBeforeCreate(object sender, BeforeCreateEventArgs e)
        {
            e.Settings.AreDefaultContextMenusEnabled = new CBOOL(this._DefaultContextMenusEnabled);
            e.Settings.AreDefaultScriptDialogsEnabled = new CBOOL(this._DefaultScriptDialogsEnabled);
            e.Settings.AreDevToolsEnabled = new CBOOL(this._DevToolsEnabled);
            //e.Settings.AreRemoteObjectsAllowed = new CBOOL(this._RemoteObjectsAllowed);
            e.Settings.IsScriptEnabled = new CBOOL(this._IsScriptEnabled);
            e.Settings.IsStatusBarEnabled = new CBOOL(this._IsStatusBarEnabled);
            e.Settings.IsWebMessageEnabled = new CBOOL(this._IsWebMessageEnabled);
            //e.Settings.IsZoomControlEnabled = new CBOOL(this._IsZoomControlEnabled);
        }

        private void OnWebWindowCreated(object sender, EventArgs e)
        {
            this.IsCreated = true;
            if(!string.IsNullOrEmpty(this._Url))
                this.Navigate(this.Url);
            if(!string.IsNullOrEmpty(this._HtmlContent))
                this.NavigateToString(this._HtmlContent);

        }
        public void Navigate(string url)
        {
            this._Url = url;
            if (this.IsCreated && !string.IsNullOrEmpty(this.Url))
                this._WebWindow.Navigate(this._Url);
        }

        public void NavigateToString(string htmlContent)
        {
            _HtmlContent = htmlContent;
            if(this.IsCreated)
            {
                this._WebWindow.NavigateToString(_HtmlContent);
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
                    this._WebWindow.Navigate(_Url);
                }
            }
        }

        private void TestControl_Resize(object sender, EventArgs e)
        {
            if (this.IsCreated)
            {
                this._WebWindow.DockToParent();
            }
        }

        private bool IsInDesignMode()
        {
            if (System.ComponentModel.LicenseManager.UsageMode == System.ComponentModel.LicenseUsageMode.Designtime)
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
    }
}
