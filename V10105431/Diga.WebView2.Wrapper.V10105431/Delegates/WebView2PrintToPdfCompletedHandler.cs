using System;
using System.Diagnostics;
using System.Threading.Tasks;
using Diga.WebView2.Interop;

namespace Diga.WebView2.Wrapper.Delegates
{
    public class PrintToPdfCompletedDelegate:ICoreWebView2PrintToPdfCompletedHandler
    {
        private readonly TaskCompletionSource<(int, int)> _Source;

        public PrintToPdfCompletedDelegate(TaskCompletionSource<(int,int)> source)
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
                Debug.Print(nameof(PrintToPdfCompletedDelegate) + " Exception:" + ex.ToString());

            }

            
        }
    }
}