using System.Threading.Tasks;
using Diga.WebView2.Interop;

namespace Diga.WebView2.Scripting.DOM
{
    public class CSSImportRule : CSSRule
    {
        public CSSImportRule(IWebViewControl control, DOMVar domVar) : base(control, domVar)
        {
            
        }
        public string href => Get<string>();
        public Task<string> hrefAsync => GetAsync<string>(nameof(this.href));

        public string media
        {
            get => Get<string>();
            set => Set(value);
        }

        public Task<string> mediaAsync
        {
            get => GetAsync<string>(nameof(this.media));
            set => _ = SetAsync(value,nameof(this.media));
        }


    }
}