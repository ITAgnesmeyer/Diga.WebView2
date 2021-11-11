using Diga.WebView2.Interop;
using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace Diga.WebView2.Wrapper
{
    public class WebView2Environment6Interface : WebView2Environment5Interface, ICoreWebView2Environment6
    {
        private ICoreWebView2Environment6 _Environment;
        private ICoreWebView2Environment6 Environment
        {
            get
            {
                if (_Environment == null)
                {
                    Debug.Print(nameof(WebView2Environment6Interface) + "." + nameof(Environment) + " is null");
                    throw new InvalidOperationException(nameof(WebView2Environment6Interface) + "." + nameof(Environment) + " is null");

                }
                return _Environment;
            }
            set { _Environment = value; }
        }
        public WebView2Environment6Interface(ICoreWebView2Environment6 environment) : base(environment)
        {
              if(environment == null)
                throw new ArgumentNullException(nameof(environment));

            this.Environment = environment;
        }

        [return: MarshalAs(UnmanagedType.Interface)]
        public ICoreWebView2PrintSettings CreatePrintSettings()
        {
            return Environment.CreatePrintSettings();
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