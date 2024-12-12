
using System;
using System.Diagnostics;
using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.Types;

namespace Diga.WebView2.Wrapper.Implementation
{


    public class WebView2CompositionController2Interface : WebView2CompositionControllerInterface
    {
        private ComObjectHolder<  ICoreWebView2CompositionController2> _Controller;
        private ICoreWebView2CompositionController2 Controller
        {
            get
            {
                if (_Controller == null)
                {
                    Debug.Print(nameof(WebView2CompositionController2Interface) + "=>" + nameof(Controller) + " is null");

                    throw new InvalidOperationException(nameof(WebView2CompositionController2Interface) + "=>" + nameof(Controller) + " is null");
                }
                return _Controller.Interface;
            }
            set
            {
                this._Controller = new ComObjectHolder<ICoreWebView2CompositionController2>( value);
            }
        }
        public WebView2CompositionController2Interface(ICoreWebView2CompositionController2 controller) : base(controller)
        {
            Controller = controller ?? throw new ArgumentNullException(nameof(controller));
        }
        public object UIAProvider => this.Controller.AutomationProvider;
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

        public object AutomationProvider => Controller.AutomationProvider;
    }
}