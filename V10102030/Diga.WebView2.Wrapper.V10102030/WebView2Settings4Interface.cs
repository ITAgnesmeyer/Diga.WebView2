using Diga.WebView2.Interop;
using System;
using System.Diagnostics;

// ReSharper disable once CheckNamespace
namespace Diga.WebView2.Wrapper
{
    public class WebView2Settings4Interface : WebView2Settings3Interface, ICoreWebView2Settings4
    {
        private ICoreWebView2Settings4 _Settings;
        private ICoreWebView2Settings4 Settings
        {
            get
            {
                if (_Settings == null)
                {
                    Debug.Print(nameof(WebView2Settings4Interface) + "." + nameof(Settings) + " is null");
                    throw new InvalidOperationException(nameof(WebView2Settings4Interface) + "." + nameof(Settings) + " is null");

                }
                return _Settings;
            }
            set
            {
                _Settings = value;
            }
        }
        public WebView2Settings4Interface(ICoreWebView2Settings4 settings) : base(settings)
        {
            if (settings == null)
                throw new ArgumentNullException(nameof(settings));

            this._Settings = settings;
        }

        public int IsPasswordAutosaveEnabled { get => Settings.IsPasswordAutosaveEnabled; set => Settings.IsPasswordAutosaveEnabled = value; }
        public int IsGeneralAutofillEnabled { get => Settings.IsGeneralAutofillEnabled; set => Settings.IsGeneralAutofillEnabled = value; }
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