using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.Types;

namespace Diga.WebView2.Wrapper.Implementation
{
    [EditorBrowsable(EditorBrowsableState.Never)]
    public class WebView2View3Interface : WebView2View2Interface
    {
        private ComObjectHolder< ICoreWebView2_3> _WebView;

        private ICoreWebView2_3 WebView
        {
            get
            {
                if (this._WebView == null)
                {
                    Debug.Print(nameof(WebView2View3Interface) + "." + nameof(this.WebView) + " is null");
                    throw new InvalidOperationException(nameof(WebView2View3Interface) + "." + nameof(this.WebView) + " is null");

                }
                return this._WebView.Interface;
            }
            set
            {
                this._WebView = new ComObjectHolder<ICoreWebView2_3>(value);
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public WebView2View3Interface(ICoreWebView2_3 webView) : base(webView)
        {
            this.WebView = webView ?? throw new ArgumentNullException(nameof(webView));
        }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public void TrySuspend([In, MarshalAs(UnmanagedType.Interface)] ICoreWebView2TrySuspendCompletedHandler handler)
        {
            this.WebView.TrySuspend(handler);
        }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public void Resume()
        {
            this.WebView.Resume();
        }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int IsSuspended => this.WebView.IsSuspended;
        [EditorBrowsable(EditorBrowsableState.Never)]
        public void SetVirtualHostNameToFolderMapping([In, MarshalAs(UnmanagedType.LPWStr)] string hostName, [In, MarshalAs(UnmanagedType.LPWStr)] string folderPath, [In] COREWEBVIEW2_HOST_RESOURCE_ACCESS_KIND accessKind)
        {
            this.WebView.SetVirtualHostNameToFolderMapping(hostName, folderPath, accessKind);
        }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public void ClearVirtualHostNameToFolderMapping([In, MarshalAs(UnmanagedType.LPWStr)] string hostName)
        {
            this.WebView.ClearVirtualHostNameToFolderMapping(hostName);
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