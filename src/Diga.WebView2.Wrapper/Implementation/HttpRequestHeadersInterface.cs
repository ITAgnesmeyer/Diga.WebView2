using System;
using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.Types;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;
using System.Diagnostics;

namespace Diga.WebView2.Wrapper.Implementation
{
    /// <summary>
    /// Provides methods to manipulate HTTP request headers for WebView2.
    /// </summary>
    public class HttpRequestHeadersInterface : IDisposable, ICoreWebView2HttpRequestHeaders
    {
        private ComObjectHolder<ICoreWebView2HttpRequestHeaders> _Iface;
        private bool _IsDesposed;

        /// Wraps in SafeHandle so resources can be released if consumer forgets to call Dispose. Recommended
        ///             pattern for any type that is not sealed.
        ///             https://docs.microsoft.com/dotnet/api/system.idisposable#idisposable-and-the-inheritance-hierarchy
        private SafeHandle handle = new SafeFileHandle(IntPtr.Zero, true);
        public HttpRequestHeadersInterface(ICoreWebView2HttpRequestHeaders iface)
        {
            Iface = iface ?? throw new ArgumentNullException(nameof(iface));
        }

        private ICoreWebView2HttpRequestHeaders Iface
        {
            get
            {
                if (_Iface == null)
                {
                    Debug.Print(nameof(HttpRequestHeadersInterface) + "=>" + nameof(Iface) + " is null");

                    throw new InvalidOperationException(nameof(HttpRequestHeadersInterface) + "=>" + nameof(Iface) + " is null");
                }

                return _Iface.Interface;
            }
            set => _Iface = new ComObjectHolder<ICoreWebView2HttpRequestHeaders>(value);
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
        /// Gets the value of the specified header.
        /// </summary>
        /// <param name="name">The name of the header.</param>
        /// <returns>The value of the header, or null if not found.</returns>
        [return: MarshalAs(UnmanagedType.LPWStr)]
        public string GetHeader([In, MarshalAs(UnmanagedType.LPWStr)] string name)
        {
            return Iface.GetHeader(name);
        }

        /// <summary>
        /// Gets an iterator for all values of the specified header.
        /// </summary>
        /// <param name="name">The name of the header.</param>
        /// <returns>An iterator for the header values.</returns>
        [return: MarshalAs(UnmanagedType.Interface)]
        public ICoreWebView2HttpHeadersCollectionIterator GetHeaders([In, MarshalAs(UnmanagedType.LPWStr)] string name)
        {
            return Iface.GetHeaders(name);
        }

        /// <summary>
        /// Determines whether the specified header exists.
        /// </summary>
        /// <param name="name">The name of the header.</param>
        /// <returns>1 if the header exists, otherwise 0.</returns>
        public int Contains([In, MarshalAs(UnmanagedType.LPWStr)] string name)
        {
            return Iface.Contains(name);
        }

        /// <summary>
        /// Sets the value of the specified header.
        /// </summary>
        /// <param name="name">The name of the header.</param>
        /// <param name="value">The value to set.</param>
        public void SetHeader([In, MarshalAs(UnmanagedType.LPWStr)] string name, [In, MarshalAs(UnmanagedType.LPWStr)] string value)
        {
            Iface.SetHeader(name, value);
        }

        /// <summary>
        /// Removes the specified header.
        /// </summary>
        /// <param name="name">The name of the header to remove.</param>
        public void RemoveHeader([In, MarshalAs(UnmanagedType.LPWStr)] string name)
        {
            Iface.RemoveHeader(name);
        }

        /// <summary>
        /// Gets an iterator for all headers in the collection.
        /// </summary>
        /// <returns>An iterator for all headers.</returns>
        [return: MarshalAs(UnmanagedType.Interface)]
        public ICoreWebView2HttpHeadersCollectionIterator GetIterator()
        {
            return Iface.GetIterator();
        }
    }
}