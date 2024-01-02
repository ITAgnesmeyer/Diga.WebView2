using System;
using System.Diagnostics;
using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.Types;

namespace Diga.WebView2.Wrapper.Implementation
{
    public class WebView2View19Interface : WebView2View18Interface
    {
        private ComObjectHolder<ICoreWebView2_19> _Iface;
        private ICoreWebView2_19 Iface
        {
            get
            {
                if (_Iface == null)
                {
                    Debug.Print(nameof(WebView2View19Interface) + "=>" + nameof(Iface) + " is null");

                    throw new InvalidOperationException(nameof(WebView2View19Interface) + "=>" + nameof(Iface) + " is null");
                }
                return _Iface.Interface;
            }
            set => _Iface = new ComObjectHolder<ICoreWebView2_19>(value);
        }
        public WebView2View19Interface(ICoreWebView2_19 iface) : base(iface)
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

        public COREWEBVIEW2_MEMORY_USAGE_TARGET_LEVEL MemoryUsageTargetLevel { get => this.Iface.MemoryUsageTargetLevel; set => this.Iface.MemoryUsageTargetLevel = value; }
    }
}