using System.Threading.Tasks;

namespace Diga.WebView2.Wpf.Scripting.DOM
{
    public class DOMStorage : DOMObject
    {
        public DOMStorage(WebView control, DOMVar domVar) : base(control, domVar)
        {
            
        }
        public string key(int index) => Exec<string>(new object[] { index });
        public Task<string> keyAsync(int index) => ExecAsync<string>(new object[] { index },nameof(key));
        public int length => Get<int>();
        public Task<int> lengthAsync => GetAsync<int>(nameof(length));

        public string getItem(string index) => Exec<string>(new object[] { index });
        public Task<string> getItemAsync(string index) => ExecAsync<string>(new object[] { index },nameof(getItem));

        public void setItem(string key, string value) => Exec(new object[] { key, value });
        public Task setItemAsync(string key, string value) => ExecAsync(new object[] { key, value },nameof(setItem));

        public void removeItem(string key) => Exec(new object[] { key });
        public Task removeItemAsync(string key) => ExecAsync(new object[] { key },nameof(removeItem));

        public void clear() => Exec(new object[]{});
        public Task clearAsync() => ExecAsync(new object[]{},nameof(clear));
    }
}