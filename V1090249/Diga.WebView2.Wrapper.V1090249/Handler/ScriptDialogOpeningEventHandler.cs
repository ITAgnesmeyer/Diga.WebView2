using System;
using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.EventArguments;

namespace Diga.WebView2.Wrapper.Handler
{
    public class ScriptDialogOpeningEventHandler : ICoreWebView2ScriptDialogOpeningEventHandler
    {
        public event EventHandler<ScriptDialogOpeningEventArgs> ScriptDialogOpening;
       

        private void OnScriptDialogOpening(ScriptDialogOpeningEventArgs e)
        {
            this.ScriptDialogOpening?.Invoke(this, e);
        }

        public void Invoke(ICoreWebView2 sender, ICoreWebView2ScriptDialogOpeningEventArgs args)
        {
            OnScriptDialogOpening(new ScriptDialogOpeningEventArgs(args));
        }
    }
}