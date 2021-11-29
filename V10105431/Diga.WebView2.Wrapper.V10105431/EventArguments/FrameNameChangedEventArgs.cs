using System;

namespace Diga.WebView2.Wrapper.EventArguments
{
    public class FrameNameChangedEventArgs : EventArgs
    {
        public Frame Frame { get; }
        public object Args { get; }

        public FrameNameChangedEventArgs(Frame frame , object args)
        {
            this.Frame = frame;
            this.Args = args;
        }
    }
}