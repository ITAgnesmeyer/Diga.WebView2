using System;
using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.EventArguments;

namespace Diga.WebView2.Wrapper.Handler
{
    public class AddScriptToExecuteOnDocumentCreatedCompletedHandler
        : ICoreWebView2AddScriptToExecuteOnDocumentCreatedCompletedHandler
    {
        public event EventHandler<AddScriptToExecuteOnDocumentCreatedCompletedEventArgs> ScriptExecuted;
        public void Invoke(int errorCode, string id)
        {
            OnScriptExecuted(new AddScriptToExecuteOnDocumentCreatedCompletedEventArgs(errorCode, id));
        }

        protected virtual void OnScriptExecuted(AddScriptToExecuteOnDocumentCreatedCompletedEventArgs e)
        {
            ScriptExecuted?.Invoke(this, e);
        }
    }
}