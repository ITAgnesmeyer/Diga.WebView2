﻿using System.Collections.Generic;
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

        private Color _DefaultBackgroundColor = Color.Empty;


        #region Public Properties

        [Editor(typeof(FolderNameEditor), typeof(System.Drawing.Design.UITypeEditor))]
        public string MonitoringFolder { get; set; }

        public string MonitoringUrl { get; set; }
        public bool EnableMonitoring { get; set; }

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

        public Task<string> PageSource => GetDocumentText();

        [Browsable(false)]
        public string DocumentTitle
        {
            get => this._WebViewControl.DocumentTitle;
        }

        public string HtmlContent
        {
            get => this._HtmlContent;
            set => NavigateToString(value);
        }

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

        [Browsable(false)] public bool IsCreated { get; private set; }

        [Browsable(false)] public bool IsBrowserEnded { get; private set; }

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

        #endregion
    }
}