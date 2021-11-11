﻿
using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Diga.WebView2.Interop;

namespace Diga.WebView2.Wrapper
{
    public class WebView2CompositionControllerInterface : ICoreWebView2CompositionController, IDisposable
    {
        private ICoreWebView2CompositionController _Controller;
        private ICoreWebView2CompositionController Controller
        {
            get
            {
                if (_Controller == null)
                {
                    Debug.Print(nameof(WebView2CompositionControllerInterface) + "=>" + nameof(Controller) + " is null");

                    throw new InvalidOperationException(nameof(WebView2CompositionControllerInterface) + "=>" + nameof(Controller) + " is null");
                }
                return _Controller;
            }
            set
            {
                _Controller = value;
            }
        }
        public WebView2CompositionControllerInterface(ICoreWebView2CompositionController controller)
        {
            if (controller == null)
                throw new ArgumentNullException(nameof(controller));
            Controller = controller;

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
                    this._Controller = null;
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