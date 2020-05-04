using System;
using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.EventArguments;
using Diga.WebView2.Wrapper.Types;

namespace Diga.WebView2.Wrapper.Handler
{
#if V9488
    public class HostCompletedHandler : ICoreWebView2CreateCoreWebView2ControllerCompletedHandler
#else
    public class HostCompletedHandler : ICoreWebView2CreateCoreWebView2HostCompletedHandler
#endif
    {
        public event EventHandler<CoreWebView2HostCompletedArgs> HostCompleted;
        public event EventHandler<CoreWebView2HostCompletedErrorArgs> HostCompletedError;
        public event EventHandler<BeforeHostCreateEventArgs> BeforeHostCreate;
#if V9488
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
#else
        public void Invoke(int result, ICoreWebView2Host createdHost)
        {
            ICoreWebView2 webView = null;
            ICoreWebView2Host host = null;
            if (createdHost != null)
            {
                host = createdHost;
                webView = host.CoreWebView2;
            }
            else
            {
                OnHostCompletedError(new CoreWebView2HostCompletedErrorArgs(result, "Could not create Host!"));
                return;
            }

            if (webView != null)
                webView.AddWebResourceRequestedFilter("*",
                    CORE_WEBVIEW2_WEB_RESOURCE_CONTEXT.CORE_WEBVIEW2_WEB_RESOURCE_CONTEXT_ALL);
            ICoreWebView2Settings settings = webView.Settings;
            OnBeforeHostCreate(new BeforeHostCreateEventArgs(webView, host, settings));
            settings.IsScriptEnabled = new CBOOL(true);
            settings.AreDefaultScriptDialogsEnabled = new CBOOL(true);
            settings.IsWebMessageEnabled = new CBOOL(true);
            tagRECT rect;
            Native.GetClientRect(createdHost.ParentWindow, out rect);
            host.Bounds = rect;
            OnHostCompleted(new CoreWebView2HostCompletedArgs(host, webView));

        }
#endif
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