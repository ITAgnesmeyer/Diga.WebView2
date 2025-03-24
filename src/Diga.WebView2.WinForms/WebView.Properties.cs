using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Threading.Tasks;
using Diga.WebView2.Wrapper;


namespace Diga.WebView2.WinForms
{
    public partial class WebView
    {
        private bool _DefaultContextMenusEnabled;
        private string _Url;
        private bool _DefaultScriptDialogsEnabled = true;
        private bool _DevToolsEnabled = true;

        private bool _RemoteObjectsAllowed = true;
        private bool _IsZoomControlEnabled = true;

        private bool _IsScriptEnabled = true;
        private bool _IsStatusBarEnabled;
        private bool _IsWebMessageEnabled = true;
        private bool _AreBrowserAcceleratorKeysEnabled = true;
        private bool _IsGeneralAutoFillEnabled;
        private bool _IsPasswordAutosaveEnabled;

        private string _HtmlContent;
        private double _ZoomFactor;
        private string _ProfileName;
        private bool _ProfileInPrivateModeEnabled;


        private Color _DefaultBackgroundColor = Color.Empty;

        private SchemeRegistration[] _SchemeRegistrations;

        #region Public Properties
        private string _MonitoringFolder;
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Editor(typeof(FolderNameEditor), typeof(System.Drawing.Design.UITypeEditor))]
        public string MonitoringFolder
        {
            get
            {
                return _MonitoringFolder;
            }
            set
            {
                _MonitoringFolder = value;
                this._MonitoringActionList.FileMonitoring.SetMonitoringFolder(_MonitoringFolder);
            }
        }
        private string _MonitoringUrl;
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string MonitoringUrl
        {
            get
            {
                return _MonitoringUrl;
            }
            set
            {
                _MonitoringUrl = value;

                this._MonitoringActionList.FileMonitoring.SetMonitoringUrl(_MonitoringUrl);
            }
        }

        private bool _EnableMonitoring;
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public bool EnableMonitoring
        {
            get
            {
                return this._EnableMonitoring; 

            }
            set
            {
                this._EnableMonitoring = value; 
                this._MonitoringActionList.FileMonitoring.SetIsEnabled(value);
            }
        }

        private bool _EnableCgi;
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public bool EnableCgi
        {
            get
            {
                return this._EnableCgi;
            }
            set
            {
                this._EnableCgi = value;
                this._MonitoringActionList.CgiMointoring.SetIsEnabled(value);
            }
        }

        private string _CgiMonitoringUrl;
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string CgiMoitoringUrl
        {
            get
            {
                return this._CgiMonitoringUrl;
            }
            set
            {
                this._CgiMonitoringUrl = value;
                this._MonitoringActionList.CgiMointoring.SetMonitoringUrl(value);
            }
        }

