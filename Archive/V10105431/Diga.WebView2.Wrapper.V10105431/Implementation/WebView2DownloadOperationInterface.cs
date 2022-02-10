using System;
using System.Runtime.InteropServices;
using Diga.WebView2.Interop;
using Microsoft.Win32.SafeHandles;

namespace Diga.WebView2.Wrapper.Implementation
{
    public class WebView2DownloadOperationInterface : ICoreWebView2DownloadOperation,IDisposable
    {
        private ICoreWebView2DownloadOperation _DownloadOperation;
        private bool disposedValue;
        /// Wraps in SafeHandle so resources can be released if consumer forgets to call Dispose. Recommended
        ///             pattern for any type that is not sealed.
        ///             https://docs.microsoft.com/dotnet/api/system.idisposable#idisposable-and-the-inheritance-hierarchy
        private SafeHandle handle = (SafeHandle) new SafeFileHandle(IntPtr.Zero, true);
        public WebView2DownloadOperationInterface(ICoreWebView2DownloadOperation downloadOperation)
        {
            this._DownloadOperation = downloadOperation;
        }

        public void add_BytesReceivedChanged([In, MarshalAs(UnmanagedType.Interface)] ICoreWebView2BytesReceivedChangedEventHandler eventHandler, out EventRegistrationToken token)
        {
            this._DownloadOperation.add_BytesReceivedChanged(eventHandler, out token);
        }

        public void remove_BytesReceivedChanged([In] EventRegistrationToken token)
        {
            this._DownloadOperation.remove_BytesReceivedChanged(token);
        }

        public void add_EstimatedEndTimeChanged([In, MarshalAs(UnmanagedType.Interface)] ICoreWebView2EstimatedEndTimeChangedEventHandler eventHandler, out EventRegistrationToken token)
        {
            this._DownloadOperation.add_EstimatedEndTimeChanged(eventHandler, out token);
        }

        public void remove_EstimatedEndTimeChanged([In] EventRegistrationToken token)
        {
            this._DownloadOperation.remove_EstimatedEndTimeChanged(token);
        }

        public void add_StateChanged([In, MarshalAs(UnmanagedType.Interface)] ICoreWebView2StateChangedEventHandler eventHandler, out EventRegistrationToken token)
        {
            this._DownloadOperation.add_StateChanged(eventHandler, out token);
        }

        public void remove_StateChanged([In] EventRegistrationToken token)
        {
            this._DownloadOperation.remove_StateChanged(token);
        }

        public string uri => this._DownloadOperation.uri;

        public string ContentDisposition => this._DownloadOperation.ContentDisposition;

        public string MimeType => this._DownloadOperation.MimeType;

        public long TotalBytesToReceive => this._DownloadOperation.TotalBytesToReceive;

        public long BytesReceived => this._DownloadOperation.BytesReceived;

        public string EstimatedEndTime => this._DownloadOperation.EstimatedEndTime;

        public string ResultFilePath => this._DownloadOperation.ResultFilePath;

        public COREWEBVIEW2_DOWNLOAD_STATE State => this._DownloadOperation.State;

        public COREWEBVIEW2_DOWNLOAD_INTERRUPT_REASON InterruptReason => this._DownloadOperation.InterruptReason;

        public void Cancel()
        {
            this._DownloadOperation.Cancel();
        }

        public void Pause()
        {
            this._DownloadOperation.Pause();
        }

        public void Resume()
        {
            this._DownloadOperation.Resume();
        }

        public int CanResume => this._DownloadOperation.CanResume;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposedValue)
            {
                if (disposing)
                {
                    this.handle.Dispose();
                    this._DownloadOperation = null;
                }

                
                this.disposedValue = true;
            }
        }

       

        public void Dispose()
        {
            
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}