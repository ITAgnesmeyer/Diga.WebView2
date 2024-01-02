using System;
using System.Diagnostics;
using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.Types;

namespace Diga.WebView2.Wrapper.Implementation
{


    public class WebView2Profile3Interface : WebView2Profile2Interface
    {
        private ComObjectHolder<ICoreWebView2Profile3> _Iface;
        private ICoreWebView2Profile3 Iface
        {
            get
            {
                if (_Iface == null)
                {
                    Debug.Print(nameof(WebView2Profile3Interface) + "=>" + nameof(Iface) + " is null");

                    throw new InvalidOperationException(nameof(WebView2Profile3Interface) + "=>" + nameof(Iface) + " is null");
                }
                return _Iface.Interface;
            }
            set => _Iface = new ComObjectHolder<ICoreWebView2Profile3>(value);
        }
        public WebView2Profile3Interface(ICoreWebView2Profile3 iface) : base(iface)
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

        public COREWEBVIEW2_TRACKING_PREVENTION_LEVEL PreferredTrackingPreventionLevel { get => this.Iface.PreferredTrackingPreventionLevel; set => this.Iface.PreferredTrackingPreventionLevel = value; }
    }
}