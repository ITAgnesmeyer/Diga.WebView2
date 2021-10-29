using System.ComponentModel;
using System.Runtime.InteropServices;
using Diga.WebView2.Interop;

namespace Diga.WebView2.Wrapper
{
    [EditorBrowsable(EditorBrowsableState.Advanced )]
    public class WebView2View4Interface : WebView2View3Interface, ICoreWebView2_4
    {
        private ICoreWebView2_4 _WebView;
        [EditorBrowsable(EditorBrowsableState.Never)]
        public WebView2View4Interface(ICoreWebView2_4 webView) : base(webView)
        {
            this._WebView = webView;
        }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public void add_FrameCreated([In, MarshalAs(UnmanagedType.Interface)] ICoreWebView2FrameCreatedEventHandler eventHandler, out EventRegistrationToken token)
        {
            _WebView.add_FrameCreated(eventHandler, out token);
        }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public void remove_FrameCreated([In] EventRegistrationToken token)
        {
            _WebView.remove_FrameCreated(token);
        }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public void add_DownloadStarting([In, MarshalAs(UnmanagedType.Interface)] ICoreWebView2DownloadStartingEventHandler eventHandler, out EventRegistrationToken token)
        {
            _WebView.add_DownloadStarting(eventHandler, out token);
        }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public void remove_DownloadStarting([In] EventRegistrationToken token)
        {
            _WebView.remove_DownloadStarting(token);
        }
    }
}