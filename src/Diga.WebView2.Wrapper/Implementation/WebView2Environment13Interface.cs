using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.Types;

namespace Diga.WebView2.Wrapper.Implementation
{
    public class WebView2Environment13Interface : WebView2Environment12Interface, ICoreWebView2Environment13
    {
        private ComObjectHolder<ICoreWebView2Environment13> _Iface;
        private ICoreWebView2Environment13 Iface
        {
            get
            {
                if (_Iface == null)
                {
                    Debug.Print(nameof(WebView2Environment13Interface) + "=>" + nameof(Iface) + " is null");

                    throw new InvalidOperationException(nameof(WebView2Environment13Interface) + "=>" + nameof(Iface) + " is null");
                }
                return _Iface.Interface;
            }
            set => _Iface = new ComObjectHolder<ICoreWebView2Environment13>(value);
        }
        public WebView2Environment13Interface(ICoreWebView2Environment13 iface) : base(iface)
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

        public void GetProcessExtendedInfos([In, MarshalAs(UnmanagedType.Interface)] ICoreWebView2GetProcessExtendedInfosCompletedHandler handler)
        {
            this.Iface.GetProcessExtendedInfos(handler);
        }
    }
}