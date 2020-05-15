using System;
using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.EventArguments;
using Diga.WebView2.Wrapper.Types;

namespace Diga.WebView2.Wrapper.Handler
{
    public class CreateWebViewCompletedHandler : IWebView2CreateWebViewCompletedHandler
    {
        public event EventHandler<HostCompletedArgs> HostCompleted;
        public event EventHandler<HostCompletedErrorArgs> HostCompletedError;
        public event EventHandler<BeforeHostCreateEventArgs> BeforeHostCreate;
        public IntPtr ParentWindow{get;}
        public CreateWebViewCompletedHandler(IntPtr parentWindow)
        {
            this.ParentWindow = parentWindow;
        }
        public void Invoke(int result, IWebView2WebView webview)
        {
            if (webview == null)
            {
                OnHostCompletedError(new HostCompletedErrorArgs(result, "Could not create Host!"));
                return;
            }

            var webV = (IWebView2WebView5) webview;
            webV.AddWebResourceRequestedFilter("*", WEBVIEW2_WEB_RESOURCE_CONTEXT.WEBVIEW2_WEB_RESOURCE_CONTEXT_ALL);
            IWebView2Settings2 settings = (IWebView2Settings2)webview.Settings;
            
            settings.IsScriptEnabled = new CBOOL(true);
            settings.AreDefaultScriptDialogsEnabled = new CBOOL(true);
            settings.IsWebMessageEnabled = new CBOOL(true);
            OnBeforeHostCreate(new BeforeHostCreateEventArgs(webV,settings));
            
            tagRECT rect;
            Native.GetClientRect(this.ParentWindow, out rect);
            webV.Bounds = rect;
            OnHostCompleted(new HostCompletedArgs( webV));

        }

        protected virtual void OnHostCompleted(HostCompletedArgs e)
        {
            HostCompleted?.Invoke(this, e);
        }

        protected virtual void OnHostCompletedError(HostCompletedErrorArgs e)
        {
            HostCompletedError?.Invoke(this, e);
        }

        protected virtual void OnBeforeHostCreate(BeforeHostCreateEventArgs e)
        {
            BeforeHostCreate?.Invoke(this, e);
        }

       
    }
}