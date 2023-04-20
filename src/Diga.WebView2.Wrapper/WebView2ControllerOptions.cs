using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.Implementation;

namespace Diga.WebView2.Wrapper
{
    public class WebView2ControllerOptions : WebView2ControllerOptions2Interface
    {
        public WebView2ControllerOptions(ICoreWebView2ControllerOptions2 options):base(options)
        {
            
        }
    }
}