using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.Types;
using Microsoft.Win32.SafeHandles;

namespace Diga.WebView2.Wrapper.Implementation
{


    public class WebView2SharedBufferInteface : IDisposable
    {
        private ComObjectHolder<ICoreWebView2SharedBuffer> _Iface;
        private bool _IsDesposed;

        /// Wraps in SafeHandle so resources can be released if consumer forgets to call Dispose. Recommended
        ///             pattern for any type that is not sealed.
        ///             https://docs.microsoft.com/dotnet/api/system.idisposable#idisposable-and-the-inheritance-hierarchy
        private SafeHandle handle = new SafeFileHandle(IntPtr.Zero, true);
        public WebView2SharedBufferInteface(ICoreWebView2SharedBuffer iface)
        {
            Iface = iface ?? throw new ArgumentNullException(nameof(iface));
        }

        private ICoreWebView2SharedBuffer Iface
        {
            get
            {
                if (_Iface == null)
                {
                    Debug.Print(nameof(WebView2SharedBufferInteface) + "=>" + nameof(Iface) + " is null");

                    throw new InvalidOperationException(nameof(WebView2SharedBufferInteface) + "=>" + nameof(Iface) + " is null");
                }

                return _Iface.Interface;
            }
            set => _Iface = new ComObjectHolder<ICoreWebView2SharedBuffer>(value);
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

        public ulong Size => Iface.Size;

        public IntPtr Buffer => Iface.Buffer;

        [return: MarshalAs(UnmanagedType.Interface)]
        public IStream OpenStream()
        {
            return Iface.OpenStream();
        }

        public IntPtr FileMappingHandle => Iface.FileMappingHandle;

        public void Close()
        {
            Iface.Close();
        }
    }
}