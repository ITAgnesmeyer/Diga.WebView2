using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.Implementation;

namespace Diga.WebView2.Wrapper.EventArguments
{


    public class WebResourceResponseReceivedEventArgs : WebResourceResponseReceivedEventArgsInterface
    {
        
 

        public WebResourceResponseReceivedEventArgs(ICoreWebView2WebResourceResponseReceivedEventArgs args):base(args)
        {
            
        }

        
        public new WebResourceRequest Request => new WebResourceRequest(base.Request);

        public new WebResourceResponseView Response => new WebResourceResponseView(base.Response);

        
        
        
        // // TODO: Finalizer nur überschreiben, wenn "Dispose(bool disposing)" Code für die Freigabe nicht verwalteter Ressourcen enthält
        ~WebResourceResponseReceivedEventArgs()
        {
            
            // Ändern Sie diesen Code nicht. Fügen Sie Bereinigungscode in der Methode "Dispose(bool disposing)" ein.
            Dispose(disposing: false);
        }

        
    }
}