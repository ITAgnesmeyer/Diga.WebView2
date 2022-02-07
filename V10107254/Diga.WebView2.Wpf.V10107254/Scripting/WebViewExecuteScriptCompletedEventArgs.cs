using Diga.WebView2.Wrapper.EventArguments;

namespace Diga.WebView2.Wpf.Scripting
{
    public class WebViewExecuteScriptCompletedEventArgs : ExecuteScriptCompletedEventArgs
    {
        public ScriptErrorObject ScriptError { get; }
        public WebViewExecuteScriptCompletedEventArgs(int errorCode, string resultObjectAsJson, string id) : base(errorCode, resultObjectAsJson, id)
        {
            ScriptError = ScriptSerializationHelper.GetScriptErrorObject(ResultObjectAsJson);
        }
    }
}
