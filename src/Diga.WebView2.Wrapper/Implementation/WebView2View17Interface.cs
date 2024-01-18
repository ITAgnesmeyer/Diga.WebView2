using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.Types;
using Microsoft.Win32.SafeHandles;

namespace Diga.WebView2.Wrapper.Implementation
{


    public class WebView2View17Interface : WebView2View16Interface //, ICoreWebView2_17
    {
        private ComObjectHolder< ICoreWebView2_17> _WebView;

        private ICoreWebView2_17 WebView
        {
            get
            {
                if (this._WebView == null)
                {
                    Debug.Print(nameof(WebView2View17Interface) + "." + nameof(this.WebView) + " is null");
                    throw new InvalidOperationException(nameof(WebView2View17Interface) + "." + nameof(this.WebView) + " is null");

                }
                return this._WebView.Interface;
            }
            set => this._WebView = new ComObjectHolder<ICoreWebView2_17>(value);
        }

        public WebView2View17Interface(ICoreWebView2_17 webView) : base(webView)
        {
            this.WebView = webView ?? throw new ArgumentNullException(nameof(webView));
        }

        public void PostSharedBufferToScript([In, MarshalAs(UnmanagedType.Interface)] ICoreWebView2SharedBuffer sharedBuffer, [In] COREWEBVIEW2_SHARED_BUFFER_ACCESS access, [In, MarshalAs(UnmanagedType.LPWStr)] string additionalDataAsJson)
        {
            this.WebView.PostSharedBufferToScript(sharedBuffer, access, additionalDataAsJson);
        }
    }
}