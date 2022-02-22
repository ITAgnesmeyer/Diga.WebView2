using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.Implementation;

namespace Diga.WebView2.Wrapper
{
    public class WebView2Deferral : WebView2DeferralInterface
    {
        internal WebView2Deferral(ICoreWebView2Deferral deferral):base(deferral)
        {
            
        }

    }
}