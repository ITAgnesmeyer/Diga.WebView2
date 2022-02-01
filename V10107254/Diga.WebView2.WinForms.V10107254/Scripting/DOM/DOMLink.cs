using System.Threading.Tasks;

namespace Diga.WebView2.WinForms.Scripting.DOM
{
    public class DOMLink : DOMElement
    {
        public DOMLink(WebView control, DOMVar domVar):base(control, domVar)
        {
            
        }
        
        public Task<bool> disabled
        {
            get => GetAsync<bool>(nameof(disabled));
            set=> _ = SetAsync(value,nameof(disabled));
        }

        public Task<string> href
        {
            get => GetAsync<string>(nameof(href));
            set=> _ = SetAsync(value,nameof(href));
        }

        public string hreflang
        {
            get => Get<string>();
            set => Set(value);
        }
        public Task<string> hreflangAsync
        {
            get => GetAsync<string>(nameof(hreflang));
            set=> _ = SetAsync(value,nameof(hreflang));
        }

        public string media
        {
            get => Get<string>();
            set => Set(value);
        }
        public Task<string> mediaAsync
        {
            get => GetAsync<string>(nameof(media));
            set => _= SetAsync(value,nameof(media));
        }

        public string rel
        {
            get => Get<string>();
            set => Set(value);
        }
        public Task<string> relAsync
        {
            get => GetAsync<string>(nameof(rel));
            set=> _ = SetAsync(value,nameof(rel));
        }

        public string type
        {
            get => Get<string>();
            set => Set(value);
        }
        public Task<string> typeAsync
        {
            get => GetAsync<string>(nameof(type));
            set => _ = SetAsync(value,nameof(type));
        }

        public string integrity
        {
            get=> Get<string>();
            set => Set(value);
        }
        public Task<string> integrityAsync
        {
            get => GetAsync<string>(nameof(integrity));
            set=> _ = SetAsync(value,nameof(integrity));
        }

        public string crossOrigin
        {
            get => Get<string>();
            set => Set(value);
        }
        public Task<string> crossOriginAsync
        {
            get => GetAsync<string>(nameof(crossOrigin));
            set=> _ = SetAsync(value,nameof(crossOrigin));
        }

        public string sizes
        {
            get => Get<string>();
            set => Set(value);
        }

        public Task<string> sizesAsync
        {
            get => GetAsync<string>(nameof(sizes));
            set => _ = SetAsync(value, nameof(sizes));
        }
    }
}