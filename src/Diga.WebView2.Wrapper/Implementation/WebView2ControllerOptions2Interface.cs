using System;
using System.Diagnostics;
using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.Types;

namespace Diga.WebView2.Wrapper.Implementation
{
    public class WebView2ControllerOptions2Interface : WebView2ControllerOptionsInterface //, ICoreWebView2ControllerOptions2
    {
        private ComObjectHolder<ICoreWebView2ControllerOptions2> _Options;
        private bool _IsDesposed;
        private ICoreWebView2ControllerOptions2 Options
        {
            get
            {
                if (this._Options == null)
                {
                    Debug.Print(nameof(WebView2ControllerOptionsInterface) + "WebView2ControllerOptions2Interface is null");

                    throw new InvalidOperationException("WebView2ControllerOptions2Interface is null!");
                }

                return this._Options.Interface;
            }
            set => this._Options = new ComObjectHolder<ICoreWebView2ControllerOptions2>(value);
        }
        public WebView2ControllerOptions2Interface(ICoreWebView2ControllerOptions2 options):base(options)
        {
            this.Options = options ?? throw new ArgumentNullException(nameof(options));
        }

        public string ScriptLocale { get => this.Options.ScriptLocale; set => this.Options.ScriptLocale = value; }
        protected override void Dispose(bool disposing)
        {
            if (!this._IsDesposed)
            {
                if (disposing)
                {
                    this._Options = null;
                }
                this._IsDesposed = true;
            }

            base.Dispose(disposing);
        }
    }
}