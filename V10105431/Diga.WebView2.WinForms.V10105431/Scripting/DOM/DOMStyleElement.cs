using System.Threading.Tasks;

namespace Diga.WebView2.WinForms.Scripting.DOM
{
    public class DOMStyleElement : DOMElement
    {
        public DOMStyleElement(WebView control, DOMVar domVar) : base(control, domVar)
        {
            
        }

        public Task<string> medium
        {
            get => GetAsync<string>();
            set => _ = SetAsync(value);
        }

        public Task<bool> disabled
        {
            get => GetAsync<bool>();
            set => _ = SetAsync(value);
        }

      

       

        public Task<CSSStyleSheet> sheet => GetTypedVar<CSSStyleSheet>();

    }
}