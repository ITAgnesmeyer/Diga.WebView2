using System.Threading.Tasks;

namespace Diga.WebView2.Wpf.Scripting.DOM
{
    public class DOMDialog : DOMElement
    {
        public DOMDialog(WebView control, DOMVar domVar):base(control, domVar)
        {
            
        }

        public Task<bool> open
        {
            get => GetAsync<bool>();
            set => _ = SetAsync(value);
        }

        public Task<string> returnValue
        {
            get => GetAsync<string>();
            set => _ = SetAsync(value);
        }

        public Task close() => Exec<object>(new object[] { });

        public Task show() => Exec<object>(new object[] { });
        public Task showModal() => Exec<object>(new object[] { });

    }
}