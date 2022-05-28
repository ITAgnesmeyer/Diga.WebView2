using Diga.WebView2.Interop;
using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;

namespace Diga.WebView2.Wrapper.Implementation
{
    public class WebView2Environment2Interface : WebView2EnvironmentInterface, ICoreWebView2Environment2
    {
        private object _Environment;
        private ICoreWebView2Environment2 Environment
        {
            get
            {
                if (_Environment == null)
                {
                    Debug.Print(nameof(WebView2Environment2Interface) + "." + nameof(Environment) + " is null");
                    throw new InvalidOperationException(nameof(WebView2Environment2Interface) + "." + nameof(Environment) + " is null");

                }
                return (ICoreWebView2Environment2)_Environment;
            }
            set { _Environment = value; }
        }

        public WebView2Environment2Interface(ICoreWebView2Environment2 environment) : base(environment)
        {
            if (environment == null)
                throw new ArgumentNullException(nameof(environment));
            _Environment = environment;
        }

        [return: MarshalAs(UnmanagedType.Interface)]
        public ICoreWebView2WebResourceRequest CreateWebResourceRequest([In, MarshalAs(UnmanagedType.LPWStr)] string uri, [In, MarshalAs(UnmanagedType.LPWStr)] string Method, [In, MarshalAs(UnmanagedType.Interface)] IStream postData, [In, MarshalAs(UnmanagedType.LPWStr)] string Headers)
        {
            return Environment.CreateWebResourceRequest(uri, Method, postData, Headers);
        }
        private bool _IsDisposed;
        protected override void Dispose(bool disposing)
        {
            if (_IsDisposed) return;
            if (disposing)
            {
                _Environment = null;
                _IsDisposed = true;
            }
            base.Dispose(disposing);
        }
    }
}