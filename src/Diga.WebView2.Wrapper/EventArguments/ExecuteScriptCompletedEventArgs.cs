using System;
using Diga.WebView2.Interop;

namespace Diga.WebView2.Wrapper.EventArguments
{
    

    public class ExecuteScriptCompletedEventArgs : EventArgs, IExecuteScriptCompletedEventArgs
    {
        public ExecuteScriptCompletedEventArgs(int errorCode, string resultObjectAsJson, string id)
        {
            this.ErrorCode = errorCode;
            this.ResultObjectAsJson = resultObjectAsJson;
            this.Id = id;
        }

        public int ErrorCode{get;}
        public string Id{get;}
        public string ResultObjectAsJson{get;}
    }
}