using Diga.WebView2.Interop;

namespace Diga.WebView2.Wrapper.EventArguments
{
    public class BeforeHostCreateEventArgs : System.EventArgs
    {
        public BeforeHostCreateEventArgs(IWebView2WebView5 webView, IWebView2Settings2 settings)
        {
            this.WebView = webView;
            //this.Host = host;
            this.Settings = settings;
        }

        public IWebView2WebView5 WebView{get;}
        //public ICoreWebView2Host Host{get;}
        public IWebView2Settings2 Settings{get;}

    }
}