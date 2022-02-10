using System.Threading.Tasks;

namespace Diga.WebView2.WinForms.Scripting.DOM
{
    public class CSSRuleList : DOMObject
    {
        public CSSRuleList(WebView control, DOMVar domVar) : base(control, domVar)
        {
            
        }

        public Task<int> length => GetAsync<int>();

        public async Task<CSSRule> item(int index)
        {
            DOMVar var = await ExecGetVarAsync(new object[] { index });
            return new CSSRule(this._View2Control, var);
        }
    }
}