using System;
using System.Diagnostics;
using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.Types;

namespace Diga.WebView2.Wrapper.Implementation
{
    public class WebView2Settings9Interface: WebView2Settings8Interface //, ICoreWebView2Settings9
    {
        private ComObjectHolder<ICoreWebView2Settings9> _Settings;
        private ICoreWebView2Settings9 Settings
        {
            get
            {
                if (this._Settings == null)
                {
                    Debug.Print(nameof(WebView2Settings9Interface) + "." + nameof(this.Settings) + " is null");
                    throw new InvalidOperationException(nameof(WebView2Settings9Interface) + "." + nameof(this.Settings) + " is null");

                }
                return this._Settings.Interface;
            }
            set => this._Settings = new ComObjectHolder<ICoreWebView2Settings9>(value);
        }
        public WebView2Settings9Interface(ICoreWebView2Settings9 settings) : base(settings)
        {
            this.Settings = settings ?? throw new ArgumentNullException(nameof(settings));
        }
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

        public int IsNonClientRegionSupportEnabled { get => Settings.IsNonClientRegionSupportEnabled; set => Settings.IsNonClientRegionSupportEnabled = value; }
    }
}