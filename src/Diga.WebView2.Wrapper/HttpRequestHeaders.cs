using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.Types;
using Diga.WebView2.Wrapper.Implementation;

namespace Diga.WebView2.Wrapper
{


    public class HttpRequestHeaders : HttpRequestHeadersInterface
    {
       
        public HttpRequestHeaders(ICoreWebView2HttpRequestHeaders iface):base(iface)
        {
            
        }

        //public string GetHeader(string name)
        //{
            
        //    return base.GetHeader(name);
        //}

        public new bool Contains(string name)
        {
            int contains = base.Contains(name);
            return new CBOOL(contains);
        }

        //public void SetHeader(string name, string value)
        //{
        //    base.SetHeader(name, value);
        //}

        //public void RemoveHeader(string name)
        //{
        //    base.RemoveHeader(name);
        //}

        public new HttpHeadersCollectionIterator GetIterator()
        {
            var iterator = base.GetIterator();
            return new HttpHeadersCollectionIterator(iterator);
        }
       






        
        ~HttpRequestHeaders()
        {
            // Ändern Sie diesen Code nicht. Fügen Sie Bereinigungscode in der Methode "Dispose(bool disposing)" ein.
            Dispose(disposing: false);
        }

    }
}