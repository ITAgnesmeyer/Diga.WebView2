using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Diga.WebView2.Interop;

namespace Diga.WebView2.Wrapper.Implementation
{
    [EditorBrowsable(EditorBrowsableState.Advanced)]
    public class WebView2View5Interface : WebView2View4Interface, ICoreWebView2_5
    {
        private ICoreWebView2_5 _WebView;
        private ICoreWebView2_5 WebView
        {
            get
            {
                if (_WebView == null)
                {
                    Debug.Print(nameof(WebView2View5Interface) + "." + nameof(WebView) + " is null");
                    throw new InvalidOperationException(nameof(WebView2View5Interface) + "." + nameof(WebView) + " is null");

                }
                return _WebView;
            }
            set
            {
                _WebView = value;
            }
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public WebView2View5Interface(ICoreWebView2_5 webView) : base(webView)
        {
            _WebView = webView ?? throw new ArgumentNullException(nameof(webView));
        }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public void add_ClientCertificateRequested([In, MarshalAs(UnmanagedType.Interface)] ICoreWebView2ClientCertificateRequestedEventHandler eventHandler, out EventRegistrationToken token)
        {
            WebView.add_ClientCertificateRequested(eventHandler, out token);
        }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public void remove_ClientCertificateRequested([In] EventRegistrationToken token)
        {
            try
            {

                WebView.remove_ClientCertificateRequested(token);
            }
            catch (AccessViolationException accessViolation)
            {

                Debug.Print("AccessViolation Exception:" + accessViolation.ToString());
            }

        }
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