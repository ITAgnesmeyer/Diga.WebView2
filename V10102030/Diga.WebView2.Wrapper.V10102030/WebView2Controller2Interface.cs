using Diga.WebView2.Interop;

namespace Diga.WebView2.Wrapper
{
    public class WebView2Controller2Interface:WebView2ControllerInterface,ICoreWebView2Controller2
    {
        private ICoreWebView2Controller2 _Controller2;
        public WebView2Controller2Interface(ICoreWebView2Controller2 controller):base(controller)
        {
            this._Controller2 = controller;
        }
        public COREWEBVIEW2_COLOR DefaultBackgroundColor { get => _Controller2.DefaultBackgroundColor; set => _Controller2.DefaultBackgroundColor = value; }
        protected override void Dispose(bool disposing)
        {
            if(disposing)
            {
                this._Controller2 = null;
            }
            base.Dispose(disposing);
        }
    }

    

}