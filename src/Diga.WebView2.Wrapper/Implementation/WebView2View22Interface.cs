using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.Types;

namespace Diga.WebView2.Wrapper.Implementation
{

    public class WebView2View22Interface : WebView2View21Interface //, ICoreWebView2_22
    {
        private ComObjectHolder<ICoreWebView2_22> _Iface;
        private ICoreWebView2_22 Iface
        {
            get
            {
                if (_Iface == null)
                {
                    Debug.Print(nameof(WebView2View22Interface) + "=>" + nameof(Iface) + " is null");

                    throw new InvalidOperationException(nameof(WebView2View22Interface) + "=>" + nameof(Iface) + " is null");
                }
                return _Iface.Interface;
            }
            set => _Iface = new ComObjectHolder<ICoreWebView2_22>(value);
        }
        public WebView2View22Interface(ICoreWebView2_22 iface) : base(iface)
        {
            Iface = iface ?? throw new ArgumentNullException(nameof(iface));
        }

        public void AddWebResourceRequestedFilterWithRequestSourceKinds([In, MarshalAs(UnmanagedType.LPWStr)] string uri, [In] COREWEBVIEW2_WEB_RESOURCE_CONTEXT ResourceContext, [In] COREWEBVIEW2_WEB_RESOURCE_REQUEST_SOURCE_KINDS requestSourceKinds)
        {
            Iface.AddWebResourceRequestedFilterWithRequestSourceKinds(uri, ResourceContext, requestSourceKinds);
        }

        public void RemoveWebResourceRequestedFilterWithRequestSourceKinds([In, MarshalAs(UnmanagedType.LPWStr)] string uri, [In] COREWEBVIEW2_WEB_RESOURCE_CONTEXT ResourceContext, [In] COREWEBVIEW2_WEB_RESOURCE_REQUEST_SOURCE_KINDS requestSourceKinds)
        {
            Iface.RemoveWebResourceRequestedFilterWithRequestSourceKinds(uri, ResourceContext, requestSourceKinds);
        }
        private bool _IsDisposed;
        protected override void Dispose(bool disposing)
        {
            if (_IsDisposed) return;
            if (disposing)
            {
                _Iface = null;
                _IsDisposed = true;
            }
            base.Dispose(disposing);
        }
    }
}