        private string _CgiMoitoringFolder;
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Editor(typeof(FolderNameEditor), typeof(System.Drawing.Design.UITypeEditor))]
        public string CgiMoitoringFolder
        {
            get
            {
                return _CgiMoitoringFolder;
            }
            set
            {
                this._CgiMoitoringFolder = value;
                this._MonitoringActionList.CgiMointoring.SetMonitoringFolder(value);
            }
        }

        private string[] _CgiFileExtensions;
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string[] CgiFileExtensions
        {
            get
            {
                return this._CgiFileExtensions;
            }
            set
            {
                this._CgiFileExtensions = value;
                this._MonitoringActionList.CgiMointoring.SetCgiExtionsions(value);

            }
        }
        private string _CgiExeFile;
        [Editor(typeof(ExeSelectFileNameEditor), typeof(System.Drawing.Design.UITypeEditor))]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string CgiExeFile
        {
            get
            {
                return this._CgiExeFile;
            }
            set
            {
                this._CgiExeFile = value;
                this._MonitoringActionList.CgiMointoring.SetCgiExeFile(value);
            }
        }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string Url
        {
            get => this._Url;
            set
            {
                this._Url = value;
                if (this.CheckIsCreatedOrEnded)
                {
                    Navigate(value);
                }
            }
        }

        public List<string> Content
        {
            get
            {
                if (!this.CheckIsCreatedOrEnded)
                {
                    return new List<string>();
                }

                return this._WebViewControl.Content;
            }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Color DefaultBackgroundColor
        {
            get
            {
                if (this.CheckIsCreatedOrEnded)
                {
                    this._DefaultBackgroundColor = this._WebViewControl.DefaultBackgroundColor;
                }

                return this._DefaultBackgroundColor;
            }
            set
            {
                this._DefaultBackgroundColor = value;
                if (this.CheckIsCreatedOrEnded)
                {
                    this._WebViewControl.DefaultBackgroundColor = this._DefaultBackgroundColor;
                }
            }
        }

        public Task<string> PageSource => GetDocumentTextAsync();

        [Browsable(false)]
        public string DocumentTitle
        {
            get => this._WebViewControl.DocumentTitle;
        }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string HtmlContent
        {
            get => this._HtmlContent;
            set => NavigateToString(value);
        }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public bool IsZoomControlEnabled
        {
            get => this._IsZoomControlEnabled;
            set
            {
                this._IsZoomControlEnabled = value;
                if (this.CheckIsCreatedOrEnded)
                {
                    this._WebViewControl.Settings.IsZoomControlEnabled = value;
                }
            }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public bool IsPasswordAutosaveEnabled
        {
            get => this._IsPasswordAutosaveEnabled;
            set
            {
                this._IsPasswordAutosaveEnabled = value;
                if (this.CheckIsCreatedOrEnded)
                {
                    this._WebViewControl.Settings.IsPasswordAutosaveEnabled = value;
                }
            }
        }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public bool IsGeneralAutoFillEnabled
        {
            get => this._IsGeneralAutoFillEnabled;
            set
            {
                this._IsGeneralAutoFillEnabled = value;
                if (this.CheckIsCreatedOrEnded)
                {
                    if (this._WebViewControl.Settings != null)
                        this._WebViewControl.Settings.IsGeneralAutofillEnabled = value;
                }
            }
        }

        private bool _IsMuted;
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public bool IsMuted
        {
            get => this._IsMuted;
            set
            {
                this._IsMuted = value;
                if (this.CheckIsCreatedOrEnded)
                {
                    this._WebViewControl.IsMuted = this._IsMuted;
                }
            }
        }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public bool AreBrowserAcceleratorKeysEnabled
        {
            get => this._AreBrowserAcceleratorKeysEnabled;
            set
            {
                this._AreBrowserAcceleratorKeysEnabled = value;
                if (this.CheckIsCreatedOrEnded)
                    this._WebViewControl.Settings.AreBrowserAcceleratorKeysEnabled = value;
            }
        }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public bool IsWebMessageEnabled
        {
            get => this._IsWebMessageEnabled;
            set
            {
                this._IsWebMessageEnabled = value;
                if (this.CheckIsCreatedOrEnded)
                {
                    this._WebViewControl.Settings.IsWebMessageEnabled = value;
                }
            }
        }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public bool IsStatusBarEnabled
        {
            get => this._IsStatusBarEnabled;
            set
            {
                this._IsStatusBarEnabled = value;
                if (this.CheckIsCreatedOrEnded)
                {
                    this._WebViewControl.Settings.IsStatusBarEnabled = value;
                }
            }
        }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public bool IsScriptEnabled
        {
            get => this._IsScriptEnabled;
            set
            {
                this._IsScriptEnabled = value;
                if (this.CheckIsCreatedOrEnded)
                {
                    this._WebViewControl.Settings.IsScriptEnabled = value;
                }
            }
        }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public bool RemoteObjectsAllowed
        {
            get => this._RemoteObjectsAllowed;

            set
            {
                this._RemoteObjectsAllowed = value;
                if (this.CheckIsCreatedOrEnded)
                {
                    this._WebViewControl.Settings.AreHostObjectsAllowed = value;
                }
            }
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsCreated { get; private set; }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsBrowserEnded { get; private set; }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public bool DevToolsEnabled
        {
            get => this._DevToolsEnabled;
            set
            {
                this._DevToolsEnabled = value;
                if (this.CheckIsCreatedOrEnded)
                {
                    this._WebViewControl.Settings.AreDevToolsEnabled = value;
                }
            }
        }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public bool DefaultScriptDialogsEnabled
        {
            get => this._DefaultScriptDialogsEnabled;
            set
            {
                this._DefaultScriptDialogsEnabled = value;
                if (this.CheckIsCreatedOrEnded)
                {
                    this._WebViewControl.Settings.AreDefaultScriptDialogsEnabled = value;
                }
            }
        }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public bool DefaultContextMenusEnabled
        {
            get => this._DefaultContextMenusEnabled;
            set
            {
                this._DefaultContextMenusEnabled = value;
                if (this.CheckIsCreatedOrEnded)
                {
                    this._WebViewControl.Settings.AreDefaultContextMenusEnabled = value;
                }
            }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string ProfileName
        {
            get => this._ProfileName;
            set
            {
                this._ProfileName = value;
                if (this.CheckIsCreatedOrEnded)
                {
                    this._WebViewControl.ProfileName = value;
                }
            }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public bool ProfileNameInPrivateModeEnabled
        {
            get => this._ProfileInPrivateModeEnabled;
            set
            {
                this._ProfileInPrivateModeEnabled = value;
                if (this.CheckIsCreatedOrEnded)
                {
                    this._WebViewControl.ProfileInPrivateMode = value;
                }
            }
        }
        private string _BrowserExecutableFolder;
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string BrowserExecutableFolder
        {
            get => this._BrowserExecutableFolder;
            set
            {
                this._BrowserExecutableFolder = value;
                if (this.CheckIsCreatedOrEnded)
                {
                    this._BrowserExecutableFolder = value;
                }
            }
        }

        private string _UserDataFolder;
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string UserDataFolder
        {
            get => this._UserDataFolder;
            set
            {
                this._UserDataFolder = value;
                if (this.CheckIsCreatedOrEnded)
                {
                    this._UserDataFolder = value;
                }
            }
        }

        private string _AdditionalBrowserArguments;

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string AdditionalBrowserArguments
        {
            get => this._AdditionalBrowserArguments;
            set
            {
                this._AdditionalBrowserArguments = value;
                if (this.CheckIsCreatedOrEnded)
                {
                    this._AdditionalBrowserArguments = value;
                }
            }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public double ZoomFactor
        {
            get
            {
                if (this.CheckIsCreatedOrEnded)
                {
                    this._ZoomFactor = this._WebViewControl.ZoomFactor;
                }

                return this._ZoomFactor;
            }
            set
            {
                this._ZoomFactor = value;
                if (this.CheckIsCreatedOrEnded)
                {
                    this._WebViewControl.ZoomFactor = this._ZoomFactor;
                }
            }
        }


        public string Source
        {
            get
            {
                if (this.CheckIsCreatedOrEnded)
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
                if (this.CheckIsCreatedOrEnded)
                    return this._WebViewControl.GetCookieManager;
                return null;
            }
        }


        public WebView2Profile Profile => this._WebViewControl.Profile;

        public WebView2Environment Environment => this._WebViewControl.Environment;
        public WebView2View WebView2 => this._WebViewControl.WebView;
        
        public WebView2CompositionController CompositionController => this._WebViewControl.CompositionController;
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public SchemeRegistration[] SchemeRegistrations
        {
            get => this._SchemeRegistrations;
            set => this._SchemeRegistrations = value;
        }
        #endregion
    }
}