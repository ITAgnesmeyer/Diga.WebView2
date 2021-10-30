using System;
using System.Runtime.InteropServices;
using Diga.WebView2.Interop;

namespace Diga.WebView2.Wrapper
{
    public  class WebView2ControllerInterface : ICoreWebView2Controller,IDisposable
    {
        private ICoreWebView2Controller _Controller;
        private bool disposedValue;

        public WebView2ControllerInterface(ICoreWebView2Controller controller)
        {
            this._Controller = controller;
        }
        public int IsVisible { get => _Controller.IsVisible; set => _Controller.IsVisible = value; }
        public tagRECT Bounds { get => _Controller.Bounds; set => _Controller.Bounds = value; }
        public double ZoomFactor { get => _Controller.ZoomFactor; set => _Controller.ZoomFactor = value; }

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

        public IntPtr ParentWindow { get => _Controller.ParentWindow; set => _Controller.ParentWindow = value; }

        public void NotifyParentWindowPositionChanged()
        {
            _Controller.NotifyParentWindowPositionChanged();
        }

        public void Close()
        {
            _Controller.Close();
        }

        public ICoreWebView2 CoreWebView2 => _Controller.CoreWebView2;

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    this._Controller = null;
                }

                // TODO: Nicht verwaltete Ressourcen (nicht verwaltete Objekte) freigeben und Finalizer überschreiben
                // TODO: Große Felder auf NULL setzen
                disposedValue = true;
            }
        }

        // // TODO: Finalizer nur überschreiben, wenn "Dispose(bool disposing)" Code für die Freigabe nicht verwalteter Ressourcen enthält
        // ~WebView2ControllerInterface()
        // {
        //     // Ändern Sie diesen Code nicht. Fügen Sie Bereinigungscode in der Methode "Dispose(bool disposing)" ein.
        //     Dispose(disposing: false);
        // }

        public void Dispose()
        {
            // Ändern Sie diesen Code nicht. Fügen Sie Bereinigungscode in der Methode "Dispose(bool disposing)" ein.
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }

}