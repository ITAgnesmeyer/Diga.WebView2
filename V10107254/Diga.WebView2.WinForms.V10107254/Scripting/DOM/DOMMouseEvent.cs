using System.Threading.Tasks;

namespace Diga.WebView2.WinForms.Scripting.DOM
{
    public class DOMMouseEvent : DOMUiEvent
    {
        public DOMMouseEvent(WebView control,DOMVar var):base(control,var)
        {
            
        }

        public bool altKey => Get<bool>();
        public Task<bool> altKeyAsync => GetAsync<bool>(nameof(altKey));

        public int button => Get<int>();
        public Task<int> buttonAsync => GetAsync<int>(nameof(button));

        public int buttons => Get<int>();
        public Task<int> buttonsAsync => GetAsync<int>(nameof(buttons));

        public int clientX => Get<int>();
        public Task<int> clientXAsync => GetAsync<int>(nameof(clientX));
        public int clientY => Get<int>();

        public Task<int> clientYAsync => GetAsync<int>(nameof(clientY));

        public bool ctrlKey => Get<bool>();
        public Task<bool> ctrlKeyAsync => GetAsync<bool>(nameof(ctrlKey));

        public bool getModifierState(string modifierKey)
        {
            return Exec<bool>(new object[] { modifierKey });
        }
        public Task<bool> getModifierStateAsync(string modifierKey)
        {
            return ExecAsync<bool>(new object[] { modifierKey },nameof(getModifierState));
        }

        public bool metaKey => Get<bool>();
        public Task<bool> metaKeyAsync => GetAsync<bool>(nameof(metaKey));

        public int movementX => Get<int>();
        public Task<int> movementXAsync => GetAsync<int>(nameof(movementX));

        public int movementY => Get<int>();
        public Task<int> movementYAsync => GetAsync<int>(nameof(movementY));

        public int offsetX => Get<int>();
        public Task<int> offsetXAsync => GetAsync<int>(nameof(offsetX));

        public int offsetY => Get<int>();
        public Task<int> offsetYAsync => GetAsync<int>(nameof(offsetY));
        public int pageX => Get<int>();
        public Task<int> pageXAsync => GetAsync<int>(nameof(pageX));
        public int pageY => Get<int>();
        public Task<int> pageYAsync => GetAsync<int>(nameof(pageY));

        public DOMElement relatedTarget => GetTypedVar<DOMElement>();
        public Task<DOMElement> relatedTargetAsync => GetTypedVarAsync<DOMElement>(nameof(relatedTarget));

        public int screenX => Get<int>();
        public Task<int> screenXAsync => GetAsync<int>(nameof(screenX));
        public int screenY => Get<int>();
        public Task<int> screenYAsync => GetAsync<int>(nameof(screenY));
        public bool shiftKey => Get<bool>();
        public Task<bool> shiftKeyAsync => GetAsync<bool>(nameof(shiftKey));

        public int which => Get<int>();
        public Task<int> whichAsync => GetAsync<int>(nameof(which));

    }
}