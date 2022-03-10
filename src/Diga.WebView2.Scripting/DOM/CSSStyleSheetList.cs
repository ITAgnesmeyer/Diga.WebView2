using System.Threading.Tasks;
using Diga.WebView2.Interop;

namespace Diga.WebView2.Scripting.DOM
{
    public class CSSStyleSheetList : DOMObject
    {
        public CSSStyleSheetList(IWebViewControl control, DOMVar domVar) : base(control, domVar)
        {
            
        }

        public int length => Get<int>();
        public Task<int> lengthAsync => GetAsync<int>(nameof(this.length));

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