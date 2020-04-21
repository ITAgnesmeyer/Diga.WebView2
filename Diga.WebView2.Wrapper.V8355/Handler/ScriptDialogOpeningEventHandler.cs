using System;
using Diga.WebView2.Interop;

namespace Diga.WebView2.Wrapper
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