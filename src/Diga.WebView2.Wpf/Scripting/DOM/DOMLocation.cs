using System.Threading.Tasks;

namespace Diga.WebView2.Wpf.Scripting.DOM
{
    public class DOMLocation : DOMObject
    {
        public DOMLocation(WebView control):base(control)
        {
            this._InstanceName = "location";
        }
        public DOMLocation(WebView control, DOMVar domVar) : base(control,domVar)
        {
            
        }

        public string hash
        {
            get => Get<string>();
            set => Set(value);
        }
        public Task<string> hashAsync
        {
            get=>GetAsync<string>(nameof(hash));
            set=>_=SetAsync(value,nameof(hash));
        }

        public string host
        {
            get => Get<string>();
            set => Set(value);
        }
        public Task<string> hostAsync
        {
            get=>GetAsync<string>(nameof(host));
            set=>_=SetAsync(value,nameof(host));
        }
        public string hostname
        {
            get => Get<string>();
            set => Set(value);
        }

        public Task<string> hostnameAsync
        {
            get=>GetAsync<string>(nameof(hostname));
            set=>_=SetAsync(value,nameof(hostname));
        }
        public string href
        {
            get => Get<string>();
            set => Set(value);
        }

        public Task<string> hrefAsync
        {
            get=>GetAsync<string>(nameof(href));
            set=>_=SetAsync(value,nameof(href));
        }

        public string origin => Get<string>();
        public Task<string> originAsync => GetAsync<string>(nameof(origin));

        public string pathname
        {
            get => Get<string>();
            set => Set(value);
        }

        public Task<string> pathnameAsync
        {
            get=>GetAsync<string>(nameof(pathname));
            set=>_=SetAsync(value,nameof(pathname));
        }

        public string port
        {
            get => Get<string>();
            set => Set(value);
        }

        public Task<string> portAsync
        {
            get=>GetAsync<string>(nameof(port));
            set=>_=SetAsync(value,nameof(port));
        }
        public string protocol
        {
            get => Get<string>();
            set => Set(value);
        }

        public Task<string> protocolAsync
        {
            get=>GetAsync<string>(nameof(protocol));
            set=>_=SetAsync(value,nameof(protocol));

        }

        public string search
        {
            get => Get<string>();
            set => Set(value);
        }

        public Task<string> searchAsync
        {
            get=>GetAsync<string>(nameof(search));
            set=>_=SetAsync(value,nameof(search));
        }

    }
}