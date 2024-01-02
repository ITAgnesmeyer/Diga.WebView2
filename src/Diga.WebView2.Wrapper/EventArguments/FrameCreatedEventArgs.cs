using System;
using System.Diagnostics;
using Diga.WebView2.Interop;

namespace Diga.WebView2.Wrapper.EventArguments
{





    public class FrameCreatedEventArgs : ICoreWebView2FrameCreatedEventArgs
    {
        private ICoreWebView2FrameCreatedEventArgs _Args;
        private Frame _Frame;
        public FrameCreatedEventArgs(ICoreWebView2FrameCreatedEventArgs args)
        {
            this._Args = args;
            try
            {
                string name = this._Args.Frame.name;
                Debug.Print(name);
                this._Frame = new Frame((ICoreWebView2Frame5)this._Args.Frame);

            }
            catch (Exception ex)
            {
                Debug.Print("Error:" + ex.Message);
            }
            
        }
        public Frame Frame => this._Frame;

        ICoreWebView2Frame ICoreWebView2FrameCreatedEventArgs.Frame => this._Args.Frame;
    }
}