using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.Implementation;

namespace Diga.WebView2.Wrapper.EventArguments
{





    public class ClientCertificateRequestedEventArgs : ClientCertificateRequestedEventArgsInterface
    {
       

        public ClientCertificateRequestedEventArgs(ICoreWebView2ClientCertificateRequestedEventArgs iface ): base(iface) 
        {

        }
       
    }
}