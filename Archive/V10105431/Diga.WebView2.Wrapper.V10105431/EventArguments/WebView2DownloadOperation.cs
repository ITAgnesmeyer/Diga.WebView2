using Diga.WebView2.Interop;
using System;
using System.Diagnostics;
using Diga.WebView2.Wrapper.Implementation;

namespace Diga.WebView2.Wrapper.EventArguments
{
    public class WebView2DownloadOperation : WebView2DownloadOperationInterface
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

        protected override void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                   UnRegisterEvents();
                }

                
                disposedValue = true;
            }
        }

       
    }
}