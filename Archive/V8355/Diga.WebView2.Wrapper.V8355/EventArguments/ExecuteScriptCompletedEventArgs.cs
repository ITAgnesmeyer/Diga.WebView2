using System;

namespace Diga.WebView2.Wrapper.EventArguments
{
    public class ExecuteScriptCompletedEventArgs : EventArgs
    {
        public ExecuteScriptCompletedEventArgs(string id, int errorCode, string resultObjectAsJson)
        {
            this.Id = id;
            this.ErrorCode = errorCode;
            this.ResultObjectAsJson = resultObjectAsJson;
        }
        public string Id{get;}
        public int ErrorCode{get;}
        public string ResultObjectAsJson{get;}
    }
}