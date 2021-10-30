using System.ComponentModel;
using System.Runtime.InteropServices;
using Diga.WebView2.Interop;

namespace Diga.WebView2.Wrapper
{
    [EditorBrowsable(EditorBrowsableState.Advanced)]
    public class WebView2View5Interface : WebView2View4Interface, ICoreWebView2_5
    {
        private ICoreWebView2_5 _WebView;
        [EditorBrowsable(EditorBrowsableState.Never)]
        public WebView2View5Interface(ICoreWebView2_5 webView) : base(webView)
        {
            this._WebView = webView;
        }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public void add_ClientCertificateRequested([In, MarshalAs(UnmanagedType.Interface)] ICoreWebView2ClientCertificateRequestedEventHandler eventHandler, out EventRegistrationToken token)
        {
            _WebView.add_ClientCertificateRequested(eventHandler, out token);
        }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public void remove_ClientCertificateRequested([In] EventRegistrationToken token)
        {
            _WebView.remove_ClientCertificateRequested(token);
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