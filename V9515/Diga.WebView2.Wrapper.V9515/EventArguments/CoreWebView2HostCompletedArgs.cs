using Diga.WebView2.Interop;

namespace Diga.WebView2.Wrapper.EventArguments
{
    public class CoreWebView2HostCompletedArgs : System.EventArgs
    {
        public CoreWebView2HostCompletedArgs(ICoreWebView2Controller host, ICoreWebView2 webView)
        {
            this.Host = host;
            this.WebView = webView;
        }

        public ICoreWebView2Controller Host{get;}
 
        public ICoreWebView2 WebView{get;}
    }
}