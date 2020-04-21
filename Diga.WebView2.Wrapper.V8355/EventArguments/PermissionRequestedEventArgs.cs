using System;
using Diga.WebView2.Interop;

namespace Diga.WebView2.Wrapper
{
    public class PermissionRequestedEventArgs : EventArgs, IWebView2PermissionRequestedEventArgs
    {
        private IWebView2PermissionRequestedEventArgs _Args;

        public PermissionRequestedEventArgs(IWebView2PermissionRequestedEventArgs args)
        {
            this._Args = args;
        }

        private IWebView2PermissionRequestedEventArgs Tointerface()
        {
            return this._Args;
        }

        public string Uri => this.Tointerface().uri;

        public PermissionState State
        {
            get => (PermissionState) this.Tointerface().State;
            set => this.Tointerface().State = (WEBVIEW2_PERMISSION_STATE) value;
        }

        public PermissionType PermissionType => (PermissionType) this.Tointerface().PermissionType;

        public void OnDeferral(Action action)
        {
            Deferral deferral =(Deferral)this.Tointerface().GetDeferral();
            deferral.DeferralComplete = action;

        }
        string IWebView2PermissionRequestedEventArgs.uri => this._Args.uri;

        WEBVIEW2_PERMISSION_TYPE IWebView2PermissionRequestedEventArgs.PermissionType => this._Args.PermissionType;

        int IWebView2PermissionRequestedEventArgs.IsUserInitiated => this._Args.IsUserInitiated;

        WEBVIEW2_PERMISSION_STATE IWebView2PermissionRequestedEventArgs.State
        {
            get => this._Args.State;
            set => this._Args.State = value;
        }

        IWebView2Deferral IWebView2PermissionRequestedEventArgs.GetDeferral()
        {
            return this._Args.GetDeferral();
        }
    }
}