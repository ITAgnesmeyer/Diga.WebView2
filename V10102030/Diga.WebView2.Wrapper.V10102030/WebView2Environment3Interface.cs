using Diga.WebView2.Interop;
using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace Diga.WebView2.Wrapper
{
    public class WebView2Environment3Interface : WebView2Environment2Interface, ICoreWebView2Environment3
    {
        private ICoreWebView2Environment3 _Environment;

        private ICoreWebView2Environment3 Environment
        {
            get
            {
                if (_Environment == null)
                {
                    Debug.Print(nameof(WebView2Environment3Interface) + "." + nameof(Environment) + " is null");
                    throw new InvalidOperationException(nameof(WebView2Environment3Interface) + "." + nameof(Environment) + " is null");

                }
                return _Environment;
            }
            set { _Environment = value; }
        }


        public WebView2Environment3Interface(ICoreWebView2Environment3 environment) : base(environment)
        {
            if (environment == null)
                throw new ArgumentNullException(nameof(environment));

            this._Environment = environment;
        }

        public void CreateCoreWebView2CompositionController(IntPtr ParentWindow, [MarshalAs(UnmanagedType.Interface)] ICoreWebView2CreateCoreWebView2CompositionControllerCompletedHandler handler)
        {
            Environment.CreateCoreWebView2CompositionController(ParentWindow, handler);
        }

        [return: MarshalAs(UnmanagedType.Interface)]
        public ICoreWebView2PointerInfo CreateCoreWebView2PointerInfo()
        {
            return Environment.CreateCoreWebView2PointerInfo();
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