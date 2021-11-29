using System;
using System.Runtime.InteropServices;
using Diga.WebView2.Interop;

namespace Diga.WebView2.Wrapper
{
    

    public partial class WebView2Controller : ICoreWebView2Controller3
    {
        private ICoreWebView2Controller3 _Controller;

        public int IsVisible
        {
            get => ((ICoreWebView2Controller)this._Controller).IsVisible;
            set => ((ICoreWebView2Controller)this._Controller).IsVisible = value;
        }

        void ICoreWebView2Controller.add_ZoomFactorChanged(ICoreWebView2ZoomFactorChangedEventHandler eventHandler, out EventRegistrationToken token)
        {
            ((ICoreWebView2Controller)this._Controller).add_ZoomFactorChanged(eventHandler, out token);
        }

        void ICoreWebView2Controller3.remove_ZoomFactorChanged(EventRegistrationToken token)
        {
            this._Controller.remove_ZoomFactorChanged(token);
        }

        void ICoreWebView2Controller3.SetBoundsAndZoomFactor(tagRECT Bounds, double ZoomFactor)
        {
            this._Controller.SetBoundsAndZoomFactor(Bounds, ZoomFactor);
        }

        void ICoreWebView2Controller3.MoveFocus(COREWEBVIEW2_MOVE_FOCUS_REASON reason)
        {
            this._Controller.MoveFocus(reason);
        }

        void ICoreWebView2Controller3.add_MoveFocusRequested(ICoreWebView2MoveFocusRequestedEventHandler eventHandler, out EventRegistrationToken token)
        {
            this._Controller.add_MoveFocusRequested(eventHandler, out token);
        }

        void ICoreWebView2Controller3.remove_MoveFocusRequested(EventRegistrationToken token)
        {
            this._Controller.remove_MoveFocusRequested(token);
        }

        void ICoreWebView2Controller3.add_GotFocus(ICoreWebView2FocusChangedEventHandler eventHandler, out EventRegistrationToken token)
        {
            this._Controller.add_GotFocus(eventHandler, out token);
        }

        void ICoreWebView2Controller3.remove_GotFocus(EventRegistrationToken token)
        {
            this._Controller.remove_GotFocus(token);
        }

        void ICoreWebView2Controller3.add_LostFocus(ICoreWebView2FocusChangedEventHandler eventHandler, out EventRegistrationToken token)
        {
            this._Controller.add_LostFocus(eventHandler, out token);
        }

        void ICoreWebView2Controller3.remove_LostFocus(EventRegistrationToken token)
        {
            this._Controller.remove_LostFocus(token);
        }

        void ICoreWebView2Controller3.add_AcceleratorKeyPressed(ICoreWebView2AcceleratorKeyPressedEventHandler eventHandler,
            out EventRegistrationToken token)
        {
            this._Controller.add_AcceleratorKeyPressed(eventHandler, out token);
        }

        void ICoreWebView2Controller3.remove_AcceleratorKeyPressed(EventRegistrationToken token)
        {
            this._Controller.remove_AcceleratorKeyPressed(token);
        }

        void ICoreWebView2Controller3.add_ZoomFactorChanged(ICoreWebView2ZoomFactorChangedEventHandler eventHandler, out EventRegistrationToken token)
        {
            this._Controller.add_ZoomFactorChanged(eventHandler, out token);
        }

        void ICoreWebView2Controller2.remove_ZoomFactorChanged(EventRegistrationToken token)
        {
            ((ICoreWebView2Controller2)this._Controller).remove_ZoomFactorChanged(token);
        }

        void ICoreWebView2Controller2.SetBoundsAndZoomFactor(tagRECT Bounds, double ZoomFactor)
        {
            ((ICoreWebView2Controller2)this._Controller).SetBoundsAndZoomFactor(Bounds, ZoomFactor);
        }

        void ICoreWebView2Controller2.MoveFocus(COREWEBVIEW2_MOVE_FOCUS_REASON reason)
        {
            ((ICoreWebView2Controller2)this._Controller).MoveFocus(reason);
        }

        void ICoreWebView2Controller2.add_MoveFocusRequested(ICoreWebView2MoveFocusRequestedEventHandler eventHandler, out EventRegistrationToken token)
        {
            ((ICoreWebView2Controller2)this._Controller).add_MoveFocusRequested(eventHandler, out token);
        }

        void ICoreWebView2Controller2.remove_MoveFocusRequested(EventRegistrationToken token)
        {
            ((ICoreWebView2Controller2)this._Controller).remove_MoveFocusRequested(token);
        }

        void ICoreWebView2Controller2.add_GotFocus(ICoreWebView2FocusChangedEventHandler eventHandler, out EventRegistrationToken token)
        {
            ((ICoreWebView2Controller2)this._Controller).add_GotFocus(eventHandler, out token);
        }

