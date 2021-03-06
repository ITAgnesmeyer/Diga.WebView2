﻿using System;
using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.EventArguments;
using Diga.WebView2.Wrapper.Types;

namespace Diga.WebView2.Wrapper.Handler
{
    public class ExecuteScriptCompletedHandler : IWebView2ExecuteScriptCompletedHandler
    {
        public event EventHandler<ExecuteScriptCompletedEventArgs> ScriptCompleted;
        public Action<string,int, string> ActionToInvoke;
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public void Invoke(int errorCode, string resultObjectAsJson)
        {
            InvokeAction(this.Id , errorCode, resultObjectAsJson);
            OnScriptCompleted(new ExecuteScriptCompletedEventArgs(this.Id,errorCode, resultObjectAsJson));

        }

        protected virtual void InvokeAction(string id, int errorCode, string resultObjectAsString)
        {
            this.ActionToInvoke?.Invoke(id, errorCode, resultObjectAsString);
        }
        protected virtual void OnScriptCompleted(ExecuteScriptCompletedEventArgs e)
        {
            ScriptCompleted?.Invoke(this, e);
        }
    }
}