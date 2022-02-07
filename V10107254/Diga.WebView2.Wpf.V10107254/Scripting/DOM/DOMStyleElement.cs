using System.Threading.Tasks;

namespace Diga.WebView2.Wpf.Scripting.DOM
{
    public class DOMStyleElement : DOMElement
    {
        public DOMStyleElement(WebView control, DOMVar domVar) : base(control, domVar)
        {
            
        }

        public string medium
        {
            get => Get<string>();
            set => Set(value);
        }
        public Task<string> mediumAsync
        {
            get => GetAsync<string>(nameof(medium));
            set => _ = SetAsync(value,nameof(medium));
        }

        public bool disabled
        {
            get => Get<bool>();
            set => Set(value);
        }
        public Task<bool> disabledAsync
        {
            get => GetAsync<bool>(nameof(disabled));
            set => _ = SetAsync(value,nameof(disabled));
        }

      

       
        public CSSStyleSheet sheet => GetTypedVar<CSSStyleSheet>();
        public Task<CSSStyleSheet> sheetAsync => GetTypedVarAsync<CSSStyleSheet>(nameof(sheet));

    }
}