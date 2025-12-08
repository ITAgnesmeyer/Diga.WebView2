using System;
using System.Diagnostics;
using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.EventArguments;

namespace Diga.WebView2.Wrapper.Handler
{
    public class ServerCertificateErrorDetectedEventHandler : ICoreWebView2ServerCertificateErrorDetectedEventHandler
    {         
        public event EventHandler<ServerCertificateErrorDetectedEventArgs> ServerCertificateErrorDetected;
        private void OnServerCertificateErrorDetected(ServerCertificateErrorDetectedEventArgs e)
        {
            this.ServerCertificateErrorDetected?.Invoke(this, e);
        }
        public void Invoke(ICoreWebView2 sender, ICoreWebView2ServerCertificateErrorDetectedEventArgs args)
        {
            try
            {
                OnServerCertificateErrorDetected(new ServerCertificateErrorDetectedEventArgs(args));
            }
            catch (Exception ex)
            {
                Debug.Print(nameof(ServerCertificateErrorDetectedEventHandler) + " Exception:" + ex.ToString());
            }
            
        }
    }
}