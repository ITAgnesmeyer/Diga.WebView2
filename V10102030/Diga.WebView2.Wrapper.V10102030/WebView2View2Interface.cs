using System.ComponentModel;
using System.Runtime.InteropServices;
using Diga.WebView2.Interop;

namespace Diga.WebView2.Wrapper
{
    [EditorBrowsable(EditorBrowsableState.Advanced)]
    public class WebView2View2Interface : WebView2ViewInterface, ICoreWebView2_2
    {
        private ICoreWebView2_2 _WebView;
        [EditorBrowsable(EditorBrowsableState.Never)]
        public WebView2View2Interface(ICoreWebView2_2 webView) : base(webView)
        {
            this._WebView = webView;
        }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public void add_WebResourceResponseReceived([In, MarshalAs(UnmanagedType.Interface)] ICoreWebView2WebResourceResponseReceivedEventHandler eventHandler, out EventRegistrationToken token)
        {
            _WebView.add_WebResourceResponseReceived(eventHandler, out token);
        }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public void remove_WebResourceResponseReceived([In] EventRegistrationToken token)
        {
            _WebView.remove_WebResourceResponseReceived(token);
        }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public void NavigateWithWebResourceRequest([In, MarshalAs(UnmanagedType.Interface)] ICoreWebView2WebResourceRequest Request)
        {
            _WebView.NavigateWithWebResourceRequest(Request);
        }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public void add_DOMContentLoaded([In, MarshalAs(UnmanagedType.Interface)] ICoreWebView2DOMContentLoadedEventHandler eventHandler, out EventRegistrationToken token)
        {
            _WebView.add_DOMContentLoaded(eventHandler, out token);
        }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public void remove_DOMContentLoaded([In] EventRegistrationToken token)
        {
            _WebView.remove_DOMContentLoaded(token);
        }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public ICoreWebView2CookieManager CookieManager => _WebView.CookieManager;
        [EditorBrowsable(EditorBrowsableState.Never)]
        public ICoreWebView2Environment Environment => _WebView.Environment;
    }
}