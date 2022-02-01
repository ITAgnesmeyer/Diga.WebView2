using System.Threading.Tasks;

namespace Diga.WebView2.WinForms.Scripting.DOM
{
    public class DOMScript : DOMElement
    {
        public DOMScript(WebView control, DOMVar domVar) : base(control, domVar)
        {

        }

        public bool async
        {
            get => Get<bool>();
            set => Set(value);
        }

        public Task<bool> asyncAsync
        {
            get => GetAsync<bool>(nameof(async));
            set => _ = SetAsync(value,nameof(async));
        }

        public Task<string> charset
        {
            get => GetAsync<string>(nameof(charset));
            set => _ = SetAsync(value,nameof(charset));
        }

        public string crossOrigin
        {
            get => Get<string>();
            set => Set(value);
        }

        public Task<string> crossOriginAsync
        {
            get => GetAsync<string>(nameof(crossOrigin));
            set => _ = SetAsync(value,nameof(crossOrigin));
        }

        public bool defer
        {
            get => Get<bool>();
            set => Set(value);
        }
        public Task<bool> deferAsync
        {
            get => GetAsync<bool>(nameof(defer));
            set => _ = SetAsync(value,nameof(defer));
        }

        public string src
        {
            get => Get<string>();
            set => Set(value);
        }
        public Task<string> srcAsync
        {
            get => GetAsync<string>(nameof(src));
            set => _ = SetAsync(value,nameof(src));
        }
        public string text
        {
            get => Get<string>();
            set => Set(value);
        }
        public Task<string> textAsync
        {
            get => GetAsync<string>(nameof(text));
            set => _ = SetAsync(value,nameof(text));
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
    }
}