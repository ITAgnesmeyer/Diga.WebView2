using System.Threading.Tasks;
using Diga.WebView2.Interop;

namespace Diga.WebView2.Scripting.DOM
{
    public class DOMMouseEvent : DOMUiEvent
    {
        public DOMMouseEvent(IWebViewControl control,DOMVar var):base(control,var)
        {
            
        }

        public bool altKey => Get<bool>();
        public Task<bool> altKeyAsync => GetAsync<bool>(nameof(this.altKey));

        public int button => Get<int>();
        public Task<int> buttonAsync => GetAsync<int>(nameof(this.button));

        public int buttons => Get<int>();
        public Task<int> buttonsAsync => GetAsync<int>(nameof(this.buttons));

        public int clientX => Get<int>();
        public Task<int> clientXAsync => GetAsync<int>(nameof(this.clientX));
        public int clientY => Get<int>();

        public Task<int> clientYAsync => GetAsync<int>(nameof(this.clientY));

        public bool ctrlKey => Get<bool>();
        public Task<bool> ctrlKeyAsync => GetAsync<bool>(nameof(this.ctrlKey));

        public bool getModifierState(string modifierKey)
        {
            return Exec<bool>(new object[] { modifierKey });
        }
        public Task<bool> getModifierStateAsync(string modifierKey)
        {
            return ExecAsync<bool>(new object[] { modifierKey },nameof(getModifierState));
        }

        public bool metaKey => Get<bool>();
        public Task<bool> metaKeyAsync => GetAsync<bool>(nameof(this.metaKey));

        public int movementX => Get<int>();
        public Task<int> movementXAsync => GetAsync<int>(nameof(this.movementX));

        public int movementY => Get<int>();
        public Task<int> movementYAsync => GetAsync<int>(nameof(this.movementY));

        public int offsetX => Get<int>();
        public Task<int> offsetXAsync => GetAsync<int>(nameof(this.offsetX));

        public int offsetY => Get<int>();
        public Task<int> offsetYAsync => GetAsync<int>(nameof(this.offsetY));
        public int pageX => Get<int>();
        public Task<int> pageXAsync => GetAsync<int>(nameof(this.pageX));
        public int pageY => Get<int>();
        public Task<int> pageYAsync => GetAsync<int>(nameof(this.pageY));

        public DOMElement relatedTarget => GetTypedVar<DOMElement>();
        public Task<DOMElement> relatedTargetAsync => GetTypedVarAsync<DOMElement>(nameof(this.relatedTarget));

        public int screenX => Get<int>();
        public Task<int> screenXAsync => GetAsync<int>(nameof(this.screenX));
        public int screenY => Get<int>();
        public Task<int> screenYAsync => GetAsync<int>(nameof(this.screenY));
        public bool shiftKey => Get<bool>();
        public Task<bool> shiftKeyAsync => GetAsync<bool>(nameof(this.shiftKey));

        public int which => Get<int>();
        public Task<int> whichAsync => GetAsync<int>(nameof(this.which));

    }
}