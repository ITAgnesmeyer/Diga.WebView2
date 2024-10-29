using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.Types;

namespace Diga.WebView2.Wrapper.Implementation
{
    public class WebView2View26Interface : WebView2View25Interface //, ICoreWebView2_26
    {
        private ComObjectHolder<ICoreWebView2_26> _Iface;
        private ICoreWebView2_26 Iface
        {
            get
            {
                if (_Iface == null)
                {
                    Debug.Print(nameof(WebView2View26Interface) + "=>" + nameof(Iface) + " is null");

                    throw new InvalidOperationException(nameof(WebView2View26Interface) + "=>" + nameof(Iface) + " is null");
                }
                return _Iface.Interface;
            }
            set => _Iface = new ComObjectHolder<ICoreWebView2_26>(value);

        }
        public WebView2View26Interface(ICoreWebView2_26 iface) : base(iface)
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

        public void add_SaveFileSecurityCheckStarting([In, MarshalAs(UnmanagedType.Interface)] ICoreWebView2SaveFileSecurityCheckStartingEventHandler eventHandler, out EventRegistrationToken token)
        {
            Iface.add_SaveFileSecurityCheckStarting(eventHandler, out token);
        }

        public void remove_SaveFileSecurityCheckStarting([In] EventRegistrationToken token)
        {
            Iface.remove_SaveFileSecurityCheckStarting(token);
        }
    }
}
       