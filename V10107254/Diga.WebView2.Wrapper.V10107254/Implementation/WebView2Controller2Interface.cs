using Diga.WebView2.Interop;
using System;
using System.Diagnostics;

namespace Diga.WebView2.Wrapper.Implementation
{
    public class WebView2Controller2Interface : WebView2ControllerInterface, ICoreWebView2Controller2
    {
        private ICoreWebView2Controller2 _Controller;
        public WebView2Controller2Interface(ICoreWebView2Controller2 controller) : base(controller)
        {
            if (controller == null)
                throw new ArgumentNullException(nameof(controller));

            Controller = controller;
        }
        public COREWEBVIEW2_COLOR DefaultBackgroundColor { get => Controller.DefaultBackgroundColor; set => Controller.DefaultBackgroundColor = value; }
        private ICoreWebView2Controller2 Controller
        {
            get
            {
                if (_Controller == null)
                {
                    Debug.Print(nameof(WebView2Controller2Interface) + "=>" + nameof(Controller) + " is null");

                    throw new InvalidOperationException(nameof(WebView2Controller2Interface) + "=>" + nameof(Controller) + " is null");
                }
                return _Controller;
            }
            set => _Controller = value;
        }

        private bool _IsDisposed;
        protected override void Dispose(bool disposing)
        {
            if (_IsDisposed) return;
            if (disposing)
            {
                Controller = null;
                _IsDisposed = true;
            }
            base.Dispose(disposing);
        }
    }



}