using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.Types;
using Microsoft.Win32.SafeHandles;
using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace Diga.WebView2.Wrapper.Implementation
{
    /// <summary>
    /// Provides data for the ClientCertificateRequested event in WebView2.
    /// </summary>
    public class ClientCertificateRequestedEventArgsInterface : IDisposable //, ICoreWebView2ClientCertificateRequestedEventArgs
    {
        private ComObjectHolder<ICoreWebView2ClientCertificateRequestedEventArgs> _Iface;
        private bool _IsDesposed;

        /// Wraps in SafeHandle so resources can be released if consumer forgets to call Dispose. Recommended
        ///             pattern for any type that is not sealed.
        ///             https://docs.microsoft.com/dotnet/api/system.idisposable#idisposable-and-the-inheritance-hierarchy
        private SafeHandle handle = new SafeFileHandle(IntPtr.Zero, true);
        public ClientCertificateRequestedEventArgsInterface(ICoreWebView2ClientCertificateRequestedEventArgs iface)
        {
            Iface = iface ?? throw new ArgumentNullException(nameof(iface));
        }

        private ICoreWebView2ClientCertificateRequestedEventArgs Iface
        {
            get
            {
                if (_Iface == null)
                {
                    Debug.Print(nameof(ClientCertificateRequestedEventArgsInterface) + "=>" + nameof(Iface) + " is null");

                    throw new InvalidOperationException(nameof(ClientCertificateRequestedEventArgsInterface) + "=>" + nameof(Iface) + " is null");
                }

                return _Iface.Interface;
            }
            set => _Iface = new ComObjectHolder<ICoreWebView2ClientCertificateRequestedEventArgs>(value);
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
        /// Gets the host name for which the client certificate is requested.
        /// </summary>
        public string Host => Iface.Host;

        /// <summary>
        /// Gets the port number for which the client certificate is requested.
        /// </summary>
        public int Port => Iface.Port;

        /// <summary>
        /// Gets a value indicating whether the request is made through a proxy.
        /// </summary>
        public int IsProxy => Iface.IsProxy;

        /// <summary>
        /// Gets the collection of allowed certificate authorities.
        /// </summary>
        public ICoreWebView2StringCollection AllowedCertificateAuthorities => Iface.AllowedCertificateAuthorities;

        /// <summary>
        /// Gets the collection of mutually trusted client certificates.
        /// </summary>
        public ICoreWebView2ClientCertificateCollection MutuallyTrustedCertificates => Iface.MutuallyTrustedCertificates;

        /// <summary>
        /// Gets or sets the selected client certificate.
        /// </summary>
        public ICoreWebView2ClientCertificate SelectedCertificate { get => Iface.SelectedCertificate; set => Iface.SelectedCertificate = value; }

        /// <summary>
        /// Gets or sets a value indicating whether the certificate request is canceled.
        /// </summary>
        public int Cancel { get => Iface.Cancel; set => Iface.Cancel = value; }

        /// <summary>
        /// Gets or sets a value indicating whether the certificate request is handled.
        /// </summary>
        public int Handled { get => Iface.Handled; set => Iface.Handled = value; }

        /// <summary>
        /// Gets a deferral object to defer the certificate selection decision.
        /// </summary>
        /// <returns>An <see cref="ICoreWebView2Deferral"/> object.</returns>
        [return: MarshalAs(UnmanagedType.Interface)]
        public ICoreWebView2Deferral GetDeferral()
        {
            return Iface.GetDeferral();
        }
    }
}