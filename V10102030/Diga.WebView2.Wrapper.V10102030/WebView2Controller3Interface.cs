using System.Runtime.InteropServices;
using Diga.WebView2.Interop;

namespace Diga.WebView2.Wrapper
{
    public class WebView2Controller3Interface:WebView2Controller2Interface,ICoreWebView2Controller3
    {
        private ICoreWebView2Controller3 _Controller3;
        public WebView2Controller3Interface(ICoreWebView2Controller3 controller):base(controller)
        {
            this._Controller3 = controller;
        }
        public double RasterizationScale { get => _Controller3.RasterizationScale; set => _Controller3.RasterizationScale = value; }
        public int ShouldDetectMonitorScaleChanges { get => _Controller3.ShouldDetectMonitorScaleChanges; set => _Controller3.ShouldDetectMonitorScaleChanges = value; }

        public void add_RasterizationScaleChanged(ICoreWebView2RasterizationScaleChangedEventHandler eventHandler, out EventRegistrationToken token)
        {
            _Controller3.add_RasterizationScaleChanged(eventHandler, out token);
        }

        public void remove_RasterizationScaleChanged([In] EventRegistrationToken token)
        {
            _Controller3.remove_RasterizationScaleChanged(token);
        }

        public COREWEBVIEW2_BOUNDS_MODE BoundsMode { get => _Controller3.BoundsMode; set => _Controller3.BoundsMode = value; }

        protected override void Dispose(bool disposing)
        {
            if(disposing)
            {
                this._Controller3 = null;
            }
            base.Dispose(disposing);
        }
    }

}