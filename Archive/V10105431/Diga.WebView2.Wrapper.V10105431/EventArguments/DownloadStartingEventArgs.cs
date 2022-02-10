using Diga.WebView2.Interop;
using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Diga.WebView2.Wrapper.Implementation;

namespace Diga.WebView2.Wrapper.EventArguments
{

    public class DownloadStartingEventArgs:DownloadStartingEventArgsInterface
    {
        public DownloadStartingEventArgs(ICoreWebView2DownloadStartingEventArgs args):base(args)
        {

        }

        new public WebView2DownloadOperation DownloadOperation => new WebView2DownloadOperation(base.DownloadOperation);
    }
}