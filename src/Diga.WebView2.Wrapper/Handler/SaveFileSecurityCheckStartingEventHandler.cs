using System;
using System.Diagnostics;
using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.EventArguments;

namespace Diga.WebView2.Wrapper.Handler
{
    public class SaveFileSecurityCheckStartingEventHandler: ICoreWebView2SaveFileSecurityCheckStartingEventHandler
    {
        public event EventHandler<SaveFileSecurityCheckStartingEventArgs> SaveFileSecurityCheckStarting;
        private void OnSaveFileSecurityCheckStarting(SaveFileSecurityCheckStartingEventArgs e)
        {
            this.SaveFileSecurityCheckStarting?.Invoke(this, e);
        }
        public void Invoke(ICoreWebView2 sender, ICoreWebView2SaveFileSecurityCheckStartingEventArgs args)
        {
            try
            {
                OnSaveFileSecurityCheckStarting(new SaveFileSecurityCheckStartingEventArgs(args));
            }
            catch (Exception ex)
            {
                Debug.Print(nameof(SaveFileSecurityCheckStartingEventHandler) + " Exception:" + ex.ToString());
            }
        }
    }
}