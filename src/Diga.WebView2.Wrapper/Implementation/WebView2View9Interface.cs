using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Diga.WebView2.Interop;

namespace Diga.WebView2.Wrapper.Implementation
{
    public class WebView2View9Interface : WebView2View8Interface, ICoreWebView2_9
    {
        private ICoreWebView2_9 _WebView;
        private ICoreWebView2_9 WebView
        {
            get
            {
                if (this._WebView == null)
                {
                    Debug.Print(nameof(WebView2View8Interface) + "." + nameof(this.WebView) + " is null");
                    throw new InvalidOperationException(nameof(WebView2View8Interface) + "." + nameof(this.WebView) + " is null");

                }
                return this._WebView;
            }
            set
            {
                this._WebView = value;
            }


        }
        public WebView2View9Interface(ICoreWebView2_9 webView) : base(webView)
        {
            this._WebView = webView ?? throw new ArgumentNullException(nameof(webView));
        }

        public void add_IsDefaultDownloadDialogOpenChanged([In, MarshalAs(UnmanagedType.Interface)] ICoreWebView2IsDefaultDownloadDialogOpenChangedEventHandler handler, out EventRegistrationToken token)
        {
            this.WebView.add_IsDefaultDownloadDialogOpenChanged(handler, out token);
        }

        public void remove_IsDefaultDownloadDialogOpenChanged([In] EventRegistrationToken token)
        {
            this.WebView.remove_IsDefaultDownloadDialogOpenChanged(token);
        }

        public int IsDefaultDownloadDialogOpen => this.WebView.IsDefaultDownloadDialogOpen;

        public void OpenDefaultDownloadDialog()
        {
            this.WebView.OpenDefaultDownloadDialog();
        }

        public void CloseDefaultDownloadDialog()
        {
            this.WebView.CloseDefaultDownloadDialog();
        }

        public COREWEBVIEW2_DEFAULT_DOWNLOAD_DIALOG_CORNER_ALIGNMENT DefaultDownloadDialogCornerAlignment { get => this.WebView.DefaultDownloadDialogCornerAlignment; set => this.WebView.DefaultDownloadDialogCornerAlignment = value; }
        public tagPOINT DefaultDownloadDialogMargin { get => this.WebView.DefaultDownloadDialogMargin; set => this.WebView.DefaultDownloadDialogMargin = value; }
    }
}