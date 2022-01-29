using System.Threading.Tasks;

namespace Diga.WebView2.WinForms.Scripting.DOM
{
    public class DOMTokenList : DOMObject
    {
   

        public DOMTokenList(WebView control, DOMVar var):base(control,var)
        {
           
        }

        public Task<int> length => GetAsync<int>();

        public Task<object> value => GetAsync<object>();

        public Task add(params object[] objParams)
        {
            
            return ExecAsync<object>(objParams);
        }

        public Task<bool> contains(string key)
        {
            return ExecAsync<bool>(new object[] { key });
        }

        public Task<object> item(int index)
        {
            return ExecAsync<object>(new object[] { index });
        }

        public Task remove(params object[] parObjects)
        {
            return ExecAsync<object>(parObjects);
        }

        public Task<bool> toggle(object obj, bool add)
        {
            return ExecAsync<bool>(new object[] { obj, add });
        }

    }
}