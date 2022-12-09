using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.Types;

namespace Diga.WebView2.Wrapper.Implementation
{
    [EditorBrowsable(EditorBrowsableState.Advanced)]
    public class WebView2View5Interface : WebView2View4Interface
    {
        private ComObjectHolder< ICoreWebView2_5> _WebView;
        private ICoreWebView2_5 WebView
        {
            get
            {
                if (this._WebView == null)
                {
                    Debug.Print(nameof(WebView2View5Interface) + "." + nameof(this.WebView) + " is null");
                    throw new InvalidOperationException(nameof(WebView2View5Interface) + "." + nameof(this.WebView) + " is null");

                }
                return this._WebView.Interface;
            }
            set => this._WebView = new ComObjectHolder<ICoreWebView2_5>(value);
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public WebView2View5Interface(ICoreWebView2_5 webView) : base(webView)
        {
            this.WebView = webView ?? throw new ArgumentNullException(nameof(webView));
        }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public void add_ClientCertificateRequested([In, MarshalAs(UnmanagedType.Interface)] ICoreWebView2ClientCertificateRequestedEventHandler eventHandler, out EventRegistrationToken token)
        {
            this.WebView.add_ClientCertificateRequested(eventHandler, out token);
        }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public void remove_ClientCertificateRequested([In] EventRegistrationToken token)
        {
            try
            {
                this.WebView.remove_ClientCertificateRequested(token);
            }
            catch (AccessViolationException accessViolation)
            {

                Debug.Print("AccessViolation Exception:" + accessViolation.ToString());
            }

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