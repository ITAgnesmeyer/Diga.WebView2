using System;

namespace Diga.WebView2.Wrapper.EventArguments
{
    public class ExecuteScriptCompletedEventArgs : EventArgs
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