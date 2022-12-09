using Diga.WebView2.Interop;
using System;
using System.Diagnostics;
using Diga.WebView2.Wrapper.Types;

// ReSharper disable once CheckNamespace
namespace Diga.WebView2.Wrapper.Implementation
{
    public class WebView2Settings5Interface : WebView2Settings4Interface
    {
        private ComObjectHolder< ICoreWebView2Settings5> _Settings;
        private ICoreWebView2Settings5 Settings
        {
            get
            {
                if (this._Settings == null)
                {
                    Debug.Print(nameof(WebView2Settings5Interface) + "." + nameof(this.Settings) + " is null");
                    throw new InvalidOperationException(nameof(WebView2Settings5Interface) + "." + nameof(this.Settings) + " is null");

                }
                return this._Settings.Interface;
            }
            set => this._Settings = new ComObjectHolder<ICoreWebView2Settings5>(value);
        }
        public WebView2Settings5Interface(ICoreWebView2Settings5 settings) : base(settings)
        {
            this.Settings = settings ?? throw new ArgumentNullException(nameof(settings));
        }

        public int IsPinchZoomEnabled { get => this.Settings.IsPinchZoomEnabled; set => this.Settings.IsPinchZoomEnabled = value; }
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