using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Diga.WebView2.Interop;
using Microsoft.Win32.SafeHandles;

namespace Diga.WebView2.Wrapper.Implementation
{
    public class WebView2ControllerInterface : ICoreWebView2Controller, IDisposable
    {
        private ICoreWebView2Controller _Controller;
        private bool _IsDesposed;

        /// Wraps in SafeHandle so resources can be released if consumer forgets to call Dispose. Recommended
        ///             pattern for any type that is not sealed.
        ///             https://docs.microsoft.com/dotnet/api/system.idisposable#idisposable-and-the-inheritance-hierarchy
        private SafeHandle handle = (SafeHandle) new SafeFileHandle(IntPtr.Zero, true);
        public WebView2ControllerInterface(ICoreWebView2Controller controller)
        {
            if (controller == null)
                throw new ArgumentNullException(nameof(controller));

            Controller = controller;
        }
        public int IsVisible { get => Controller.IsVisible; set => Controller.IsVisible = value; }
        public tagRECT Bounds { get => Controller.Bounds; set => Controller.Bounds = value; }
        public double ZoomFactor { get => Controller.ZoomFactor; set => Controller.ZoomFactor = value; }

        public void add_ZoomFactorChanged([In, MarshalAs(UnmanagedType.Interface)] ICoreWebView2ZoomFactorChangedEventHandler eventHandler, out EventRegistrationToken token)
        {
            Controller.add_ZoomFactorChanged(eventHandler, out token);
        }

        public void remove_ZoomFactorChanged([In] EventRegistrationToken token)
        {
            Controller.remove_ZoomFactorChanged(token);
        }

        public void SetBoundsAndZoomFactor([In] tagRECT Bounds, [In] double ZoomFactor)
        {
            Controller.SetBoundsAndZoomFactor(Bounds, ZoomFactor);
        }

        public void MoveFocus([In] COREWEBVIEW2_MOVE_FOCUS_REASON reason)
        {
            Controller.MoveFocus(reason);
        }

        public void add_MoveFocusRequested([In, MarshalAs(UnmanagedType.Interface)] ICoreWebView2MoveFocusRequestedEventHandler eventHandler, out EventRegistrationToken token)
        {
            Controller.add_MoveFocusRequested(eventHandler, out token);
        }

        public void remove_MoveFocusRequested([In] EventRegistrationToken token)
        {
            Controller.remove_MoveFocusRequested(token);
        }

        public void add_GotFocus([In, MarshalAs(UnmanagedType.Interface)] ICoreWebView2FocusChangedEventHandler eventHandler, out EventRegistrationToken token)
        {
            Controller.add_GotFocus(eventHandler, out token);
        }

        public void remove_GotFocus([In] EventRegistrationToken token)
        {
            Controller.remove_GotFocus(token);
        }

        public void add_LostFocus([In, MarshalAs(UnmanagedType.Interface)] ICoreWebView2FocusChangedEventHandler eventHandler, out EventRegistrationToken token)
        {
            Controller.add_LostFocus(eventHandler, out token);
        }

        public void remove_LostFocus([In] EventRegistrationToken token)
        {
            Controller.remove_LostFocus(token);
        }

        public void add_AcceleratorKeyPressed([In, MarshalAs(UnmanagedType.Interface)] ICoreWebView2AcceleratorKeyPressedEventHandler eventHandler, out EventRegistrationToken token)
        {
            Controller.add_AcceleratorKeyPressed(eventHandler, out token);
        }

        public void remove_AcceleratorKeyPressed([In] EventRegistrationToken token)
        {
            Controller.remove_AcceleratorKeyPressed(token);
        }

        public IntPtr ParentWindow { get => Controller.ParentWindow; set => Controller.ParentWindow = value; }

        public void NotifyParentWindowPositionChanged()
        {
            Controller.NotifyParentWindowPositionChanged();
        }

        public void Close()
        {
            try
            {
                Controller.Close();
            }
            catch (Exception ex)
            {
                Debug.Print("Controller.Close Exception:" + ex.ToString());

            }


        }

        public ICoreWebView2 CoreWebView2 => Controller.CoreWebView2;

        private ICoreWebView2Controller Controller
        {
            get
            {
                if (_Controller == null)
                {
                    Debug.Print(nameof(WebView2ControllerInterface) + "Controller is null");

                    throw new InvalidOperationException("Controller is null!");
                }

                return _Controller;
            }
            set => _Controller = value;
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_IsDesposed)
            {
                if (disposing)
                {
                    this.handle.Dispose();
                    Controller = null;
                }


                _IsDesposed = true;
            }
        }



        public void Dispose()
        {
            // Ändern Sie diesen Code nicht. Fügen Sie Bereinigungscode in der Methode "Dispose(bool disposing)" ein.
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }

}