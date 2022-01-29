using System.Threading.Tasks;

namespace Diga.WebView2.WinForms.Scripting.DOM
{
    public class CSSStyleSheet : DOMObject
    {
        public CSSStyleSheet(WebView control, DOMVar domVar) : base(control, domVar)
        {
            
        }

        public Task<CSSRuleList> cssRules => GetTypedVarAsync<CSSRuleList>();
        public Task<CSSImportRule> ownerRule => GetTypedVarAsync<CSSImportRule>();

        public Task<int> insertRule(string ruleString, int index = 0) => ExecAsync<int>(new object[] { ruleString, index });

        public Task deleteRule(int index) => ExecAsync<object>(new object[] { index });


        public Task replaceSync(string ruleString) => ExecAsync<object>(new object[] { ruleString });


    }
}