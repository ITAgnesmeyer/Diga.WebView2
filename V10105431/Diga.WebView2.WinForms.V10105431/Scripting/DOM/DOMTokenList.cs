using System.Threading.Tasks;

namespace Diga.WebView2.WinForms.Scripting.DOM
{
    public class DOMTokenList : DOMObject
    {
   

        public DOMTokenList(WebView control, DOMVar var):base(control)
        {
            this._Var = var;
            this._InstanceName = var.Name;
        }

        public Task<int> length => GetAsync<int>();

        public Task<object> value => GetAsync<object>();

        public void add(params object[] objParams)
        {
            
            Exec(objParams);
        }

        public Task<bool> contains(string key)
        {
            return Exec<bool>(new object[] { key });
        }

        public Task<object> item(int index)
        {
            return Exec<object>(new object[] { index });
        }

        public void remove(params object[] parObjects)
        {
            Exec(parObjects);
        }

        public Task<bool> toggle(object obj, bool add)
        {
            return Exec<bool>(new object[] { obj, add });
        }

    }
}