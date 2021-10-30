using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using Diga.WebView2.Interop;

namespace Diga.WebView2.Wrapper
{
    [EditorBrowsable(EditorBrowsableState.Advanced )]
    public class WebView2View7Interface : WebView2View6Interface, ICoreWebView2_7
    {
        private ICoreWebView2_7 _WebView;
       

        [EditorBrowsable(EditorBrowsableState.Never)]
        public WebView2View7Interface(ICoreWebView2_7 webView) : base(webView)
        {
            this._WebView = webView;
        }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public void PrintToPdf([In, MarshalAs(UnmanagedType.LPWStr)] string ResultFilePath, [In, MarshalAs(UnmanagedType.Interface)] ICoreWebView2PrintSettings printSettings, [In, MarshalAs(UnmanagedType.Interface)] ICoreWebView2PrintToPdfCompletedHandler handler)
        {
            _WebView.PrintToPdf(ResultFilePath, printSettings, handler);
        }
          protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                this._WebView = null;
            }
            base.Dispose(disposing);
        }
       
    }
}