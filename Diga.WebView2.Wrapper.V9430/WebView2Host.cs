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
        private EventRegistrationToken _AcceleratorKeyPressedToken;
        private EventRegistrationToken _MoveFocusRequestedToken;
        public event EventHandler<AcceleratorKeyPressedEventArgs> AcceleratorKeyPressed;
        public event EventHandler<WebView2EventArgs> ZoomFactorChanged;
        public event EventHandler<WebView2EventArgs> GotFocus;
        public event EventHandler<WebView2EventArgs> LostFocus;
        public event EventHandler<MoveFocusRequestedEventArgs> MoveFocusRequested;

        public WebView2Host(ICoreWebView2Host host)
        {
            this._Host = host;
            RegisterEvents();
        }

        private ICoreWebView2Host ToInterface()
        {
            return this;
        }

        private void RegisterEvents()
        {
            AcceleratorKeyPressedEventHandler acceleratorKeyPressedEventHandler =
                new AcceleratorKeyPressedEventHandler();
            acceleratorKeyPressedEventHandler.AcceleratorKeyPressed += OnAcceleratorKeyPressedIntern;
            this.ToInterface()
                .add_AcceleratorKeyPressed(acceleratorKeyPressedEventHandler, out this._AcceleratorKeyPressedToken);

            FocusChangedEventHandler focusChange = new FocusChangedEventHandler();
            focusChange.FocusChanged += OnGotFocusIntern;
            this.ToInterface().add_GotFocus(focusChange, out this._GotFocusToken);

            FocusChangedEventHandler lostFocusChange = new FocusChangedEventHandler();
            lostFocusChange.FocusChanged += OnLostFocusIntern;
            this.ToInterface().add_LostFocus(lostFocusChange, out this._LostFocusToken);

            


            MoveFocusRequestedEventHandler moveFocusRequestedHandler = new MoveFocusRequestedEventHandler();
            moveFocusRequestedHandler.MoveFocusRequested += OnMoveFocusRequestedIntern;
            this.ToInterface().add_MoveFocusRequested(moveFocusRequestedHandler, out this._MoveFocusRequestedToken);
            
            ZoomFactorChangedEventHandler zoomFactorChangedEventHandler = new ZoomFactorChangedEventHandler();
            zoomFactorChangedEventHandler.ZoomFactorChanged += OnZoomFactorChangedIntern;
            this.ToInterface().add_ZoomFactorChanged(zoomFactorChangedEventHandler,
                out this._ZoomFactorChangedToken);

          
        }

        private void OnMoveFocusRequestedIntern(object sender, MoveFocusRequestedEventArgs e)
        {
            OnMoveFocusRequested(e);
        }

        private void OnLostFocusIntern(object sender, WebView2EventArgs e)
        {
            OnLostFocus(e);
        }

        private void OnGotFocusIntern(object sender, WebView2EventArgs e)
        {
            OnGotFocus(e);
        }

        private void OnZoomFactorChangedIntern(object sender, WebView2EventArgs e)
        {
            OnZoomFactorChanged(e);
        }

        private void OnAcceleratorKeyPressedIntern(object sender, AcceleratorKeyPressedEventArgs e)
        {
            OnAcceleratorKeyPressed(e);
        }

        private void UnRegisterEvents()
        {
            this.ToInterface().remove_AcceleratorKeyPressed(this._AcceleratorKeyPressedToken);
            this.ToInterface().remove_MoveFocusRequested(this._MoveFocusRequestedToken);
            this.ToInterface().remove_ZoomFactorChanged(this._ZoomFactorChangedToken);
            this.ToInterface().remove_GotFocus(this._GotFocusToken);
            this.ToInterface().remove_LostFocus(this._LostFocusToken);
        }

       

       

        

        public bool IsVisible
        {
            get => new CBOOL(this.ToInterface().IsVisible);
            set => this.ToInterface().IsVisible = new CBOOL(value);
        }

        public tagRECT Bounds
        {
            get => this.ToInterface().Bounds;
            set => this.ToInterface().Bounds = value;
        }

        public double ZoomFactor
        {
            get => this.ToInterface().ZoomFactor;
            set => this.ToInterface().ZoomFactor = value;
        }

        public void SetBoundsAndZoomFactor(Rectangle bounds, double zoomFactor)
        {
            this.ToInterface().SetBoundsAndZoomFactor(bounds, zoomFactor);
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
            get => this.ToInterface().ParentWindow;
            set => this.ToInterface().ParentWindow = value;
        }

        public void NotifyParentWindowPositionChanged()
        {
            this.ToInterface().NotifyParentWindowPositionChanged();
        }

        public void Close()
        {
            this.ToInterface().Close();
        }

        public WebView2View WebView => new WebView2View(this.ToInterface().CoreWebView2);

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
            this.ToInterface().MoveFocus((CORE_WEBVIEW2_MOVE_FOCUS_REASON) reason);
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

        protected virtual void OnAcceleratorKeyPressed(AcceleratorKeyPressedEventArgs e)
        {
            AcceleratorKeyPressed?.Invoke(this, e);
        }

        protected virtual void OnZoomFactorChanged(WebView2EventArgs e)
        {
            ZoomFactorChanged?.Invoke(this, e);
        }

        protected virtual void OnGotFocus(WebView2EventArgs e)
        {
            GotFocus?.Invoke(this, e);
        }

        protected virtual void OnLostFocus(WebView2EventArgs e)
        {
            LostFocus?.Invoke(this, e);
        }

        protected virtual void OnMoveFocusRequested(MoveFocusRequestedEventArgs e)
        {
            MoveFocusRequested?.Invoke(this, e);
        }
    }
}