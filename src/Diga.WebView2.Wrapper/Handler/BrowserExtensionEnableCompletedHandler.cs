using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.EventArguments;

namespace Diga.WebView2.Wrapper.Handler
{
    public class BrowserExtensionEnableCompletedHandler: ICoreWebView2BrowserExtensionEnableCompletedHandler
    {
        public event EventHandler<BrowserExtensionEnableRemoveArgs> BrowserExtensionEnabled;
        public void Invoke([In, MarshalAs(UnmanagedType.Error)] int errorCode)
        {
            try
            {
                OnBrowserExtensionEnabled(new BrowserExtensionEnableRemoveArgs(errorCode));
            }
            catch (Exception ex)
            {

                Debug.Print("BrowserExtensionEnableCompletedHandler error:" + ex.ToString());
            }
        }
        protected virtual void OnBrowserExtensionEnabled(BrowserExtensionEnableRemoveArgs args)
        {
            BrowserExtensionEnabled?.Invoke(this, args);
        }
    }
}