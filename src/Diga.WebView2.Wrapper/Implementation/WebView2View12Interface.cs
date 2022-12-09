using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.Types;

namespace Diga.WebView2.Wrapper.Implementation
{
    public class WebView2View12Interface : WebView2View11Interface
    {
        private ComObjectHolder< ICoreWebView2_12> _WebView;
        private ICoreWebView2_12 WebView
        {
            get
            {
                if (this._WebView == null)
                {
                    Debug.Print(nameof(WebView2View12Interface) + "." + nameof(this.WebView) + " is null");
                    throw new InvalidOperationException(nameof(WebView2View12Interface) + "." + nameof(this.WebView) + " is null");

                }
                return this._WebView.Interface;
            }
            set => this._WebView = new ComObjectHolder<ICoreWebView2_12>(value);
        }

        public WebView2View12Interface(ICoreWebView2_12 webView) : base(webView)
        {
            this.WebView = webView ?? throw new ArgumentNullException(nameof(webView));
        }

       

        public void add_StatusBarTextChanged([In, MarshalAs(UnmanagedType.Interface)] ICoreWebView2StatusBarTextChangedEventHandler eventHandler, out EventRegistrationToken token)
        {
            this.WebView.add_StatusBarTextChanged(eventHandler, out token);
        }

        public void remove_StatusBarTextChanged([In] EventRegistrationToken token)
        {
            this.WebView.remove_StatusBarTextChanged(token);
        }

        public string StatusBarText => this.WebView.StatusBarText;
    }
}