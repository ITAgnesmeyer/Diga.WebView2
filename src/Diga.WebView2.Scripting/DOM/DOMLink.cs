using System.Threading.Tasks;
using Diga.WebView2.Interop;

namespace Diga.WebView2.Scripting.DOM
{
    public class DOMLink : DOMElement
    {
        public DOMLink(IWebViewControl control, DOMVar domVar):base(control, domVar)
        {
            
        }

        public Task<bool> disabled
        {
            get => GetAsync<bool>(nameof(this.disabled));
            set=> _ = SetAsync(value,nameof(this.disabled));
        }

        public Task<string> href
        {
            get => GetAsync<string>(nameof(this.href));
            set=> _ = SetAsync(value,nameof(this.href));
        }

        public string hreflang
        {
            get => Get<string>();
            set => Set(value);
        }
        public Task<string> hreflangAsync
        {
            get => GetAsync<string>(nameof(this.hreflang));
            set=> _ = SetAsync(value,nameof(this.hreflang));
        }

        public string media
        {
            get => Get<string>();
            set => Set(value);
        }
        public Task<string> mediaAsync
        {
            get => GetAsync<string>(nameof(this.media));
            set => _= SetAsync(value,nameof(this.media));
        }

        public string rel
        {
            get => Get<string>();
            set => Set(value);
        }
        public Task<string> relAsync
        {
            get => GetAsync<string>(nameof(this.rel));
            set=> _ = SetAsync(value,nameof(this.rel));
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

        public string integrity
        {
            get=> Get<string>();
            set => Set(value);
        }
        public Task<string> integrityAsync
        {
            get => GetAsync<string>(nameof(this.integrity));
            set=> _ = SetAsync(value,nameof(this.integrity));
        }

        public string crossOrigin
        {
            get => Get<string>();
            set => Set(value);
        }
        public Task<string> crossOriginAsync
        {
            get => GetAsync<string>(nameof(this.crossOrigin));
            set=> _ = SetAsync(value,nameof(this.crossOrigin));
        }

        public string sizes
        {
            get => Get<string>();
            set => Set(value);
        }

        public Task<string> sizesAsync
        {
            get => GetAsync<string>(nameof(this.sizes));
            set => _ = SetAsync(value, nameof(this.sizes));
        }
    }
}