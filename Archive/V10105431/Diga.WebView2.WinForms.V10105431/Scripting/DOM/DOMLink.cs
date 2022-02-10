using System.Threading.Tasks;

namespace Diga.WebView2.WinForms.Scripting.DOM
{
    public class DOMLink : DOMElement
    {
        public DOMLink(WebView control, DOMVar domVar):base(control, domVar)
        {
            
        }

        public Task<bool> diabled
        {
            get => GetAsync<bool>();
            set=> _ = SetAsync(value);
        }

        public Task<string> href
        {
            get => GetAsync<string>();
            set=> _ = SetAsync(value);
        }

        public Task<string> hreflang
        {
            get => GetAsync<string>();
            set=> _ = SetAsync(value);
        }

        public Task<string> media
        {
            get => GetAsync<string>();
            set => _= SetAsync(value);
        }

        public Task<string> rel
        {
            get => GetAsync<string>();
            set=> _ = SetAsync(value);
        }

        public Task<string> type
        {
            get => GetAsync<string>();
            set => _ = SetAsync(value);
        }

        public Task<string> integrity
        {
            get => GetAsync<string>();
            set=> _ = SetAsync(value);
        }

        public Task<string> crossorigin
        {
            get => GetAsync<string>();
            set=> _ = SetAsync(value);
        }


    }
}