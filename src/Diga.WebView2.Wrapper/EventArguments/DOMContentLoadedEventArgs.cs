using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.Implementation;

namespace Diga.WebView2.Wrapper.EventArguments
{




    public class DOMContentLoadedEventArgs : DOMContentLoadedEventArgsInterface
    {
        

        public DOMContentLoadedEventArgs(ICoreWebView2DOMContentLoadedEventArgs args):base(args)
        {
        }

       
    }
}