using System;
using System.Diagnostics;
using Diga.Core.Threading;
using Diga.WebView2.WinForms.Scripting;
using Diga.WebView2.WinForms.Scripting.DOM;
using Diga.WebView2.Wrapper;
using Diga.WebView2.Wrapper.EventArguments;


namespace Diga.WebView2.WinForms
{
    public partial class WebView
    {
        public event EventHandler<NavigationStartingEventArgs> NavigationStart;
        public event EventHandler<ContentLoadingEventArgs> ContentLoading;
        public event EventHandler<SourceChangedEventArgs> SourceChanged;
        public event EventHandler<WebView2EventArgs> HistoryChanged;
        public event EventHandler<NavigationCompletedEventArgs> NavigationCompleted;
        public event EventHandler<WebResourceRequestedEventArgs> WebResourceRequested;
        public event EventHandler<AcceleratorKeyPressedEventArgs> AcceleratorKeyPressed;
        public event EventHandler<WebView2EventArgs> WebViewGotFocus;
        public event EventHandler<WebView2EventArgs> WebViewLostFocus;
        public event EventHandler<MoveFocusRequestedEventArgs> MoveFocusRequested;
        public event EventHandler<WebView2EventArgs> ZoomFactorChanged;
        public event EventHandler<WebView2EventArgs> DocumentTitleChanged;
        public event EventHandler<WebView2EventArgs> ContainsFullScreenElementChanged;
        public event EventHandler<NewWindowRequestedEventArgs> NewWindowRequested;
        public event EventHandler<PermissionRequestedEventArgs> PermissionRequested;
        public event EventHandler<NavigationCompletedEventArgs> FrameNavigationCompleted;
        public event EventHandler<NavigationStartingEventArgs> FrameNavigationStarting;
        public event EventHandler<ExecuteScriptCompletedEventArgs> ExecuteScriptCompleted;
        public event EventHandler<ProcessFailedEventArgs> ProcessFailed;
        public event EventHandler<ScriptDialogOpeningEventArgs> ScriptDialogOpening;
        public event EventHandler<WebMessageReceivedEventArgs> WebMessageReceived;

        public event EventHandler<AddScriptToExecuteOnDocumentCreatedCompletedEventArgs>
            ScriptToExecuteOnDocumentCreatedCompleted;

        public event EventHandler<EnvironmentCompletedHandlerArgs> BeforeEnvironmentCompleted;
        public event EventHandler<DownloadStartingEventArgs> DownloadStarting;
        public event EventHandler<FrameCreatedEventArgs> FrameCreated;
        public event EventHandler<WebView2EventArgs> RasterizationScaleChanged;
        public event EventHandler<RpcEventHandlerArgs> ScriptEvent;
        public event EventHandler<DOMContentLoadedEventArgs> DOMContentLoaded;
        public event EventHandler<WebResourceResponseReceivedEventArgs> WebResourceResponseReceived;

        public event EventHandler WebViewCreated;

        public event EventHandler BeforeWebViewDestroy;

        public event EventHandler<WebView2EventArgs> WindowCloseRequested;
        public event EventHandler<WebView2EventArgs> IsMutedChanged;
        public event EventHandler<WebView2EventArgs> IsDocumentPlayingAudioChanged;
        public event EventHandler<WebView2EventArgs> IsDefaultDownloadDialogOpenChanged;

        public event EventHandler DocumentLoading;
        public event EventHandler<DocumentReadyStateChangeEventArgs> DocumentReadyStateChange;
        private void OnWebWindowBeforeCreate(object sender, BeforeCreateEventArgs e)
        {
            WebWindowInitSettings(e);
        }

        private void OnWebWindowCreated(object sender, EventArgs e)
        {
            WebWindowInitAction();

            OnWebViewCreated();
        }

        protected virtual void OnWebResourceRequested(WebResourceRequestedEventArgs e)
        {
            CheckMonitoring(e);


            WebResourceRequested?.Invoke(this, e);
        }


        protected virtual void OnNavigationStart(NavigationStartingEventArgs e)
        {
            NavigationStart?.Invoke(this, e);
        }

        protected virtual void OnContentLoading(ContentLoadingEventArgs e)
        {
            ContentLoading?.Invoke(this, e);
        }

        protected virtual void OnSourceChanged(SourceChangedEventArgs e)
        {
            SourceChanged?.Invoke(this, e);
        }

        protected virtual void OnHistoryChanged(WebView2EventArgs e)
        {
            HistoryChanged?.Invoke(this, e);
        }

