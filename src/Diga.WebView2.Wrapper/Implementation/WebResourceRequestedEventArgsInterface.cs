using System;
using System.Runtime.InteropServices;
using Diga.WebView2.Interop;
using Microsoft.Win32.SafeHandles;
using System.Diagnostics;

/* Nicht gemergte Änderung aus Projekt "Diga.WebView2.Wrapper (netstandard2.1)"
Vor:
using Diga.WebView2.Wrapper.Types;
Nach:
using Diga.WebView2.Wrapper.Types;
using Diga;
using Diga.WebView2;
using Diga.WebView2.Wrapper;
using Diga.WebView2.Wrapper.EventArguments;
using Diga.WebView2.Wrapper.Implementation;
*/
using Diga.WebView2.Wrapper.Types;


namespace Diga.WebView2.Wrapper.Implementation
{
    public class WebResourceRequestedEventArgsInterface : EventArgs, IDisposable//, ICoreWebView2WebResourceRequestedEventArgs
    {
        private ComObjectHolder<ICoreWebView2WebResourceRequestedEventArgs> _Iface;
        private bool _IsDesposed;

        /// Wraps in SafeHandle so resources can be released if consumer forgets to call Dispose. Recommended
        ///             pattern for any type that is not sealed.
        ///             https://docs.microsoft.com/dotnet/api/system.idisposable#idisposable-and-the-inheritance-hierarchy
        private SafeHandle handle = new SafeFileHandle(IntPtr.Zero, true);
        public WebResourceRequestedEventArgsInterface(ICoreWebView2WebResourceRequestedEventArgs iface)
        {
            Iface = iface ?? throw new ArgumentNullException(nameof(iface));
        }

        private ICoreWebView2WebResourceRequestedEventArgs Iface
        {
            get
            {
                if (_Iface == null)
                {
                    Debug.Print(nameof(WebResourceRequestedEventArgsInterface) + "=>" + nameof(Iface) + " is null");

                    throw new InvalidOperationException(nameof(WebResourceRequestedEventArgsInterface) + "=>" + nameof(Iface) + " is null");
                }

                return _Iface.Interface;
            }
            set => _Iface = new ComObjectHolder<ICoreWebView2WebResourceRequestedEventArgs>(value);
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

        public ICoreWebView2WebResourceRequest Request => Iface.Request;

        public ICoreWebView2WebResourceResponse Response { get => Iface.Response; set => Iface.Response = value; }

        [return: MarshalAs(UnmanagedType.Interface)]
        public ICoreWebView2Deferral GetDeferral()
        {
            return Iface.GetDeferral();
        }

        public COREWEBVIEW2_WEB_RESOURCE_CONTEXT ResourceContext => Iface.ResourceContext;
    }
}