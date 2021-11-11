using Diga.WebView2.Interop;
using System;
using System.Diagnostics;

// ReSharper disable once CheckNamespace
namespace Diga.WebView2.Wrapper
{
    public class WebView2Settings5Interface : WebView2Settings4Interface, ICoreWebView2Settings5
    {
        private ICoreWebView2Settings5 _Settings;
        private ICoreWebView2Settings5 Settings
        {
            get
            {
                if (_Settings == null)
                {
                    Debug.Print(nameof(WebView2Settings5Interface) + "." + nameof(Settings) + " is null");
                    throw new InvalidOperationException(nameof(WebView2Settings5Interface) + "." + nameof(Settings) + " is null");

                }
                return _Settings;
            }
            set
            {
                _Settings = value;
            }
        }
        public WebView2Settings5Interface(ICoreWebView2Settings5 settings) : base(settings)
        {
            if (settings == null)
                throw new ArgumentNullException(nameof(settings));

            this._Settings = settings;
        }

        public int IsPinchZoomEnabled { get => Settings.IsPinchZoomEnabled; set => Settings.IsPinchZoomEnabled = value; }
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