using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.Types;

namespace Diga.WebView2.Wrapper.Implementation
{
    public class WebView2Controller3Interface : WebView2Controller2Interface
    {
        private ComObjectHolder< ICoreWebView2Controller3> _Controller;
        public WebView2Controller3Interface(ICoreWebView2Controller3 controller) : base(controller)
        {
            if (controller == null)
                throw new ArgumentNullException(nameof(controller));

            this.Controller = controller;
        }
        public double RasterizationScale { get => this.Controller.RasterizationScale; set => this.Controller.RasterizationScale = value; }
        public int ShouldDetectMonitorScaleChanges { get => this.Controller.ShouldDetectMonitorScaleChanges; set => this.Controller.ShouldDetectMonitorScaleChanges = value; }

        public void add_RasterizationScaleChanged(ICoreWebView2RasterizationScaleChangedEventHandler eventHandler, out EventRegistrationToken token)
        {
            this.Controller.add_RasterizationScaleChanged(eventHandler, out token);
        }

        public void remove_RasterizationScaleChanged([In] EventRegistrationToken token)
        {
            this.Controller.remove_RasterizationScaleChanged(token);
        }

        public COREWEBVIEW2_BOUNDS_MODE BoundsMode { get => this.Controller.BoundsMode; set => this.Controller.BoundsMode = value; }
        private ICoreWebView2Controller3 Controller
        {
            get
            {
                if (this._Controller == null)
                {
                    Debug.Print(nameof(WebView2Controller3Interface) + "=>" + nameof(this.Controller) + " is null");

                    throw new InvalidOperationException(nameof(WebView2Controller3Interface) + "=>" + nameof(this.Controller) + " is null");
                }
                return this._Controller.Interface;
            }
            set => this._Controller = new ComObjectHolder<ICoreWebView2Controller3>(value);
        }

        private bool _IsDisposed;
        protected override void Dispose(bool disposing)
        {
            if (this._IsDisposed) return;
            if (disposing)
            {
                this._Controller = null;
                this._IsDisposed = true;
            }
            base.Dispose(disposing);
        }
    }

}