        protected virtual void OnNavigationCompleted(NavigationCompletedEventArgs e)
        {
            NavigationCompleted?.Invoke(this, e);
        }

        protected virtual void OnAcceleratorKeyPressed(AcceleratorKeyPressedEventArgs e)
        {
            AcceleratorKeyPressed?.Invoke(this, e);
        }


        protected virtual void OnContainsFullScreenElementChanged(WebView2EventArgs e)
        {
            ContainsFullScreenElementChanged?.Invoke(this, e);
        }

        protected virtual void OnDocumentTitleChanged(WebView2EventArgs e)
        {
            DocumentTitleChanged?.Invoke(this, e);
        }

        protected virtual void OnFrameNavigationStarting(NavigationStartingEventArgs e)
        {
            FrameNavigationStarting?.Invoke(this, e);
        }

        protected virtual void OnScriptDialogOpening(ScriptDialogOpeningEventArgs e)
        {
            ScriptDialogOpening?.Invoke(this, e);
        }

        protected virtual void OnWindowCloseRequested(WebView2EventArgs e)
        {
            WindowCloseRequested?.Invoke(this, e);
        }

        protected virtual void OnScriptToExecuteOnDocumentCreatedCompleted(
            AddScriptToExecuteOnDocumentCreatedCompletedEventArgs e)
        {
            ScriptToExecuteOnDocumentCreatedCompleted?.Invoke(this, e);
        }

        protected virtual void OnWebMessageReceived(WebMessageReceivedEventArgs e)
        {
            WebMessageReceived?.Invoke(this, e);
        }

        protected virtual void OnProcessFailed(ProcessFailedEventArgs e)
        {
            ProcessFailed?.Invoke(this, e);
        }

        protected virtual void OnExecuteScriptCompleted(ExecuteScriptCompletedEventArgs e)
        {
            ExecuteScriptCompleted?.Invoke(this, e);
        }

        protected virtual void OnNewWindowRequested(NewWindowRequestedEventArgs e)
        {

            NewWindowRequested?.Invoke(this, e);
        }

        protected virtual void OnPermissionRequested(PermissionRequestedEventArgs e)
        {
            PermissionRequested?.Invoke(this, e);
        }


        protected virtual void OnZoomFactorChanged(WebView2EventArgs e)
        {
            ZoomFactorChanged?.Invoke(this, e);
        }


        protected virtual void OnWebViewGotFocus(WebView2EventArgs e)
        {
            WebViewGotFocus?.Invoke(this, e);
        }

        protected virtual void OnWebViewLostFocus(WebView2EventArgs e)
        {
            WebViewLostFocus?.Invoke(this, e);
        }

        protected virtual void OnMoveFocusRequested(MoveFocusRequestedEventArgs e)
        {
            MoveFocusRequested?.Invoke(this, e);
        }

        public string BrowserVersion => this._WebViewControl.BrowserInfo;

        protected virtual void OnWebViewCreated()
        {
            WebViewCreated?.Invoke(this, EventArgs.Empty);
        }

        protected virtual void OnFrameNavigationCompleted(NavigationCompletedEventArgs e)
        {
            FrameNavigationCompleted?.Invoke(this, e);
        }

        protected virtual void OnBeforeWebViewDestroy()
        {
            try
            {
                BeforeWebViewDestroy?.Invoke(this, EventArgs.Empty);
            }
            catch (Exception ex)
            {
                Debug.Print(nameof(OnBeforeWebViewDestroy) + " Exception:" + ex);
            }
            finally
            {
                BeforeDisposeWebView();
            }
        }

        //private DOMDocument _Docuemnt;
        //private DOMWindow _Window;
        protected virtual void OnDocumentLoading()
        {
            //DOMWindow window = this.GetDOMWindow();
            //if (this._Docuemnt != null)
            //    this._Docuemnt.DomEvent -= OnDomEvent;
            UIDispatcher.UIThread.Post(() =>
            {
                try
                {
                    //this._Window = this.GetDOMWindow().GetCopy();
                    //this._Window.addEventListener("error", new DOMEventListenerScript(this._Window, "error"),false);
                    //this._Window.addEventListener("beforeunload", new DOMEventListenerScript(this._Window,"beforeunload"),false);
                    //this._Window.addEventListener("pagehide", new DOMEventListenerScript(this._Window,"pagehide"),false);
                    //this._Docuemnt = this._Window.document;

                    //this._Docuemnt.addEventListener("load", new DOMEventListenerScript(this._Docuemnt, "load"), false);
                    //this._Docuemnt.DomEvent += OnDomEvent;
                    //this._Window.DomEvent += OnDomEvent;
                }
                catch (Exception e)
                {

                    Debug.Print(e.ToString());
                }
               

                DocumentLoading?.Invoke(this, EventArgs.Empty);

            });
        }

