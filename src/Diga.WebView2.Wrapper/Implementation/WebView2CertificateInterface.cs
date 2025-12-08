
using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.Types;
using Microsoft.Win32.SafeHandles;
using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace Diga.WebView2.Wrapper.Implementation
{
    public class WebView2CertificateInterface : IDisposable
    {
        // Implementation omitted for brevity
        private ComObjectHolder<ICoreWebView2Certificate> _Iface;
        private bool disposedValue;
        /// Wraps in SafeHandle so resources can be released if consumer forgets to call Dispose. Recommended
        ///             pattern for any type that is not sealed.
        ///             https://docs.microsoft.com/dotnet/api/system.idisposable#idisposable-and-the-inheritance-hierarchy
        private SafeHandle handle = (SafeHandle)new SafeFileHandle(IntPtr.Zero, true);

        private ICoreWebView2Certificate Iface
        {
            get
            {
                if (_Iface == null)
                {
                    Debug.Print(nameof(WebView2CertificateInterface) + "=>" + nameof(Iface) + " is null");
                    throw new InvalidOperationException(nameof(WebView2CertificateInterface) + "=>" + nameof(Iface) + " is null");
                }
                return _Iface.Interface;
            }
            set => _Iface = new ComObjectHolder<ICoreWebView2Certificate>(value);
        }

        public WebView2CertificateInterface(ICoreWebView2Certificate iface)
        {
            Iface = iface ?? throw new ArgumentNullException(nameof(iface));
        }

        public string Subject => Iface.Subject;

        public string Issuer => Iface.Issuer;

        public double ValidFrom => Iface.ValidFrom;

        public double ValidTo => Iface.ValidTo;

        public string DerEncodedSerialNumber => Iface.DerEncodedSerialNumber;

        public string DisplayName => Iface.DisplayName;

        [return: MarshalAs(UnmanagedType.LPWStr)]
        public string ToPemEncoding()
        {
            return Iface.ToPemEncoding();
        }

        public ICoreWebView2StringCollection PemEncodedIssuerCertificateChain => Iface.PemEncodedIssuerCertificateChain;

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: Verwalteten Zustand (verwaltete Objekte) bereinigen
                    handle.Dispose();
                    Iface = null;
                }

                // TODO: Nicht verwaltete Ressourcen (nicht verwaltete Objekte) freigeben und Finalizer überschreiben
                // TODO: Große Felder auf NULL setzen
                disposedValue = true;
            }
        }

        // // TODO: Finalizer nur überschreiben, wenn "Dispose(bool disposing)" Code für die Freigabe nicht verwalteter Ressourcen enthält
        // ~WebView2CertificateInterface()
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