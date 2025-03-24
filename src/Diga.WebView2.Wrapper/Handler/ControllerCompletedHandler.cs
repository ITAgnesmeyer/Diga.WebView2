using System;
using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.EventArguments;
using Diga.WebView2.Wrapper.interop;
using Diga.WebView2.Wrapper.Types;

namespace Diga.WebView2.Wrapper.Handler
{
    public class ControllerCompletedHandler : ICoreWebView2CreateCoreWebView2ControllerCompletedHandler
    {
        public event EventHandler<ControllerCompletedArgs> ControllerCompleted;
        public event EventHandler<ControllerCompletedErrorArgs> ControllerCompletedError;
        public event EventHandler<BeforeControllerCreateEventArgs> BeforeControllerCreate;
        public void Invoke(int result, ICoreWebView2Controller createdController)
        {
            ICoreWebView2 webView = null;
            ICoreWebView2Controller controller = null;
            if (createdController != null)
            {
                controller = createdController;
                webView =controller.CoreWebView2;
                if (webView == null)
                {
                    OnHostCompletedError(new ControllerCompletedErrorArgs(result, "Could not create WebView2!",null));
                    return;
                }
            }
            else
            {
                OnHostCompletedError(new ControllerCompletedErrorArgs(result, "Could not create Controller!",null));
                return;
            }


            webView.AddWebResourceRequestedFilter("*",
                     COREWEBVIEW2_WEB_RESOURCE_CONTEXT.COREWEBVIEW2_WEB_RESOURCE_CONTEXT_ALL);
            ICoreWebView2Settings settings = webView.Settings;
            OnBeforeControllerCreate(new BeforeControllerCreateEventArgs(webView, controller, settings));
            settings.IsScriptEnabled = new CBOOL(true);
            settings.AreDefaultScriptDialogsEnabled = new CBOOL(true);
            settings.IsWebMessageEnabled = new CBOOL(true);
            tagRECT rect;
            NativeUser32.GetClientRect(createdController.ParentWindow, out rect);
            controller.Bounds = rect;
            OnControllerCompleted(new ControllerCompletedArgs(controller, webView));
        }
        protected virtual void OnControllerCompleted(ControllerCompletedArgs e)
        {
            ControllerCompleted?.Invoke(this, e);
        }

        protected virtual void OnHostCompletedError(ControllerCompletedErrorArgs e)
        {
            ControllerCompletedError?.Invoke(this, e);
        }

        protected virtual void OnBeforeControllerCreate(BeforeControllerCreateEventArgs e)
        {
            BeforeControllerCreate?.Invoke(this, e);
        }


    }
}