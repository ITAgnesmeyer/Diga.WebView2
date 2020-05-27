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
        public ICoreWebView2Controller Host { get; set; }

        public event EventHandler<EnvironmentCompletedHandlerArgs> BeforeEnvironmentCompleted;
        public event EventHandler<EnvironmentCompletedHandlerArgs> AfterEnvironmentCompleted;

        public event EventHandler<CoreWebView2HostCompletedArgs> HostCompleted;
        public event EventHandler<BeforeHostCreateEventArgs> PrepareHostCreate;

        public EnvironmentCompletedHandler(IntPtr parentHandle)
        {
            this.ParentHandle = parentHandle;
        }
        public IntPtr ParentHandle { get; set; }
        public void Invoke(int result, ICoreWebView2Environment createdEnvironment)
        {
            IntPtr hWnd = this.ParentHandle;
            var handler = new HostCompletedHandler();
            handler.HostCompleted += OnHostCompleted;
            handler.HostCompletedError += OnHostCompletedError;
            handler.BeforeHostCreate += OnBeforeHostCreate;
            createdEnvironment.CreateCoreWebView2Controller(hWnd, handler);

            OnAfterEnvironmentCompleted(new EnvironmentCompletedHandlerArgs(createdEnvironment));
            result = HRESULT.S_OK;
        }

        private void OnBeforeHostCreate(object sender, BeforeHostCreateEventArgs e)
        {
            OnPrepareHostCreate(e);
        }

        private void OnHostCompletedError(object sender, CoreWebView2HostCompletedErrorArgs e)
        {

        }

        private void OnHostCompleted(object sender, CoreWebView2HostCompletedArgs e)
        {
            this.Host = e.Host;
            this.WebView = e.WebView;
            OnHostCompleted(e);
        }

        protected virtual void OnBeforeEnvironmentCompleted(EnvironmentCompletedHandlerArgs e)
        {
            BeforeEnvironmentCompleted?.Invoke(this, e);
        }

        protected virtual void OnAfterEnvironmentCompleted(EnvironmentCompletedHandlerArgs e)
        {
            AfterEnvironmentCompleted?.Invoke(this, e);
        }

        protected virtual void OnHostCompleted(CoreWebView2HostCompletedArgs e)
        {
            HostCompleted?.Invoke(this, e);
        }

        protected virtual void OnPrepareHostCreate(BeforeHostCreateEventArgs e)
        {
            PrepareHostCreate?.Invoke(this, e);
        }
    }
}
