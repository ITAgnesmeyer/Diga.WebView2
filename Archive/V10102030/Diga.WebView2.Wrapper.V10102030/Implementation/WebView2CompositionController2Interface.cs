
using System;
using System.Diagnostics;
using Diga.WebView2.Interop;

namespace Diga.WebView2.Wrapper.Implementation
{
    public class WebView2CompositionController2Interface : WebView2CompositionControllerInterface, ICoreWebView2CompositionController2
    {
        private ICoreWebView2CompositionController2 _Controller;
        private ICoreWebView2CompositionController2 Controller
        {
            get
            {
                if (_Controller == null)
                {
                    Debug.Print(nameof(WebView2CompositionController2Interface) + "=>" + nameof(Controller) + " is null");

                    throw new InvalidOperationException(nameof(WebView2CompositionController2Interface) + "=>" + nameof(Controller) + " is null");
                }
                return _Controller;
            }
            set
            {
                _Controller = value;
            }
        }
        public WebView2CompositionController2Interface(ICoreWebView2CompositionController2 controller) : base(controller)
        {
            if (controller == null)
                throw new ArgumentNullException(nameof(controller));
            Controller = controller;
        }
        public object UIAProvider => Controller.UIAProvider;
        private bool _IsDisposed;
        protected override void Dispose(bool disposing)
        {
            if (_IsDisposed) return;

            if (disposing)
            {
                _Controller = null;
                _IsDisposed = true;
            }
            base.Dispose(disposing);
        }



    }
}