using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Threading.Tasks;
using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.Delegates;
using Diga.WebView2.Wrapper.Implementation;
using Diga.WebView2.Wrapper.Types;


namespace Diga.WebView2.Wrapper
{


    public class WebResourceResponseView : WebResourceResponseViewInterface
    {
        

       
        public WebResourceResponseView(ICoreWebView2WebResourceResponseView iface):base(iface)
        {
            
        }

       

        public new int StatusCode => base.StatusCode;
        public new string ReasonPhrase => base.ReasonPhrase;

        public void GetContent(WebResourceResponseViewGetContentCompletedHandler handler)
        {
            base.GetContent(handler);
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
                base.GetContent(webViewResponse);
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
        public new HttpResponseHeaders Headers => new HttpResponseHeaders(base.Headers);

       

       

    

        // // TODO: Finalizer nur überschreiben, wenn "Dispose(bool disposing)" Code für die Freigabe nicht verwalteter Ressourcen enthält
        ~WebResourceResponseView()
        {
            // Ändern Sie diesen Code nicht. Fügen Sie Bereinigungscode in der Methode "Dispose(bool disposing)" ein.
            Dispose(disposing: false);
        }

        
    }
}