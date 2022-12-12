using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.EventArguments;
using System;
using System.Runtime.InteropServices;

namespace Diga.WebView2.Wrapper.Handler
{
    public class EstimatedEndTimeChangedEventHandler : ICoreWebView2EstimatedEndTimeChangedEventHandler
    {
        public event EventHandler<WebView2EventArgs> EstimatedEndTimeChanged;
        public void Invoke([In, MarshalAs(UnmanagedType.Interface)] ICoreWebView2DownloadOperation sender, [In, MarshalAs(UnmanagedType.IUnknown)] object args)
        {
            OnEstimatedEndTimeChanged(sender, args);
        }
        private void OnEstimatedEndTimeChanged(ICoreWebView2DownloadOperation sender, object obj)
        {
            EstimatedEndTimeChanged?.Invoke(sender, new WebView2EventArgs(sender, obj));
        }
    }
}