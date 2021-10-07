﻿using System;
using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.EventArguments;

namespace Diga.WebView2.Wrapper.Handler
{
    public class ClientCertificateRequestedEventHandler : ICoreWebView2ClientCertificateRequestedEventHandler
    {
        public event EventHandler<ClientCertificateRequestedEventArgs> CertificateRequested; 
        public void Invoke(ICoreWebView2 sender, ICoreWebView2ClientCertificateRequestedEventArgs args)
        {
            OnCertificateRequested(new ClientCertificateRequestedEventArgs(args));
        }

        protected virtual void OnCertificateRequested(ClientCertificateRequestedEventArgs e)
        {
            CertificateRequested?.Invoke(this, e);
        }
    }
}