using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.Types;

namespace Diga.WebView2.Wrapper
{
    public class WebView2EnvironmentOptions : ICoreWebView2EnvironmentOptions
    {
        public WebView2EnvironmentOptions()
        {
            this.TargetCompatibleBrowserVersion = "95.0.1020.30";
            this.AllowSingleSignOnUsingOSPrimaryAccount = new CBOOL(true);
        }
        public string AdditionalBrowserArguments { get; set; }
        public string Language { get; set; }
        public string TargetCompatibleBrowserVersion { get; set; }
        public int AllowSingleSignOnUsingOSPrimaryAccount { get; set; }
    }
}