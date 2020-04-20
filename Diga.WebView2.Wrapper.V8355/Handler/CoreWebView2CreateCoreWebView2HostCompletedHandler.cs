using System;
using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.EventArguments;

namespace Diga.WebView2.Wrapper.Handler
{
    public class CoreWebView2CreateCoreWebView2HostCompletedHandler : IWebView2CreateWebViewCompletedHandler
    {
        public event EventHandler<CoreWebView2HostCompletedArgs> HostCompleted;
        public event EventHandler<CoreWebView2HostCompletedErrorArgs> HostCompletedError;
        public event EventHandler<BeforeHostCreateEventArgs> BeforeHostCreate;
        public IntPtr ParentWindow{get;}
        public CoreWebView2CreateCoreWebView2HostCompletedHandler(IntPtr parentWindow)
        {
            this.ParentWindow = parentWindow;
        }
        public void Invoke(int result, IWebView2WebView webview)
        {
            IWebView2WebView5 webV;
            
            if (webview == null)
            {
                OnHostCompletedError(new CoreWebView2HostCompletedErrorArgs(result, "Could not create Host!"));
                return;
            }

            webV = (IWebView2WebView5) webview;
            IWebView2Settings2 settings = (IWebView2Settings2)webview.Settings;
            OnBeforeHostCreate(new BeforeHostCreateEventArgs(webV,settings));
            settings.IsScriptEnabled = new CBOOL(true);
            settings.AreDefaultScriptDialogsEnabled = new CBOOL(true);
            settings.IsWebMessageEnabled = new CBOOL(true);
            tagRECT rect;
            Native.GetClientRect(this.ParentWindow, out rect);
            webV.Bounds = rect;
            OnHostCompleted(new CoreWebView2HostCompletedArgs( webV));

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