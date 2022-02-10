using System.Threading.Tasks;

namespace Diga.WebView2.WinForms.Scripting.DOM
{
    public class CSSStyleSheet : DOMObject
    {
        public CSSStyleSheet(WebView control, DOMVar domVar) : base(control, domVar)
        {
            
        }

        public Task<CSSRuleList> cssRules => GetTypedVar<CSSRuleList>();
        public Task<CSSImportRule> ownerRule => GetTypedVar<CSSImportRule>();

        public Task<int> insertRule(string ruleString, int index = 0) => Exec<int>(new object[] { ruleString, index });

        public Task deleteRule(int index) => Exec<object>(new object[] { index });


        public Task replaceSync(string ruleString) => Exec<object>(new object[] { ruleString });


    }
}