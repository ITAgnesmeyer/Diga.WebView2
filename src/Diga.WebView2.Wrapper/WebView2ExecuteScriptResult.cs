using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.Implementation;

namespace Diga.WebView2.Wrapper
{
    public class WebView2ExecuteScriptResult: WebView2ExecuteScriptResultInterface
    {
        public WebView2ExecuteScriptResult(ICoreWebView2ExecuteScriptResult result):base(result)
        {
            
        }

        new public WebView2ScriptException Exception => new WebView2ScriptException(base.Exception);
    }


}