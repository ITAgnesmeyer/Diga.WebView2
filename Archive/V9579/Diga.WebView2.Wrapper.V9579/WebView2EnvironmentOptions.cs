using Diga.WebView2.Interop;

namespace Diga.WebView2.Wrapper
{
    public class WebView2EnvironmentOptions : ICoreWebView2EnvironmentOptions
    {
        public WebView2EnvironmentOptions()
        {
            this.TargetCompatibleBrowserVersion = "86.0.579.0";
        }
        public string AdditionalBrowserArguments { get; set; }
        public string Language { get; set; }
        public string TargetCompatibleBrowserVersion { get; set; }
    }
}