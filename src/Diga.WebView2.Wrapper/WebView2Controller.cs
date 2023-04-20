using System;
using System.Diagnostics;
using System.Runtime.ExceptionServices;
using System.Security;
using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.EventArguments;
using Diga.WebView2.Wrapper.Handler;
using Diga.WebView2.Wrapper.Implementation;
using Diga.WebView2.Wrapper.Types;

namespace Diga.WebView2.Wrapper
{
    public class WebView2Controller : WebView2Controller4Interface
    {
        private EventRegistrationToken _ZoomFactorChangedToken;
        private EventRegistrationToken _GotFocusToken;
        private EventRegistrationToken _LostFocusToken;
        private EventRegistrationToken _AcceleratorKeyPressedToken;
        private EventRegistrationToken _MoveFocusRequestedToken;
        private EventRegistrationToken _RasterizationScaleChangedToken;
        public event EventHandler<AcceleratorKeyPressedEventArgs> AcceleratorKeyPressed;
        public event EventHandler<WebView2EventArgs> ZoomFactorChanged;
        public event EventHandler<WebView2EventArgs> GotFocus;
        public event EventHandler<WebView2EventArgs> LostFocus;
        public event EventHandler<MoveFocusRequestedEventArgs> MoveFocusRequested;
        public event EventHandler<WebView2EventArgs> RasterizationScaleChanged;

        public WebView2Controller(ICoreWebView2Controller4 controller) : base(controller)
        {
            if(controller == null)
                throw new ArgumentNullException(nameof(controller));

            RegisterEvents();
        }



        private void RegisterEvents()
        {
            //add_AcceleratorKeyPressed
            AcceleratorKeyPressedEventHandler acceleratorKeyPressedEventHandler =
                new AcceleratorKeyPressedEventHandler();
            acceleratorKeyPressedEventHandler.AcceleratorKeyPressed += OnAcceleratorKeyPressedIntern;
            this.add_AcceleratorKeyPressed(acceleratorKeyPressedEventHandler, out this._AcceleratorKeyPressedToken);

            //add_GotFocus
            FocusChangedEventHandler focusChange = new FocusChangedEventHandler();
            focusChange.FocusChanged += OnGotFocusIntern;
            this.add_GotFocus(focusChange, out this._GotFocusToken);

            //add_LostFocus
            FocusChangedEventHandler lostFocusChange = new FocusChangedEventHandler();
            lostFocusChange.FocusChanged += OnLostFocusIntern;
            this.add_LostFocus(lostFocusChange, out this._LostFocusToken);

            //add_MoveFocusRequested
            MoveFocusRequestedEventHandler moveFocusRequestedHandler = new MoveFocusRequestedEventHandler();
            moveFocusRequestedHandler.MoveFocusRequested += OnMoveFocusRequestedIntern;
            this.add_MoveFocusRequested(moveFocusRequestedHandler, out this._MoveFocusRequestedToken);

            //add_ZoomFactorChanged
            ZoomFactorChangedEventHandler zoomFactorChangedEventHandler = new ZoomFactorChangedEventHandler();
            zoomFactorChangedEventHandler.ZoomFactorChanged += OnZoomFactorChangedIntern;
            this.add_ZoomFactorChanged(zoomFactorChangedEventHandler, out this._ZoomFactorChangedToken);

            RasterizationScaleChangedEventHandler rasterizationScaleChangedEventHandler =
                new RasterizationScaleChangedEventHandler();
            rasterizationScaleChangedEventHandler.RasteriazationScaleChanged += OnRasterizationScaleChangedIntern;
            this.add_RasterizationScaleChanged(rasterizationScaleChangedEventHandler, out this._RasterizationScaleChangedToken);
        }

        private void OnRasterizationScaleChangedIntern(object sender, WebView2EventArgs e)
        {
            OnRasterizationScaleChanged(e);
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
        [SecurityCritical]
#pragma warning disable SYSLIB0032 // Typ oder Element ist veraltet
        [HandleProcessCorruptedStateExceptions]
#pragma warning restore SYSLIB0032 // Typ oder Element ist veraltet
        private void UnRegisterEvents()
        {

            try
            {

                EventRegistrationTool.UnWireToken(this._AcceleratorKeyPressedToken, this.remove_AcceleratorKeyPressed);
                EventRegistrationTool.UnWireToken(this._MoveFocusRequestedToken, this.remove_MoveFocusRequested);
                EventRegistrationTool.UnWireToken(this._ZoomFactorChangedToken, this.remove_ZoomFactorChanged);
                EventRegistrationTool.UnWireToken(this._GotFocusToken, this.remove_GotFocus);
                EventRegistrationTool.UnWireToken(this._LostFocusToken, this.remove_LostFocus);
                EventRegistrationTool.UnWireToken(this._RasterizationScaleChangedToken, this.remove_RasterizationScaleChanged);
            }
            catch (Exception e)
            {
                Debug.Print(e.ToString());
            }
        }




        public void SetBoundsAndZoomFactor(Rectangle bounds, double zoomFactor)
        {
            base.SetBoundsAndZoomFactor(bounds, zoomFactor);
        }





        public WebView2View WebView => new WebView2View((ICoreWebView2_17)base.CoreWebView2);
        private bool _IsDisposed;
        protected override void Dispose(bool disposing)
        {
            if (this._IsDisposed) return;
            if (disposing)
            {
                UnRegisterEvents();
                
                this.Close();
                this._IsDisposed = true;
            }
            base.Dispose(disposing);

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

        protected virtual void OnRasterizationScaleChanged(WebView2EventArgs e)
        {
            RasterizationScaleChanged?.Invoke(this, e);
        }
    }
}