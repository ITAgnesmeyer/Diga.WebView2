using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.Implementation;
using Diga.WebView2.Wrapper.Types;
using Microsoft.Win32.SafeHandles;
using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace Diga.WebView2.Wrapper.EventArguments
{




    public class DOMContentLoadedEventArgs : DOMContentLoadedEventArgsInterface
    {
        

        public DOMContentLoadedEventArgs(ICoreWebView2DOMContentLoadedEventArgs args):base(args)
        {
        }

       
    }
}