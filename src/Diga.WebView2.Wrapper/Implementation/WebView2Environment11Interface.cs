using System;
using System.Diagnostics;
using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.Types;

namespace Diga.WebView2.Wrapper.Implementation
{
    public class WebView2Environment11Interface : WebView2Environment10Interface //, ICoreWebView2Environment11
    {
        private ComObjectHolder<ICoreWebView2Environment11> _Environment;

        private ICoreWebView2Environment11 Environment
        {
            get
            {
                if (this._Environment == null)
                {
                    Debug.Print(nameof(WebView2Environment11Interface) + "." + nameof(this.Environment) + " is null");
                    throw new InvalidOperationException(nameof(WebView2Environment11Interface) + "." + nameof(this.Environment) + " is null");

                }
                return this._Environment.Interface;
            }
            set => this._Environment = new ComObjectHolder<ICoreWebView2Environment11>(value);
        }

        public WebView2Environment11Interface(ICoreWebView2Environment11 environment) : base(environment)
        {
            this.Environment = environment ?? throw new ArgumentNullException(nameof(environment));
        }

        public string FailureReportFolderPath => this.Environment.FailureReportFolderPath;
    }
}