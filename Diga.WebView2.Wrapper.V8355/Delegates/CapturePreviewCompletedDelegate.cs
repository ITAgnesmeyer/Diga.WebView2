using System.Threading.Tasks;
using Diga.WebView2.Interop;

namespace Diga.WebView2.Wrapper.Delegates
{
    public class CapturePreviewCompletedDelegate : IWebView2CapturePreviewCompletedHandler
    {
        private readonly TaskCompletionSource<int> _Source;

        public CapturePreviewCompletedDelegate(TaskCompletionSource<int> source)
        {
            this._Source = source;
        }
        void IWebView2CapturePreviewCompletedHandler.Invoke(int result)
        {
            this._Source.SetResult(result);
        }
    }
}