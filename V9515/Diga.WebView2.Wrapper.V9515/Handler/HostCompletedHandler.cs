using System;
using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.EventArguments;
using Diga.WebView2.Wrapper.Types;

namespace Diga.WebView2.Wrapper.Handler
{
    public class HostCompletedHandler : ICoreWebView2CreateCoreWebView2ControllerCompletedHandler
    {
        public event EventHandler<CoreWebView2HostCompletedArgs> HostCompleted;
        public event EventHandler<CoreWebView2HostCompletedErrorArgs> HostCompletedError;
        public event EventHandler<BeforeHostCreateEventArgs> BeforeHostCreate;
        public void Invoke(int result, ICoreWebView2Controller createdController)
        {
            ICoreWebView2 webView = null;
            ICoreWebView2Controller host = null;
            if (createdController != null)
            {
                host = createdController;
                webView = host.CoreWebView2;
            }
            else
            {
                OnHostCompletedError(new CoreWebView2HostCompletedErrorArgs(result, "Could not create Host!"));
                return;
            }

            if (webView != null)
                webView.AddWebResourceRequestedFilter("*",
                    COREWEBVIEW2_WEB_RESOURCE_CONTEXT.COREWEBVIEW2_WEB_RESOURCE_CONTEXT_ALL);
            ICoreWebView2Settings settings = webView.Settings;
            OnBeforeHostCreate(new BeforeHostCreateEventArgs(webView, host, settings));
            settings.IsScriptEnabled = new CBOOL(true);
            settings.AreDefaultScriptDialogsEnabled = new CBOOL(true);
            settings.IsWebMessageEnabled = new CBOOL(true);
            tagRECT rect;
            Native.GetClientRect(createdController.ParentWindow, out rect);
            host.Bounds = rect;
            OnHostCompleted(new CoreWebView2HostCompletedArgs(host, webView));
        }
        protected virtual void OnHostCompleted(CoreWebView2HostCompletedArgs e)
        {
            HostCompleted?.Invoke(this, e);
        }

        protected virtual void OnHostCompletedError(CoreWebView2HostCompletedErrorArgs e)
        {
            HostCompletedError?.Invoke(this, e);
        }

        protected virtual void OnBeforeHostCreate(BeforeHostCreateEventArgs e)
        {
            BeforeHostCreate?.Invoke(this, e);
        }

        
    }
}