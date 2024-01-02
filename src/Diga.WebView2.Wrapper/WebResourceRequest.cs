using System.IO;
using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.Implementation;

namespace Diga.WebView2.Wrapper
{


    public class WebResourceRequest : WebResourceRequestInterface
    {


        public WebResourceRequest(ICoreWebView2WebResourceRequest iface):base(iface)
        {
            
        }


        public string Uri => base.uri;

        public new string Method
        {
            get => base.Method;
            set => base.Method = value;
        }

        public new Stream Content
        {
            get
            {
                if (base.Content == null) return null;
                return new ComStream(base.Content);
            }
            set
            {

                base.Content = new ManagedIStream(ref value);
            }
        }

        public new HttpRequestHeaders Headers
        {
            get
            {
                if (base.Headers == null) return null;
                return new HttpRequestHeaders(base.Headers);
            }
        }




        // // TODO: Finalizer nur überschreiben, wenn "Dispose(bool disposing)" Code für die Freigabe nicht verwalteter Ressourcen enthält
        ~WebResourceRequest()
        {
            // Ändern Sie diesen Code nicht. Fügen Sie Bereinigungscode in der Methode "Dispose(bool disposing)" ein.
            Dispose(disposing: false);
        }

        

    }
}