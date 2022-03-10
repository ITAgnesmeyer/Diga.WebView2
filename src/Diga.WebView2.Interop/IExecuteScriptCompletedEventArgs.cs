using System;
using System.Threading.Tasks;

namespace Diga.WebView2.Interop
{

    public interface IWebViewControlEvents
    {
        event EventHandler<IExecuteScriptCompletedEventArgs> ExecuteScriptCompleted;
    }

    public interface IWebViewControlScript
    {
        
        Task<string> ExecuteScriptAsync(string javaScript);
        string ExecuteScriptSync(string javaScript);
        string InvokeScript(string javaScript);

    }

    public interface IWebViewControl:IWebViewControlScript,IWebViewControlEvents
    {

    }

    public interface IExecuteScriptCompletedEventArgs
    {
        int ErrorCode { get; }
        string Id { get; }
        string ResultObjectAsJson { get; }
    }
}