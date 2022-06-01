using System;
using System.Diagnostics;
using Diga.WebView2.Interop;

namespace Diga.WebView2.Wrapper.Implementation
{
    public class WebView2View13Interface : WebView2View12Interface, ICoreWebView2_13
    {
        private ICoreWebView2_13 _WebView;
        private ICoreWebView2_13 WebView
        {
            get
            {
                if (this._WebView == null)
                {
                    Debug.Print(nameof(WebView2View13Interface) + "." + nameof(this.WebView) + " is null");
                    throw new InvalidOperationException(nameof(WebView2View13Interface) + "." + nameof(this.WebView) + " is null");

                }
                return this._WebView;
            }
            set
            {
                this._WebView = value;
            }


        }

        public WebView2View13Interface(ICoreWebView2_13 webView) : base(webView)
        {
            this._WebView = webView ?? throw new ArgumentNullException(nameof(webView));
        }

        public ICoreWebView2Profile Profile => this.WebView.Profile;
    }
}