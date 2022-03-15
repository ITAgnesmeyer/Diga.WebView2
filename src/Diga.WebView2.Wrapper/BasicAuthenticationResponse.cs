using System;
using System.Diagnostics;
using Diga.WebView2.Interop;

namespace Diga.WebView2.Wrapper
{
    public class BasicAuthenticationResponse : ICoreWebView2BasicAuthenticationResponse, IDisposable
    {
        private ICoreWebView2BasicAuthenticationResponse _Response;
        private bool disposedValue;

        private ICoreWebView2BasicAuthenticationResponse Response
        {
            get
            {
                if (this._Response == null)
                {
                    Debug.Print(nameof(BasicAuthenticationResponse) + "=>" + nameof(this.Response) + " is null");

                    throw new InvalidOperationException(nameof(BasicAuthenticationResponse) + "=>" + nameof(this.Response) + " is null");
                }
                return this._Response;
            }
            set { this._Response = value; }
        }

        public BasicAuthenticationResponse(ICoreWebView2BasicAuthenticationResponse response)
        {

            this._Response = response ?? throw new ArgumentNullException(nameof(response));
        }

        public string UserName { get => this.Response.UserName; set => this.Response.UserName = value; }
        public string Password { get => this.Response.Password; set => this.Response.Password = value; }

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposedValue)
            {
                if (disposing)
                {
                    this._Response = null;
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