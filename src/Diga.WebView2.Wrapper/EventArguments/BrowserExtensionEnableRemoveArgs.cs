namespace Diga.WebView2.Wrapper.EventArguments
{
    public class BrowserExtensionEnableRemoveArgs : System.EventArgs
    { 
        public int ErrorCode { get; }
        public BrowserExtensionEnableRemoveArgs(int errorCode)
        {
            this.ErrorCode = errorCode;
        }
    }
}