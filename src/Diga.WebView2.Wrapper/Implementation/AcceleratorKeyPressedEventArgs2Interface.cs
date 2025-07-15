using System;
using System.Diagnostics;
using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.Types;

namespace Diga.WebView2.Wrapper.Implementation
{
    /// <summary>
    /// Provides data for the AcceleratorKeyPressed event in WebView2 with additional browser accelerator key information.
    /// </summary>
    public class AcceleratorKeyPressedEventArgs2Interface : AcceleratorKeyPressedEventArgsInterface
    {
        private ComObjectHolder<ICoreWebView2AcceleratorKeyPressedEventArgs2> _Iface;
        private ICoreWebView2AcceleratorKeyPressedEventArgs2 Iface
        {
            get
            {
                if (_Iface == null)
                {
                    Debug.Print(nameof(AcceleratorKeyPressedEventArgs2Interface) + "=>" + nameof(Iface) + " is null");

                    throw new InvalidOperationException(nameof(AcceleratorKeyPressedEventArgs2Interface) + "=>" + nameof(Iface) + " is null");
                }
                return _Iface.Interface;
            }
            set => _Iface = new ComObjectHolder<ICoreWebView2AcceleratorKeyPressedEventArgs2>(value);
        }
        public AcceleratorKeyPressedEventArgs2Interface(ICoreWebView2AcceleratorKeyPressedEventArgs2 iface) : base(iface)
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

        /// <summary>
        /// Gets or sets a value indicating whether the browser accelerator key is enabled for this event.
        /// </summary>
        public int IsBrowserAcceleratorKeyEnabled { get => this.Iface.IsBrowserAcceleratorKeyEnabled; set => this.Iface.IsBrowserAcceleratorKeyEnabled = value; }
    }
}