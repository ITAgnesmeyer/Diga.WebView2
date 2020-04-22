using System;
using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.EventArguments;
using Diga.WebView2.Wrapper.Types;

namespace Diga.WebView2.Wrapper.Handler
{
    public class
        EnvironmentCompletedHandler :
          IWebView2CreateWebView2EnvironmentCompletedHandler
    {
        public IWebView2WebView5 WebView{get;private set;}
        //public ICoreWebView2Host Host{get; private set; }
        public event EventHandler<EnvironmentCompletedHandlerArgs> BeforeEnvironmentCompleted;
        public event EventHandler<EnvironmentCompletedHandlerArgs> AfterEnvironmentCompleted;

        public event EventHandler<HostCompletedArgs> HostCompleted;
        public event EventHandler<BeforeHostCreateEventArgs> PrepareHostCreate;

        public EnvironmentCompletedHandler(IntPtr parentHandle)
        {
            this.ParentHandle = parentHandle;
        }
        public IntPtr ParentHandle { get; set; }
        public void Invoke(int result, IWebView2Environment createdEnvironment)
        {
            IntPtr hWnd = this.ParentHandle;
            var handler = new CreateWebViewCompletedHandler(this.ParentHandle);
            handler.HostCompleted += OnHostCompleted;
            handler.HostCompletedError += OnHostCompletedError;
            handler.BeforeHostCreate += OnBeforeHostCreate;

            IWebView2Environment3 env = (IWebView2Environment3) createdEnvironment;
            env.CreateWebView(this.ParentHandle, handler);
            OnAfterEnvironmentCompleted(new EnvironmentCompletedHandlerArgs(env));
            result = HRESULT.S_OK;
        }

        private void OnBeforeHostCreate(object sender, BeforeHostCreateEventArgs e)
        {
            OnPrepareHostCreate(e);
        }

        private void OnHostCompletedError(object sender, HostCompletedErrorArgs e)
        {
            
        }

        private void OnHostCompleted(object sender, HostCompletedArgs e)
        {
            //this.Host = e.Host;
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

        protected virtual void OnHostCompleted(HostCompletedArgs e)
        {
            HostCompleted?.Invoke(this, e);
        }

        protected virtual void OnPrepareHostCreate(BeforeHostCreateEventArgs e)
        {
            PrepareHostCreate?.Invoke(this, e);
        }
    }
}
