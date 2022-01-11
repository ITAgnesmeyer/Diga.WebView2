﻿using System;
using System.Diagnostics;
using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.EventArguments;

namespace Diga.WebView2.Wrapper.Handler
{
    public class WebResourceResponseReceivedEventHandler : ICoreWebView2WebResourceResponseReceivedEventHandler
    {
        public event EventHandler<WebResourceResponseReceivedEventArgs> WebResourceResponseReceived;
        public void Invoke(ICoreWebView2 sender, ICoreWebView2WebResourceResponseReceivedEventArgs args)
        {
            try
            {
                OnWebResourceResponseReceived(new WebResourceResponseReceivedEventArgs(args));
            }
            catch (Exception ex)
            {
                Debug.Print(nameof(WebResourceResponseReceivedEventHandler) + " Exception:" + ex.ToString());

            }


        }

        protected virtual void OnWebResourceResponseReceived(WebResourceResponseReceivedEventArgs e)
        {
            WebResourceResponseReceived?.Invoke(this, e);
        }
    }
}