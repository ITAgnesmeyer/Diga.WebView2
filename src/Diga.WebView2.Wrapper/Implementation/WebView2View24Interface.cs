using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.Types;

namespace Diga.WebView2.Wrapper.Implementation
{

    public class WebView2View24Interface : WebView2View23Interface //, ICoreWebView2_24
    {
        private ComObjectHolder<ICoreWebView2_24> _Iface;
        private ICoreWebView2_24 Iface
        {
            get
            {
                if (_Iface == null)
                {
                    Debug.Print(nameof(WebView2View24Interface) + "=>" + nameof(Iface) + " is null");

                    throw new InvalidOperationException(nameof(WebView2View24Interface) + "=>" + nameof(Iface) + " is null");
                }
                return _Iface.Interface;
            }
            set => _Iface = new ComObjectHolder<ICoreWebView2_24>(value);
        }
        public WebView2View24Interface(ICoreWebView2_24 iface) : base(iface)
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

        public void add_NotificationReceived([In, MarshalAs(UnmanagedType.Interface)] ICoreWebView2NotificationReceivedEventHandler eventHandler, out EventRegistrationToken token)
        {
            Iface.add_NotificationReceived(eventHandler, out token);
        }

        public void remove_NotificationReceived([In] EventRegistrationToken token)
        {
            Iface.remove_NotificationReceived(token);
        }
    }
}