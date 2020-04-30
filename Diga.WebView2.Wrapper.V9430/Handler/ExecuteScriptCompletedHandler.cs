using System;
using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.EventArguments;

namespace Diga.WebView2.Wrapper.Handler
{
    public class ExecuteScriptCompletedHandler : ICoreWebView2ExecuteScriptCompletedHandler
    {
        public event EventHandler<ExecuteScriptCompletedEventArgs> ScriptCompleted;
        public Action<int, string> ActionToInvoke;
        public void Invoke(int errorCode, string resultObjectAsJson)
        {
            InvokeAction(errorCode, resultObjectAsJson);
            OnScriptCompleted(new ExecuteScriptCompletedEventArgs(errorCode, resultObjectAsJson));
        }
        protected virtual void InvokeAction(int errorCode, string resultObjectAsString)
        {
            this.ActionToInvoke?.Invoke(errorCode, resultObjectAsString);
        }
        protected virtual void OnScriptCompleted(ExecuteScriptCompletedEventArgs e)
        {
            ScriptCompleted?.Invoke(this, e);
        }
    }
}