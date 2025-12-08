using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.Implementation;

namespace Diga.WebView2.Wrapper.EventArguments
{
    public class ServerCertificateErrorDetectedEventArgs : ServerCertificateErrorDetectedEventArgsInterface
    {
        public ServerCertificateErrorDetectedEventArgs(ICoreWebView2ServerCertificateErrorDetectedEventArgs args) : base(args)
        {
        }

        public new WebView2Certificate ServerCertificate => new WebView2Certificate(base.ServerCertificate);
        public new WebView2Deferral GetDeferral()
        {
            return new WebView2Deferral(base.GetDeferral());
        }
    }
}