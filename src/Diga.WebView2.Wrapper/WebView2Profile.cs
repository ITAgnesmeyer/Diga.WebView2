using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.Implementation;

namespace Diga.WebView2.Wrapper
{
    public class WebView2Profile : WebView2Profile2Interface
    {
        public WebView2Profile(ICoreWebView2Profile2 profile):base(profile)
        {
            
        }
    }
}