using Diga.WebView2.Interop;

namespace Diga.WebView2.Wrapper.EventArguments
{
    public class EnvironmentCompletedHandlerArgs : System.EventArgs
    {
        public EnvironmentCompletedHandlerArgs(IWebView2Environment3 environment)
        {
            this.Environment = environment;
        }

        public IWebView2Environment3 Environment{get;}

    }
}