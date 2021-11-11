using Diga.WebView2.Interop;
using System;
using System.ComponentModel;
using System.Diagnostics;

namespace Diga.WebView2.Wrapper
{
    [EditorBrowsable(EditorBrowsableState.Advanced)]
    public class WebView2View6Interface : WebView2View5Interface, ICoreWebView2_6
    {
        private ICoreWebView2_6 _WebView;

        private ICoreWebView2_6 WebView
        {
            get
            {
                if (_WebView == null)
                {
                    Debug.Print(nameof(WebView2View6Interface) + "." + nameof(WebView) + " is null");
                    throw new InvalidOperationException(nameof(WebView2View6Interface) + "." + nameof(WebView) + " is null");

                }
                return _WebView;
            }
            set
            {
                _WebView = value;
            }
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public WebView2View6Interface(ICoreWebView2_6 webView) : base(webView)
        {
            if (webView == null)
                throw new ArgumentNullException(nameof(webView));
            this._WebView = webView;
        }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public void OpenTaskManagerWindow()
        {
            WebView.OpenTaskManagerWindow();
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