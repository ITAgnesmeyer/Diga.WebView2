using System.Threading.Tasks;

namespace Diga.WebView2.WinForms.Scripting.DOM
{
    public class DOMKeyboardEvent : DOMUiEvent
    {
        public DOMKeyboardEvent(WebView control, DOMVar var):base(control, var)
        {
            
        }

        public Task<bool> altKey => GetAsync<bool>();
        public Task<int> charCode => GetAsync<int>();
        public Task<bool> ctrlKey => GetAsync<bool>();

        public async Task<bool> getModifierState(string modifierKey)
        {
            return await Exec<bool>(new object[] { modifierKey });
        }

        public Task<bool> isComposing => GetAsync<bool>();
        public Task<string> key => GetAsync<string>();
        public Task<int> location => GetAsync<int>();
        public Task<bool> metaKey => GetAsync<bool>();
        public Task<bool> repeat => GetAsync<bool>();
        public Task<bool> shiftKey => GetAsync<bool>();
        public Task<int> which => GetAsync<int>();

    }
}