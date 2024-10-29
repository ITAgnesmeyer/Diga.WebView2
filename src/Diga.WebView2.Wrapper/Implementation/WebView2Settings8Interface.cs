using System;
using System.Diagnostics;
using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.Types;

namespace Diga.WebView2.Wrapper.Implementation
{
    public class WebView2Settings8Interface : WebView2Settings7Interface //, ICoreWebView2Settings8
    {
        private ComObjectHolder< ICoreWebView2Settings8> _Settings;

        private ICoreWebView2Settings8 Settings
        {
            get
            {
                if (this._Settings == null)
                {
                    Debug.Print(nameof(WebView2Settings8Interface) + "." + nameof(this.Settings) + " is null");
                    throw new InvalidOperationException(nameof(WebView2Settings8Interface) + "." + nameof(this.Settings) + " is null");

                }
                return this._Settings.Interface;
            }
            set => this._Settings = new ComObjectHolder<ICoreWebView2Settings8>(value);
        }
        public WebView2Settings8Interface(ICoreWebView2Settings8 settings) : base(settings)
        {
            this.Settings = settings ?? throw new ArgumentNullException(nameof(settings));
        }
        public int IsReputationCheckingRequired { get => this.Settings.IsReputationCheckingRequired; set => this.Settings.IsReputationCheckingRequired = value; }

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