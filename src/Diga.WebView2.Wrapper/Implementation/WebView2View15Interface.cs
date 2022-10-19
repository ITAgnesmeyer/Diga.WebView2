using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Diga.WebView2.Interop;

namespace Diga.WebView2.Wrapper.Implementation
{
    public class WebView2View15Interface : WebView2View14Interface, ICoreWebView2_15
    {
        private ICoreWebView2_15 _WebView;
        private ICoreWebView2_15 WebView
        {
            get
            {
                if (this._WebView == null)
                {
                    Debug.Print(nameof(WebView2View15Interface) + "." + nameof(this.WebView) + " is null");
                    throw new InvalidOperationException(nameof(WebView2View15Interface) + "." + nameof(this.WebView) + " is null");

                }
                return this._WebView;
            }
            set
            {
                this._WebView = value;
            }


        }
        public WebView2View15Interface(ICoreWebView2_15 webView) : base(webView)
        {
            this._WebView = webView ?? throw new ArgumentNullException(nameof(webView));
        }

        public void add_FaviconChanged([In, MarshalAs(UnmanagedType.Interface)] ICoreWebView2FaviconChangedEventHandler eventHandler, out EventRegistrationToken token)
        {
            this.WebView.add_FaviconChanged(eventHandler, out token);
        }

        public void remove_FaviconChanged([In] EventRegistrationToken token)
        {
            this.WebView.remove_FaviconChanged(token);
        }

        public string FaviconUri => this._WebView.FaviconUri;

        public void GetFavicon([In] COREWEBVIEW2_FAVICON_IMAGE_FORMAT format, [In, MarshalAs(UnmanagedType.Interface)] ICoreWebView2GetFaviconCompletedHandler completedHandler)
        {
            this.WebView.GetFavicon(format, completedHandler);
        }
    }
}