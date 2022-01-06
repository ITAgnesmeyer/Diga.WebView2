using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace Diga.WebView2.WinForms.Scripting.DOM
{
    public class DOMObjectCollection : DOMObject
    {
 

        public DOMObjectCollection(WebView control, DOMVar var):base(control)
        {
            this._Var = var;
            this._InstanceName = var.Name;
        }

        public async Task< DOMElement> item(int index)
        {
            DOMVar var =await ExecGetVarAsync(new object[] { index });
            return new DOMElement(this._View2Control, var);
        }
        public Task<DOMElement> this[int index] => item(index);

        public Task<int> length => GetAsync<int>();

        public async Task< DOMElement> namedItem(string name)
        {
            DOMVar var = await ExecGetVarAsync(new object[] { name });

            return new DOMElement(this._View2Control, var);
        }

    }
}