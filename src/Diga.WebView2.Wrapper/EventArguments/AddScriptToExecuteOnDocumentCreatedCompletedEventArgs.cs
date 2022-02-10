using System;

namespace Diga.WebView2.Wrapper.EventArguments
{
    public class AddScriptToExecuteOnDocumentCreatedCompletedEventArgs : EventArgs
    {
        public AddScriptToExecuteOnDocumentCreatedCompletedEventArgs(int errorCode, string id)
        {
            this.ErrorCode = errorCode;
            this.Id = id;
        }

        public int ErrorCode{get;}
        public string Id{get;}
    }
}