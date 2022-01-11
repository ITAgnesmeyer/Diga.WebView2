using Diga.WebView2.Interop;

namespace Diga.WebView2.Wrapper.EventArguments
{
    public class BeforeControllerCreateEventArgs : System.EventArgs
    {
        public BeforeControllerCreateEventArgs(ICoreWebView2 webView, ICoreWebView2Controller host, ICoreWebView2Settings settings)
        {
            this.WebView = webView;
            this.Controller = host;
            this.Settings = settings;
        }

        public ICoreWebView2 WebView { get; }
        public ICoreWebView2Controller Controller { get; }

        public ICoreWebView2Settings Settings { get; }

    }
}