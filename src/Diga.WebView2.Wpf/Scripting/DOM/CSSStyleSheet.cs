using System.Threading.Tasks;

namespace Diga.WebView2.Wpf.Scripting.DOM
{
    public class CSSStyleSheet : DOMObject
    {
        public CSSStyleSheet(WebView control, DOMVar domVar) : base(control, domVar)
        {
            
        }
        public CSSRuleList cssRules => GetTypedVar<CSSRuleList>();
        public Task<CSSRuleList> cssRulesAsync => GetTypedVarAsync<CSSRuleList>(nameof(cssRules));

        public CSSImportRule ownerRule=>GetTypedVar<CSSImportRule>();
        public Task<CSSImportRule> ownerRuleAsync => GetTypedVarAsync<CSSImportRule>(nameof(ownerRule));

        public int insertRule(string ruleString, int index = 0) => Exec<int>(new object[] { ruleString, index });
        public Task<int> insertRuleAsync(string ruleString, int index = 0) => ExecAsync<int>(new object[] { ruleString, index },nameof(insertRule));

        public void deleteRule(int index) => Exec(new object[] { index });
        public Task deleteRuleAsync(int index) => ExecAsync(new object[] { index },nameof(deleteRule));

        public void replaceSync(string ruleString) => Exec(new object[] { ruleString });
        public Task replaceSyncAsync(string ruleString) => ExecAsync(new object[] { ruleString },nameof(replaceSync));


    }
}