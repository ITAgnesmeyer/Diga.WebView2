using Diga.WebView2.Interop;
using System;
using System.Runtime.InteropServices;

namespace Diga.WebView2.Wrapper
{
    public class WebView2Environment3Interface:WebView2Environment2Interface,ICoreWebView2Environment3
    {
        private  ICoreWebView2Environment3 _Environment3;
        public WebView2Environment3Interface(ICoreWebView2Environment3 environment):base(environment)
        {
            this._Environment3 = environment;
        }

        public void CreateCoreWebView2CompositionController(IntPtr ParentWindow, [MarshalAs(UnmanagedType.Interface)] ICoreWebView2CreateCoreWebView2CompositionControllerCompletedHandler handler)
        {
            _Environment3.CreateCoreWebView2CompositionController(ParentWindow, handler);
        }

        [return: MarshalAs(UnmanagedType.Interface)]
        public ICoreWebView2PointerInfo CreateCoreWebView2PointerInfo()
        {
            return _Environment3.CreateCoreWebView2PointerInfo();
        }

         protected override void Dispose(bool disposing)
        {
            if(disposing)
            {
                this._Environment3 = null;
            }
            base.Dispose(disposing);
        }
    }
}