using System.Threading.Tasks;
using Diga.WebView2.Interop;

namespace Diga.WebView2.Scripting.DOM
{
    public class DOMKeyboardEvent : DOMUiEvent
    {
        public DOMKeyboardEvent(IWebViewControl control, DOMVar var):base(control, var)
        {
            
        }

        public bool altKey => Get<bool>();
        public Task<bool> altKeyAsync => GetAsync<bool>(nameof(this.altKey));

        public int charCode => Get<int>();
        public Task<int> charCodeAsync => GetAsync<int>(nameof(this.charCode));

        public bool ctrlKey => Get<bool>();
        public Task<bool> ctrlKeyAsync => GetAsync<bool>(nameof(this.ctrlKey));

        public bool getModifierState(string modifierKey)
        {
            return Exec<bool>(new object[] { modifierKey });
        }

        public async Task<bool> getModifierStateAsync(string modifierKey)
        {
            return await ExecAsync<bool>(new object[] { modifierKey },nameof(getModifierState));
        }

        public bool isComposing => Get<bool>();
        public Task<bool> isComposingAsync => GetAsync<bool>(nameof(this.isComposing));
        public string key => Get<string>();
        public Task<string> keyAsync => GetAsync<string>(nameof(this.key));
        public int location => Get<int>();
        public Task<int> locationAsync => GetAsync<int>(nameof(this.location));

        public bool metaKey => Get<bool>();
        public Task<bool> metaKeyAsync => GetAsync<bool>(nameof(this.metaKey));

        public bool repeat => Get<bool>();
        public Task<bool> repeatAsync => GetAsync<bool>(nameof(this.repeat));
        public bool shiftKey => Get<bool>();
        public Task<bool> shiftKeyAsync => GetAsync<bool>(nameof(this.shiftKey));
        public int which => Get<int>();
        public Task<int> whichAsync => GetAsync<int>(nameof(this.which));

    }
}