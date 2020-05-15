using Diga.WebView2.Interop;

namespace Diga.WebView2.Wrapper.EventArguments
{
    public class BeforeHostCreateEventArgs : System.EventArgs
    {
#if V9488
        public BeforeHostCreateEventArgs(ICoreWebView2 webView, ICoreWebView2Controller host, ICoreWebView2Settings settings)
#else
        public BeforeHostCreateEventArgs(ICoreWebView2 webView, ICoreWebView2Host host, ICoreWebView2Settings settings)
#endif
        {
            this.WebView = webView;
            this.Host = host;
            this.Settings = settings;
        }

        public ICoreWebView2 WebView{get;}
#if V9488
            public ICoreWebView2Controller Host{get;}
#else
        public ICoreWebView2Host Host{get;}
#endif
        public ICoreWebView2Settings Settings{get;}

    }
}