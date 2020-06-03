using System;
using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.EventArguments;
using Diga.WebView2.Wrapper.Types;

namespace Diga.WebView2.Wrapper.Handler
{
    public class
       EnvironmentCompletedHandler :
          ICoreWebView2CreateCoreWebView2EnvironmentCompletedHandler
    {
        public ICoreWebView2 WebView { get; private set; }
        public ICoreWebView2Controller Controller { get; set; }

        public event EventHandler<EnvironmentCompletedHandlerArgs> BeforeEnvironmentCompleted;
        public event EventHandler<EnvironmentCompletedHandlerArgs> AfterEnvironmentCompleted;

        public event EventHandler<ControllerCompletedArgs> ControllerCompleted;
        public event EventHandler<BeforeControllerCreateEventArgs> PrepareControllerCreate;

        public EnvironmentCompletedHandler(IntPtr parentHandle)
        {
            this.ParentHandle = parentHandle;
        }
        public IntPtr ParentHandle { get; set; }
        public void Invoke(int result, ICoreWebView2Environment createdEnvironment)
        {
            IntPtr hWnd = this.ParentHandle;
            var handler = new ControllerCompletedHandler();
            handler.ControllerCompleted += OnControllerCompletedIntern;
            handler.ControllerCompletedError += OnControllerCompletedErrorIntern;
            handler.BeforeControllerCreate += OnBeforeControllerCreateIntern;
            OnBeforeEnvironmentCompleted(new EnvironmentCompletedHandlerArgs(createdEnvironment));
            createdEnvironment.CreateCoreWebView2Controller(hWnd, handler);

            OnAfterEnvironmentCompleted(new EnvironmentCompletedHandlerArgs(createdEnvironment));
            result = HRESULT.S_OK;
        }

        private void OnBeforeControllerCreateIntern(object sender, BeforeControllerCreateEventArgs e)
        {
            OnPrepareControllerCreate(e);
        }

        private void OnControllerCompletedErrorIntern(object sender, ControllerCompletedErrorArgs e)
        {

        }

        private void OnControllerCompletedIntern(object sender, ControllerCompletedArgs e)
        {
            this.Controller = e.Controller;
            this.WebView = e.WebView;
            OnControllerCompleted(e);
        }

        protected virtual void OnBeforeEnvironmentCompleted(EnvironmentCompletedHandlerArgs e)
        {
            BeforeEnvironmentCompleted?.Invoke(this, e);
        }

        protected virtual void OnAfterEnvironmentCompleted(EnvironmentCompletedHandlerArgs e)
        {
            AfterEnvironmentCompleted?.Invoke(this, e);
        }

        protected virtual void OnControllerCompleted(ControllerCompletedArgs e)
        {
            ControllerCompleted?.Invoke(this, e);
        }

        protected virtual void OnPrepareControllerCreate(BeforeControllerCreateEventArgs e)
        {
            PrepareControllerCreate?.Invoke(this, e);
        }
    }
}
