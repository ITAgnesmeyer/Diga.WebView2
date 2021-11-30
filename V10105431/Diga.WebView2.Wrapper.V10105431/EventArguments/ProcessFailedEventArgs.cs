using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.Implementation;
using Microsoft.Win32.SafeHandles;

namespace Diga.WebView2.Wrapper.EventArguments
{

    public class ProcessFailedEventArgs : ProcessFailedEventArgs2Interface
    {

        public ProcessFailedEventArgs(ICoreWebView2ProcessFailedEventArgs2 args):base(args)
        {
            
        }

        public new ProcessFailedKind ProcessFailedKind => (ProcessFailedKind)base.ProcessFailedKind;

        

    }
}