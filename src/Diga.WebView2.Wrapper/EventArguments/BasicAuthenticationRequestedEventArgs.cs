using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.Implementation;

namespace Diga.WebView2.Wrapper.EventArguments
{
    public class BasicAuthenticationRequestedEventArgs : BasicAuthenticationRequestedEventArgsInterface
    {
        public BasicAuthenticationRequestedEventArgs(ICoreWebView2BasicAuthenticationRequestedEventArgs args):base(args)
        {
            
            
        }

        public new WebView2Deferral GetDeferral()
        {
            return new WebView2Deferral(base.GetDeferral());
        }
    }
}