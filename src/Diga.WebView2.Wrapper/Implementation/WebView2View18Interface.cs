using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.Types;

namespace Diga.WebView2.Wrapper.Implementation
{
    public class WebView2View18Interface : WebView2View17Interface//, ICoreWebView2_18
    {
        private ComObjectHolder<ICoreWebView2_18> _Iface;
        private ICoreWebView2_18 Iface
        {
            get
            {
                if (_Iface == null)
                {
                    Debug.Print(nameof(WebView2View18Interface) + "=>" + nameof(Iface) + " is null");

                    throw new InvalidOperationException(nameof(WebView2View18Interface) + "=>" + nameof(Iface) + " is null");
                }
                return _Iface.Interface;
            }
            set => _Iface = new ComObjectHolder<ICoreWebView2_18>(value);
        }
        public WebView2View18Interface(ICoreWebView2_18 iface) : base(iface)
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

        public void add_LaunchingExternalUriScheme([In, MarshalAs(UnmanagedType.Interface)] ICoreWebView2LaunchingExternalUriSchemeEventHandler eventHandler, out EventRegistrationToken token)
        {
            this.Iface.add_LaunchingExternalUriScheme(eventHandler, out token);
        }

        public void remove_LaunchingExternalUriScheme([In] EventRegistrationToken token)
        {
            this.Iface.remove_LaunchingExternalUriScheme(token);
        }
    }
}