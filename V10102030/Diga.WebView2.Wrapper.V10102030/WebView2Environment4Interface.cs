using Diga.WebView2.Interop;
using System;
using System.Runtime.InteropServices;

namespace Diga.WebView2.Wrapper
{
    public class WebView2Environment4Interface:WebView2Environment3Interface,ICoreWebView2Environment4
    {
        private  ICoreWebView2Environment4 _Environment4;

        public WebView2Environment4Interface(ICoreWebView2Environment4 environment):base(environment)
        {
            this._Environment4 = environment;
        }

        [return: MarshalAs(UnmanagedType.IUnknown)]
        public object GetProviderForHwnd(IntPtr hwnd)
        {
            return _Environment4.GetProviderForHwnd(hwnd);
        }
         protected override void Dispose(bool disposing)
        {
            if(disposing)
            {
                this._Environment4= null;
            }
            base.Dispose(disposing);
        }
    }
}