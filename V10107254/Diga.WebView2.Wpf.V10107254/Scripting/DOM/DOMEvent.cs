using System.Threading.Tasks;

namespace Diga.WebView2.Wpf.Scripting.DOM
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
            return Exec<bool>(new object[] { modifierKey });
        }

        public Task<bool> metaKey => GetAsync<bool>();

        public Task<int> movementX => GetAsync<int>();

        public Task<int> movementY => GetAsync<int>();

        public Task<int> offsetX => GetAsync<int>();
        public Task<int> offsetY => GetAsync<int>();
        public Task<int> pageX => GetAsync<int>();
        public Task<int> pageY => GetAsync<int>();
        public Task<DOMElement> relatedTarget => GetTypedVar<DOMElement>();

        public Task<int> screenX => GetAsync<int>();
        public Task<int> screenY => GetAsync<int>();

        public Task<bool> shiftKey => GetAsync<bool>();

        public Task<int> which => GetAsync<int>();

    }

    public class DOMEvent : DOMObject
    {
        public DOMEvent(WebView control,DOMVar var):base(control,var)
        {
            
        }

        public Task<bool> bubbles => GetAsync<bool>();

        public Task<bool> cancelBubble
        {
            set => _ = SetAsync(value);
        }

        public Task<bool> cancelable => GetAsync<bool>();

        public Task<bool> composed => GetAsync<bool>();


        public async Task<DOMEvent> createEvent(string eventName)
        {
            DOMVar var = await ExecGetVarAsync(new object[] { eventName });
            return new DOMEvent(this._View2Control, var);
        }

        public Task<string> composedPath() => Exec<string>(new object[] { });

        public Task<DOMObject> currentTarget => GetTypedVar<DOMObject>();

        public Task<bool> defaultPrevented => GetAsync<bool>();

        public Task<int> eventPhase => GetAsync<int>();

        public Task<bool> isTrusted => GetAsync<bool>();

        public Task preventDefault() => Exec<object>(new object[]{});

        public Task stopImmediatePropagation() => Exec<object>(new object[] { });

        public Task stopPropagation() => Exec<object>(new object[] { });

        public Task<DOMElement> target => GetTypedVar<DOMElement>();

        public Task<string> timeStamp => GetAsync<string>();

        public Task<string> type => GetAsync<string>();

    }
}