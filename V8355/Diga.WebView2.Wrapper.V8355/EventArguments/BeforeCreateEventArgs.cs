using Diga.WebView2.Interop;

namespace Diga.WebView2.Wrapper.EventArguments
{
    public class BeforeCreateEventArgs : System.EventArgs
    {
        public WebView2Settings Settings { get; }

        public BeforeCreateEventArgs(IWebView2Settings2 settings)
        {
            this.Settings = new WebView2Settings(settings);
        }
    }
}