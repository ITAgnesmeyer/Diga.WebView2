using System.Threading.Tasks;

namespace Diga.WebView2.WinForms.Scripting.DOM
{
    public class CSSImportRule : CSSRule
    {
        public CSSImportRule(WebView control, DOMVar domVar) : base(control, domVar)
        {
            
        }

        public Task<string> href => GetAsync<string>();

        public Task<string> media
        {
            get => GetAsync<string>();
            set => _ = SetAsync(value);
        }


    }
}