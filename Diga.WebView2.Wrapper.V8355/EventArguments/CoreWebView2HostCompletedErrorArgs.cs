namespace Diga.WebView2.Wrapper.EventArguments
{
    public class CoreWebView2HostCompletedErrorArgs : System.EventArgs
    {
        public CoreWebView2HostCompletedErrorArgs(int result, string message)
        {
            this.Result = result;
            this.Message = message;
        }
        public string Message{get;}
        public int Result { get; }

    }
}