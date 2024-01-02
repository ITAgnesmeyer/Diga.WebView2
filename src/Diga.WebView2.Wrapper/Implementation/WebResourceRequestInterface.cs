using System;
using Diga.WebView2.Interop;
using System.Runtime.InteropServices.ComTypes;
using Diga.WebView2.Wrapper.Types;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

/* Nicht gemergte Änderung aus Projekt "Diga.WebView2.Wrapper (netstandard2.0)"
Vor:
using System.Diagnostics;
Nach:
using System.Diagnostics;
using Diga;
using Diga.WebView2;
using Diga.WebView2.Wrapper;
using Diga.WebView2.Wrapper.Implementation;
*/
using System.Diagnostics;

namespace Diga.WebView2.Wrapper.Implementation
{
    public class WebResourceRequestInterface : IDisposable
    {
        private ComObjectHolder<ICoreWebView2WebResourceRequest> _Iface;
        private bool _IsDesposed;

        /// Wraps in SafeHandle so resources can be released if consumer forgets to call Dispose. Recommended
        ///             pattern for any type that is not sealed.
        ///             https://docs.microsoft.com/dotnet/api/system.idisposable#idisposable-and-the-inheritance-hierarchy
        private SafeHandle handle = new SafeFileHandle(IntPtr.Zero, true);
        public WebResourceRequestInterface(ICoreWebView2WebResourceRequest iface)
        {
            Iface = iface ?? throw new ArgumentNullException(nameof(iface));
        }

        private ICoreWebView2WebResourceRequest Iface
        {
            get
            {
                if (_Iface == null)
                {
                    Debug.Print(nameof(WebResourceRequestInterface) + "=>" + nameof(Iface) + " is null");

                    throw new InvalidOperationException(nameof(WebResourceRequestInterface) + "=>" + nameof(Iface) + " is null");
                }

                return _Iface.Interface;
            }
            set => _Iface = new ComObjectHolder<ICoreWebView2WebResourceRequest>(value);
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

        public string uri { get => Iface.uri; set => Iface.uri = value; }
        public string Method { get => Iface.Method; set => Iface.Method = value; }
        public IStream Content { get => Iface.Content; set => Iface.Content = value; }

        public ICoreWebView2HttpRequestHeaders Headers => Iface.Headers;

        public ICoreWebView2WebResourceRequest ToInterface() => Iface;
    }
}