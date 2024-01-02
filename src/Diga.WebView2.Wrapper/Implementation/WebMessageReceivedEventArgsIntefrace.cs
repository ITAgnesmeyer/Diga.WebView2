using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.Types;
using Microsoft.Win32.SafeHandles;

namespace Diga.WebView2.Wrapper.Implementation
{
    public class WebMessageReceivedEventArgsIntefrace : EventArgs, IDisposable//, ICoreWebView2WebMessageReceivedEventArgs
    {
        private ComObjectHolder<ICoreWebView2WebMessageReceivedEventArgs> _Iface;
        private bool _IsDesposed;

        /// Wraps in SafeHandle so resources can be released if consumer forgets to call Dispose. Recommended
        ///             pattern for any type that is not sealed.
        ///             https://docs.microsoft.com/dotnet/api/system.idisposable#idisposable-and-the-inheritance-hierarchy
        private SafeHandle handle = new SafeFileHandle(IntPtr.Zero, true);
        public WebMessageReceivedEventArgsIntefrace(ICoreWebView2WebMessageReceivedEventArgs iface)
        {
            Iface = iface ?? throw new ArgumentNullException(nameof(iface));
        }

        private ICoreWebView2WebMessageReceivedEventArgs Iface
        {
            get
            {
                if (_Iface == null)
                {
                    Debug.Print(nameof(WebMessageReceivedEventArgsIntefrace) + "=>" + nameof(Iface) + " is null");

                    throw new InvalidOperationException(nameof(WebMessageReceivedEventArgsIntefrace) + "=>" + nameof(Iface) + " is null");
                }

                return _Iface.Interface;
            }
            set => _Iface = new ComObjectHolder<ICoreWebView2WebMessageReceivedEventArgs>(value);
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

        public string Source => Iface.Source;

        public string webMessageAsJson => Iface.webMessageAsJson;

        [return: MarshalAs(UnmanagedType.LPWStr)]
        public string TryGetWebMessageAsString()
        {
            return Iface.TryGetWebMessageAsString();
        }
    }
}