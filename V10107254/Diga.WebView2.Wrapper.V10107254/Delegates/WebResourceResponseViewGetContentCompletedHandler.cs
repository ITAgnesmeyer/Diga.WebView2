using System;
using System.Diagnostics;
using System.Runtime.InteropServices.ComTypes;
using System.Threading.Tasks;
using Diga.WebView2.Interop;

namespace Diga.WebView2.Wrapper.Delegates
{
    public class WebResourceResponseViewGetContentCompletedHandler : ICoreWebView2WebResourceResponseViewGetContentCompletedHandler
    {
        private readonly TaskCompletionSource<(int, IStream)> _Source;
        

        public WebResourceResponseViewGetContentCompletedHandler(TaskCompletionSource<(int, IStream)> source)
        {
            this._Source = source;
        }
       
        
        public void Invoke(int errorCode, IStream Content)
        {
           
            try
            {
                this._Source.SetResult((errorCode, Content));
            }
            catch (Exception ex)
            {
                Debug.Print(nameof(WebResourceResponseViewGetContentCompletedHandler) + " Exception:" + ex.ToString());

            }
        }

      
    }
}