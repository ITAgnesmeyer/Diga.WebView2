using System;
using System.Diagnostics;
using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.EventArguments;
using Diga.WebView2.Wrapper.Types;

namespace Diga.WebView2.Wrapper.Implementation
{
    public class ProcessFailedEventArgs2Interface : ProcessFailedEventArgsInterface
    {
        private ComObjectHolder< ICoreWebView2ProcessFailedEventArgs2> _Args;

        private ICoreWebView2ProcessFailedEventArgs2 Args
        {
            get
            {
                if (this._Args == null)
                {
                    Debug.Print(nameof(ProcessFailedEventArgs2Interface) + " Args is null");
                    throw new InvalidOperationException(nameof(ProcessFailedEventArgs2Interface) + " Args is null");
                }

                return this._Args.Interface;
            }
            set => this._Args = new ComObjectHolder<ICoreWebView2ProcessFailedEventArgs2>(value);
        }
        public ProcessFailedEventArgs2Interface(ICoreWebView2ProcessFailedEventArgs2 args):base(args)
        {
            this.Args = args;
        }

        public COREWEBVIEW2_PROCESS_FAILED_REASON reason => this.Args.reason;

        public int ExitCode => this.Args.ExitCode;

        public string ProcessDescription => this.Args.ProcessDescription;

        public ICoreWebView2FrameInfoCollection FrameInfosForFailedProcess => this.Args.FrameInfosForFailedProcess;

        private bool disposedValue;
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (!this.disposedValue)
                {
                    this._Args = null;
                }

                this.disposedValue = true;
            }
            base.Dispose(disposing);
        }
    }
}