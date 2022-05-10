using System;
using System.Diagnostics;
using Diga.WebView2.Interop;

namespace Diga.WebView2.Wrapper.Implementation
{
    public class WebView2Settings7Interface : WebView2Settings6Interface, ICoreWebView2Settings7
    {
        private ICoreWebView2Settings7 _Settings;
        private ICoreWebView2Settings7 Settings
        {
            get
            {
                if (this._Settings == null)
                {
                    Debug.Print(nameof(WebView2Settings5Interface) + "." + nameof(this.Settings) + " is null");
                    throw new InvalidOperationException(nameof(WebView2Settings5Interface) + "." + nameof(this.Settings) + " is null");

                }
                return this._Settings;
            }
            set
            {
                this._Settings = value;
            }
        }

        public WebView2Settings7Interface(ICoreWebView2Settings7 settings) : base(settings)
        {
            if (settings == null)
                throw new ArgumentNullException(nameof(settings));

            this._Settings = settings;
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

        public COREWEBVIEW2_PDF_TOOLBAR_ITEMS HiddenPdfToolbarItems { get => this.Settings.HiddenPdfToolbarItems; set => this.Settings.HiddenPdfToolbarItems = value; }
    }
}