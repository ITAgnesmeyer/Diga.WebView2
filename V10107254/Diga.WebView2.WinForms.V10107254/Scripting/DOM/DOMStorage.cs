using System.Threading.Tasks;

namespace Diga.WebView2.WinForms.Scripting.DOM
{
    public class DOMStorage : DOMObject
    {
        public DOMStorage(WebView control, DOMVar domVar) : base(control, domVar)
        {
            
        }

        public Task<string> key(int index) => ExecAsync<string>(new object[] { index });

        public Task<int> length => GetAsync<int>();

        public Task<string> getItem(string index) => ExecAsync<string>(new object[] { index });

        public Task setItem(string key, string value) => ExecAsync<object>(new object[] { key, value });

        public Task removeItem(string key) => ExecAsync<object>(new object[] { key });

        public Task clear() => ExecAsync<object>(new object[]{});
    }
}