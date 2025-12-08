using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.EventArguments;

namespace Diga.WebView2.Wrapper.Handler
{

    public class SaveAsUIShowingEventHandler : ICoreWebView2SaveAsUIShowingEventHandler
    {
        public event EventHandler<SaveAsUIShowingEventArgs> SaveAsUIShowing;
        private void OnSaveAsUIShowing(SaveAsUIShowingEventArgs e)
        {
            this.SaveAsUIShowing?.Invoke(this, e);
        }
        public void Invoke(ICoreWebView2 sender, ICoreWebView2SaveAsUIShowingEventArgs args)
        {
            try
            {
                OnSaveAsUIShowing(new SaveAsUIShowingEventArgs(args));
            }
            catch (Exception ex)
            {
                Debug.Print(nameof(SaveAsUIShowingEventHandler) + " Exception:" + ex.ToString());
            }
        }
    }
}