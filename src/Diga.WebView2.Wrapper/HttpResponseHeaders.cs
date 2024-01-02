using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.Implementation;
using Diga.WebView2.Wrapper.Types;

// ReSharper disable once CheckNamespace
namespace Diga.WebView2.Wrapper
{


    public class HttpResponseHeaders : HttpResponseHeadersInterface
    {
      

        public HttpResponseHeaders(ICoreWebView2HttpResponseHeaders iface):base(iface)
        {
            
        }

        

        public new bool Contains(string name)
        {
            int contians = base.Contains(name);
            return new CBOOL(contians);
        }

        public new HttpHeadersCollectionIterator GetHeaders(string name)
        {
            var iterator = base.GetHeaders(name);
            return new HttpHeadersCollectionIterator(iterator);
        }
        public new HttpHeadersCollectionIterator GetIterator()
        {
            var iterator = base.GetIterator();
            return new HttpHeadersCollectionIterator(iterator);
        }



        // // TODO: Finalizer nur überschreiben, wenn "Dispose(bool disposing)" Code für die Freigabe nicht verwalteter Ressourcen enthält
        // ~HttpResponseHeaders()
        // {
        //     // Ändern Sie diesen Code nicht. Fügen Sie Bereinigungscode in der Methode "Dispose(bool disposing)" ein.
        //     Dispose(disposing: false);
        // }

    }
}