using System;
using System.IO;
using System.Runtime.InteropServices.ComTypes;
using Diga.WebView2.Interop;

namespace Diga.WebView2.Wrapper
{
    public class WebResourceResponse : ICoreWebView2WebResourceResponse,IDisposable
    {
        private  ICoreWebView2WebResourceResponse _Interface;
        private bool disposedValue;

        public WebResourceResponse()
        {
            this._Interface = this.ToInterface();
        }
        public WebResourceResponse(ICoreWebView2WebResourceResponse iface)
        {
            this._Interface = iface;
        }

        private ICoreWebView2WebResourceResponse ToInterface()
        {
            return this;
        }



        public Stream Content
        {
            get
            {
                if (this.ToInterface().Content == null) return null;
                return new ComStream(this.ToInterface().Content);
            }
        }

        public int StatusCode => this.ToInterface().StatusCode;

        public string ReasonPhrase
        {
            get => this.ToInterface().ReasonPhrase;
            set => this.ToInterface().ReasonPhrase = value;
        }





        public HttpResponseHeaders Headers
        {
            get
            {
                if (this.ToInterface().Headers == null) return null;
                return new HttpResponseHeaders(this.ToInterface().Headers);
            }
        }

        IStream ICoreWebView2WebResourceResponse.Content
        {
            get => this._Interface.Content;
            set => this._Interface.Content = value;
        }

        ICoreWebView2HttpResponseHeaders ICoreWebView2WebResourceResponse.Headers => this._Interface.Headers;

        int ICoreWebView2WebResourceResponse.StatusCode
        {
            get => this._Interface.StatusCode;
            set => this._Interface.StatusCode = value;
        }

        string ICoreWebView2WebResourceResponse.ReasonPhrase
        {
            get => this._Interface.ReasonPhrase;
            set => this._Interface.ReasonPhrase = value;
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: Verwalteten Zustand (verwaltete Objekte) bereinigen
                }

                this._Interface = null;
                // TODO: Nicht verwaltete Ressourcen (nicht verwaltete Objekte) freigeben und Finalizer überschreiben
                // TODO: Große Felder auf NULL setzen
                disposedValue = true;
            }
        }

        // // TODO: Finalizer nur überschreiben, wenn "Dispose(bool disposing)" Code für die Freigabe nicht verwalteter Ressourcen enthält
        ~WebResourceResponse()
        {
            // Ändern Sie diesen Code nicht. Fügen Sie Bereinigungscode in der Methode "Dispose(bool disposing)" ein.
            Dispose(disposing: false);
        }

        public void Dispose()
        {
            // Ändern Sie diesen Code nicht. Fügen Sie Bereinigungscode in der Methode "Dispose(bool disposing)" ein.
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}