using System.Threading.Tasks;
using Diga.WebView2.Interop;

namespace Diga.WebView2.Scripting.DOM
{
    public class DOMScript : DOMElement
    {
        public DOMScript(IWebViewControl control, DOMVar domVar) : base(control, domVar)
        {

        }

        public bool async
        {
            get => Get<bool>();
            set => Set(value);
        }

        public Task<bool> asyncAsync
        {
            get => GetAsync<bool>(nameof(this.async));
            set => _ = SetAsync(value,nameof(this.async));
        }

        public Task<string> charset
        {
            get => GetAsync<string>(nameof(this.charset));
            set => _ = SetAsync(value,nameof(this.charset));
        }

        public string crossOrigin
        {
            get => Get<string>();
            set => Set(value);
        }

        public Task<string> crossOriginAsync
        {
            get => GetAsync<string>(nameof(this.crossOrigin));
            set => _ = SetAsync(value,nameof(this.crossOrigin));
        }

        public bool defer
        {
            get => Get<bool>();
            set => Set(value);
        }
        public Task<bool> deferAsync
        {
            get => GetAsync<bool>(nameof(this.defer));
            set => _ = SetAsync(value,nameof(this.defer));
        }

        public string src
        {
            get => Get<string>();
            set => Set(value);
        }
        public Task<string> srcAsync
        {
            get => GetAsync<string>(nameof(this.src));
            set => _ = SetAsync(value,nameof(this.src));
        }
        public string text
        {
            get => Get<string>();
            set => Set(value);
        }
        public Task<string> textAsync
        {
            get => GetAsync<string>(nameof(this.text));
            set => _ = SetAsync(value,nameof(this.text));
        }

        public string type
        {
            get => Get<string>();
            set => Set(value);
        }
        public Task<string> typeAsync
        {
            get => GetAsync<string>(nameof(this.type));
            set => _ = SetAsync(value,nameof(this.type));

        }
    }
}