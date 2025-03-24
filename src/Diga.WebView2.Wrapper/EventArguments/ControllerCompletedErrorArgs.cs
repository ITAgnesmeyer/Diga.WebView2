using Diga.WebView2.Interop;

namespace Diga.WebView2.Wrapper.EventArguments
{
    public class ControllerCompletedErrorArgs : System.EventArgs
    {
        public ControllerCompletedErrorArgs(int result, string message, ICoreWebView2Environment env)
        {
            this.Result = result;
            this.Message = message;
            this.Environment = env;
        }
        public string Message{get;}
        public int Result { get; }

        public ICoreWebView2Environment Environment { get; set; }

    }
}