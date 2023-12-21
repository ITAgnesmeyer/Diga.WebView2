using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.Types;

namespace Diga.WebView2.Wrapper.Implementation
{


    public class WebView2Environment12Interface : WebView2Environment11Interface //, ICoreWebView2Environment12
    {
        private ComObjectHolder<ICoreWebView2Environment12> _Environment;
        private ICoreWebView2Environment12 Environment
        {
            get
            {
                if (this._Environment == null)
                {
                    Debug.Print(nameof(WebView2Environment12Interface) + "." + nameof(this.Environment) + " is null");
                    throw new InvalidOperationException(nameof(WebView2Environment12Interface) + "." + nameof(this.Environment) + " is null");

                }
                return this._Environment.Interface;
            }
            set => this._Environment = new ComObjectHolder<ICoreWebView2Environment12>(value);
        }
        public WebView2Environment12Interface(ICoreWebView2Environment12 environment) :
            base(environment)
        {

        }

        [return: MarshalAs(UnmanagedType.Interface)]
        public ICoreWebView2SharedBuffer CreateSharedBuffer([In] ulong Size)
        {
            return this.Environment.CreateSharedBuffer(Size);
        }
    }
}