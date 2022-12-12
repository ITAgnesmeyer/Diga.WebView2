using System;
using System.Diagnostics;
using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.Types;

namespace Diga.WebView2.Wrapper.Implementation
{
    public class WebView2Environment7Interface : WebView2Environment6Interface //, ICoreWebView2Environment7
    {
        private ComObjectHolder< ICoreWebView2Environment7> _Environment;
        private ICoreWebView2Environment7 Environment
        {
            get
            {
                if (this._Environment == null)
                {
                    Debug.Print(nameof(WebView2Environment7Interface) + "." + nameof(this.Environment) + " is null");
                    throw new InvalidOperationException(nameof(WebView2Environment7Interface) + "." + nameof(this.Environment) + " is null");

                }
                return this._Environment.Interface;
            }
            set { this._Environment = new ComObjectHolder<ICoreWebView2Environment7>(value); }
        }

        public WebView2Environment7Interface(ICoreWebView2Environment7 environment):base(environment)
        {
            this.Environment = environment ?? throw new ArgumentNullException(nameof(environment));
        }

        public string UserDataFolder => this.Environment.UserDataFolder;
        private bool _IsDisposed;
        protected override void Dispose(bool disposing)
        {
            if (this._IsDisposed) return;
            if (disposing)
            {
                this._Environment = null;
                this._IsDisposed = true;
            }
        }
    }
}