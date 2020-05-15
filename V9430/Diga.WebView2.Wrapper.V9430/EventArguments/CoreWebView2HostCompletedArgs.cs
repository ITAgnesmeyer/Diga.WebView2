using Diga.WebView2.Interop;

namespace Diga.WebView2.Wrapper.EventArguments
{
    public class CoreWebView2HostCompletedArgs : System.EventArgs
    {
#if V9488
        public CoreWebView2HostCompletedArgs(ICoreWebView2Controller host, ICoreWebView2 webView)
        {
            this.Host = host;
            this.WebView = webView;
        }

        public ICoreWebView2Controller Host{get;}
        #else
        public CoreWebView2HostCompletedArgs(ICoreWebView2Host host, ICoreWebView2 webView)
        {
            this.Host = host;
            this.WebView = webView;
        }

        public ICoreWebView2Host Host{get;}
#endif
        public ICoreWebView2 WebView{get;}
    }
}