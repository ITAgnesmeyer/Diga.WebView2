﻿using System;
using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.EventArguments;
using Diga.WebView2.Wrapper.Handler;
using Diga.WebView2.Wrapper.Types;

namespace Diga.WebView2.Wrapper
{
    public partial class WebView2Controller
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

        public WebView2Controller(ICoreWebView2Controller3 controller)
        {
            this._Controller = controller;
            RegisterEvents();
        }

        protected ICoreWebView2Controller3 ToInterface()
        {
            return _Controller;
        }

        private void RegisterEvents()
        {
            //add_AcceleratorKeyPressed
            AcceleratorKeyPressedEventHandler acceleratorKeyPressedEventHandler =
                new AcceleratorKeyPressedEventHandler();
            acceleratorKeyPressedEventHandler.AcceleratorKeyPressed += OnAcceleratorKeyPressedIntern;
            this.ToInterface()
                .add_AcceleratorKeyPressed(acceleratorKeyPressedEventHandler, out this._AcceleratorKeyPressedToken);

            //add_GotFocus
            FocusChangedEventHandler focusChange = new FocusChangedEventHandler();
            focusChange.FocusChanged += OnGotFocusIntern;
            this.ToInterface().add_GotFocus(focusChange, out this._GotFocusToken);

            //add_LostFocus
            FocusChangedEventHandler lostFocusChange = new FocusChangedEventHandler();
            lostFocusChange.FocusChanged += OnLostFocusIntern;
            this.ToInterface().add_LostFocus(lostFocusChange, out this._LostFocusToken);

            //add_MoveFocusRequested
            MoveFocusRequestedEventHandler moveFocusRequestedHandler = new MoveFocusRequestedEventHandler();
            moveFocusRequestedHandler.MoveFocusRequested += OnMoveFocusRequestedIntern;
            this.ToInterface().add_MoveFocusRequested(moveFocusRequestedHandler, out this._MoveFocusRequestedToken);

            //add_ZoomFactorChanged
            ZoomFactorChangedEventHandler zoomFactorChangedEventHandler = new ZoomFactorChangedEventHandler();
            zoomFactorChangedEventHandler.ZoomFactorChanged += OnZoomFactorChangedIntern;
            this.ToInterface().add_ZoomFactorChanged(zoomFactorChangedEventHandler, out this._ZoomFactorChangedToken);
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

        public WebView2View WebView => new WebView2View((ICoreWebView2_3) this.ToInterface().CoreWebView2);

        public void Dispose()
        {
            UnRegisterEvents();
            this._Controller = null;
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

        public ICoreWebView2 CoreWebView2 => ((ICoreWebView2Controller) this._Controller).CoreWebView2;

        public COREWEBVIEW2_COLOR DefaultBackgroundColor
        {
            get => ((ICoreWebView2Controller2) this._Controller).DefaultBackgroundColor;
            set => ((ICoreWebView2Controller2) this._Controller).DefaultBackgroundColor = value;
        }

        public double RasterizationScale
        {
            get => this._Controller.RasterizationScale;
            set => this._Controller.RasterizationScale = value;
        }

        public int ShouldDetectMonitorScaleChanges
        {
            get => this._Controller.ShouldDetectMonitorScaleChanges;
            set => this._Controller.ShouldDetectMonitorScaleChanges = value;
        }

        public void add_RasterizationScaleChanged(ICoreWebView2RasterizationScaleChangedEventHandler eventHandler,
            out EventRegistrationToken token)
        {
            this._Controller.add_RasterizationScaleChanged(eventHandler, out token);
        }

        public void remove_RasterizationScaleChanged(EventRegistrationToken token)
        {
            this._Controller.remove_RasterizationScaleChanged(token);
        }

        public COREWEBVIEW2_BOUNDS_MODE BoundsMode
        {
            get => this._Controller.BoundsMode;
            set => this._Controller.BoundsMode = value;
        }

        
    }
}