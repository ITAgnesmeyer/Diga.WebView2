using Diga.WebView2.Interop;

namespace Diga.WebView2.Wrapper.EventArguments
{
    public class ClientCertificateRequestedEventArgs : ICoreWebView2ClientCertificateRequestedEventArgs
    {
        private ICoreWebView2ClientCertificateRequestedEventArgs _Iface;

        public ClientCertificateRequestedEventArgs(ICoreWebView2ClientCertificateRequestedEventArgs iface )
        {
            this._Iface = iface;
        }
        public string Host
        {
            get => this._Iface.Host;
           
        }

        public int Port
        {
            get => this._Iface.Port;
            
        }

        public int IsProxy
        {
            get => this._Iface.IsProxy;
            
        }

        public ICoreWebView2StringCollection AllowedCertificateAuthorities
        {
            get => this._Iface.AllowedCertificateAuthorities;
            
        }

        public ICoreWebView2ClientCertificateCollection MutuallyTrustedCertificates
        {
            get => this._Iface.MutuallyTrustedCertificates;
            
        }

        public ICoreWebView2ClientCertificate SelectedCertificate
        {
            get => this._Iface.SelectedCertificate;
            set => this._Iface.SelectedCertificate = value;
        }

        public int Cancel
        {
            get => this._Iface.Cancel;
            set => this._Iface.Cancel = value;
        }

        public int Handled
        {
            get => this._Iface.Handled;
            set => this._Iface.Handled = value;
        }

        public ICoreWebView2Deferral GetDeferral()
        {
            return this._Iface.GetDeferral();
        }
    }
}