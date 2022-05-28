
using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Diga.WebView2.Interop;
using Microsoft.Win32.SafeHandles;

namespace Diga.WebView2.Wrapper.Implementation
{
    public class WebView2CompositionControllerInterface : ICoreWebView2CompositionController, IDisposable
    {
        private object _Controller;
        private ICoreWebView2CompositionController Controller
        {
            get
            {
                if (_Controller == null)
                {
                    Debug.Print(nameof(WebView2CompositionControllerInterface) + "=>" + nameof(Controller) + " is null");

                    throw new InvalidOperationException(nameof(WebView2CompositionControllerInterface) + "=>" + nameof(Controller) + " is null");
                }
                return (ICoreWebView2CompositionController)_Controller;
            }
            set
            {
                _Controller = value;
            }
        }

        /// Wraps in SafeHandle so resources can be released if consumer forgets to call Dispose. Recommended
        ///             pattern for any type that is not sealed.
        ///             https://docs.microsoft.com/dotnet/api/system.idisposable#idisposable-and-the-inheritance-hierarchy
        private SafeHandle handle = (SafeHandle) new SafeFileHandle(IntPtr.Zero, true);
        public WebView2CompositionControllerInterface(ICoreWebView2CompositionController controller)
        {
            if (controller == null)
                throw new ArgumentNullException(nameof(controller));
            this.Controller = controller;

        }

        public object RootVisualTarget { get => Controller.RootVisualTarget; set => Controller.RootVisualTarget = value; }

        public void SendMouseInput([In] COREWEBVIEW2_MOUSE_EVENT_KIND eventKind, [In] COREWEBVIEW2_MOUSE_EVENT_VIRTUAL_KEYS virtualKeys, [In] uint mouseData, [In] tagPOINT point)
        {
            Controller.SendMouseInput(eventKind, virtualKeys, mouseData, point);
        }

        public void SendPointerInput([In] COREWEBVIEW2_POINTER_EVENT_KIND eventKind, [In, MarshalAs(UnmanagedType.Interface)] ICoreWebView2PointerInfo pointerInfo)
        {
            Controller.SendPointerInput(eventKind, pointerInfo);
        }

        public IntPtr Cursor => Controller.Cursor;

        public uint SystemCursorId => Controller.SystemCursorId;

        public void add_CursorChanged([In, MarshalAs(UnmanagedType.Interface)] ICoreWebView2CursorChangedEventHandler eventHandler, out EventRegistrationToken token)
        {
            Controller.add_CursorChanged(eventHandler, out token);
        }

        public void remove_CursorChanged([In] EventRegistrationToken token)
        {
            Controller.remove_CursorChanged(token);
        }

        private bool _IsDisposed;
        protected virtual void Dispose(bool disposing)
        {
            if (!_IsDisposed)
            {
                if (disposing)
                {
                    this.handle.Dispose();
                    _Controller = null;
                }

                _IsDisposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}