        //private void OnDomEvent(object sender, RpcEventHandlerArgs e)
        //{
        //    switch (e.EventName)
        //    {
        //        case "readystatechange":
        //            {
        //                string state = this._Docuemnt.readyState;
        //                OnDocumentReadyStateChange(new DocumentReadyStateChangeEventArgs(this._Docuemnt, state));
        //            }
        //            break;

        //    }
        //}

        protected virtual void OnDomContentLoaded(DOMContentLoadedEventArgs e)
        {


            DOMContentLoaded?.Invoke(this, e);
            UIDispatcher.UIThread.InvokeAsync(OnDocumentLoading);
        }

        protected virtual void OnWebResourceResponseReceived(WebResourceResponseReceivedEventArgs e)
        {
            WebResourceResponseReceived?.Invoke(this, e);
            CleanUpResponses(e);
        }


        protected virtual void OnBeforeEnvironmentCompleted(EnvironmentCompletedHandlerArgs e)
        {
            BeforeEnvironmentCompleted?.Invoke(this, e);
        }

        protected virtual void OnDownloadStarting(DownloadStartingEventArgs e)
        {
            DownloadStarting?.Invoke(this, e);
        }

        protected virtual void OnFrameCreated(FrameCreatedEventArgs e)
        {
            FrameCreated?.Invoke(this, e);
        }

        protected virtual void OnRasterizationScaleChanged(WebView2EventArgs e)
        {
            RasterizationScaleChanged?.Invoke(this, e);
        }

        protected virtual void OnScriptEvent(RpcEventHandlerArgs e)
        {
            ScriptEvent?.Invoke(this, e);
        }


        private void OnRpcEventIntern(object sender, RpcEventHandlerArgs e)
        {
            OnScriptEvent(e);
        }


        private void OnRasterizationScaleChangedIntern(object sender, WebView2EventArgs e)
        {
            OnRasterizationScaleChanged(e);
        }

        private void OnFrameCreatedIntern(object sender, FrameCreatedEventArgs e)
        {
            OnFrameCreated(e);
        }

        private void OnDownalodStartingIntern(object sender, DownloadStartingEventArgs e)
        {
            OnDownloadStarting(e);
        }

        private void WebResourceResponseReceivedIntern(object sender, WebResourceResponseReceivedEventArgs e)
        {
            OnWebResourceResponseReceived(e);
        }

        private void OnDOMContentLoadedIntern(object sender, DOMContentLoadedEventArgs e)
        {
            OnDomContentLoaded(e);
        }

        private void OnNewBrowserVersionAvailableIntern(object sender, WebView2EventArgs e)
        {
        }

        private void OnFrameNavigationCompletedIntern(object sender, NavigationCompletedEventArgs e)
        {
            OnFrameNavigationCompleted(e);
        }


        private void OnMoveFocusRequestedIntern(object sender, MoveFocusRequestedEventArgs e)
        {
            OnMoveFocusRequested(e);
        }

        private void OnLostFocusIntern(object sender, WebView2EventArgs e)
        {
            OnWebViewLostFocus(e);
        }

        private void OnGotFocusIntern(object sender, WebView2EventArgs e)
        {
            OnWebViewGotFocus(e);
        }

        private void OnZoomFactorChangedIntern(object sender, WebView2EventArgs e)
        {
            OnZoomFactorChanged(e);
        }

        private void OnPermissionRequestedIntern(object sender, PermissionRequestedEventArgs e)
        {
            OnPermissionRequested(e);
        }

        private void OnNewWindowRequestedIntern(object sender, NewWindowRequestedEventArgs e)
        {
            OnNewWindowRequested(e);
        }

        private void OnExecuteScriptCompletedIntern(object sender, ExecuteScriptCompletedEventArgs e)
        {
            OnExecuteScriptCompleted(e);
        }

        private void OnWebMessageReceivedIntern(object sender, WebMessageReceivedEventArgs e)
        {
            OnWebMessageReceived(e);
        }

        private void ScriptToExecuteOnDocumentCreatedCompletedIntern(object sender,
            AddScriptToExecuteOnDocumentCreatedCompletedEventArgs e)
        {
            OnScriptToExecuteOnDocumentCreatedCompleted(e);
        }

