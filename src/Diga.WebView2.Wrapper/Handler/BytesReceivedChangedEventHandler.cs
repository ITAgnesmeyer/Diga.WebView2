using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.EventArguments;
using System;
using System.Runtime.InteropServices;

namespace Diga.WebView2.Wrapper.Handler
{
    public class BytesReceivedChangedEventHandler : ICoreWebView2BytesReceivedChangedEventHandler
    {
        public event EventHandler<WebView2EventArgs> BytesReceivedChanged;

        public void Invoke([In, MarshalAs(UnmanagedType.Interface)] ICoreWebView2DownloadOperation sender, [In, MarshalAs(UnmanagedType.IUnknown)] object args)
        {
            OnBytesReceivedChanged(sender, args);
        }

        private void OnBytesReceivedChanged(ICoreWebView2DownloadOperation sender, object obj)
        {
            BytesReceivedChanged?.Invoke(sender, new WebView2EventArgs(sender, obj));
        }
    }
}