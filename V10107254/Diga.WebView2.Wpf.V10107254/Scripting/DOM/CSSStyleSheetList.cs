using System.Threading.Tasks;

namespace Diga.WebView2.Wpf.Scripting.DOM
{
    public class CSSStyleSheetList : DOMObject
    {
        public CSSStyleSheetList(WebView control, DOMVar domVar) : base(control, domVar)
        {
            
        }

        public int length => Get<int>();
        public Task<int> lengthAsync => GetAsync<int>(nameof(length));

        public CSSStyleSheet item(int index)
        {
            DOMVar var = ExecGetVar(new object[] { index });
            return new CSSStyleSheet(this._View2Control, var);
        }

        public async Task<CSSStyleSheet> itemAsync(int index)
        {
            DOMVar var = await ExecGetVarAsync(new object[] { index },nameof(item));
            return new CSSStyleSheet(this._View2Control, var);
        }
    }
}