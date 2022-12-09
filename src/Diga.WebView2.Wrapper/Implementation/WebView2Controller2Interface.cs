using Diga.WebView2.Interop;
using System;
using System.Diagnostics;
using Diga.WebView2.Wrapper.Types;

namespace Diga.WebView2.Wrapper.Implementation
{
    public class WebView2Controller2Interface : WebView2ControllerInterface
    {
        private ComObjectHolder< ICoreWebView2Controller2> _Controller;
        public WebView2Controller2Interface(ICoreWebView2Controller2 controller) : base(controller)
        {
            if (controller == null)
                throw new ArgumentNullException(nameof(controller));

            this.Controller = controller;
        }
        public COREWEBVIEW2_COLOR DefaultBackgroundColor { get => this.Controller.DefaultBackgroundColor; set => this.Controller.DefaultBackgroundColor = value; }
        private ICoreWebView2Controller2 Controller
        {
            get
            {
                if (this._Controller == null)
                {
                    Debug.Print(nameof(WebView2Controller2Interface) + "=>" + nameof(this.Controller) + " is null");

                    throw new InvalidOperationException(nameof(WebView2Controller2Interface) + "=>" + nameof(this.Controller) + " is null");
                }
                return this._Controller.Interface;
            }
            set => this._Controller = new ComObjectHolder<ICoreWebView2Controller2>(value);
        }

        private bool _IsDisposed;
        protected override void Dispose(bool disposing)
        {
            if (this._IsDisposed) return;
            if (disposing)
            {
                this.Controller = null;
                this._IsDisposed = true;
            }
            base.Dispose(disposing);
        }
    }



}