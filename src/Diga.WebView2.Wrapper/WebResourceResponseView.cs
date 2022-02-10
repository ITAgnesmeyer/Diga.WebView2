using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Threading.Tasks;
using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.Delegates;
using Diga.WebView2.Wrapper.Types;


namespace Diga.WebView2.Wrapper
{
    public class WebResourceResponseView : ICoreWebView2WebResourceResponseView, IDisposable
    {
        private  ICoreWebView2WebResourceResponseView _Interface;

        public WebResourceResponseView()
        {
            this._Interface = this.ToInterface();
        }

        public WebResourceResponseView(ICoreWebView2WebResourceResponseView iface)
        {
            this._Interface = iface;
        }

        private ICoreWebView2WebResourceResponseView ToInterface()
        {
            return this;
        }

        public int StatusCode => this.ToInterface().StatusCode;
        public string ReasonPhrase => this.ToInterface().ReasonPhrase;

        public void GetContent(WebResourceResponseViewGetContentCompletedHandler handler)
        {
            this.ToInterface().GetContent(handler);
        }

        private object LocObject = new object();
        private bool disposedValue;

        public Stream GetContent()
        {
         
            
            Task<Stream> resultTask = GetContentAsync();
            resultTask.Wait(20000);
            return resultTask.Result;

        }
        public async Task<Stream> GetContentAsync()
        {
            try
            {

                var source = new TaskCompletionSource<(int, IStream)>();
                var webViewResponse = new WebResourceResponseViewGetContentCompletedHandler(source);
                this.ToInterface().GetContent(webViewResponse);
                (int errorCode, IStream stream) result = await source.Task;
                HRESULT hr = result.errorCode;
                if (hr.Failed)
                    throw Marshal.GetExceptionForHR(hr);
                byte[] arr = null;
                using (ComStream sw = new ComStream(result.stream))
                {
                    arr = await sw.GetAllBytesAsync();
                }
                
                return new MemoryStream(arr);
                

            }
            catch (Exception e)
            {
                Debug.Print(e.Message);
            }

            return null;
        }
        public HttpResponseHeaders Headers => new HttpResponseHeaders(this.ToInterface().Headers);

        ICoreWebView2HttpResponseHeaders ICoreWebView2WebResourceResponseView.Headers => this._Interface.Headers;

        int ICoreWebView2WebResourceResponseView.StatusCode => this._Interface.StatusCode;

        string ICoreWebView2WebResourceResponseView.ReasonPhrase => this._Interface.ReasonPhrase;

        void ICoreWebView2WebResourceResponseView.GetContent(ICoreWebView2WebResourceResponseViewGetContentCompletedHandler handler)
        {
            this._Interface.GetContent(handler);
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
        ~WebResourceResponseView()
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