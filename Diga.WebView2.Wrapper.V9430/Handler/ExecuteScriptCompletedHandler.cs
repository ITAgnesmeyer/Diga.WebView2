using System;
using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.EventArguments;

namespace Diga.WebView2.Wrapper.Handler
{
    public class ExecuteScriptCompletedHandler : ICoreWebView2ExecuteScriptCompletedHandler
    {
        public event EventHandler<ExecuteScriptCompletedEventArgs> ScriptCompleted;
        public void Invoke(int errorCode, string resultObjectAsJson)
        {
            OnScriptCompleted(new ExecuteScriptCompletedEventArgs(errorCode, resultObjectAsJson));
        }

        protected virtual void OnScriptCompleted(ExecuteScriptCompletedEventArgs e)
        {
            ScriptCompleted?.Invoke(this, e);
        }
    }
}