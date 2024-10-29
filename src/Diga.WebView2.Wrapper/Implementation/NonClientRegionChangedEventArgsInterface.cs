using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.Types;
using Microsoft.Win32.SafeHandles;
using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace Diga.WebView2.Wrapper.Implementation
{
    public class NonClientRegionChangedEventArgsInterface : EventArgs, IDisposable, ICoreWebView2NonClientRegionChangedEventArgs
    {
        private ComObjectHolder<ICoreWebView2NonClientRegionChangedEventArgs> _Iface;
        /// Wraps in SafeHandle so resources can be released if consumer forgets to call Dispose. Recommended
        ///             pattern for any type that is not sealed.
        ///             https://docs.microsoft.com/dotnet/api/system.idisposable#idisposable-and-the-inheritance-hierarchy
        private readonly SafeHandle handle = new SafeFileHandle(IntPtr.Zero, true);
        private ICoreWebView2NonClientRegionChangedEventArgs Iface
        {
            get
            {
                if (_Iface == null)
                {
                    Debug.Print(nameof(NonClientRegionChangedEventArgsInterface) + "=>" + nameof(Iface) + " is null");

                    throw new InvalidOperationException(nameof(NonClientRegionChangedEventArgsInterface) + "=>" + nameof(Iface) + " is null");
                }
                return _Iface.Interface;
            }
            set => _Iface = new ComObjectHolder<ICoreWebView2NonClientRegionChangedEventArgs>(value);
        }
        public NonClientRegionChangedEventArgsInterface(ICoreWebView2NonClientRegionChangedEventArgs iface)
        {
            Iface = iface ?? throw new ArgumentNullException(nameof(iface));
        }
        private bool _IsDesposed;
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

        public COREWEBVIEW2_NON_CLIENT_REGION_KIND RegionKind => Iface.RegionKind;
    }

}