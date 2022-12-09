using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.Types;

namespace Diga.WebView2.Wrapper.Implementation
{
    public class WebView2View10Interface : WebView2View9Interface
    {
        private ComObjectHolder< ICoreWebView2_10> _WebView;
        private ICoreWebView2_10 WebView
        {
            get
            {
                if (this._WebView == null)
                {
                    Debug.Print(nameof(WebView2View10Interface) + "." + nameof(this.WebView) + " is null");
                    throw new InvalidOperationException(nameof(WebView2View10Interface) + "." + nameof(this.WebView) + " is null");

                }
                return this._WebView.Interface;
            }
            set => this._WebView = new ComObjectHolder<ICoreWebView2_10>(value);
        }

        public WebView2View10Interface(ICoreWebView2_10 webView) : base(webView)
        {
            this.WebView = webView ?? throw new ArgumentNullException(nameof(webView));
        }
        public void add_BasicAuthenticationRequested([In, MarshalAs(UnmanagedType.Interface)] ICoreWebView2BasicAuthenticationRequestedEventHandler eventHandler, out EventRegistrationToken token)
        {
            this.WebView.add_BasicAuthenticationRequested(eventHandler, out token);
        }

        public void remove_BasicAuthenticationRequested([In] EventRegistrationToken token)
        {
            this.WebView.remove_BasicAuthenticationRequested(token);
        }
    }
}