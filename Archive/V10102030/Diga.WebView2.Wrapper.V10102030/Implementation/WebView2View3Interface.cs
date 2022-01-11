using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Diga.WebView2.Interop;

namespace Diga.WebView2.Wrapper.Implementation
{
    [EditorBrowsable(EditorBrowsableState.Never)]
    public class WebView2View3Interface : WebView2View2Interface, ICoreWebView2_3
    {
        private ICoreWebView2_3 _WebView;

        private ICoreWebView2_3 WebView
        {
            get
            {
                if (_WebView == null)
                {
                    Debug.Print(nameof(WebView2View3Interface) + "." + nameof(WebView) + " is null");
                    throw new InvalidOperationException(nameof(WebView2View3Interface) + "." + nameof(WebView) + " is null");

                }
                return _WebView;
            }
            set
            {
                _WebView = value;
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public WebView2View3Interface(ICoreWebView2_3 webView) : base(webView)
        {
            if (webView == null)
                throw new ArgumentNullException(nameof(webView));

            _WebView = webView;
        }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public void TrySuspend([In, MarshalAs(UnmanagedType.Interface)] ICoreWebView2TrySuspendCompletedHandler handler)
        {
            WebView.TrySuspend(handler);
        }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public void Resume()
        {
            WebView.Resume();
        }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int IsSuspended => WebView.IsSuspended;
        [EditorBrowsable(EditorBrowsableState.Never)]
        public void SetVirtualHostNameToFolderMapping([In, MarshalAs(UnmanagedType.LPWStr)] string hostName, [In, MarshalAs(UnmanagedType.LPWStr)] string folderPath, [In] COREWEBVIEW2_HOST_RESOURCE_ACCESS_KIND accessKind)
        {
            WebView.SetVirtualHostNameToFolderMapping(hostName, folderPath, accessKind);
        }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public void ClearVirtualHostNameToFolderMapping([In, MarshalAs(UnmanagedType.LPWStr)] string hostName)
        {
            WebView.ClearVirtualHostNameToFolderMapping(hostName);
        }
        private bool _IsDisposed;
        protected override void Dispose(bool disposing)
        {
            if (_IsDisposed) return;
            if (disposing)
            {
                _WebView = null;
                _IsDisposed = true;
            }
            base.Dispose(disposing);
        }
    }
}