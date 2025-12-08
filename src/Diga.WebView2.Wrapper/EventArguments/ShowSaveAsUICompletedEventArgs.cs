using Diga.WebView2.Interop;
using System;

namespace Diga.WebView2.Wrapper.EventArguments
{
    public class ShowSaveAsUICompletedEventArgs:EventArgs
    {
        public int ErrorCode { get; }
        public COREWEBVIEW2_SAVE_AS_UI_RESULT Result { get; }
        public ShowSaveAsUICompletedEventArgs(int errorCode, COREWEBVIEW2_SAVE_AS_UI_RESULT result)
        {
            ErrorCode = errorCode;
            Result = result;
        }
    }
}