        void ICoreWebView2Controller2.remove_GotFocus(EventRegistrationToken token)
        {
            ((ICoreWebView2Controller2)this._Controller).remove_GotFocus(token);
        }

        void ICoreWebView2Controller2.add_LostFocus(ICoreWebView2FocusChangedEventHandler eventHandler, out EventRegistrationToken token)
        {
            ((ICoreWebView2Controller2)this._Controller).add_LostFocus(eventHandler, out token);
        }

        void ICoreWebView2Controller2.remove_LostFocus(EventRegistrationToken token)
        {
            ((ICoreWebView2Controller2)this._Controller).remove_LostFocus(token);
        }

        void ICoreWebView2Controller2.add_AcceleratorKeyPressed(ICoreWebView2AcceleratorKeyPressedEventHandler eventHandler,
            out EventRegistrationToken token)
        {
            ((ICoreWebView2Controller2)this._Controller).add_AcceleratorKeyPressed(eventHandler, out token);
        }

        void ICoreWebView2Controller2.remove_AcceleratorKeyPressed(EventRegistrationToken token)
        {
            ((ICoreWebView2Controller2)this._Controller).remove_AcceleratorKeyPressed(token);
        }

        void ICoreWebView2Controller2.add_ZoomFactorChanged(ICoreWebView2ZoomFactorChangedEventHandler eventHandler, out EventRegistrationToken token)
        {
            ((ICoreWebView2Controller2)this._Controller).add_ZoomFactorChanged(eventHandler, out token);
        }

        void ICoreWebView2Controller.remove_ZoomFactorChanged(EventRegistrationToken token)
        {
            ((ICoreWebView2Controller)this._Controller).remove_ZoomFactorChanged(token);
        }

        void ICoreWebView2Controller.SetBoundsAndZoomFactor(tagRECT Bounds, double ZoomFactor)
        {
            ((ICoreWebView2Controller)this._Controller).SetBoundsAndZoomFactor(Bounds, ZoomFactor);
        }

        void ICoreWebView2Controller.MoveFocus(COREWEBVIEW2_MOVE_FOCUS_REASON reason)
        {
            ((ICoreWebView2Controller)this._Controller).MoveFocus(reason);
        }

        void ICoreWebView2Controller.add_MoveFocusRequested(ICoreWebView2MoveFocusRequestedEventHandler eventHandler, out EventRegistrationToken token)
        {
            ((ICoreWebView2Controller)this._Controller).add_MoveFocusRequested(eventHandler, out token);
        }

        void ICoreWebView2Controller.remove_MoveFocusRequested(EventRegistrationToken token)
        {
            ((ICoreWebView2Controller)this._Controller).remove_MoveFocusRequested(token);
        }

        void ICoreWebView2Controller.add_GotFocus(ICoreWebView2FocusChangedEventHandler eventHandler, out EventRegistrationToken token)
        {
            ((ICoreWebView2Controller)this._Controller).add_GotFocus(eventHandler, out token);
        }

        void ICoreWebView2Controller.remove_GotFocus(EventRegistrationToken token)
        {
            ((ICoreWebView2Controller)this._Controller).remove_GotFocus(token);
        }

        void ICoreWebView2Controller.add_LostFocus(ICoreWebView2FocusChangedEventHandler eventHandler, out EventRegistrationToken token)
        {
            ((ICoreWebView2Controller)this._Controller).add_LostFocus(eventHandler, out token);
        }

        void ICoreWebView2Controller.remove_LostFocus(EventRegistrationToken token)
        {
            ((ICoreWebView2Controller)this._Controller).remove_LostFocus(token);
        }

        void ICoreWebView2Controller.add_AcceleratorKeyPressed(ICoreWebView2AcceleratorKeyPressedEventHandler eventHandler,
            out EventRegistrationToken token)
        {
            ((ICoreWebView2Controller)this._Controller).add_AcceleratorKeyPressed(eventHandler, out token);
        }

        void ICoreWebView2Controller.remove_AcceleratorKeyPressed(EventRegistrationToken token)
        {
            ((ICoreWebView2Controller)this._Controller).remove_AcceleratorKeyPressed(token);
        }

        int ICoreWebView2Controller3.ShouldDetectMonitorScaleChanges { get => this._Controller.ShouldDetectMonitorScaleChanges; set => this._Controller.ShouldDetectMonitorScaleChanges = value; }

        public void add_RasterizationScaleChanged([In, MarshalAs(UnmanagedType.Interface)] ICoreWebView2RasterizationScaleChangedEventHandler eventHandler, out EventRegistrationToken token)
        {
            this._Controller.add_RasterizationScaleChanged(eventHandler, out token);
        }

        public void remove_RasterizationScaleChanged([In] EventRegistrationToken token)
        {
            this._Controller.remove_RasterizationScaleChanged(token);
        }
    }

}