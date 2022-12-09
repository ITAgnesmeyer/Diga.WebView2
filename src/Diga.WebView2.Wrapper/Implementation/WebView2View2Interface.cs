using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.Types;

namespace Diga.WebView2.Wrapper.Implementation
{
    [EditorBrowsable(EditorBrowsableState.Never)]
    public class WebView2View2Interface : WebView2ViewInterface
    {
        private ComObjectHolder< ICoreWebView2_2> _WebView;

        private ICoreWebView2_2 WebView
        {
            get
            {
                if (this._WebView == null)
                {
                    Debug.Print(nameof(WebView2View2Interface) + "." + nameof(this.WebView) + " is null");
                    throw new InvalidOperationException(nameof(WebView2View2Interface) + "." + nameof(this.WebView) + " is null");

                }
                return this._WebView.Interface;
            }
            set
            {
                this._WebView = new ComObjectHolder<ICoreWebView2_2>(value);
            }
        }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public WebView2View2Interface(ICoreWebView2_2 webView) : base(webView)
        {
            if (webView == null)
                throw new ArgumentNullException(nameof(webView));

            this.WebView = webView;
        }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public void add_WebResourceResponseReceived([In, MarshalAs(UnmanagedType.Interface)] ICoreWebView2WebResourceResponseReceivedEventHandler eventHandler, out EventRegistrationToken token)
        {
            this.WebView.add_WebResourceResponseReceived(eventHandler, out token);
        }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public void remove_WebResourceResponseReceived([In] EventRegistrationToken token)
        {
            this.WebView.remove_WebResourceResponseReceived(token);
        }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public void NavigateWithWebResourceRequest([In, MarshalAs(UnmanagedType.Interface)] ICoreWebView2WebResourceRequest Request)
        {
            this.WebView.NavigateWithWebResourceRequest(Request);
        }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public void add_DOMContentLoaded([In, MarshalAs(UnmanagedType.Interface)] ICoreWebView2DOMContentLoadedEventHandler eventHandler, out EventRegistrationToken token)
        {
            this.WebView.add_DOMContentLoaded(eventHandler, out token);
        }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public void remove_DOMContentLoaded([In] EventRegistrationToken token)
        {
            this.WebView.remove_DOMContentLoaded(token);
        }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public ICoreWebView2CookieManager CookieManager => this.WebView.CookieManager;
        [EditorBrowsable(EditorBrowsableState.Never)]
        public ICoreWebView2Environment Environment => this.WebView.Environment;

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