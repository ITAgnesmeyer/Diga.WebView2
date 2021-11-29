using System.Runtime.InteropServices.ComTypes;

namespace Diga.WebView2.Wrapper.EventArguments
{
    public class WebView2StreamEventArgs : System.EventArgs
    {
        public int ErrorCode{get;}
        public IStream Stream { get; }

        public WebView2StreamEventArgs(int errorCode, IStream stream)
        {
            this.ErrorCode = errorCode;
            this.Stream = stream;
        }
    }
}