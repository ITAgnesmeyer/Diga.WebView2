namespace Diga.WebView2.Wrapper.EventArguments
{
    public class ControllerCompletedErrorArgs : System.EventArgs
    {
        public ControllerCompletedErrorArgs(int result, string message)
        {
            this.Result = result;
            this.Message = message;
        }
        public string Message{get;}
        public int Result { get; }

    }
}