using System.Threading.Tasks;

namespace Diga.WebView2.WinForms.Scripting.DOM
{
    public class DOMKeyboardEvent : DOMUiEvent
    {
        public DOMKeyboardEvent(WebView control, DOMVar var):base(control, var)
        {
            
        }

        public bool altKey => Get<bool>();
        public Task<bool> altKeyAsync => GetAsync<bool>(nameof(altKey));

        public int charCode => Get<int>();
        public Task<int> charCodeAsync => GetAsync<int>(nameof(charCode));

        public bool ctrlKey => Get<bool>();
        public Task<bool> ctrlKeyAsync => GetAsync<bool>(nameof(ctrlKey));

        public bool getModifierState(string modifierKey)
        {
            return Exec<bool>(new object[] { modifierKey });
        }

        public async Task<bool> getModifierStateAsync(string modifierKey)
        {
            return await ExecAsync<bool>(new object[] { modifierKey },nameof(getModifierState));
        }

        public bool isComposing => Get<bool>();
        public Task<bool> isComposingAsync => GetAsync<bool>(nameof(isComposing));
        public string key => Get<string>();
        public Task<string> keyAsync => GetAsync<string>(nameof(key));
        public int location => Get<int>();
        public Task<int> locationAsync => GetAsync<int>(nameof(location));

        public bool metaKey => Get<bool>();
        public Task<bool> metaKeyAsync => GetAsync<bool>(nameof(metaKey));

        public bool repeat => Get<bool>();
        public Task<bool> repeatAsync => GetAsync<bool>(nameof(repeat));
        public bool shiftKey => Get<bool>();
        public Task<bool> shiftKeyAsync => GetAsync<bool>(nameof(shiftKey));
        public int which => Get<int>();
        public Task<int> whichAsync => GetAsync<int>(nameof(which));

    }
}