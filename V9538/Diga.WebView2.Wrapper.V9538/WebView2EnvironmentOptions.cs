﻿using Diga.WebView2.Interop;

namespace Diga.WebView2.Wrapper
{
    public class WebView2EnvironmentOptions : ICoreWebView2EnvironmentOptions
    {
        public WebView2EnvironmentOptions()
        {
            this.TargetCompatibleBrowserVersion = "85.0.538.0";
        }
        public string AdditionalBrowserArguments { get; set; }
        public string Language { get; set; }
        public string TargetCompatibleBrowserVersion { get; set; }
    }
}