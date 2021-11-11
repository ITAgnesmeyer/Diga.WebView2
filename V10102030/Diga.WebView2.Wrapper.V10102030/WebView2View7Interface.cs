using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Diga.WebView2.Interop;

namespace Diga.WebView2.Wrapper
{
    [EditorBrowsable(EditorBrowsableState.Never)]
    public class WebView2View7Interface : WebView2View6Interface, ICoreWebView2_7
    {
        private ICoreWebView2_7 _WebView;
        private ICoreWebView2_7 WebView
        {
            get
            {
                if (_WebView == null)
                {
                    Debug.Print(nameof(WebView2View7Interface) + "." + nameof(WebView) + " is null");
                    throw new InvalidOperationException(nameof(WebView2View7Interface) + "." + nameof(WebView) + " is null");

                }
                return _WebView;
            }
            set
            {
                _WebView = value;
            }
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public WebView2View7Interface(ICoreWebView2_7 webView) : base(webView)
        {
            if (webView == null)
                throw new ArgumentNullException(nameof(webView));

            this._WebView = webView;
        }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public void PrintToPdf([In, MarshalAs(UnmanagedType.LPWStr)] string ResultFilePath, [In, MarshalAs(UnmanagedType.Interface)] ICoreWebView2PrintSettings printSettings, [In, MarshalAs(UnmanagedType.Interface)] ICoreWebView2PrintToPdfCompletedHandler handler)
        {
            WebView.PrintToPdf(ResultFilePath, printSettings, handler);
        }
        private bool _IsDisposed;
        protected override void Dispose(bool disposing)
        {
            if (this._IsDisposed) return;
            if (disposing)
            {
                this._WebView = null;
                this._IsDisposed = true;
            }
            base.Dispose(disposing);
        }

    }
}