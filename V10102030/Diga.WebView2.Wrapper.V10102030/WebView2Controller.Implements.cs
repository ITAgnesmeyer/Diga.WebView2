using System;
using System.Runtime.InteropServices;
using Diga.WebView2.Interop;

namespace Diga.WebView2.Wrapper
{
    

    public partial class WebView2Controller : ICoreWebView2Controller3
    {
        private ICoreWebView2Controller3 _Controller;

        int ICoreWebView2Controller3.IsVisible { get => _Controller.IsVisible; set => _Controller.IsVisible = value; }

        public void add_ZoomFactorChanged([In, MarshalAs(UnmanagedType.Interface)] ICoreWebView2ZoomFactorChangedEventHandler eventHandler, out EventRegistrationToken token)
        {
            _Controller.add_ZoomFactorChanged(eventHandler, out token);
        }

        public void remove_ZoomFactorChanged([In] EventRegistrationToken token)
        {
            _Controller.remove_ZoomFactorChanged(token);
        }

        public void SetBoundsAndZoomFactor([In] tagRECT Bounds, [In] double ZoomFactor)
        {
            _Controller.SetBoundsAndZoomFactor(Bounds, ZoomFactor);
        }

        public void MoveFocus([In] COREWEBVIEW2_MOVE_FOCUS_REASON reason)
        {
            _Controller.MoveFocus(reason);
        }

        public void add_MoveFocusRequested([In, MarshalAs(UnmanagedType.Interface)] ICoreWebView2MoveFocusRequestedEventHandler eventHandler, out EventRegistrationToken token)
        {
            _Controller.add_MoveFocusRequested(eventHandler, out token);
        }

        public void remove_MoveFocusRequested([In] EventRegistrationToken token)
        {
            _Controller.remove_MoveFocusRequested(token);
        }

        public void add_GotFocus([In, MarshalAs(UnmanagedType.Interface)] ICoreWebView2FocusChangedEventHandler eventHandler, out EventRegistrationToken token)
        {
            _Controller.add_GotFocus(eventHandler, out token);
        }

        public void remove_GotFocus([In] EventRegistrationToken token)
        {
            _Controller.remove_GotFocus(token);
        }

        public void add_LostFocus([In, MarshalAs(UnmanagedType.Interface)] ICoreWebView2FocusChangedEventHandler eventHandler, out EventRegistrationToken token)
        {
            _Controller.add_LostFocus(eventHandler, out token);
        }

        public void remove_LostFocus([In] EventRegistrationToken token)
        {
            _Controller.remove_LostFocus(token);
        }

        public void add_AcceleratorKeyPressed([In, MarshalAs(UnmanagedType.Interface)] ICoreWebView2AcceleratorKeyPressedEventHandler eventHandler, out EventRegistrationToken token)
        {
            _Controller.add_AcceleratorKeyPressed(eventHandler, out token);
        }

        public void remove_AcceleratorKeyPressed([In] EventRegistrationToken token)
        {
            _Controller.remove_AcceleratorKeyPressed(token);
        }

        int ICoreWebView2Controller3.ShouldDetectMonitorScaleChanges { get => _Controller.ShouldDetectMonitorScaleChanges; set => _Controller.ShouldDetectMonitorScaleChanges = value; }

        public void add_RasterizationScaleChanged([In, MarshalAs(UnmanagedType.Interface)] ICoreWebView2RasterizationScaleChangedEventHandler eventHandler, out EventRegistrationToken token)
        {
            _Controller.add_RasterizationScaleChanged(eventHandler, out token);
        }

        public void remove_RasterizationScaleChanged([In] EventRegistrationToken token)
        {
            _Controller.remove_RasterizationScaleChanged(token);
        }

        int ICoreWebView2Controller2.IsVisible { get => ((ICoreWebView2Controller2)_Controller).IsVisible; set => ((ICoreWebView2Controller2)_Controller).IsVisible = value; }
        int ICoreWebView2Controller.IsVisible { get => ((ICoreWebView2Controller)_Controller).IsVisible; set => ((ICoreWebView2Controller)_Controller).IsVisible = value; }
    }

}