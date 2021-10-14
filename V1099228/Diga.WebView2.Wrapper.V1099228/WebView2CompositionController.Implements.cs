
using System;
using Diga.WebView2.Interop;

namespace Diga.WebView2.Wrapper
{
public partial class WebView2CompositionController : ICoreWebView2CompositionController2
    {
        private  ICoreWebView2CompositionController2 _Controller;


        object ICoreWebView2CompositionController.RootVisualTarget
        {
            get => this._Controller.RootVisualTarget;
            set => this._Controller.RootVisualTarget = value;
        }

        object ICoreWebView2CompositionController2.RootVisualTarget
        {
            get => this._Controller.RootVisualTarget;
            set => this._Controller.RootVisualTarget = value;
        }

        void ICoreWebView2CompositionController.SendMouseInput(COREWEBVIEW2_MOUSE_EVENT_KIND eventKind, COREWEBVIEW2_MOUSE_EVENT_VIRTUAL_KEYS virtualKeys,
            uint mouseData, tagPOINT point)
        {
            this._Controller.SendMouseInput(eventKind, virtualKeys, mouseData, point);
        }

        void ICoreWebView2CompositionController2.SendPointerInput(COREWEBVIEW2_POINTER_EVENT_KIND eventKind, ICoreWebView2PointerInfo pointerInfo)
        {
            this._Controller.SendPointerInput(eventKind, pointerInfo);
        }

        IntPtr ICoreWebView2CompositionController2.Cursor => this._Controller.Cursor;

        uint ICoreWebView2CompositionController2.SystemCursorId => this._Controller.SystemCursorId;

        void ICoreWebView2CompositionController2.SendMouseInput(COREWEBVIEW2_MOUSE_EVENT_KIND eventKind, COREWEBVIEW2_MOUSE_EVENT_VIRTUAL_KEYS virtualKeys,
            uint mouseData, tagPOINT point)
        {
            this._Controller.SendMouseInput(eventKind, virtualKeys, mouseData, point);
        }

        void ICoreWebView2CompositionController.SendPointerInput(COREWEBVIEW2_POINTER_EVENT_KIND eventKind, ICoreWebView2PointerInfo pointerInfo)
        {
            this._Controller.SendPointerInput(eventKind, pointerInfo);
        }

        IntPtr ICoreWebView2CompositionController.Cursor => this._Controller.Cursor;

        uint ICoreWebView2CompositionController.SystemCursorId => this._Controller.SystemCursorId;

        void ICoreWebView2CompositionController.add_CursorChanged(ICoreWebView2CursorChangedEventHandler eventHandler, out EventRegistrationToken token)
        {
            this._Controller.add_CursorChanged(eventHandler, out token);
        }

        void ICoreWebView2CompositionController2.remove_CursorChanged(EventRegistrationToken token)
        {
            this._Controller.remove_CursorChanged(token);
        }

        object ICoreWebView2CompositionController2.UIAProvider => this._Controller.UIAProvider;

        void ICoreWebView2CompositionController2.add_CursorChanged(ICoreWebView2CursorChangedEventHandler eventHandler, out EventRegistrationToken token)
        {
            this._Controller.add_CursorChanged(eventHandler, out token);
        }

        void ICoreWebView2CompositionController.remove_CursorChanged(EventRegistrationToken token)
        {
            this._Controller.remove_CursorChanged(token);
        }
    }
}