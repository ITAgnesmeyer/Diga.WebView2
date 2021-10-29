using Diga.WebView2.Interop;
using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace Diga.WebView2.Wrapper.EventArguments
{
    public class StateChangedEventHandler:ICoreWebView2StateChangedEventHandler
    {
        public event EventHandler<WebView2EventArgs> StateChanged;
        public void Invoke([In, MarshalAs(UnmanagedType.Interface)] ICoreWebView2DownloadOperation sender, [In, MarshalAs(UnmanagedType.IUnknown)] object args)
        {
            throw new NotImplementedException();
        }

        private void OnStateChanged(ICoreWebView2DownloadOperation sender, object obj)
        {
            StateChanged?.Invoke(sender, new WebView2EventArgs(sender,obj));
        }
    }
    public class EstimatedEndTimeChangedEventHandler:ICoreWebView2EstimatedEndTimeChangedEventHandler
    {
        public event EventHandler<WebView2EventArgs> EstimatedEndTimeChanged;
        public void Invoke([In, MarshalAs(UnmanagedType.Interface)] ICoreWebView2DownloadOperation sender, [In, MarshalAs(UnmanagedType.IUnknown)] object args)
        {
            OnEstimatedEndTimeChanged(sender, args);
        }
        private void OnEstimatedEndTimeChanged(ICoreWebView2DownloadOperation sender, object obj)
        {
            EstimatedEndTimeChanged.Invoke(sender, new WebView2EventArgs(sender, obj));
        }
    }
    public class BytesReceivedChangedEventHandler:ICoreWebView2BytesReceivedChangedEventHandler
    {
        public event EventHandler<WebView2EventArgs> BytesReceivedChanged;

        public void Invoke([In, MarshalAs(UnmanagedType.Interface)] ICoreWebView2DownloadOperation sender, [In, MarshalAs(UnmanagedType.IUnknown)] object args)
        {
            OnBytesReceivedChanged(sender, args);
        }

        private void OnBytesReceivedChanged(ICoreWebView2DownloadOperation sender, object obj)
        {
            BytesReceivedChanged?.Invoke(sender, new WebView2EventArgs(sender , obj));
        }
    }
    public class WebView2DownloadOperation : WebView2DownloadOperationInterface,IDisposable
    {
        private bool disposedValue;
        private EventRegistrationToken _BytesReceivedChangedToken;
        private EventRegistrationToken _EstimatedEndTimeChangedToken;
        private EventRegistrationToken _StateChangedToken;
         public event EventHandler<WebView2EventArgs> StateChanged;
         public event EventHandler<WebView2EventArgs> EstimatedEndTimeChanged;
        public event EventHandler<WebView2EventArgs> BytesReceivedChanged;
        public WebView2DownloadOperation(ICoreWebView2DownloadOperation downloadOperation) : base(downloadOperation)
        {
            RegisterEvents();
        }
        private void RegisterEvents()
        {
             //add_BytesReceivedChanged
            BytesReceivedChangedEventHandler bytesReceivedChangedHandler = new BytesReceivedChangedEventHandler();
            bytesReceivedChangedHandler.BytesReceivedChanged+=OnBytesReceivedChangedInternal;
            base.add_BytesReceivedChanged(bytesReceivedChangedHandler,out _BytesReceivedChangedToken);
            //add_EstimatedEndTimeChanged
            EstimatedEndTimeChangedEventHandler estimatedEndTimeChangedHandler = new EstimatedEndTimeChangedEventHandler();
            estimatedEndTimeChangedHandler.EstimatedEndTimeChanged += OnEstimatedEndTimeChangedInternal;
            base.add_EstimatedEndTimeChanged(estimatedEndTimeChangedHandler, out _EstimatedEndTimeChangedToken);
            StateChangedEventHandler stateChangedHandler = new StateChangedEventHandler();
            stateChangedHandler.StateChanged += OnStateChangedIntern;
            //add_StateChanged
            base.add_StateChanged(stateChangedHandler, out _StateChangedToken );
        }
        private void UnRegisterEvents()
        {
            try
            {
                EventRegistrationTool.UnWireToken(this._BytesReceivedChangedToken, base.remove_BytesReceivedChanged);
                EventRegistrationTool.UnWireToken(this._EstimatedEndTimeChangedToken, base.remove_EstimatedEndTimeChanged);
                EventRegistrationTool.UnWireToken(this._StateChangedToken, base.remove_StateChanged);
            }
            catch (Exception ex)
            {

                Debug.Print("Exception on Unregister:" + ex.Message);
            }
           
        }
        private void OnStateChanged(object sender, WebView2EventArgs e)
        {
            StateChanged?.Invoke(this,e);
        }
        private void OnStateChangedIntern(object sender, WebView2EventArgs e)
        {
            OnStateChanged(sender, e);
        }
        //EstimatedEndTimeChanged
        private void OnEstimatedEndTimeChanged(object sender, WebView2EventArgs e)
        {
            EstimatedEndTimeChanged?.Invoke(this,e);
        }
        private void OnEstimatedEndTimeChangedInternal(object sender, WebView2EventArgs e)
        {
            OnEstimatedEndTimeChanged(sender, e);
        }
        private void OnBytesReceivedChanged(object sender, WebView2EventArgs e)
        {
            BytesReceivedChanged?.Invoke(this,e);
        }
        private void OnBytesReceivedChangedInternal(object sender, WebView2EventArgs e)
        {
            OnBytesReceivedChanged(sender, e);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                   UnRegisterEvents();
                }

                // TODO: Nicht verwaltete Ressourcen (nicht verwaltete Objekte) freigeben und Finalizer überschreiben
                // TODO: Große Felder auf NULL setzen
                disposedValue = true;
            }
        }

        // // TODO: Finalizer nur überschreiben, wenn "Dispose(bool disposing)" Code für die Freigabe nicht verwalteter Ressourcen enthält
        // ~WebView2DownloadOperation()
        // {
        //     // Ändern Sie diesen Code nicht. Fügen Sie Bereinigungscode in der Methode "Dispose(bool disposing)" ein.
        //     Dispose(disposing: false);
        // }

        public void Dispose()
        {
            // Ändern Sie diesen Code nicht. Fügen Sie Bereinigungscode in der Methode "Dispose(bool disposing)" ein.
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }

    public class WebView2DownloadOperationInterface : ICoreWebView2DownloadOperation
    {
        private ICoreWebView2DownloadOperation _DownloadOperation;
        public WebView2DownloadOperationInterface(ICoreWebView2DownloadOperation downloadOperation)
        {
            this._DownloadOperation = downloadOperation;
        }

        public void add_BytesReceivedChanged([In, MarshalAs(UnmanagedType.Interface)] ICoreWebView2BytesReceivedChangedEventHandler eventHandler, out EventRegistrationToken token)
        {
            _DownloadOperation.add_BytesReceivedChanged(eventHandler, out token);
        }

        public void remove_BytesReceivedChanged([In] EventRegistrationToken token)
        {
            _DownloadOperation.remove_BytesReceivedChanged(token);
        }

        public void add_EstimatedEndTimeChanged([In, MarshalAs(UnmanagedType.Interface)] ICoreWebView2EstimatedEndTimeChangedEventHandler eventHandler, out EventRegistrationToken token)
        {
            _DownloadOperation.add_EstimatedEndTimeChanged(eventHandler, out token);
        }

        public void remove_EstimatedEndTimeChanged([In] EventRegistrationToken token)
        {
            _DownloadOperation.remove_EstimatedEndTimeChanged(token);
        }

        public void add_StateChanged([In, MarshalAs(UnmanagedType.Interface)] ICoreWebView2StateChangedEventHandler eventHandler, out EventRegistrationToken token)
        {
            _DownloadOperation.add_StateChanged(eventHandler, out token);
        }

        public void remove_StateChanged([In] EventRegistrationToken token)
        {
            _DownloadOperation.remove_StateChanged(token);
        }

        public string uri => _DownloadOperation.uri;

        public string ContentDisposition => _DownloadOperation.ContentDisposition;

        public string MimeType => _DownloadOperation.MimeType;

        public long TotalBytesToReceive => _DownloadOperation.TotalBytesToReceive;

        public long BytesReceived => _DownloadOperation.BytesReceived;

        public string EstimatedEndTime => _DownloadOperation.EstimatedEndTime;

        public string ResultFilePath => _DownloadOperation.ResultFilePath;

        public COREWEBVIEW2_DOWNLOAD_STATE State => _DownloadOperation.State;

        public COREWEBVIEW2_DOWNLOAD_INTERRUPT_REASON InterruptReason => _DownloadOperation.InterruptReason;

        public void Cancel()
        {
            _DownloadOperation.Cancel();
        }

        public void Pause()
        {
            _DownloadOperation.Pause();
        }

        public void Resume()
        {
            _DownloadOperation.Resume();
        }

        public int CanResume => _DownloadOperation.CanResume;
    }

    public class DownloadStartingEventArgs:DownloadStartingEventArgsInterface
    {
        public DownloadStartingEventArgs(ICoreWebView2DownloadStartingEventArgs args):base(args)
        {

        }

        new public WebView2DownloadOperation DownloadOperation => new WebView2DownloadOperation(base.DownloadOperation);
    }

    public class DownloadStartingEventArgsInterface : ICoreWebView2DownloadStartingEventArgs
    {
        private ICoreWebView2DownloadStartingEventArgs _Args;

        public DownloadStartingEventArgsInterface(ICoreWebView2DownloadStartingEventArgs args)
        {
            this._Args = args;
        }
        public ICoreWebView2DownloadOperation DownloadOperation => this._Args.DownloadOperation;

        public int Cancel
        {
            get => this._Args.Cancel;
            set => this._Args.Cancel = value;
        }

        public string ResultFilePath
        {
            get => this._Args.ResultFilePath;
            set => this._Args.ResultFilePath = value;
        }

        public int Handled
        {
            get => this._Args.Handled;
            set => this._Args.Handled = value;
        }

        public ICoreWebView2Deferral GetDeferral()
        {
            return this._Args.GetDeferral();
        }
    }
}