using Diga.WebView2.Interop;
using System;
using System.Diagnostics;
using Diga.WebView2.Wrapper.Types;
using Microsoft.Win32.SafeHandles;
using System.Runtime.InteropServices;

// ReSharper disable once CheckNamespace
namespace Diga.WebView2.Wrapper.Implementation
{
    
    public class WebView2Settings2Interface : WebView2SettingsInterface
    {
        private ComObjectHolder< ICoreWebView2Settings2> _Settings;

        private ICoreWebView2Settings2 Settings
        {
            get
            {
                if (this._Settings == null)
                {
                    Debug.Print(nameof(WebView2Settings2Interface) + "." + nameof(this.Settings) + " is null");
                    throw new InvalidOperationException(nameof(WebView2Settings2Interface) + "." + nameof(this.Settings) + " is null");

                }
                return this._Settings.Interface;
            }
            set
            {
                this._Settings = new ComObjectHolder<ICoreWebView2Settings2>(value);
            }
        }

        public WebView2Settings2Interface(ICoreWebView2Settings2 settings) : base(settings)
        {
            this.Settings = settings ?? throw new ArgumentNullException(nameof(settings));
        }

        public string UserAgent { get => this.Settings.UserAgent; set => this.Settings.UserAgent = value; }
        private bool _IsDisposed;
        protected override void Dispose(bool disposing)
        {
            if (this._IsDisposed) return;
            if (disposing)
            {
                this._Settings = null;
                this._IsDisposed = true;
            }


            base.Dispose(disposing);
        }
    }
}