using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.Types;
using Microsoft.Win32.SafeHandles;

namespace Diga.WebView2.Wrapper.Implementation
{
    public class ServerCertificateErrorDetectedEventArgsInterface : IDisposable
    {
        // Implementation omitted for brevity

        private ComObjectHolder<ICoreWebView2ServerCertificateErrorDetectedEventArgs> _Args;
        private bool _IsDisposed;
        /// Wraps in SafeHandle so resources can be released if consumer forgets to call Dispose. Recommended
        ///             pattern for any type that is not sealed.
        ///             https://docs.microsoft.com/dotnet/api/system.idisposable#idisposable-and-the-inheritance-hierarchy
        private SafeHandle handle = (SafeHandle)new SafeFileHandle(IntPtr.Zero, true);
        

        private ICoreWebView2ServerCertificateErrorDetectedEventArgs Args
        {
            get
            {
                if (this._Args == null)
                {
                    Debug.Print(nameof(ICoreWebView2ServerCertificateErrorDetectedEventArgs) + "=>" + nameof(this.Args) + " is null");

                    throw new InvalidOperationException(nameof(ServerCertificateErrorDetectedEventArgsInterface) + "=>" + nameof(this.Args) + " is null");
                }
                return this._Args.Interface;
            }
            set { this._Args = new ComObjectHolder<ICoreWebView2ServerCertificateErrorDetectedEventArgs>(value); }
        }

        public ServerCertificateErrorDetectedEventArgsInterface(ICoreWebView2ServerCertificateErrorDetectedEventArgs args)
        {
            if (args == null)
                throw new ArgumentNullException(nameof(args));
            this.Args = args;
        }

        public COREWEBVIEW2_WEB_ERROR_STATUS ErrorStatus => Args.ErrorStatus;

        public string RequestUri => Args.RequestUri;

        public ICoreWebView2Certificate ServerCertificate => Args.ServerCertificate;

        public COREWEBVIEW2_SERVER_CERTIFICATE_ERROR_ACTION Action { get => Args.Action; set => Args.Action = value; }

        [return: MarshalAs(UnmanagedType.Interface)]
        public ICoreWebView2Deferral GetDeferral()
        {
            return Args.GetDeferral();
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_IsDisposed)
            {
                if (disposing)
                {
                    // TODO: Verwalteten Zustand (verwaltete Objekte) bereinigen
                    this.handle.Dispose();
                    this._Args = null;
                }

                // TODO: Nicht verwaltete Ressourcen (nicht verwaltete Objekte) freigeben und Finalizer überschreiben
                // TODO: Große Felder auf NULL setzen
                _IsDisposed = true;
            }
        }

        // // TODO: Finalizer nur überschreiben, wenn "Dispose(bool disposing)" Code für die Freigabe nicht verwalteter Ressourcen enthält
        // ~ServerCertificateErrorDetectedEventArgsInterface()
        // {
        //     // Ändern Sie diesen Code nicht. Fügen Sie Bereinigungscode in der Methode "Dispose(bool disposing)" ein.
        //     Dispose(disposing: false);
        // }

        public void Dispose()
        {
            // Ändern Sie diesen Code nicht. Fügen Sie Bereinigungscode in der Methode "Dispose(bool disposing)" ein.
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}