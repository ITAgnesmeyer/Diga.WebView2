using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Diga.WebView2.Interop;

namespace Diga.WebView2.Wrapper.Implementation
{
    [EditorBrowsable(EditorBrowsableState.Never)]
    public class WebView2View2Interface : WebView2ViewInterface, ICoreWebView2_2
    {
        private ICoreWebView2_2 _WebView;

        private ICoreWebView2_2 WebView
        {
            get
            {
                if (_WebView == null)
                {
                    Debug.Print(nameof(WebView2View2Interface) + "." + nameof(WebView) + " is null");
                    throw new InvalidOperationException(nameof(WebView2View2Interface) + "." + nameof(WebView) + " is null");

                }
                return _WebView;
            }
            set
            {
                _WebView = value;
            }
        }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public WebView2View2Interface(ICoreWebView2_2 webView) : base(webView)
        {
            if (webView == null)
                throw new ArgumentNullException(nameof(webView));

            _WebView = webView;
        }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public void add_WebResourceResponseReceived([In, MarshalAs(UnmanagedType.Interface)] ICoreWebView2WebResourceResponseReceivedEventHandler eventHandler, out EventRegistrationToken token)
        {
            WebView.add_WebResourceResponseReceived(eventHandler, out token);
        }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public void remove_WebResourceResponseReceived([In] EventRegistrationToken token)
        {
            WebView.remove_WebResourceResponseReceived(token);
        }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public void NavigateWithWebResourceRequest([In, MarshalAs(UnmanagedType.Interface)] ICoreWebView2WebResourceRequest Request)
        {
            WebView.NavigateWithWebResourceRequest(Request);
        }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public void add_DOMContentLoaded([In, MarshalAs(UnmanagedType.Interface)] ICoreWebView2DOMContentLoadedEventHandler eventHandler, out EventRegistrationToken token)
        {
            WebView.add_DOMContentLoaded(eventHandler, out token);
        }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public void remove_DOMContentLoaded([In] EventRegistrationToken token)
        {
            WebView.remove_DOMContentLoaded(token);
        }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public ICoreWebView2CookieManager CookieManager => WebView.CookieManager;
        [EditorBrowsable(EditorBrowsableState.Never)]
        public ICoreWebView2Environment Environment => WebView.Environment;

        private bool _IsDisposed;
        protected override void Dispose(bool disposing)
        {
            if (_IsDisposed) return;
            if (disposing)
            {
                _WebView = null;
                _IsDisposed = true;
            }
            base.Dispose(disposing);
        }
    }
}