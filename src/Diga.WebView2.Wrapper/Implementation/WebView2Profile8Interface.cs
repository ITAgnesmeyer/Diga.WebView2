using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.Types;

namespace Diga.WebView2.Wrapper.Implementation
{
    public class WebView2Profile8Interface : WebView2Profile7Interface
    {
        private ComObjectHolder<ICoreWebView2Profile8> _Iface;
        private ICoreWebView2Profile8 Iface
        {
            get
            {
                if (_Iface == null)
                {
                    Debug.Print(nameof(WebView2Profile8Interface) + "=>" + nameof(Iface) + " is null");

                    throw new InvalidOperationException(nameof(WebView2Profile8Interface) + "=>" + nameof(Iface) + " is null");
                }
                return _Iface.Interface;
            }
            set => _Iface = new ComObjectHolder<ICoreWebView2Profile8>(value);
        }
        public WebView2Profile8Interface(ICoreWebView2Profile8 iface) : base(iface)
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

        public void Delete()
        {
            this.Iface.Delete();
        }

        public void add_Deleted([In, MarshalAs(UnmanagedType.Interface)] ICoreWebView2ProfileDeletedEventHandler eventHandler, out EventRegistrationToken token)
        {
            this.Iface.add_Deleted(eventHandler, out token);
        }

        public void remove_Deleted([In] EventRegistrationToken token)
        {
            this.Iface.remove_Deleted(token);
        }
    }
}