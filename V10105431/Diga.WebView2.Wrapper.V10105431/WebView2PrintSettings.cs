using System;
using System.Runtime.InteropServices;
using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.Implementation;
using Microsoft.Win32.SafeHandles;

namespace Diga.WebView2.Wrapper
{

    public class WebView2PrintSettings : WebView2PrintSettingsInterface
    {
       
        public WebView2PrintSettings(ICoreWebView2PrintSettings printSettings):base(printSettings)
        {

        }
    }
}