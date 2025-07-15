using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.Types;
using Microsoft.Win32.SafeHandles;

namespace Diga.WebView2.Wrapper.Implementation
{
    /// <summary>
    /// Provides data for the AcceleratorKeyPressed event in WebView2.
    /// </summary>
    public class AcceleratorKeyPressedEventArgsInterface : IDisposable
    {
        private ComObjectHolder<ICoreWebView2AcceleratorKeyPressedEventArgs> _Iface;
        private bool _IsDesposed;

        /// Wraps in SafeHandle so resources can be released if consumer forgets to call Dispose. Recommended
        ///             pattern for any type that is not sealed.
        ///             https://docs.microsoft.com/dotnet/api/system.idisposable#idisposable-and-the-inheritance-hierarchy
        private SafeHandle handle = new SafeFileHandle(IntPtr.Zero, true);
        public AcceleratorKeyPressedEventArgsInterface(ICoreWebView2AcceleratorKeyPressedEventArgs iface)
        {
            Iface = iface ?? throw new ArgumentNullException(nameof(iface));
        }

        private ICoreWebView2AcceleratorKeyPressedEventArgs Iface
        {
            get
            {
                if (_Iface == null)
                {
                    Debug.Print(nameof(AcceleratorKeyPressedEventArgsInterface) + "=>" + nameof(Iface) + " is null");

                    throw new InvalidOperationException(nameof(AcceleratorKeyPressedEventArgsInterface) + "=>" + nameof(Iface) + " is null");
                }

                return _Iface.Interface;
            }
            set => _Iface = new ComObjectHolder<ICoreWebView2AcceleratorKeyPressedEventArgs>(value);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_IsDesposed)
            {
                if (disposing)
                {
                    handle.Dispose();
                    _Iface = null;
                }

                _IsDesposed = true;
            }
        }

        public void Dispose()
        {
            // Ändern Sie diesen Code nicht. Fügen Sie Bereinigungscode in der Methode "Dispose(bool disposing)" ein.
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }

        /// <summary>
        /// Gets the kind of key event (e.g., key down, key up, system key down, system key up).
        /// </summary>
        public COREWEBVIEW2_KEY_EVENT_KIND KeyEventKind => this.Iface.KeyEventKind;

        /// <summary>
        /// Gets the virtual key code of the key event.
        /// </summary>
        public uint VirtualKey => this.Iface.VirtualKey;

        /// <summary>
        /// Gets the lParam value for the key event.
        /// </summary>
        public int KeyEventLParam => this.Iface.KeyEventLParam;

        /// <summary>
        /// Gets the physical key status for the key event.
        /// </summary>
        public COREWEBVIEW2_PHYSICAL_KEY_STATUS PhysicalKeyStatus => this.Iface.PhysicalKeyStatus;

        /// <summary>
        /// Gets or sets a value indicating whether the key event is handled.
        /// </summary>
        public int Handled { get => this.Iface.Handled; set => this.Iface.Handled = value; }
    }
}