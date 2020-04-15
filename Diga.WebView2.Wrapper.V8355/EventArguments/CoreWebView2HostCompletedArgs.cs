using Diga.WebView2.Interop;

namespace Diga.WebView2.Wrapper.EventArguments
{
    public class CoreWebView2HostCompletedArgs : System.EventArgs
    {
        public CoreWebView2HostCompletedArgs(IWebView2WebView5 webView)
        {
            //this.Host = host;
            this.WebView = webView;
        }

        //public ICoreWebView2Host Host{get;}
        public IWebView2WebView5 WebView{get;}
    }
}