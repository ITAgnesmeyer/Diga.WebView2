
using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.Types;
using Microsoft.Win32.SafeHandles;

namespace Diga.WebView2.Wrapper.Implementation
{
    public class WebView2CompositionControllerInterface :  IDisposable
    {
        private ComObjectHolder<ICoreWebView2CompositionController> _Controller;
        private ICoreWebView2CompositionController Controller
        {
            get
            {
                if (this._Controller == null)
                {
                    Debug.Print(nameof(WebView2CompositionControllerInterface) + "=>" + nameof(this.Controller) + " is null");

                    throw new InvalidOperationException(nameof(WebView2CompositionControllerInterface) + "=>" + nameof(this.Controller) + " is null");
                }
                return this._Controller.Interface;
            }
            set
            {
                this._Controller = new ComObjectHolder<ICoreWebView2CompositionController>( value);
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

        public object RootVisualTarget { get => this.Controller.RootVisualTarget; set => this.Controller.RootVisualTarget = value; }

        public void SendMouseInput([In] COREWEBVIEW2_MOUSE_EVENT_KIND eventKind, [In] COREWEBVIEW2_MOUSE_EVENT_VIRTUAL_KEYS virtualKeys, [In] uint mouseData, [In] tagPOINT point)
        {
            this.Controller.SendMouseInput(eventKind, virtualKeys, mouseData, point);
        }

        public void SendPointerInput([In] COREWEBVIEW2_POINTER_EVENT_KIND eventKind, [In, MarshalAs(UnmanagedType.Interface)] ICoreWebView2PointerInfo pointerInfo)
        {
            this.Controller.SendPointerInput(eventKind, pointerInfo);
        }

        public IntPtr Cursor => this.Controller.Cursor;

        public uint SystemCursorId => this.Controller.SystemCursorId;

        public void add_CursorChanged([In, MarshalAs(UnmanagedType.Interface)] ICoreWebView2CursorChangedEventHandler eventHandler, out EventRegistrationToken token)
        {
            this.Controller.add_CursorChanged(eventHandler, out token);
        }

        public void remove_CursorChanged([In] EventRegistrationToken token)
        {
            this.Controller.remove_CursorChanged(token);
        }

        private bool _IsDisposed;
        protected virtual void Dispose(bool disposing)
        {
            if (!this._IsDisposed)
            {
                if (disposing)
                {
                    this.handle.Dispose();
                    this._Controller = null;
                }

                this._IsDisposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}