using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Diga.WebView2.Interop;

namespace Diga.WebView2.Wrapper
{
    public class WebView2Controller3Interface : WebView2Controller2Interface, ICoreWebView2Controller3
    {
        private ICoreWebView2Controller3 _Controller;
        public WebView2Controller3Interface(ICoreWebView2Controller3 controller) : base(controller)
        {
            if (controller == null)
                throw new ArgumentNullException(nameof(controller));

            this.Controller = controller;
        }
        public double RasterizationScale { get => Controller.RasterizationScale; set => Controller.RasterizationScale = value; }
        public int ShouldDetectMonitorScaleChanges { get => Controller.ShouldDetectMonitorScaleChanges; set => Controller.ShouldDetectMonitorScaleChanges = value; }

        public void add_RasterizationScaleChanged(ICoreWebView2RasterizationScaleChangedEventHandler eventHandler, out EventRegistrationToken token)
        {
            Controller.add_RasterizationScaleChanged(eventHandler, out token);
        }

        public void remove_RasterizationScaleChanged([In] EventRegistrationToken token)
        {
            Controller.remove_RasterizationScaleChanged(token);
        }

        public COREWEBVIEW2_BOUNDS_MODE BoundsMode { get => Controller.BoundsMode; set => Controller.BoundsMode = value; }
        private ICoreWebView2Controller3 Controller
        {
            get
            {
                if (_Controller == null)
                {
                    Debug.Print(nameof(WebView2Controller3Interface) + "=>" + nameof(Controller) + " is null");

                    throw new InvalidOperationException(nameof(WebView2Controller3Interface) + "=>" + nameof(Controller) + " is null");
                }
                return _Controller;
            }
            set => _Controller = value;
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