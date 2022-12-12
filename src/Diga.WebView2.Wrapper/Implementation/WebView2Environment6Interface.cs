using Diga.WebView2.Interop;
using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Diga.WebView2.Wrapper.Types;

namespace Diga.WebView2.Wrapper.Implementation
{
    public class WebView2Environment6Interface : WebView2Environment5Interface//, ICoreWebView2Environment6
    {
        private ComObjectHolder< ICoreWebView2Environment6> _Environment;
        private ICoreWebView2Environment6 Environment
        {
            get
            {
                if (this._Environment == null)
                {
                    Debug.Print(nameof(WebView2Environment6Interface) + "." + nameof(this.Environment) + " is null");
                    throw new InvalidOperationException(nameof(WebView2Environment6Interface) + "." + nameof(this.Environment) + " is null");

                }
                return this._Environment.Interface;
            }
            set => this._Environment = new ComObjectHolder<ICoreWebView2Environment6>( value);
        }
        public WebView2Environment6Interface(ICoreWebView2Environment6 environment) : base(environment)
        {
            this.Environment = environment ?? throw new ArgumentNullException(nameof(environment));
        }

        [return: MarshalAs(UnmanagedType.Interface)]
        public ICoreWebView2PrintSettings CreatePrintSettings()
        {
            return this.Environment.CreatePrintSettings();
        }
        private bool _IsDisposed;
        protected override void Dispose(bool disposing)
        {
            if (this._IsDisposed) return;
            if (disposing)
            {
                this._Environment = null;
                this._IsDisposed = true;
            }
            base.Dispose(disposing);
        }
    }
}