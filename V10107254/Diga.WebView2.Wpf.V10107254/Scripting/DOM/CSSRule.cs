using System.Threading.Tasks;

namespace Diga.WebView2.Wpf.Scripting.DOM
{
    public class CSSRule : DOMObject
    {
        public CSSRule(WebView control, DOMVar domVar) : base(control, domVar)
        {
            
        }

        public Task<string> cssText => GetAsync<string>();
        public Task<CSSRule> parentRule => GetTypedVar<CSSRule>();

        
    }
}