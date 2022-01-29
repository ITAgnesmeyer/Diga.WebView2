using System.Threading.Tasks;

namespace Diga.WebView2.WinForms.Scripting.DOM
{
    public class DOMMouseEvent : DOMUiEvent
    {
        public DOMMouseEvent(WebView control,DOMVar var):base(control,var)
        {
            
        }

        public Task<bool> altKey => GetAsync<bool>();
        public Task<int> button => GetAsync<int>();
        public Task<int> buttons => GetAsync<int>();
        public Task<int> clientX => GetAsync<int>();
        public Task<int> clientY => GetAsync<int>();
        public Task<bool> ctrlKey => GetAsync<bool>();

        public Task<bool> getModifierState(string modifierKey)
        {
            return ExecAsync<bool>(new object[] { modifierKey });
        }

        public Task<bool> metaKey => GetAsync<bool>();

        public Task<int> movementX => GetAsync<int>();

        public Task<int> movementY => GetAsync<int>();

        public Task<int> offsetX => GetAsync<int>();
        public Task<int> offsetY => GetAsync<int>();
        public Task<int> pageX => GetAsync<int>();
        public Task<int> pageY => GetAsync<int>();
        public Task<DOMElement> relatedTarget => GetTypedVarAsync<DOMElement>();

        public Task<int> screenX => GetAsync<int>();
        public Task<int> screenY => GetAsync<int>();

        public Task<bool> shiftKey => GetAsync<bool>();

        public Task<int> which => GetAsync<int>();

    }
}