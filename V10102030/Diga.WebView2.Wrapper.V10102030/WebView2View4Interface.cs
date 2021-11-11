using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Diga.WebView2.Interop;

namespace Diga.WebView2.Wrapper
{
    [EditorBrowsable(EditorBrowsableState.Advanced)]
    public class WebView2View4Interface : WebView2View3Interface, ICoreWebView2_4
    {
        private ICoreWebView2_4 _WebView;

        private ICoreWebView2_4 WebView
        {
            get
            {
                if (_WebView == null)
                {
                    Debug.Print(nameof(WebView2View4Interface) + "." + nameof(WebView) + " is null");
                    throw new InvalidOperationException(nameof(WebView2View4Interface) + "." + nameof(WebView) + " is null");

                }
                return _WebView;
            }
            set
            {
                _WebView = value;
            }
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public WebView2View4Interface(ICoreWebView2_4 webView) : base(webView)
        {
            if (webView == null)
                throw new ArgumentNullException(nameof(webView));
            this._WebView = webView;
        }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public void add_FrameCreated([In, MarshalAs(UnmanagedType.Interface)] ICoreWebView2FrameCreatedEventHandler eventHandler, out EventRegistrationToken token)
        {
            WebView.add_FrameCreated(eventHandler, out token);
        }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public void remove_FrameCreated([In] EventRegistrationToken token)
        {
            WebView.remove_FrameCreated(token);
        }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public void add_DownloadStarting([In, MarshalAs(UnmanagedType.Interface)] ICoreWebView2DownloadStartingEventHandler eventHandler, out EventRegistrationToken token)
        {
            WebView.add_DownloadStarting(eventHandler, out token);
        }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public void remove_DownloadStarting([In] EventRegistrationToken token)
        {
            try
            {
                WebView.remove_DownloadStarting(token);
            }
            catch (COMException comEx)
            {
                Debug.Print(nameof(remove_DownloadStarting) + " Exception" + comEx.ToString() );
                
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