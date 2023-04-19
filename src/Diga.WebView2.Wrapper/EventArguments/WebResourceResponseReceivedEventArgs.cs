using System;
using Diga.WebView2.Interop;

namespace Diga.WebView2.Wrapper.EventArguments
{
    public class WebResourceResponseReceivedEventArgs :EventArgs, ICoreWebView2WebResourceResponseReceivedEventArgs,IDisposable
    {
        private ICoreWebView2WebResourceResponseReceivedEventArgs _Args;
        private bool disposedValue;

        public WebResourceResponseReceivedEventArgs(ICoreWebView2WebResourceResponseReceivedEventArgs args)
        {
            this._Args = args;
        }

        private ICoreWebView2WebResourceResponseReceivedEventArgs Tointerface()
        {
            return this._Args;
        }

        public WebResourceRequest Request => new WebResourceRequest(this.Tointerface().Request);

        public WebResourceResponseView Response => new WebResourceResponseView(this.Tointerface().Response);

        ICoreWebView2WebResourceRequest ICoreWebView2WebResourceResponseReceivedEventArgs.Request
        {
            get
            {
                if (this._Args == null)
                    return null;
                return this._Args.Request;
            }
        } 

        ICoreWebView2WebResourceResponseView ICoreWebView2WebResourceResponseReceivedEventArgs.Response => this._Args.Response;

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: Verwalteten Zustand (verwaltete Objekte) bereinigen
                }

                this._Args = null;
                // TODO: Nicht verwaltete Ressourcen (nicht verwaltete Objekte) freigeben und Finalizer überschreiben
                // TODO: Große Felder auf NULL setzen
                disposedValue = true;
            }
        }

        // // TODO: Finalizer nur überschreiben, wenn "Dispose(bool disposing)" Code für die Freigabe nicht verwalteter Ressourcen enthält
        ~WebResourceResponseReceivedEventArgs()
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