using System.Threading.Tasks;

namespace Diga.WebView2.Wpf.Scripting.DOM
{
    public class DOMScript : DOMElement
    {
        public DOMScript(WebView control, DOMVar domVar) : base(control, domVar)
        {

        }

        public Task<bool> async
        {
            get => GetAsync<bool>();
            set => _ = SetAsync(value);
        }

        public Task<string> charset
        {
            get => GetAsync<string>();
            set => _ = SetAsync(value);
        }

        public Task<string> crossOrigin
        {
            get => GetAsync<string>();
            set => _ = SetAsync(value);
        }

        public Task<bool> defer
        {
            get => GetAsync<bool>();
            set => _ = SetAsync(value);
        }

        public Task<string> src
        {
            get => GetAsync<string>();
            set => _ = SetAsync(value);
        }

        public Task<string> text
        {
            get => GetAsync<string>();
            set => _ = SetAsync(value);
        }

        public Task<string> type
        {
            get => GetAsync<string>();
            set => _ = SetAsync(value);

        }
    }
}