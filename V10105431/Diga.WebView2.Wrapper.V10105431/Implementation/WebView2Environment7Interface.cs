using System;
using System.Diagnostics;
using Diga.WebView2.Interop;

namespace Diga.WebView2.Wrapper.Implementation
{
    public class WebView2Environment7Interface : WebView2Environment6Interface, ICoreWebView2Environment7
    {
        private ICoreWebView2Environment7 _Environment;
        private ICoreWebView2Environment7 Environment
        {
            get
            {
                if (this._Environment == null)
                {
                    Debug.Print(nameof(WebView2Environment7Interface) + "." + nameof(this.Environment) + " is null");
                    throw new InvalidOperationException(nameof(WebView2Environment7Interface) + "." + nameof(this.Environment) + " is null");

                }
                return this._Environment;
            }
            set { this._Environment = value; }
        }

        public WebView2Environment7Interface(ICoreWebView2Environment7 environment):base(environment)
        {
                
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