using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Diga.WebView2.Interop;

namespace Diga.WebView2.Wrapper.Delegates
{
    public class ExecuteScriptCompletedHandlerNotifyCompletion : ICoreWebView2ExecuteScriptCompletedHandler, INotifyCompletion
    {
        private Action _Continuation;

        public int ErrorCode { get; private set; }
        public string ResultAsJson { get; private set; }
        public bool IsCompleted { get; private set; }

        public ExecuteScriptCompletedHandlerNotifyCompletion GetAwaiter()
        {
            return this;
        }

        public string GetResult()
        {
            return this.ResultAsJson;
        }
        public ExecuteScriptCompletedHandlerNotifyCompletion()
        {
            this.IsCompleted = false;
        }
        public void Invoke([In, MarshalAs(UnmanagedType.Error)] int errorCode, [In, MarshalAs(UnmanagedType.LPWStr)] string resultObjectAsJson)
        {
            this.ResultAsJson = resultObjectAsJson;
            this.ErrorCode = errorCode;
            this.IsCompleted = true;
            if (this._Continuation == null)
                return;
            this._Continuation();
        }

        public void OnCompleted(Action continuation)
        {
            this._Continuation = continuation;
            if (!this.IsCompleted)
                return;
            continuation();
        }
    }

    public struct ScriptResultType
    {
        public int ErrorCode { get; set; }
        public string ResultAsJson { get; set;}
    }
    public class ExecuteScriptCompletedDelegate : ICoreWebView2ExecuteScriptCompletedHandler
    {
        private readonly TaskCompletionSource<ScriptResultType> _Source;

        public ExecuteScriptCompletedDelegate(TaskCompletionSource<ScriptResultType> source)
        {
            this._Source = source;
        }
        void ICoreWebView2ExecuteScriptCompletedHandler.Invoke(int errorCode, string resultObjectAsJson)
        {
            try
            {
                ScriptResultType result = new ScriptResultType
                {
                    ErrorCode = errorCode,
                    ResultAsJson = resultObjectAsJson
                };
                this._Source.SetResult(result);
            }
            catch (Exception ex)
            {
                Debug.Print(nameof(ExecuteScriptCompletedDelegate) + " Exception:" + ex.ToString());

            }


            
        }
    }
}