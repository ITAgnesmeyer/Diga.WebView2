using System;
using System.Diagnostics;
using System.Threading.Tasks;
using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.Types;

namespace Diga.WebView2.Wrapper.Delegates
{
    public class PrintToPdfCompleteEventArgs : EventArgs
    {
        public bool IsSuccessfunl { get;  }
        public int ErrorCode { get; }

        public PrintToPdfCompleteEventArgs(bool isSuccessfunl, int errorCode)
        {
            this.IsSuccessfunl = isSuccessfunl;
            this.ErrorCode = errorCode;
        }
    }
    public class PrintToPdfCompletedDelegate : ICoreWebView2PrintToPdfCompletedHandler
    {
        public event EventHandler<PrintToPdfCompleteEventArgs> PrintToPdfCompleted; 

        public void Invoke(int errorCode, int isSuccessful)
        {
            OnPrintToPdfCompleted(new PrintToPdfCompleteEventArgs(new CBOOL(isSuccessful), errorCode));
        }

        protected virtual void OnPrintToPdfCompleted(PrintToPdfCompleteEventArgs e)
        {
            PrintToPdfCompleted?.Invoke(this, e);
        }
    }
    public class PrintToPdfCompletedDelegateTask:ICoreWebView2PrintToPdfCompletedHandler
    {
        private readonly TaskCompletionSource<(int, int)> _Source;

        public PrintToPdfCompletedDelegateTask(TaskCompletionSource<(int,int)> source)
        {
            this._Source = source;
        }
        void ICoreWebView2PrintToPdfCompletedHandler.Invoke(int errorCode, int isSuccessful)
        {
            try
            {
                this._Source.SetResult((errorCode, isSuccessful));
            }
            catch (Exception ex)
            {
                Debug.Print(nameof(PrintToPdfCompletedDelegateTask) + " Exception:" + ex.ToString());

            }

            
        }
    }
}