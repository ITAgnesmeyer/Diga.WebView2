using Diga.WebView2.Interop;
using System;
using System.Diagnostics;
using Diga.WebView2.Wrapper.Types;

// ReSharper disable once CheckNamespace
namespace Diga.WebView2.Wrapper.Implementation
{
    public class WebView2Settings4Interface : WebView2Settings3Interface
    {
        private ComObjectHolder< ICoreWebView2Settings4> _Settings;
        private ICoreWebView2Settings4 Settings
        {
            get
            {
                if (this._Settings == null)
                {
                    Debug.Print(nameof(WebView2Settings4Interface) + "." + nameof(this.Settings) + " is null");
                    throw new InvalidOperationException(nameof(WebView2Settings4Interface) + "." + nameof(this.Settings) + " is null");

                }
                return this._Settings.Interface;
            }
            set => this._Settings = new ComObjectHolder<ICoreWebView2Settings4>(value);
        }
        public WebView2Settings4Interface(ICoreWebView2Settings4 settings) : base(settings)
        {
            this.Settings = settings ?? throw new ArgumentNullException(nameof(settings));
        }

        public int IsPasswordAutosaveEnabled { get => this.Settings.IsPasswordAutosaveEnabled; set => this.Settings.IsPasswordAutosaveEnabled = value; }
        public int IsGeneralAutofillEnabled { get => this.Settings.IsGeneralAutofillEnabled; set => this.Settings.IsGeneralAutofillEnabled = value; }
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