using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.Types;

namespace Diga.WebView2.Wrapper.Implementation
{
    public class WebView2Environment10Interface : WebView2Environment9Interface //, ICoreWebView2Environment10
    {
        private ComObjectHolder< ICoreWebView2Environment10> _Environment;
        private ICoreWebView2Environment10 Environment
        {
            get
            {
                if (this._Environment == null)
                {
                    Debug.Print(nameof(WebView2Environment10Interface) + "." + nameof(this.Environment) + " is null");
                    throw new InvalidOperationException(nameof(WebView2Environment10Interface) + "." + nameof(this.Environment) + " is null");

                }
                return this._Environment.Interface;
            }
            set { this._Environment = new ComObjectHolder<ICoreWebView2Environment10>(value); }
        }

        public WebView2Environment10Interface(ICoreWebView2Environment10 environment):base(environment)
        {
            this.Environment = environment ?? throw new ArgumentNullException(nameof(environment));  
        }

        [return: MarshalAs(UnmanagedType.Interface)]
        public ICoreWebView2ControllerOptions CreateCoreWebView2ControllerOptions()
        {
            return this.Environment.CreateCoreWebView2ControllerOptions();
        }

        public void CreateCoreWebView2ControllerWithOptions(IntPtr ParentWindow, [In, MarshalAs(UnmanagedType.Interface)] ICoreWebView2ControllerOptions options, [In, MarshalAs(UnmanagedType.Interface)] ICoreWebView2CreateCoreWebView2ControllerCompletedHandler handler)
        {
            this.Environment.CreateCoreWebView2ControllerWithOptions(ParentWindow, options, handler);
        }

        public void CreateCoreWebView2CompositionControllerWithOptions(IntPtr ParentWindow, [In, MarshalAs(UnmanagedType.Interface)] ICoreWebView2ControllerOptions options, [In, MarshalAs(UnmanagedType.Interface)] ICoreWebView2CreateCoreWebView2CompositionControllerCompletedHandler handler)
        {
            this.Environment.CreateCoreWebView2CompositionControllerWithOptions(ParentWindow, options, handler);
        }
    }
}