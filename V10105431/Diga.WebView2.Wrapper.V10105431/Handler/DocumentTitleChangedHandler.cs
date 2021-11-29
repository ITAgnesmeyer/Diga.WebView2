﻿using System;
using System.Diagnostics;
using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.EventArguments;

namespace Diga.WebView2.Wrapper.Handler
{
    public class DocumentTitleChangedHandler : ICoreWebView2DocumentTitleChangedEventHandler
    {
        public event EventHandler<WebView2EventArgs> DocumentTitleChanged;


        protected virtual void OnDocumentTitleChanged(WebView2EventArgs e)
        {
            DocumentTitleChanged?.Invoke(this, e);
        }

        public void Invoke(ICoreWebView2 sender, object args)
        {
            try
            {
                OnDocumentTitleChanged(new WebView2EventArgs(sender, args));
            }
            catch (Exception ex)
            {
                Debug.Print(nameof(DocumentTitleChangedHandler) + " Exception:" + ex.ToString());

            }


        }
    }
}