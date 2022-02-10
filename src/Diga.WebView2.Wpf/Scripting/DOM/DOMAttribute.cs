using System.Threading.Tasks;

namespace Diga.WebView2.Wpf.Scripting.DOM
{
    public class DOMAttribute : DOMObject
    {

        public DOMAttribute(WebView control,DOMVar var):base(control,var)
        {
            
        }
        public DOMAttribute getNamedItem(string itemName)
        {
            DOMVar var = ExecGetVar(new object[] { itemName });
            return new DOMAttribute(this._View2Control, var);
        }
        public async Task< DOMAttribute> getNamedItemAsync(string itemName)
        {
            DOMVar var = await ExecGetVarAsync(new object[] { itemName },nameof(getNamedItem));
            return new DOMAttribute(this._View2Control, var);
        }
        public bool isId => Get<bool>();
        public Task<bool> isIdAsync => GetAsync<bool>(nameof(isId));

        public DOMAttribute  item(int index)
        {
            DOMVar var = ExecGetVar(new object[] { index });
            return new DOMAttribute(this._View2Control, var);
        }

        public async Task< DOMAttribute>  itemAsync(int index)

        {
            DOMVar var = await ExecGetVarAsync(new object[] { index },nameof(item));
            return new DOMAttribute(this._View2Control, var);
        }

        public int length => Get<int>();
        public Task<int> lengthAsync => GetAsync<int>(nameof(length));

        public string name => Get<string>();
        public Task<string> nameAsync => GetAsync<string>(nameof(name));

        public DOMAttribute removeNamedItem(string nodeName)
        {
            DOMVar var = ExecGetVar( new object[] { nodeName });
            return new DOMAttribute(this._View2Control, var);
        }
        public async Task<DOMAttribute> removeNamedItemAsync(string nodeName)
        {
            DOMVar var = await ExecGetVarAsync( new object[] { nodeName },nameof(removeNamedItem));
            return new DOMAttribute(this._View2Control, var);
        }
        public DOMAttribute setNamedItem(DOMAttribute attribute)
        {
            DOMVar var = ExecGetVar(new object[] { attribute });
            return new DOMAttribute(this._View2Control, var);
        }

        public async Task<DOMAttribute> setNamedItemAsync(DOMAttribute attribute)
        {
            DOMVar var = await ExecGetVarAsync(new object[] { attribute },nameof(setNamedItem));
            return new DOMAttribute(this._View2Control, var);
        }
        public bool specified => Get<bool>();
        public Task<bool> specifiedAsync => GetAsync<bool>(nameof(specified));

        public string value
        {
            get => Get<string>();
            set => Set(value);
        }

        public Task<string> valueAsync
        {
            get => GetAsync<string>(nameof(value));
            set => _ = SetAsync(value,nameof(this.value));
        }



    }
}