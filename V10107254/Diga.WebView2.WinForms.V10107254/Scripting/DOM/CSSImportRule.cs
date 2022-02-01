using System.Threading.Tasks;

namespace Diga.WebView2.WinForms.Scripting.DOM
{
    public class CSSImportRule : CSSRule
    {
        public CSSImportRule(WebView control, DOMVar domVar) : base(control, domVar)
        {
            
        }
        public string href => Get<string>();
        public Task<string> hrefAsync => GetAsync<string>(nameof(href));

        public string media
        {
            get => Get<string>();
            set => Set(value);
        }

        public Task<string> mediaAsync
        {
            get => GetAsync<string>(nameof(media));
            set => _ = SetAsync(value,nameof(media));
        }


    }
}