        private void OnWindowCloseRequestedIntern(object sender, WebView2EventArgs e)
        {
            OnWindowCloseRequested(e);
        }


        private void OnScriptDialogOpeningIntern(object sender, ScriptDialogOpeningEventArgs e)
        {
            OnScriptDialogOpening(e);
        }

        private void OnProcessFailedIntern(object sender, ProcessFailedEventArgs e)
        {
            if (e.ProcessFailedKind == ProcessFailedKind.BrowserProcessExited)
            {
                this.IsBrowserEnded = true;
            }

            OnProcessFailed(e);
        }

        private void OnFrameNavigationStartingIntern(object sender, NavigationStartingEventArgs e)
        {
            OnFrameNavigationStarting(e);
        }

        private void OnDocumentTitleChangedIntern(object sender, WebView2EventArgs e)
        {
            OnDocumentTitleChanged(e);
        }

        private void OnContainsFullScreenElementChangedIntern(object sender, WebView2EventArgs e)
        {
            OnContainsFullScreenElementChanged(e);
        }

        private void OnAcceleratorKeyPressedIntern(object sender, AcceleratorKeyPressedEventArgs e)
        {
            OnAcceleratorKeyPressed(e);
        }

        private void OnWebResourceRequestedIntern(object sender, WebResourceRequestedEventArgs e)
        {
            OnWebResourceRequested(e);
        }

        private void OnNavigationCompletedIntern(object sender, NavigationCompletedEventArgs e)
        {
            OnNavigationCompleted(e);
        }

        private void OnHistoryChangedIntern(object sender, WebView2EventArgs e)
        {
            OnHistoryChanged(e);
        }

        private void OnSourceChangedIntern(object sender, SourceChangedEventArgs e)
        {
            OnSourceChanged(e);
        }

        private void OnContentLoadingIntern(object sender, ContentLoadingEventArgs e)
        {
            OnContentLoading(e);
        }

        private void OnNavigationStartIntern(object sender, NavigationStartingEventArgs e)
        {
            OnNavigationStart(e);
        }

        private void BeforeDisposeWebView()
        {
            UnWireEvents(this._WebViewControl);
        }

        private bool _UnWireExecuted;

        private void UnWireEvents(WebView2Control control)
        {
            if (this._UnWireExecuted) return;

            if (control == null) return;
            control.Created -= OnWebWindowCreated;
            control.BeforeCreate -= OnWebWindowBeforeCreate;
            control.NavigateStart -= OnNavigationStartIntern;
            control.AcceleratorKeyPressed -= OnAcceleratorKeyPressedIntern;
            control.GotFocus -= OnGotFocusIntern;
            control.LostFocus -= OnLostFocusIntern;
            control.MoveFocusRequested -= OnMoveFocusRequestedIntern;
            control.ZoomFactorChanged -= OnZoomFactorChangedIntern;
            control.ContainsFullScreenElementChanged -= OnContainsFullScreenElementChangedIntern;

            control.NewWindowRequested -= OnNewWindowRequestedIntern;
            control.PermissionRequested -= OnPermissionRequestedIntern;
            control.DocumentTitleChanged -= OnDocumentTitleChangedIntern;
            control.FrameNavigationCompleted -= OnFrameNavigationCompletedIntern;
            control.FrameNavigationStarting -= OnFrameNavigationStartingIntern;
            control.ProcessFailed -= OnProcessFailedIntern;
            control.ScriptDialogOpening -= OnScriptDialogOpeningIntern;
            control.WebMessageReceived -= OnWebMessageReceivedIntern;
            control.ScriptToExecuteOnDocumentCreatedCompleted -= ScriptToExecuteOnDocumentCreatedCompletedIntern;

            control.WindowCloseRequested -= OnWindowCloseRequestedIntern;
            control.ExecuteScriptCompleted -= OnExecuteScriptCompletedIntern;
            control.WebResourceRequested -= OnWebResourceRequestedIntern;
            control.ContentLoading -= OnContentLoadingIntern;
            control.SourceChanged -= OnSourceChangedIntern;
            control.HistoryChanged -= OnHistoryChangedIntern;
            control.NavigationCompleted -= OnNavigationCompletedIntern;
            control.NewBrowserVersionAvailable -= OnNewBrowserVersionAvailableIntern;
            control.DOMContentLoaded -= OnDOMContentLoadedIntern;
            control.WebResourceResponseReceived -= WebResourceResponseReceivedIntern;
            control.DownloadStarting -= OnDownalodStartingIntern;
            control.FrameCreated -= OnFrameCreatedIntern;
            control.RasterizationScaleChanged -= OnRasterizationScaleChangedIntern;
            control.IsMutedChanged -= OnIsMutedChangedIntern;
            control.IsDocumentPlayingAudioChanged -= OnIsDocumentPlayingAudioChangedIntern;
            control.IsDefaultDownloadDialogOpenChanged -= OnIsDefaultDownloadDialogOpenChangedIntern;
            _UnWireExecuted = true;
        }

