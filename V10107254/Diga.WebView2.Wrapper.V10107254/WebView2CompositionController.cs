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
    public partial class WebView2CompositionController : WebView2CompositionController2Interface
    {
        public event EventHandler<CursorChangedEventArgs> CursorChanged;


        public WebView2CompositionController(ICoreWebView2CompositionController2 controller) : base(controller)
        {
            if (controller == null)
                throw new ArgumentNullException(nameof(controller));

            RegisterEvents();
        }

        private EventRegistrationToken _CursorChangedToken;
        private void RegisterEvents()
        {


            CursorChangedEventHandler eventHandler = new CursorChangedEventHandler();
            eventHandler.CursorChanged += OnCursorChangedIntern;
            base.add_CursorChanged(eventHandler, out this._CursorChangedToken);

        }

        [SecurityCritical]
#pragma warning disable SYSLIB0032 // Typ oder Element ist veraltet
        [HandleProcessCorruptedStateExceptions]
#pragma warning restore SYSLIB0032 // Typ oder Element ist veraltet
        private void UnRegisterEvents()
        {

            try
            {
                EventRegistrationTool.UnWireToken(this._CursorChangedToken, base.remove_CursorChanged);
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
        private bool _IsDisposed;
        protected override void Dispose(bool disposing)
        {
            if (this._IsDisposed) return;
            if (disposing)
            {
                UnRegisterEvents();
                this._IsDisposed = true;

            }
            base.Dispose(disposing);
        }


        protected virtual void OnCursorChanged(CursorChangedEventArgs e)
        {
            CursorChanged?.Invoke(this, e);
        }
    }


}