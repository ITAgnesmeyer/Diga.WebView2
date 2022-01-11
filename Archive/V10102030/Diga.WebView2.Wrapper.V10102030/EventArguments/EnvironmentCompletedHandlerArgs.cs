using Diga.WebView2.Interop;

namespace Diga.WebView2.Wrapper.EventArguments
{
    public class EnvironmentCompletedHandlerArgs : System.EventArgs
    {
        public EnvironmentCompletedHandlerArgs(ICoreWebView2Environment6  environment)
        {
            this.Environment = new WebView2Environment(environment);
        }

        public WebView2Environment Environment{get;}

    }
}