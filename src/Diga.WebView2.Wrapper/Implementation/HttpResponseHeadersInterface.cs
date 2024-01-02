using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.Types;
using Microsoft.Win32.SafeHandles;

// ReSharper disable once CheckNamespace
namespace Diga.WebView2.Wrapper.Implementation
{
    public class HttpResponseHeadersInterface : IDisposable
    {
        private ComObjectHolder<ICoreWebView2HttpResponseHeaders> _Iface;
        private bool _IsDesposed;

        /// Wraps in SafeHandle so resources can be released if consumer forgets to call Dispose. Recommended
        ///             pattern for any type that is not sealed.
        ///             https://docs.microsoft.com/dotnet/api/system.idisposable#idisposable-and-the-inheritance-hierarchy
        private SafeHandle handle = new SafeFileHandle(IntPtr.Zero, true);
        public HttpResponseHeadersInterface(ICoreWebView2HttpResponseHeaders iface)
        {
            Iface = iface ?? throw new ArgumentNullException(nameof(iface));
        }

        private ICoreWebView2HttpResponseHeaders Iface
        {
            get
            {
                if (_Iface == null)
                {
                    Debug.Print(nameof(HttpResponseHeadersInterface) + "=>" + nameof(Iface) + " is null");

                    throw new InvalidOperationException(nameof(HttpResponseHeadersInterface) + "=>" + nameof(Iface) + " is null");
                }

                return _Iface.Interface;
            }
            set => _Iface = new ComObjectHolder<ICoreWebView2HttpResponseHeaders>(value);
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

        public void AppendHeader([In, MarshalAs(UnmanagedType.LPWStr)] string name, [In, MarshalAs(UnmanagedType.LPWStr)] string value)
        {
            Iface.AppendHeader(name, value);
        }

        public int Contains([In, MarshalAs(UnmanagedType.LPWStr)] string name)
        {
            return Iface.Contains(name);
        }

        [return: MarshalAs(UnmanagedType.LPWStr)]
        public string GetHeader([In, MarshalAs(UnmanagedType.LPWStr)] string name)
        {
            return Iface.GetHeader(name);
        }

        [return: MarshalAs(UnmanagedType.Interface)]
        public ICoreWebView2HttpHeadersCollectionIterator GetHeaders([In, MarshalAs(UnmanagedType.LPWStr)] string name)
        {
            return Iface.GetHeaders(name);
        }

        [return: MarshalAs(UnmanagedType.Interface)]
        public ICoreWebView2HttpHeadersCollectionIterator GetIterator()
        {
            return Iface.GetIterator();
        }
    }
}