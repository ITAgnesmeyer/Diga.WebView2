using Diga.WebView2.Interop;

namespace Diga.WebView2.Wrapper.EventArguments
{
    public class EnvironmentCompletedHandlerArgs : System.EventArgs
    {
        public EnvironmentCompletedHandlerArgs(ICoreWebView2Environment environment)
        {
            this.Environment = environment;
        }

        public ICoreWebView2Environment Environment{get;}

    }
}