        private void WireEvents(WebView2Control control)
        {
            if (control == null) return;
            control.Created += OnWebWindowCreated;
            control.BeforeCreate += OnWebWindowBeforeCreate;
            control.NavigateStart += OnNavigationStartIntern;
            control.AcceleratorKeyPressed += OnAcceleratorKeyPressedIntern;
            control.GotFocus += OnGotFocusIntern;
            control.LostFocus += OnLostFocusIntern;
            control.MoveFocusRequested += OnMoveFocusRequestedIntern;
            control.ZoomFactorChanged += OnZoomFactorChangedIntern;
            control.ContainsFullScreenElementChanged += OnContainsFullScreenElementChangedIntern;

            control.NewWindowRequested += OnNewWindowRequestedIntern;
            control.PermissionRequested += OnPermissionRequestedIntern;
            control.DocumentTitleChanged += OnDocumentTitleChangedIntern;
            control.FrameNavigationCompleted += OnFrameNavigationCompletedIntern;
            control.FrameNavigationStarting += OnFrameNavigationStartingIntern;
            control.ProcessFailed += OnProcessFailedIntern;
            control.ScriptDialogOpening += OnScriptDialogOpeningIntern;
            control.WebMessageReceived += OnWebMessageReceivedIntern;
            control.ScriptToExecuteOnDocumentCreatedCompleted += ScriptToExecuteOnDocumentCreatedCompletedIntern;

            control.WindowCloseRequested += OnWindowCloseRequestedIntern;
            control.ExecuteScriptCompleted += OnExecuteScriptCompletedIntern;
            control.WebResourceRequested += OnWebResourceRequestedIntern;
            control.ContentLoading += OnContentLoadingIntern;
            control.SourceChanged += OnSourceChangedIntern;
            control.HistoryChanged += OnHistoryChangedIntern;
            control.NavigationCompleted += OnNavigationCompletedIntern;
            control.NewBrowserVersionAvailable += OnNewBrowserVersionAvailableIntern;
            control.DOMContentLoaded += OnDOMContentLoadedIntern;
            control.WebResourceResponseReceived += WebResourceResponseReceivedIntern;
            control.DownloadStarting += OnDownalodStartingIntern;
            control.FrameCreated += OnFrameCreatedIntern;
            control.RasterizationScaleChanged += OnRasterizationScaleChangedIntern;
            control.IsMutedChanged += OnIsMutedChangedIntern;
            control.IsDocumentPlayingAudioChanged += OnIsDocumentPlayingAudioChangedIntern;
            control.IsDefaultDownloadDialogOpenChanged += OnIsDefaultDownloadDialogOpenChangedIntern;
        }

        private void OnIsDefaultDownloadDialogOpenChangedIntern(object sender, WebView2EventArgs e)
        {
            OnIsDefaultDownloadDialogOpenChanged(e);
        }

        private void OnIsDocumentPlayingAudioChangedIntern(object sender, WebView2EventArgs e)
        {
            OnIsDocumentPlayingAudioChanged(e);
        }

        private void OnIsMutedChangedIntern(object sender, WebView2EventArgs e)
        {
            OnIsMutedChanged(e);
        }

        protected virtual void OnIsMutedChanged(WebView2EventArgs e)
        {
            IsMutedChanged?.Invoke(this, e);
        }

        protected virtual void OnIsDocumentPlayingAudioChanged(WebView2EventArgs e)
        {
            IsDocumentPlayingAudioChanged?.Invoke(this, e);
        }

        protected virtual void OnIsDefaultDownloadDialogOpenChanged(WebView2EventArgs e)
        {
            IsDefaultDownloadDialogOpenChanged?.Invoke(this, e);
        }

        protected virtual void OnDocumentReadyStateChange(DocumentReadyStateChangeEventArgs e)
        {
            DocumentReadyStateChange?.Invoke(this, e);
        }
    }
}