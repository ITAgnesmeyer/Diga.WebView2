using System.Threading.Tasks;
using Diga.WebView2.Interop;

namespace Diga.WebView2.Wrapper.Delegates
{
    public class ExecuteScriptCompletedDelegate : IWebView2ExecuteScriptCompletedHandler
    {
        private readonly TaskCompletionSource<(int, string)> _Source;

        public ExecuteScriptCompletedDelegate(TaskCompletionSource<(int, string)> source)
        {
            this._Source = source;
        }
        void IWebView2ExecuteScriptCompletedHandler.Invoke(int errorCode, string resultObjectAsJson)
        {
            this._Source.SetResult((errorCode, resultObjectAsJson));
        }
    }
}