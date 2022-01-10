using System.Threading.Tasks;

namespace Diga.WebView2.WinForms.Scripting.DOM
{
    public class CSSStyleSheetList : DOMObject
    {
        public CSSStyleSheetList(WebView control, DOMVar domVar) : base(control, domVar)
        {
            
        }

        public Task<int> length => GetAsync<int>();

        public async Task<CSSStyleSheet> item(int index)
        {
            DOMVar var = await ExecGetVarAsync(new object[] { index });
            return new CSSStyleSheet(this._View2Control, var);
        }
    }
}