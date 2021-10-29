using System;
using System.Diagnostics;
using System.Runtime.ExceptionServices;
using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.EventArguments;
using Diga.WebView2.Wrapper.Handler;
using Diga.WebView2.Wrapper.Types;

namespace Diga.WebView2.Wrapper
{
    public partial class WebView2CompositionController:IDisposable
    {
        public event EventHandler<CursorChangedEventArgs> CursorChanged;

        public WebView2CompositionController()
        {
            this._Controller = this;
            RegisterEvents();
        }
        public WebView2CompositionController(ICoreWebView2CompositionController2 controller)
        {
            this._Controller = controller;
            RegisterEvents();
        }

        private ICoreWebView2CompositionController2 ToInterface()
        {
            return this;
        }

        public object RootVisualTarget
        {
            get => this.ToInterface().RootVisualTarget;
            set => this.ToInterface().RootVisualTarget = value;
        }

        public void SendMouseInput(COREWEBVIEW2_MOUSE_EVENT_KIND eventKind,
            COREWEBVIEW2_MOUSE_EVENT_VIRTUAL_KEYS virtualKeys,
            uint mouseData, Point point)
        {
            this.ToInterface().SendMouseInput(eventKind, virtualKeys, mouseData, point);
        }

        public void SendPointerInput(COREWEBVIEW2_POINTER_EVENT_KIND eventKind, WebView2PointerInfo pointerInfo)
        {
            this.ToInterface().SendPointerInput(eventKind, pointerInfo);
        }

        public IntPtr Cursor => this.ToInterface().Cursor;
        public uint SystemCursorId => this.ToInterface().SystemCursorId;
        public object UIAProvider => this.ToInterface().UIAProvider;
        private EventRegistrationToken _CursorChangedToken;
        private void RegisterEvents()
        {
            if (this._Controller == null) return;

           CursorChangedEventHandler eventHandler = new CursorChangedEventHandler();
           eventHandler.CursorChanged += OnCursorChangedIntern;
            this.ToInterface().add_CursorChanged(eventHandler, out this._CursorChangedToken);
        }

        [HandleProcessCorruptedStateExceptions]
        private void UnRegisterEvents()
        {
            if (this._Controller == null) return;
            try
            {
               EventRegistrationTool.UnWireToken(  this._CursorChangedToken,this._Controller.remove_CursorChanged);
            }
            catch (Exception e)
            {
                Debug.Print(e.ToString());

            }
            
        }
        private void OnCursorChangedIntern(object sender, CursorChangedEventArgs e)
        {
            OnCursorChanged(e);
        }
        public virtual void Dispose(bool dispose)
        {
            if(dispose)
            {
                UnRegisterEvents();
                this._Controller = null;

            }
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void OnCursorChanged(CursorChangedEventArgs e)
        {
            CursorChanged?.Invoke(this, e);
        }
    }

    
}