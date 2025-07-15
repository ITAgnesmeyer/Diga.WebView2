using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.Types;
using Microsoft.Win32.SafeHandles;
using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace Diga.WebView2.Wrapper.Implementation
{
    /// <summary>
    /// Provides data for the DOMContentLoaded event in WebView2.
    /// </summary>
    public class DOMContentLoadedEventArgsInterface : IDisposable
    {
        private ComObjectHolder<ICoreWebView2DOMContentLoadedEventArgs> _Iface;
        private bool _IsDesposed;

        /// Wraps in SafeHandle so resources can be released if consumer forgets to call Dispose. Recommended
        ///             pattern for any type that is not sealed.
        ///             https://docs.microsoft.com/dotnet/api/system.idisposable#idisposable-and-the-inheritance-hierarchy
        private SafeHandle handle = new SafeFileHandle(IntPtr.Zero, true);
        public DOMContentLoadedEventArgsInterface(ICoreWebView2DOMContentLoadedEventArgs iface)
        {
            Iface = iface ?? throw new ArgumentNullException(nameof(iface));
        }

        private ICoreWebView2DOMContentLoadedEventArgs Iface
        {
            get
            {
                if (_Iface == null)
                {
                    Debug.Print(nameof(DOMContentLoadedEventArgsInterface) + "=>" + nameof(Iface) + " is null");

                    throw new InvalidOperationException(nameof(DOMContentLoadedEventArgsInterface) + "=>" + nameof(Iface) + " is null");
                }

                return _Iface.Interface;
            }
            set => _Iface = new ComObjectHolder<ICoreWebView2DOMContentLoadedEventArgs>(value);
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

        /// <summary>
        /// Releases the resources used by the DOMContentLoadedEventArgsInterface instance.
        /// </summary>
        public void Dispose()
        {
            // Ändern Sie diesen Code nicht. Fügen Sie Bereinigungscode in der Methode "Dispose(bool disposing)" ein.
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
        /// <summary>
        /// Returns the underlying COM interface for advanced scenarios.
        /// </summary>
        /// <returns>The <see cref="ICoreWebView2DOMContentLoadedEventArgs"/> interface.</returns>
        public ICoreWebView2DOMContentLoadedEventArgs ToInterface()
        {
            return Iface;
        }

        /// <summary>
        /// Gets the navigation ID associated with the DOMContentLoaded event.
        /// </summary>
        public ulong NavigationId => Iface.NavigationId;
    }
}