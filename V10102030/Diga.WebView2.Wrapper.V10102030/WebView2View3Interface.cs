using System.ComponentModel;
using System.Runtime.InteropServices;
using Diga.WebView2.Interop;

namespace Diga.WebView2.Wrapper
{
    [EditorBrowsable(EditorBrowsableState.Advanced)]
    public class WebView2View3Interface : WebView2View2Interface, ICoreWebView2_3
    {
        private ICoreWebView2_3 _WebView;
        [EditorBrowsable(EditorBrowsableState.Never)]
        public WebView2View3Interface(ICoreWebView2_3 webView) : base(webView)
        {
            this._WebView = webView;
        }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public void TrySuspend([In, MarshalAs(UnmanagedType.Interface)] ICoreWebView2TrySuspendCompletedHandler handler)
        {
            _WebView.TrySuspend(handler);
        }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public void Resume()
        {
            _WebView.Resume();
        }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int IsSuspended => _WebView.IsSuspended;
        [EditorBrowsable(EditorBrowsableState.Never)]
        public void SetVirtualHostNameToFolderMapping([In, MarshalAs(UnmanagedType.LPWStr)] string hostName, [In, MarshalAs(UnmanagedType.LPWStr)] string folderPath, [In] COREWEBVIEW2_HOST_RESOURCE_ACCESS_KIND accessKind)
        {
            _WebView.SetVirtualHostNameToFolderMapping(hostName, folderPath, accessKind);
        }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public void ClearVirtualHostNameToFolderMapping([In, MarshalAs(UnmanagedType.LPWStr)] string hostName)
        {
            _WebView.ClearVirtualHostNameToFolderMapping(hostName);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                this._WebView = null;
            }
            base.Dispose(disposing);
        }
    }
}