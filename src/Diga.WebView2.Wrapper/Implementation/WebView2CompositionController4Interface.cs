
using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.Types;

namespace Diga.WebView2.Wrapper.Implementation
{
    public class WebView2CompositionController4Interface : WebView2CompositionController3Interface //, ICoreWebView2CompositionController4
    {
        private ComObjectHolder<ICoreWebView2CompositionController4> _Iface;
        private ICoreWebView2CompositionController4 Iface
        {
            get
            {
                if (_Iface == null)
                {
                    Debug.Print(nameof(WebView2CompositionController4Interface) + "=>" + nameof(Iface) + " is null");

                    throw new InvalidOperationException(nameof(WebView2CompositionController4Interface) + "=>" + nameof(Iface) + " is null");
                }
                return _Iface.Interface;
            }
            set => _Iface = new ComObjectHolder<ICoreWebView2CompositionController4>(value);
        }
        public WebView2CompositionController4Interface(ICoreWebView2CompositionController4 iface) : base(iface)
        {
            Iface = iface ?? throw new ArgumentNullException(nameof(iface));
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

        public COREWEBVIEW2_NON_CLIENT_REGION_KIND GetNonClientRegionAtPoint([In] tagPOINT point)
        {
            return Iface.GetNonClientRegionAtPoint(point);
        }

        [return: MarshalAs(UnmanagedType.Interface)]
        public ICoreWebView2RegionRectCollectionView QueryNonClientRegion([In] COREWEBVIEW2_NON_CLIENT_REGION_KIND Kind)
        {
            return Iface.QueryNonClientRegion(Kind);
        }

        public void add_NonClientRegionChanged([In, MarshalAs(UnmanagedType.Interface)] ICoreWebView2NonClientRegionChangedEventHandler eventHandler, out EventRegistrationToken token)
        {
            Iface.add_NonClientRegionChanged(eventHandler, out token);
        }

        public void remove_NonClientRegionChanged([In] EventRegistrationToken token)
        {
            Iface.remove_NonClientRegionChanged(token);
        }
    }
}