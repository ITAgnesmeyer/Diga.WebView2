using System;
using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.EventArguments;
using Diga.WebView2.Wrapper.Handler;
using Diga.WebView2.Wrapper.Types;

namespace Diga.WebView2.Wrapper
{
    public class WebView2Host : ICoreWebView2Host, IDisposable
    {
        private ICoreWebView2Host _Host;
        private EventRegistrationToken _ZoomFactorChangedToken;
        private EventRegistrationToken _GotFocusToken;
        private EventRegistrationToken _LostFocusToken;

        public WebView2Host(ICoreWebView2Host host)
        {
            this._Host = host;
            RegisterEvents();
        }


        private void RegisterEvents()
        {
            ZoomFactorChangedEventHandler zoomFactorChengedEventHandler = new ZoomFactorChangedEventHandler();
            zoomFactorChengedEventHandler.ZoomFactorChanged += OnZoomFactorChanged;
            ((ICoreWebView2Host) this).add_ZoomFactorChanged(zoomFactorChengedEventHandler,
                out this._ZoomFactorChangedToken);
            FocusChangedEventHandler focusChange = new FocusChangedEventHandler();
            focusChange.FocusChanged += OnGotFocus;
            ((ICoreWebView2Host) this).add_GotFocus(focusChange, out this._GotFocusToken);

            FocusChangedEventHandler lostFocusChange = new FocusChangedEventHandler();
            lostFocusChange.FocusChanged += OnLostFocus;
            ((ICoreWebView2Host) this).add_LostFocus(lostFocusChange, out this._LostFocusToken);
        }

        private void UnRegisterEvents()
        {
            ((ICoreWebView2Host) this).remove_ZoomFactorChanged(this._ZoomFactorChangedToken);
            ((ICoreWebView2Host) this).remove_GotFocus(this._GotFocusToken);
            ((ICoreWebView2Host) this).remove_LostFocus(this._LostFocusToken);
        }

        private void OnLostFocus(object sender, WebView2EventArgs e)
        {
            //throw new NotImplementedException();
        }

        private void OnGotFocus(object sender, WebView2EventArgs e)
        {
            //throw new NotImplementedException();
        }

        private void OnZoomFactorChanged(object sender, WebView2EventArgs e)
        {
            //throw new NotImplementedException();
        }

        public bool IsVisible
        {
            get => new BOOL(((ICoreWebView2Host) this).IsVisible);
            set => ((ICoreWebView2Host) this).IsVisible = new BOOL(value);
        }

        public tagRECT Bounds
        {
            get => ((ICoreWebView2Host) this).Bounds;
            set => ((ICoreWebView2Host) this).Bounds = value;
        }

        public double ZoomFactor
        {
            get => ((ICoreWebView2Host) this).ZoomFactor;
            set => ((ICoreWebView2Host) this).ZoomFactor = value;
        }

        public void SetBoundsAndZoomFactor(Rectangle bounds, double zoomFactor)
        {
            ((ICoreWebView2Host) this).SetBoundsAndZoomFactor(bounds, zoomFactor);
        }

        int ICoreWebView2Host.IsVisible
        {
            get => this._Host.IsVisible;
            set => this._Host.IsVisible = value;
        }


        tagRECT ICoreWebView2Host.Bounds
        {
            get => this._Host.Bounds;
            set => this._Host.Bounds = value;
        }

        double ICoreWebView2Host.ZoomFactor
        {
            get => this._Host.ZoomFactor;
            set => this._Host.ZoomFactor = value;
        }

        public IntPtr ParentWindow
        {
            get => ((ICoreWebView2Host) this).ParentWindow;
            set => ((ICoreWebView2Host) this).ParentWindow = value;
        }

        public void NotifyParentWindowPositionChanged()
        {
            ((ICoreWebView2Host) this).NotifyParentWindowPositionChanged();
        }

        public void Close()
        {
            ((ICoreWebView2Host) this).Close();
        }

        public WebView2View WebView => new WebView2View(((ICoreWebView2Host) this).CoreWebView2);

        #region Implementation

        void ICoreWebView2Host.add_ZoomFactorChanged(ICoreWebView2ZoomFactorChangedEventHandler eventHandler,
            out EventRegistrationToken token)
        {
            this._Host.add_ZoomFactorChanged(eventHandler, out token);
        }

        void ICoreWebView2Host.remove_ZoomFactorChanged(EventRegistrationToken token)
        {
            this._Host.remove_ZoomFactorChanged(token);
        }

        void ICoreWebView2Host.SetBoundsAndZoomFactor(tagRECT bounds, double zoomFactor)
        {
            this._Host.SetBoundsAndZoomFactor(bounds, zoomFactor);
        }


        void ICoreWebView2Host.MoveFocus(CORE_WEBVIEW2_MOVE_FOCUS_REASON reason)
        {
            this._Host.MoveFocus(reason);
        }

        public void MoveFocus(FocusReason reason)
        {
            ((ICoreWebView2Host) this).MoveFocus((CORE_WEBVIEW2_MOVE_FOCUS_REASON) reason);
        }

        void ICoreWebView2Host.add_MoveFocusRequested(ICoreWebView2MoveFocusRequestedEventHandler eventHandler,
            out EventRegistrationToken token)
        {
            this._Host.add_MoveFocusRequested(eventHandler, out token);
        }

        void ICoreWebView2Host.remove_MoveFocusRequested(EventRegistrationToken token)
        {
            this._Host.remove_MoveFocusRequested(token);
        }

        void ICoreWebView2Host.add_GotFocus(ICoreWebView2FocusChangedEventHandler eventHandler,
            out EventRegistrationToken token)
        {
            this._Host.add_GotFocus(eventHandler, out token);
        }

        void ICoreWebView2Host.remove_GotFocus(EventRegistrationToken token)
        {
            this._Host.remove_GotFocus(token);
        }

        void ICoreWebView2Host.add_LostFocus(ICoreWebView2FocusChangedEventHandler eventHandler,
            out EventRegistrationToken token)
        {
            this._Host.add_LostFocus(eventHandler, out token);
        }

        void ICoreWebView2Host.remove_LostFocus(EventRegistrationToken token)
        {
            this._Host.remove_LostFocus(token);
        }

        void ICoreWebView2Host.add_AcceleratorKeyPressed(ICoreWebView2AcceleratorKeyPressedEventHandler eventHandler,
            out EventRegistrationToken token)
        {
            this._Host.add_AcceleratorKeyPressed(eventHandler, out token);
        }

        void ICoreWebView2Host.remove_AcceleratorKeyPressed(EventRegistrationToken token)
        {
            this._Host.remove_AcceleratorKeyPressed(token);
        }

        IntPtr ICoreWebView2Host.ParentWindow
        {
            get => this._Host.ParentWindow;
            set => this._Host.ParentWindow = value;
        }


        void ICoreWebView2Host.NotifyParentWindowPositionChanged()
        {
            this._Host.NotifyParentWindowPositionChanged();
        }


        void ICoreWebView2Host.Close()
        {
            this._Host.Close();
        }


        ICoreWebView2 ICoreWebView2Host.CoreWebView2 => this._Host.CoreWebView2;

        #endregion


        public void Dispose()
        {
            UnRegisterEvents();
        }
    }
}