using System;
using System.Runtime.CompilerServices;
using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.EventArguments;
using Diga.WebView2.Wrapper.Handler;
using Diga.WebView2.Wrapper.Types;

namespace Diga.WebView2.Wrapper
{
 
    public class WebView2Controller : ICoreWebView2Controller
    {
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

        private ICoreWebView2Controller _Controller;

        public WebView2Controller(ICoreWebView2Controller controller)
        {
            this._Controller = controller;
            RegisterEvents();
        }

        protected ICoreWebView2Controller ToInterface()
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


        int ICoreWebView2Controller.IsVisible
        {
            get => this._Controller.IsVisible;
            set => this._Controller.IsVisible = value;
        }

        tagRECT ICoreWebView2Controller.Bounds
        {
            get => this._Controller.Bounds;
            set => this._Controller.Bounds = value;
        }

        double ICoreWebView2Controller.ZoomFactor
        {
            get => this._Controller.ZoomFactor;
            set => this._Controller.ZoomFactor = value;
        }

        void ICoreWebView2Controller.add_ZoomFactorChanged(ICoreWebView2ZoomFactorChangedEventHandler eventHandler, out EventRegistrationToken token)
        {
            this._Controller.add_ZoomFactorChanged(eventHandler, out token);
        }

        void ICoreWebView2Controller.remove_ZoomFactorChanged(EventRegistrationToken token)
        {
            this._Controller.remove_ZoomFactorChanged(token);
        }

        void ICoreWebView2Controller.SetBoundsAndZoomFactor(tagRECT Bounds, double ZoomFactor)
        {
            this._Controller.SetBoundsAndZoomFactor(Bounds, ZoomFactor);
        }

        void ICoreWebView2Controller.MoveFocus(COREWEBVIEW2_MOVE_FOCUS_REASON reason)
        {
            this._Controller.MoveFocus( reason);
        }

        void ICoreWebView2Controller.add_MoveFocusRequested(ICoreWebView2MoveFocusRequestedEventHandler eventHandler, out EventRegistrationToken token)
        {
            this._Controller.add_MoveFocusRequested(eventHandler, out token);
        }

        void ICoreWebView2Controller.remove_MoveFocusRequested(EventRegistrationToken token)
        {
            this._Controller.remove_MoveFocusRequested(token);
        }

        void ICoreWebView2Controller.add_GotFocus(ICoreWebView2FocusChangedEventHandler eventHandler, out EventRegistrationToken token)
        {
            this._Controller.add_GotFocus(eventHandler, out token);
        }

        void ICoreWebView2Controller.remove_GotFocus(EventRegistrationToken token)
        {
            this._Controller.remove_GotFocus(token);
        }

        void ICoreWebView2Controller.add_LostFocus(ICoreWebView2FocusChangedEventHandler eventHandler, out EventRegistrationToken token)
        {
            this._Controller.add_LostFocus(eventHandler, out token);
        }

        void ICoreWebView2Controller.remove_LostFocus(EventRegistrationToken token)
        {
            this._Controller.remove_LostFocus(token);
        }

        void ICoreWebView2Controller.add_AcceleratorKeyPressed(ICoreWebView2AcceleratorKeyPressedEventHandler eventHandler,
            out EventRegistrationToken token)
        {
            this._Controller.add_AcceleratorKeyPressed(eventHandler, out token);
        }

        void ICoreWebView2Controller.remove_AcceleratorKeyPressed(EventRegistrationToken token)
        {
            this._Controller.remove_AcceleratorKeyPressed(token);
        }

        IntPtr ICoreWebView2Controller.ParentWindow
        {
            get => this._Controller.ParentWindow;
            set => this._Controller.ParentWindow = value;
        }

        void ICoreWebView2Controller.NotifyParentWindowPositionChanged()
        {
            this._Controller.NotifyParentWindowPositionChanged();
        }

        void ICoreWebView2Controller.Close()
        {
            this._Controller.Close();
        }

        ICoreWebView2 ICoreWebView2Controller.CoreWebView2 => this._Controller.CoreWebView2;

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

    public class WebView2Host : WebView2Controller
    {
        public WebView2Host(ICoreWebView2Controller controller) : base(controller)
        {
        }
    }
   
}