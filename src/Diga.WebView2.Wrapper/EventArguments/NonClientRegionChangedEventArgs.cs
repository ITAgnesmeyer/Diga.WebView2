using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.Implementation;

namespace Diga.WebView2.Wrapper.EventArguments
{
    public class NonClientRegionChangedEventArgs : NonClientRegionChangedEventArgsInterface
    {
        public WebView2CompositionController CompositionController { get; }
        public NonClientRegionChangedEventArgs(WebView2CompositionController ctrlr, ICoreWebView2NonClientRegionChangedEventArgs iface) : base(iface)
        {
            CompositionController = ctrlr;
        }

    }

}