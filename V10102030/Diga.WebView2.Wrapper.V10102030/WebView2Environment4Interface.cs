using Diga.WebView2.Interop;
using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace Diga.WebView2.Wrapper
{
    public class WebView2Environment4Interface : WebView2Environment3Interface, ICoreWebView2Environment4
    {
        private ICoreWebView2Environment4 _Environment;
        private ICoreWebView2Environment4 Environment
        {
            get
            {
                if (_Environment == null)
                {
                    Debug.Print(nameof(WebView2Environment4Interface) + "." + nameof(Environment) + " is null");
                    throw new InvalidOperationException(nameof(WebView2Environment4Interface) + "." + nameof(Environment) + " is null");

                }
                return _Environment;
            }
            set { _Environment = value; }
        }

        public WebView2Environment4Interface(ICoreWebView2Environment4 environment) : base(environment)
        {
            if (environment == null)
                throw new ArgumentNullException(nameof(environment));

            this._Environment = environment;
        }

        [return: MarshalAs(UnmanagedType.IUnknown)]
        public object GetProviderForHwnd(IntPtr hwnd)
        {
            return Environment.GetProviderForHwnd(hwnd);
        }
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                this._Environment = null;
            }
            base.Dispose(disposing);
        }
    }
}