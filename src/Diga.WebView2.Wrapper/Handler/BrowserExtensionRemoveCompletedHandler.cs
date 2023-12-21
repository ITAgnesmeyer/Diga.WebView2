using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.EventArguments;

namespace Diga.WebView2.Wrapper.Handler
{
    public class BrowserExtensionRemoveCompletedHandler: ICoreWebView2BrowserExtensionRemoveCompletedHandler
    {
        public event EventHandler<BrowserExtensionEnableRemoveArgs> BrowserExtensionRemove;
        public void Invoke([In, MarshalAs(UnmanagedType.Error)] int errorCode)
        {
            try
            {
                OnBrowserExtensionRemove(new BrowserExtensionEnableRemoveArgs(errorCode));
            }
            catch (Exception ex)
            {

                Debug.Print("BrowserExtensionRemoveCompletedHandler error:" + ex.ToString());
            }
        }
        protected virtual void OnBrowserExtensionRemove(BrowserExtensionEnableRemoveArgs args)
        {
            BrowserExtensionRemove?.Invoke(this, args);
        }
    }
}