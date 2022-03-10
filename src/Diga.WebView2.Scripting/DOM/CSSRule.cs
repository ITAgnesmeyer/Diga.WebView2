using System.Threading.Tasks;
using Diga.WebView2.Interop;

namespace Diga.WebView2.Scripting.DOM
{
    public class CSSRule : DOMObject
    {
        public CSSRule(IWebViewControl control, DOMVar domVar) : base(control, domVar)
        {
            
        }
        public string cssText => Get<string>();
        public Task<string> cssTextAsync => GetAsync<string>(nameof(this.cssText));

        public CSSRule parentRule => GetTypedVar<CSSRule>();
        public Task<CSSRule> parentRuleAsync => GetTypedVarAsync<CSSRule>(nameof(this.parentRule));

        
    }
}