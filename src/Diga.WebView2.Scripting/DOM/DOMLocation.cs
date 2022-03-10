using System.Threading.Tasks;
using Diga.WebView2.Interop;

namespace Diga.WebView2.Scripting.DOM
{
    public class DOMLocation : DOMObject
    {
        public DOMLocation(IWebViewControl control):base(control)
        {
            this._InstanceName = "location";
        }
        public DOMLocation(IWebViewControl control, DOMVar domVar) : base(control,domVar)
        {
            
        }

        public string hash
        {
            get => Get<string>();
            set => Set(value);
        }
        public Task<string> hashAsync
        {
            get=>GetAsync<string>(nameof(this.hash));
            set=>_=SetAsync(value,nameof(this.hash));
        }

        public string host
        {
            get => Get<string>();
            set => Set(value);
        }
        public Task<string> hostAsync
        {
            get=>GetAsync<string>(nameof(this.host));
            set=>_=SetAsync(value,nameof(this.host));
        }
        public string hostname
        {
            get => Get<string>();
            set => Set(value);
        }

        public Task<string> hostnameAsync
        {
            get=>GetAsync<string>(nameof(this.hostname));
            set=>_=SetAsync(value,nameof(this.hostname));
        }
        public string href
        {
            get => Get<string>();
            set => Set(value);
        }

        public Task<string> hrefAsync
        {
            get=>GetAsync<string>(nameof(this.href));
            set=>_=SetAsync(value,nameof(this.href));
        }

        public string origin => Get<string>();
        public Task<string> originAsync => GetAsync<string>(nameof(this.origin));

        public string pathname
        {
            get => Get<string>();
            set => Set(value);
        }

        public Task<string> pathnameAsync
        {
            get=>GetAsync<string>(nameof(this.pathname));
            set=>_=SetAsync(value,nameof(this.pathname));
        }

        public string port
        {
            get => Get<string>();
            set => Set(value);
        }

        public Task<string> portAsync
        {
            get=>GetAsync<string>(nameof(this.port));
            set=>_=SetAsync(value,nameof(this.port));
        }
        public string protocol
        {
            get => Get<string>();
            set => Set(value);
        }

        public Task<string> protocolAsync
        {
            get=>GetAsync<string>(nameof(this.protocol));
            set=>_=SetAsync(value,nameof(this.protocol));

        }

        public string search
        {
            get => Get<string>();
            set => Set(value);
        }

        public Task<string> searchAsync
        {
            get=>GetAsync<string>(nameof(this.search));
            set=>_=SetAsync(value,nameof(this.search));
        }

    }
}