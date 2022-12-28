using System;
using System.Diagnostics;
using System.Runtime.InteropServices.ComTypes;
using System.Threading.Tasks;
using Diga.WebView2.Interop;

namespace Diga.WebView2.Wrapper.Delegates
{
    public class GetFaviconCompleteResult
    {
        public IStream Stream { get; }
        public int ErrorCode { get; }

        public GetFaviconCompleteResult(int errorCode, IStream stream)
        {
            this.Stream = stream;
            this.ErrorCode = errorCode;
        }
    }
    public class GetFaviconCompletedHandler : ICoreWebView2GetFaviconCompletedHandler
    {
        private readonly TaskCompletionSource<GetFaviconCompleteResult> _Source;

        public GetFaviconCompletedHandler(TaskCompletionSource<GetFaviconCompleteResult> source)
        {
            this._Source = source;
        }
        public void Invoke(int errorCode, IStream faviconStream)
        {
            try
            {
                GetFaviconCompleteResult result = new GetFaviconCompleteResult(errorCode, faviconStream);
                this._Source.SetResult(result);
            }
            catch (Exception ex)
            {
                Debug.Print(nameof(GetFaviconCompletedHandler) + " Exception:" + ex.ToString());
            }
            

        }
    }
    public class CapturePreviewCompletedDelegate : ICoreWebView2CapturePreviewCompletedHandler
    {
        private readonly TaskCompletionSource<int> _Source;

        public CapturePreviewCompletedDelegate(TaskCompletionSource<int> source)
        {
            this._Source = source;
        }
        void ICoreWebView2CapturePreviewCompletedHandler.Invoke(int result)
        {
            try
            {
                this._Source.SetResult(result);
            }
            catch (Exception ex)
            {
                Debug.Print(nameof(CapturePreviewCompletedDelegate) + " Exception:" + ex.ToString());

            }

            
        }
    }
}