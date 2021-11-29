using System;
using System.Diagnostics;
using System.Threading.Tasks;
using Diga.WebView2.Interop;

namespace Diga.WebView2.Wrapper.Delegates
{

    public class ExecuteScriptCompletedDelegate : ICoreWebView2ExecuteScriptCompletedHandler
    {
        private readonly TaskCompletionSource<(int, string)> _Source;

        public ExecuteScriptCompletedDelegate(TaskCompletionSource<(int, string)> source)
        {
            this._Source = source;
        }
        void ICoreWebView2ExecuteScriptCompletedHandler.Invoke(int errorCode, string resultObjectAsJson)
        {
            try
            {
                this._Source.SetResult((errorCode, resultObjectAsJson));
            }
            catch (Exception ex)
            {
                Debug.Print(nameof(ExecuteScriptCompletedDelegate) + " Exception:" + ex.ToString());

            }


            
        }
    }
}