using System.Threading.Tasks;

namespace Diga.WebView2.WinForms.Scripting.DOM
{
    public class DOMAttribute : DOMObject
    {

        public DOMAttribute(WebView control,DOMVar var):base(control,var)
        {
            
        }

        public async Task< DOMAttribute> getNamedItem(string itemName)
        {
            DOMVar var = await ExecGetVarAsync(new object[] { itemName });
            return new DOMAttribute(this._View2Control, var);
        }

        public Task<bool> isId => GetAsync<bool>();

        public async Task< DOMAttribute>  item(int index)
        {
            DOMVar var = await ExecGetVarAsync(new object[] { index });
            return new DOMAttribute(this._View2Control, var);
        }

        public Task<int> length => GetAsync<int>();

        public Task<string> name => GetAsync<string>();

        public async Task<DOMAttribute> removeNamedItem(string nodeName)
        {
            DOMVar var = await ExecGetVarAsync( new object[] { nodeName });
            return new DOMAttribute(this._View2Control, var);
        }

        public async Task<DOMAttribute> setNamedItem(DOMAttribute attribute)
        {
            DOMVar var = await ExecGetVarAsync(new object[] { attribute });
            return new DOMAttribute(this._View2Control, var);
        }

        public Task<bool> specified => GetAsync<bool>();

        public Task<string> value
        {
            get => GetAsync<string>();
            set => _ = SetAsync(value);
        }



    }
}