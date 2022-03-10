using System;
using Diga.WebView2.Interop;

namespace Diga.WebView2.Scripting.DOM
{
    public class MediaStreamTrack : DOMObject
    {
        public MediaStreamTrack(IWebViewControl control, DOMVar domVar) : base(control, domVar)
        {

        }

        public string contentHint
        {
            get => base.Get<string>();
            set => base.Set<string>(value);
        }

        public bool enabled
        {
            get => base.Get<bool>();
            set => base.Set(value);
        }

        public string id => base.Get<string>();
        public string kind => base.Get<string>();
        public string label => base.Get<string>();
        public bool muted => base.Get<bool>();
        public string readyState => base.Get<string>();

        public MediaStreamTrack clone()
        {
            DOMVar var = ExecGetVar(new Object[] { });
            return new MediaStreamTrack(this._View2Control, var);
        }


        public DOMObject getCapabilities()
        {
            DOMVar var = ExecGetVar(new object[] { });
            return new DOMObject(this._View2Control, var);
        }

        public DOMObject getConstraints()
        {
            DOMVar var = ExecGetVar(new object[] { });
            return new DOMObject(this._View2Control, var);
        }

        public DOMObject getSettings()
        {
            DOMVar var = ExecGetVar(new object[] { });
            return new DOMObject(this._View2Control, var);
        }

        public void stop()
        {
            Exec(new object[]{});
        }


    }
}