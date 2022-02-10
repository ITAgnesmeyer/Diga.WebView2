using System.Threading.Tasks;

namespace Diga.WebView2.WinForms.Scripting.DOM
{
    public class DOMTokenList : DOMObject
    {
   

        public DOMTokenList(WebView control, DOMVar var):base(control,var)
        {
           
        }

        public int length => Get<int>();
        public Task<int> lengthAsync => GetAsync<int>(nameof(length));

        public object value => Get<object>();
        public Task<object> valueAsync => GetAsync<object>(nameof(value));

        public void add(params object[] objParams)
        {
            
            Exec(objParams);
        }

        public Task addAsync(params object[] objParams)
        {
            
            return ExecAsync(objParams,nameof(add));
        }

        public bool contains(string key)
        {
            return Exec<bool>(new object[] { key });
        }
        public Task<bool> containsAsync(string key)
        {
            return ExecAsync<bool>(new object[] { key },nameof(contains));
        }

        public object item(int index)
        {
            return Exec<object>(new object[] { index });
        }

        public Task<object> itemAsync(int index)
        {
            return ExecAsync<object>(new object[] { index },nameof(item));
        }

        public  void remove(params object[] parObjects)
        {
            Exec(parObjects);
        }

        public Task removeAsync(params object[] parObjects)
        {
            return ExecAsync(parObjects,nameof(remove));
        }

        public bool toggle(object obj, bool add)
        {
            return Exec<bool>(new object[] { obj, add });
        }
        public Task<bool> toggleAsync(object obj, bool add)
        {
            return ExecAsync<bool>(new object[] { obj, add },nameof(toggle));
        }

    }
}