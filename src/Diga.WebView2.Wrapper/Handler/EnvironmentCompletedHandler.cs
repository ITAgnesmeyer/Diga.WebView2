using System;
using System.Diagnostics;
using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.EventArguments;
using Diga.WebView2.Wrapper.Types;

namespace Diga.WebView2.Wrapper.Handler
{
    public class EnvironmentCompletedHandler :
          ICoreWebView2CreateCoreWebView2EnvironmentCompletedHandler
    {
        public ICoreWebView2 WebView { get; private set; }
        public ICoreWebView2Controller Controller { get; set; }
        private ICoreWebView2Environment Environment { get; set; }
        public event EventHandler<EnvironmentCompletedHandlerArgs> BeforeEnvironmentCompleted;
        public event EventHandler<EnvironmentCompletedHandlerArgs> AfterEnvironmentCompleted;
        public event EventHandler<ControllerCompletedErrorArgs> ControllerCompletedError;
        public event EventHandler<ControllerCompletedArgs> ControllerCompleted;
        public event EventHandler<BeforeControllerCreateEventArgs> PrepareControllerCreate;
        public event EventHandler<CompositionControllerCompletedEventArgs> CompositionControllerCompleted;
        private string _ProfileName = string.Empty;
        private bool _IsInPrivateModeEnabled = false;
        public EnvironmentCompletedHandler(IntPtr parentHandle)
        {
            this.ParentHandle = parentHandle;
        }

        public EnvironmentCompletedHandler(IntPtr parentHandle, string profileName, bool isInPrivateModeEnabled)
        {
            this.ParentHandle = parentHandle;
            this._ProfileName = profileName;
            this._IsInPrivateModeEnabled = isInPrivateModeEnabled;
        }

        public IntPtr ParentHandle { get; set; }
        public void Invoke(int result, ICoreWebView2Environment createdEnvironment)
        {
            IntPtr hWnd = this.ParentHandle;
            this.Environment = createdEnvironment;
            var handler = new ControllerCompletedHandler();
            handler.ControllerCompleted += OnControllerCompletedIntern;
            handler.ControllerCompletedError += OnControllerCompletedErrorIntern;
            handler.BeforeControllerCreate += OnBeforeControllerCreateIntern;
            OnBeforeEnvironmentCompleted(new EnvironmentCompletedHandlerArgs((ICoreWebView2Environment14)createdEnvironment));
            //createdEnvironment.CreateCoreWebView2Controller(hWnd, handler);
            bool controllerCreated = false;
            try
            {
                ICoreWebView2Environment10 env = (ICoreWebView2Environment10)createdEnvironment;

                var options = env.CreateCoreWebView2ControllerOptions();
                options.IsInPrivateModeEnabled = new CBOOL(this._IsInPrivateModeEnabled);
                options.ProfileName = this._ProfileName;

                env.CreateCoreWebView2ControllerWithOptions(hWnd, options, handler);
                controllerCreated = true;
            }
            catch (Exception ex)
            {
                Debug.Print("CreateControllerWithOptions Error:" + ex.ToString());

            }

            if (!controllerCreated)
                createdEnvironment.CreateCoreWebView2Controller(hWnd, handler);


            var handler2 = new CompositionControllerCompletedHandler();
            handler2.Completed += OnCompositionControllerCompletedIntern;
            ((ICoreWebView2Environment4)createdEnvironment).CreateCoreWebView2CompositionController(hWnd, handler2);
            OnAfterEnvironmentCompleted(new EnvironmentCompletedHandlerArgs((ICoreWebView2Environment14)createdEnvironment));
            result = HRESULT.S_OK;
        }

        private void OnCompositionControllerCompletedIntern(object sender, CompositionControllerCompletedEventArgs e)
        {
            OnCompositionControllerCompleted(e);
        }

        private void OnBeforeControllerCreateIntern(object sender, BeforeControllerCreateEventArgs e)
        {
            OnPrepareControllerCreate(e);
        }

        private void OnControllerCompletedErrorIntern(object sender, ControllerCompletedErrorArgs e)
        {
            OnControllerCompletedError(e);
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

        protected virtual void OnCompositionControllerCompleted(CompositionControllerCompletedEventArgs e)
        {
            CompositionControllerCompleted?.Invoke(this, e);
        }

        protected virtual void OnControllerCompletedError(ControllerCompletedErrorArgs e)
        {
            ControllerCompletedError?.Invoke(this, e);
        }
    }
}
