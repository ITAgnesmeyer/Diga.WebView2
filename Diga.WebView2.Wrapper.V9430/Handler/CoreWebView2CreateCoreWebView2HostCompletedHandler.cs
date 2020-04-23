using System;
using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.EventArguments;

namespace Diga.WebView2.Wrapper.Handler
{
    public class CoreWebView2CreateCoreWebView2HostCompletedHandler : ICoreWebView2CreateCoreWebView2HostCompletedHandler
    {
        public event EventHandler<CoreWebView2HostCompletedArgs> HostCompleted;
        public event EventHandler<CoreWebView2HostCompletedErrorArgs> HostCompletedError;
        public event EventHandler<BeforeHostCreateEventArgs> BeforeHostCreate;

        public void Invoke(int result, ICoreWebView2Host createdHost)
        {
            ICoreWebView2 webView = null;
            ICoreWebView2Host host=null;
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