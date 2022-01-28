using System.Threading.Tasks;

namespace Diga.WebView2.WinForms.Scripting.DOM
{
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