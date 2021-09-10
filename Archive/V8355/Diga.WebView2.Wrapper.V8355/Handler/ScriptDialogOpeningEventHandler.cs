using System;
using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.EventArguments;

namespace Diga.WebView2.Wrapper.Handler
{
    public class ScriptDialogOpeningEventHandler : IWebView2ScriptDialogOpeningEventHandler
    {
        public event EventHandler<ScriptDialogOpeningEventArgs> ScriptDialogOpening;
        public void Invoke(IWebView2WebView webview, IWebView2ScriptDialogOpeningEventArgs args)
        {
            OnScriptDialogOpening(new ScriptDialogOpeningEventArgs(args));
        }

        private void OnScriptDialogOpening(ScriptDialogOpeningEventArgs e)
        {
            this.ScriptDialogOpening?.Invoke(this, e);
        }
    }
}