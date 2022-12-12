using Diga.WebView2.Interop;
using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Diga.WebView2.Wrapper.Types;

namespace Diga.WebView2.Wrapper.Implementation
{
    public class WebView2Environment4Interface : WebView2Environment3Interface //, ICoreWebView2Environment4
    {
        private ComObjectHolder< ICoreWebView2Environment4> _Environment;
        private ICoreWebView2Environment4 Environment
        {
            get
            {
                if (this._Environment == null)
                {
                    Debug.Print(nameof(WebView2Environment4Interface) + "." + nameof(this.Environment) + " is null");
                    throw new InvalidOperationException(nameof(WebView2Environment4Interface) + "." + nameof(this.Environment) + " is null");

                }
                return this._Environment.Interface;
            }
            set => this._Environment = new ComObjectHolder<ICoreWebView2Environment4>( value);
        }

        public WebView2Environment4Interface(ICoreWebView2Environment4 environment) : base(environment)
        {
            this.Environment = environment ?? throw new ArgumentNullException(nameof(environment));
        }

        [return: MarshalAs(UnmanagedType.IUnknown)]
        public object GetProviderForHwnd(IntPtr hwnd)
        {
            return this.Environment.GetProviderForHwnd(hwnd);
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