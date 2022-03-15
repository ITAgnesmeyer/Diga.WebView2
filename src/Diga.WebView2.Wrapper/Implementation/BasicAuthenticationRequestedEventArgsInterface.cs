using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Diga.WebView2.Interop;

namespace Diga.WebView2.Wrapper.Implementation
{
    public class BasicAuthenticationRequestedEventArgsInterface : ICoreWebView2BasicAuthenticationRequestedEventArgs, IDisposable
    {
        private ICoreWebView2BasicAuthenticationRequestedEventArgs _Args;
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
                return this._Args;
            }
            set { this._Args = value; }
        }

        public BasicAuthenticationRequestedEventArgsInterface(ICoreWebView2BasicAuthenticationRequestedEventArgs args)
        {
            _Args = args ?? throw new ArgumentNullException(nameof(args));
        }
        public string uri => this.Args.uri;

        public string Challenge => this.Args.Challenge;

        public ICoreWebView2BasicAuthenticationResponse Response => this.Args.Response;

        public int Cancel { get => this.Args.Cancel; set => this.Args.Cancel = value; }

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

       
        public void Dispose()
        {
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}