using Diga.WebView2.Interop;
using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using Diga.WebView2.Wrapper.Types;

namespace Diga.WebView2.Wrapper.Implementation
{
    public class WebView2Environment2Interface : WebView2EnvironmentInterface //, ICoreWebView2Environment2
    {
        private ComObjectHolder<ICoreWebView2Environment2> _Environment;
        private ICoreWebView2Environment2 Environment
        {
            get
            {
                if (this._Environment == null)
                {
                    Debug.Print(nameof(WebView2Environment2Interface) + "." + nameof(this.Environment) + " is null");
                    throw new InvalidOperationException(nameof(WebView2Environment2Interface) + "." + nameof(this.Environment) + " is null");

                }
                return this._Environment.Interface;
            }
            set => this._Environment = new ComObjectHolder<ICoreWebView2Environment2>(value);
        }

        public WebView2Environment2Interface(ICoreWebView2Environment2 environment) : base(environment)
        {
            this.Environment = environment ?? throw new ArgumentNullException(nameof(environment));
        }

        [return: MarshalAs(UnmanagedType.Interface)]
        public ICoreWebView2WebResourceRequest CreateWebResourceRequest([In, MarshalAs(UnmanagedType.LPWStr)] string uri, [In, MarshalAs(UnmanagedType.LPWStr)] string Method, [In, MarshalAs(UnmanagedType.Interface)] IStream postData, [In, MarshalAs(UnmanagedType.LPWStr)] string Headers)
        {
            return this.Environment.CreateWebResourceRequest(uri, Method, postData, Headers);
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