using System.Threading.Tasks;
using Diga.WebView2.Interop;

namespace Diga.WebView2.Scripting.DOM
{
    public class DOMEvent : DOMObject
    {
        public DOMEvent(IWebViewControl control,DOMVar var):base(control,var)
        {
            
        }

        public bool bubbles => Get<bool>();
        public Task<bool> bubblesAsync=> GetAsync<bool>(nameof(this.bubbles));

        public bool cancelBubble
        {
            set => Set(value);
        }

        public Task<bool> cancelBubbleAsync
        {
            set => _ = SetAsync(value,nameof(this.cancelBubble));
        }

        public bool cancelable => Get<bool>();
        public Task<bool> cancelableAsync => GetAsync<bool>(nameof(this.cancelable));

        public bool composed => Get<bool>();
        public Task<bool> composedAsync => GetAsync<bool>(nameof(this.composed));


        public DOMEvent createEvent(string eventName)
    {
            DOMVar var = ExecGetVar(new object[] { eventName });
            return new DOMEvent(this._View2Control, var);
        }

        public async Task<DOMEvent> createEventAsync(string eventName)
        {
            DOMVar var = await ExecGetVarAsync(new object[] { eventName },nameof(createEvent));
            return new DOMEvent(this._View2Control, var);
        }


        public string composedPath() => Exec<string>(new object[] { });
        public Task<string> composedPathAsync() => ExecAsync<string>(new object[] { },nameof(composedPath));

        public DOMObject currentTarget => GetTypedVar<DOMObject>();
        public Task<DOMObject> currentTargetAsync => GetTypedVarAsync<DOMObject>(nameof(this.currentTarget));


        public bool defaultPrevented => Get<bool>();
        public Task<bool> defaultPreventedAsync => GetAsync<bool>(nameof(this.defaultPrevented));

        public int eventPhase => Get<int>();
        public Task<int> eventPhaseAsync => GetAsync<int>(nameof(this.eventPhase));

        public bool isTrusted => Get<bool>();
        public Task<bool> isTrustedAsync => GetAsync<bool>(nameof(this.isTrusted));

        public void preventDefault() => Exec(new object[]{});
        public Task preventDefaultAsync() => ExecAsync<object>(new object[]{},nameof(preventDefault));

        public void stopImmediatePropagation() => Exec(new object[] { });
        public Task stopImmediatePropagationAsync() => ExecAsync<object>(new object[] { },nameof(stopImmediatePropagation));

        public void stopPropagation() => Exec(new object[] { });
        public Task stopPropagationAsync() => ExecAsync<object>(new object[] { },nameof(stopPropagation));

        public DOMElement target => GetTypedVar<DOMElement>();
        public Task<DOMElement> targetAsync => GetTypedVarAsync<DOMElement>(nameof(this.target));

        public string timeStamp => Get<string>();
        public Task<string> timeStampAsync => GetAsync<string>(nameof(this.timeStamp));

        public string type => Get<string>();
        public Task<string> typeAsync => GetAsync<string>(nameof(this.type));

    }
}