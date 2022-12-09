using Diga.WebView2.Interop;
using System;
using System.ComponentModel;
using System.Diagnostics;
using Diga.WebView2.Wrapper.Types;

namespace Diga.WebView2.Wrapper.Implementation
{
    [EditorBrowsable(EditorBrowsableState.Advanced)]
    public class WebView2View6Interface : WebView2View5Interface
    {
        private ComObjectHolder< ICoreWebView2_6> _WebView;

        private ICoreWebView2_6 WebView
        {
            get
            {
                if (this._WebView == null)
                {
                    Debug.Print(nameof(WebView2View6Interface) + "." + nameof(this.WebView) + " is null");
                    throw new InvalidOperationException(nameof(WebView2View6Interface) + "." + nameof(this.WebView) + " is null");

                }
                return this._WebView.Interface;
            }
            set => this._WebView = new ComObjectHolder<ICoreWebView2_6>(value);
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public WebView2View6Interface(ICoreWebView2_6 webView) : base(webView)
        {
            this.WebView = webView ?? throw new ArgumentNullException(nameof(webView));
        }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public void OpenTaskManagerWindow()
        {
            this.WebView.OpenTaskManagerWindow();
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