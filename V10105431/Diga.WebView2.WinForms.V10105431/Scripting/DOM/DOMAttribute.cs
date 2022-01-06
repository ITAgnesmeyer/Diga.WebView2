using System.Threading.Tasks;

namespace Diga.WebView2.WinForms.Scripting.DOM
{
    public class DOMAttribute : DOMObject
    {

        public DOMAttribute(WebView control,DOMVar var):base(control)
        {
            this._Var = var;
            this._InstanceName = var.Name;
        }

        public DOMAttribute getNamedItem(string itemName)
        {
            DOMVar var = ExecGetVar(new object[] { itemName });
            return new DOMAttribute(this._View2Control, var);
        }

        public Task<bool> isId => GetAsync<bool>();

        public DOMAttribute item(int index)
        {
            DOMVar var = ExecGetVar(new object[] { index });
            return new DOMAttribute(this._View2Control, var);
        }

        public Task<int> length => GetAsync<int>();

        public Task<string> name => GetAsync<string>();

        public DOMAttribute removeNamedItem(string nodeName)
        {
            DOMVar var = ExecGetVar(new object[] { nodeName });
            return new DOMAttribute(this._View2Control, var);
        }

        public DOMAttribute setNamedItem(DOMAttribute attribute)
        {
            DOMVar var = ExecGetVar(new object[] { attribute });
            return new DOMAttribute(this._View2Control, var);
        }

        public Task<bool> specified => GetAsync<bool>();

        public Task<string> GetValue => GetAsync<string>("value");

        public void SetValue(string value)
        {
            Exec(new object[]{value},"value");
        }


    }
}