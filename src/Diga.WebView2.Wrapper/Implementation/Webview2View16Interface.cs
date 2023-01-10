using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.Types;

namespace Diga.WebView2.Wrapper.Implementation
{
    public class Webview2View16Interface : WebView2View15Interface //, ICoreWebView2_16
    {
        private ComObjectHolder< ICoreWebView2_16> _WebView;

        private ICoreWebView2_16 WebView
        {
            get
            {
                if (this._WebView == null)
                {
                    Debug.Print(nameof(Webview2View16Interface) + "." + nameof(this.WebView) + " is null");
                    throw new InvalidOperationException(nameof(Webview2View16Interface) + "." + nameof(this.WebView) + " is null");

                }
                return this._WebView.Interface;
            }
            set => this._WebView = new ComObjectHolder<ICoreWebView2_16>(value);
        }

        public Webview2View16Interface(ICoreWebView2_16 webView) : base(webView)
        {
            this.WebView = webView ?? throw new ArgumentNullException(nameof(webView));
        }

        public void Print([In, MarshalAs(UnmanagedType.Interface)] ICoreWebView2PrintSettings printSettings, [In, MarshalAs(UnmanagedType.Interface)] ICoreWebView2PrintCompletedHandler handler)
        {
            this.WebView.Print(printSettings, handler);
        }

        public void ShowPrintUI([In] COREWEBVIEW2_PRINT_DIALOG_KIND printDialogKind)
        {
            this.WebView.ShowPrintUI(printDialogKind);
        }

        public void PrintToPdfStream([In, MarshalAs(UnmanagedType.Interface)] ICoreWebView2PrintSettings printSettings, [In, MarshalAs(UnmanagedType.Interface)] ICoreWebView2PrintToPdfStreamCompletedHandler handler)
        {
            this.WebView.PrintToPdfStream(printSettings, handler);
        }
    }
}