using Diga.WebView2.Interop;
using System;
using System.Diagnostics;
using Diga.WebView2.Wrapper.Types;

// ReSharper disable once CheckNamespace
namespace Diga.WebView2.Wrapper.Implementation
{
    public class WebView2Settings6Interface : WebView2Settings5Interface
    {
        private ComObjectHolder< ICoreWebView2Settings6> _Settings;
        private ICoreWebView2Settings6 Settings
        {
            get
            {
                if (this._Settings == null)
                {
                    Debug.Print(nameof(WebView2Settings6Interface) + "." + nameof(this.Settings) + " is null");
                    throw new InvalidOperationException(nameof(WebView2Settings6Interface) + "." + nameof(this.Settings) + " is null");

                }
                return this._Settings.Interface;
            }
            set => this._Settings = new ComObjectHolder<ICoreWebView2Settings6>(value);
        }

        public WebView2Settings6Interface(ICoreWebView2Settings6 settings) : base(settings)
        {
            this.Settings = settings ?? throw new ArgumentNullException(nameof(settings));
        }

        public int IsSwipeNavigationEnabled { get => this.Settings.IsSwipeNavigationEnabled; set => this.Settings.IsSwipeNavigationEnabled = value; }
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