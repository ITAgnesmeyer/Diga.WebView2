using System.Threading.Tasks;

namespace Diga.WebView2.Wpf.Scripting.DOM
{
    public class DOMDialog : DOMElement
    {
        public DOMDialog(WebView control, DOMVar domVar):base(control, domVar)
        {
            
        }

        public bool open
        {
            get => Get<bool>();
            set => Set(value);
        }

        public Task<bool> openAsync
        {
            get => GetAsync<bool>(nameof(open));
            set => _ = SetAsync(value,nameof(open));
        }

        public string returnValue
        {
            get => Get<string>();
            set => Set(value);
        }
        public Task<string> returnValueAsync
        {
            get => GetAsync<string>(nameof(returnValue));
            set => _ = SetAsync(value,nameof(returnValue));
        }

        public void close() => Exec(new object[] { });
        public Task closeAsync() => ExecAsync<object>(new object[] { },nameof(close));
        public void show() => Exec(new object[] { });
        public Task showAsync() => ExecAsync<object>(new object[] { },nameof(show));
        public void showModal() => Exec(new object[] { });
        public Task showModalAsync() => ExecAsync<object>(new object[] { },nameof(showModal));

    }
}