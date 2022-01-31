﻿using System.Threading.Tasks;

namespace Diga.WebView2.WinForms.Scripting.DOM
{
    public class DOMEvent : DOMObject
    {
        public DOMEvent(WebView control,DOMVar var):base(control,var)
        {
            
        }

        public bool bubbles => Get<bool>();
        public Task<bool> bubblesAsync=> GetAsync<bool>(nameof(bubbles));

        public bool cancelBubble
        {
            set => Set(value);
        }

        public Task<bool> cancelBubbleAsync
        {
            set => _ = SetAsync(value,nameof(cancelBubble));
        }

        public bool cancelable => Get<bool>();
        public Task<bool> cancelableAsync => GetAsync<bool>(nameof(cancelable));

        public bool composed => Get<bool>();
        public Task<bool> composedAsync => GetAsync<bool>(nameof(composed));


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
        public Task<DOMObject> currentTargetAsync => GetTypedVarAsync<DOMObject>(nameof(currentTarget));


        public bool defaultPrevented => Get<bool>();
        public Task<bool> defaultPreventedAsync => GetAsync<bool>(nameof(defaultPrevented));

        public int eventPhase => Get<int>();
        public Task<int> eventPhaseAsync => GetAsync<int>(nameof(eventPhase));

        public bool isTrusted => Get<bool>();
        public Task<bool> isTrustedAsync => GetAsync<bool>(nameof(isTrusted));

        public void preventDefault() => Exec(new object[]{});
        public Task preventDefaultAsync() => ExecAsync<object>(new object[]{},nameof(preventDefault));

        public Task stopImmediatePropagation() => ExecAsync<object>(new object[] { });

        public Task stopPropagation() => ExecAsync<object>(new object[] { });

        public Task<DOMElement> target => GetTypedVarAsync<DOMElement>();

        public Task<string> timeStamp => GetAsync<string>();

        public Task<string> type => GetAsync<string>();

    }
}