using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.Types;

namespace Diga.WebView2.Wrapper.Implementation
{



    /// <summary>
    /// Provides data for the BasicAuthenticationRequested event in WebView2.
    /// </summary>
    public class BasicAuthenticationRequestedEventArgsInterface : IDisposable
    {
        private ComObjectHolder<ICoreWebView2BasicAuthenticationRequestedEventArgs> _Args;
        private bool disposedValue;

        private ICoreWebView2BasicAuthenticationRequestedEventArgs Args
        {
            get
            {
                if (this._Args == null)
                {
                    Debug.Print(nameof(BasicAuthenticationRequestedEventArgsInterface) + "=>" + nameof(this.Args) + " is null");

                    throw new InvalidOperationException(nameof(BasicAuthenticationRequestedEventArgsInterface) + "=>" + nameof(this.Args) + " is null");
                }
                return this._Args.Interface;
            }
            set { this._Args = new ComObjectHolder<ICoreWebView2BasicAuthenticationRequestedEventArgs>(value); }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BasicAuthenticationRequestedEventArgsInterface"/> class.
        /// </summary>
        /// <param name="args">The native BasicAuthenticationRequested event arguments.</param>
        /// <exception cref="ArgumentNullException">Thrown when args is null.</exception>
        public BasicAuthenticationRequestedEventArgsInterface(ICoreWebView2BasicAuthenticationRequestedEventArgs args)
        {
            this.Args = args ?? throw new ArgumentNullException(nameof(args));
        }
        /// <summary>
        /// Gets the URI for which authentication is requested.
        /// </summary>
        public string uri => this.Args.uri;

        /// <summary>
        /// Gets the authentication challenge string.
        /// </summary>
        public string Challenge => this.Args.Challenge;

        /// <summary>
        /// Gets the response object for providing credentials.
        /// </summary>
        public ICoreWebView2BasicAuthenticationResponse Response => this.Args.Response;

        /// <summary>
        /// Gets or sets a value indicating whether the authentication request is canceled.
        /// </summary>
        public int Cancel { get => this.Args.Cancel; set => this.Args.Cancel = value; }

        /// <summary>
        /// Gets a deferral object to defer the authentication decision.
        /// </summary>
        /// <returns>An <see cref="ICoreWebView2Deferral"/> object.</returns>
        [return: MarshalAs(UnmanagedType.Interface)]
        public ICoreWebView2Deferral GetDeferral()
        {
            return this.Args.GetDeferral();
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposedValue)
            {
                if (disposing)
                {
                    this._Args = null;
                }

              
                this.disposedValue = true;
            }
        }

       
        /// <summary>
        /// Disposes the object and releases resources.
        /// </summary>
        public void Dispose()
        {
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}