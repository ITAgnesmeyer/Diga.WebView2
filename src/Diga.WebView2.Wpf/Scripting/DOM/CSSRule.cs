using System.Threading.Tasks;

namespace Diga.WebView2.Wpf.Scripting.DOM
{
    public class CSSRule : DOMObject
    {
        public CSSRule(WebView control, DOMVar domVar) : base(control, domVar)
        {
            
        }
        public string cssText => Get<string>();
        public Task<string> cssTextAsync => GetAsync<string>(nameof(cssText));

        public CSSRule parentRule => GetTypedVar<CSSRule>();
        public Task<CSSRule> parentRuleAsync => GetTypedVarAsync<CSSRule>(nameof(parentRule));

        
    }
}