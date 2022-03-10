using System.Threading.Tasks;
using Diga.WebView2.Interop;

namespace Diga.WebView2.Scripting.DOM
{
    public class DOMStyleElement : DOMElement
    {
        public DOMStyleElement(IWebViewControl control, DOMVar domVar) : base(control, domVar)
        {
            
        }

        public string medium
        {
            get => Get<string>();
            set => Set(value);
        }
        public Task<string> mediumAsync
        {
            get => GetAsync<string>(nameof(this.medium));
            set => _ = SetAsync(value,nameof(this.medium));
        }

        public bool disabled
        {
            get => Get<bool>();
            set => Set(value);
        }
        public Task<bool> disabledAsync
        {
            get => GetAsync<bool>(nameof(this.disabled));
            set => _ = SetAsync(value,nameof(this.disabled));
        }

      

       
        public CSSStyleSheet sheet => GetTypedVar<CSSStyleSheet>();
        public Task<CSSStyleSheet> sheetAsync => GetTypedVarAsync<CSSStyleSheet>(nameof(this.sheet));

    }
}