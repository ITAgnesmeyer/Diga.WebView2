using System;

namespace Diga.WebView2.Wrapper.EventArguments
{
    public class ExecuteScriptCompletedEventArgs : EventArgs
    {
        public ExecuteScriptCompletedEventArgs(int errorCode, string resultObjectAsJson)
        {
            this.ErrorCode = errorCode;
            this.ResultObjectAsJson = resultObjectAsJson;
        }

        public int ErrorCode{get;}
        public string ResultObjectAsJson{get;}
    }
}