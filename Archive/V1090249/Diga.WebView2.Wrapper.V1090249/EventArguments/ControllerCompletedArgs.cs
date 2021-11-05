using Diga.WebView2.Interop;

namespace Diga.WebView2.Wrapper.EventArguments
{
    public class ControllerCompletedArgs : System.EventArgs
    {
        public ControllerCompletedArgs(ICoreWebView2Controller3 controller, ICoreWebView2 webView)
        {
            this.Controller = controller;
            this.WebView = webView;
        }

        public ICoreWebView2Controller3 Controller{get;}
 
        public ICoreWebView2 WebView{get;}
    }
}