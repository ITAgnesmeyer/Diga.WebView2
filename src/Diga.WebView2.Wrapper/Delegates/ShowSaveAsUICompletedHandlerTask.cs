using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.EventArguments;
using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace Diga.WebView2.Wrapper.Delegates
{
    public class ShowSaveAsUICompletedHandlerTask : ICoreWebView2ShowSaveAsUICompletedHandler
    {
        private readonly TaskCompletionSource<ShowSaveAsUICompletedEventArgs> _Source;

        public ShowSaveAsUICompletedHandlerTask(TaskCompletionSource<ShowSaveAsUICompletedEventArgs> source)
        {
            _Source = source;
        }

        public void Invoke([In, MarshalAs(UnmanagedType.Error)] int errorCode, [In] COREWEBVIEW2_SAVE_AS_UI_RESULT result)
        {
            try
            {
                this._Source.SetResult(new ShowSaveAsUICompletedEventArgs(errorCode,result));
            }
            catch (Exception ex)
            {

                Debug.Print(nameof(ShowSaveAsUICompletedHandlerTask) + " Exception:" + ex.ToString());
            }
        }
    }
}