using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Diga.WebView2.Interop;

namespace Diga.WebView2.Wrapper.Handler
{
    public class ExecuteScriptWithResultCompletedDelegate: ICoreWebView2ExecuteScriptWithResultCompletedHandler
    {
        private TaskCompletionSource<WebView2ExecuteScriptResult> _source;
        public ExecuteScriptWithResultCompletedDelegate(TaskCompletionSource<WebView2ExecuteScriptResult> source)
        {
            this._source = source;
        }
        public void Invoke([In, MarshalAs(UnmanagedType.Error)] int errorCode, [In, MarshalAs(UnmanagedType.Interface)] ICoreWebView2ExecuteScriptResult result)
        {
            try
            {
                var r = new WebView2ExecuteScriptResult(result);
                _source.SetResult(r);

            }
            catch (Exception ex)
            {
                    
                Debug.Print("ExecuteScriptWithResultCompletedDelegate error:" + ex.ToString());
            }
        }


    }
}