using System;
using System.Diagnostics;
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
            try
            {
                OnScriptExecuted(new AddScriptToExecuteOnDocumentCreatedCompletedEventArgs(errorCode, id));
            }
            catch (Exception ex)
            {

                Debug.Print("AddScriptToExecuteOnDocumentCreatedCompletedHandler Exception=>" + ex.ToString());
            }
            
        }

        protected virtual void OnScriptExecuted(AddScriptToExecuteOnDocumentCreatedCompletedEventArgs e)
        {
            ScriptExecuted?.Invoke(this, e);
        }
    }
}