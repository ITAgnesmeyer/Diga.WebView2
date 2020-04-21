using System;
using Diga.WebView2.Interop;

namespace Diga.WebView2.Wrapper
{
    public class Deferral : IWebView2Deferral
    {
        public Action DeferralComplete;
        private IWebView2Deferral _Deferral;

        public Deferral(IWebView2Deferral deferral)
        {
            this._Deferral = deferral;
        }
        void  IWebView2Deferral.Complete()
        {
            this._Deferral.Complete();
            OnDeferralComplete();
        }

        protected virtual void OnDeferralComplete()
        {
            this.DeferralComplete?.Invoke();
        }
    }
}