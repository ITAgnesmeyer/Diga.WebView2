using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace Diga.WebView2.WinForms.Scripting.DOM
{
    public class DOMObjectCollection : DOMObject
    {
 

        public DOMObjectCollection(WebView control, DOMVar var):base(control,var)
        {
           
        }

        public DOMElement item(int index)
        {
            DOMVar var =ExecGetVar(new object[] { index });
            return new DOMElement(this._View2Control, var);

        }
        public async Task< DOMElement> itemAsync(int index)
        {
            DOMVar var =await ExecGetVarAsync(new object[] { index },nameof(item));
            return new DOMElement(this._View2Control, var);
        }

        public DOMElement this[string key] => namedItem(key);
        public DOMElement this[int index] => item(index);

        public int length => Get<int>();
        public Task<int> lengthAsync => GetAsync<int>(nameof(length));

        public DOMElement namedItem(string name)
        {
            DOMVar var = ExecGetVar(new object[] { name });
            return new DOMElement(this._View2Control, var);
        }

        public async Task< DOMElement> namedItemAsync(string name)
        {
            DOMVar var = await ExecGetVarAsync(new object[] { name },nameof(namedItem));

            return new DOMElement(this._View2Control, var);
        }

    }
}