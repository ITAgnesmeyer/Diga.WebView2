using Diga.WebView2.Interop;
using System;
using System.Diagnostics;
using Diga.WebView2.Wrapper.Types;

namespace Diga.WebView2.Wrapper.Implementation
{
    public class NewWindowRequestedEventArgs3Interface : NewWindowRequestedEventArgs2Interface
    {
        private ComObjectHolder<ICoreWebView2NewWindowRequestedEventArgs3> _Iface;
        private ICoreWebView2NewWindowRequestedEventArgs3 Iface
        {
            get
            {
                if (_Iface == null)
                {
                    Debug.Print(nameof(NewWindowRequestedEventArgs3Interface) + "=>" + nameof(Iface) + " is null");

                    throw new InvalidOperationException(nameof(NewWindowRequestedEventArgs3Interface) + "=>" + nameof(Iface) + " is null");
                }
                return _Iface.Interface;
            }
            set => _Iface = new ComObjectHolder<ICoreWebView2NewWindowRequestedEventArgs3>(value);
        }
        public NewWindowRequestedEventArgs3Interface(ICoreWebView2NewWindowRequestedEventArgs3 iface) : base(iface)
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

        public ICoreWebView2FrameInfo OriginalSourceFrameInfo => this.Iface.OriginalSourceFrameInfo;
    }
}