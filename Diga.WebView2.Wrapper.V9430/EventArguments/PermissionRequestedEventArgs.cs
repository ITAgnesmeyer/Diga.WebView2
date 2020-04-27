using System;
using Diga.WebView2.Interop;

namespace Diga.WebView2.Wrapper
{
    public class PermissionRequestedEventArgs : EventArgs, ICoreWebView2PermissionRequestedEventArgs
    {
        private ICoreWebView2PermissionRequestedEventArgs _Args;

        public PermissionRequestedEventArgs(ICoreWebView2PermissionRequestedEventArgs args)
        {
            this._Args = args;
        }

        private ICoreWebView2PermissionRequestedEventArgs Tointerface()
        {
            return this._Args;
        }

        public string Uri => this.Tointerface().uri;

        public PermissionState State
        {
            get => (PermissionState)this.Tointerface().State;
            set => this.Tointerface().State = (CORE_WEBVIEW2_PERMISSION_STATE)value;
        }

        public PermissionType PermissionType => (PermissionType)this.Tointerface().PermissionKind;

        //public void OnDeferral(Action action)
        //{
        //    Deferral deferral =(Deferral)this.Tointerface().GetDeferral();
        //    deferral.DeferralComplete = action;

        //}
       
        string ICoreWebView2PermissionRequestedEventArgs.uri => this._Args.uri;

        CORE_WEBVIEW2_PERMISSION_KIND ICoreWebView2PermissionRequestedEventArgs.PermissionKind => this._Args.PermissionKind;

        int ICoreWebView2PermissionRequestedEventArgs.IsUserInitiated => this._Args.IsUserInitiated;

        CORE_WEBVIEW2_PERMISSION_STATE ICoreWebView2PermissionRequestedEventArgs.State
        {
            get => this._Args.State;
            set => this._Args.State = value;
        }

        ICoreWebView2Deferral ICoreWebView2PermissionRequestedEventArgs.GetDeferral()
        {
            return this._Args.GetDeferral();
        }
    }
}