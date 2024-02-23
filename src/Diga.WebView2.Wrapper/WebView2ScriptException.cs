using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.Implementation;

namespace Diga.WebView2.Wrapper
{
    public class WebView2ScriptException: WebView2ScriptExceptionInterface
    {
        public WebView2ScriptException(ICoreWebView2ScriptException exception):base(exception) 
        {
            
        }

    }


}