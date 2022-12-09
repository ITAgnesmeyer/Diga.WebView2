using System;
using System.Diagnostics;
using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.Types;

namespace Diga.WebView2.Wrapper.Implementation
{
    public class WebView2Settings7Interface : WebView2Settings6Interface
    {
        private ComObjectHolder< ICoreWebView2Settings7> _Settings;
        private ICoreWebView2Settings7 Settings
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
            set => this._Settings = new ComObjectHolder<ICoreWebView2Settings7>(value);
        }

        public WebView2Settings7Interface(ICoreWebView2Settings7 settings) : base(settings)
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

        public COREWEBVIEW2_PDF_TOOLBAR_ITEMS HiddenPdfToolbarItems { get => this.Settings.HiddenPdfToolbarItems; set => this.Settings.HiddenPdfToolbarItems = value; }
    }
}