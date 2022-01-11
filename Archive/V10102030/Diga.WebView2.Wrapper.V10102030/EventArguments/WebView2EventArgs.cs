namespace Diga.WebView2.Wrapper.EventArguments
{
    public class WebView2EventArgs : System.EventArgs
    {
        public WebView2EventArgs(object sender, object args)
        {
            this.Sender = sender;
            this.Args = args;
        }

        public object Sender{get;}
        public object Args{get;}

    }
}