﻿using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.Implementation;

namespace Diga.WebView2.Wrapper
{
    public class WebView2Profile : WebView2Profile8Interface
    {
        public WebView2Profile(ICoreWebView2Profile8 profile):base(profile)
        {
            
        }
    }
}