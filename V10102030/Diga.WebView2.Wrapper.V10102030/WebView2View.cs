﻿using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.EventArguments;
using Diga.WebView2.Wrapper.Handler;
using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Diga.WebView2.Wrapper.Delegates;
using Diga.WebView2.Wrapper.Types;

// ReSharper disable once CheckNamespace
namespace Diga.WebView2.Wrapper
{
    public partial class WebView2View :WebView2View7Interface, IDisposable
    {

        public event EventHandler<NavigationStartingEventArgs> NavigationStarting;
        public event EventHandler<ContentLoadingEventArgs> ContentLoading;
        public event EventHandler<ExecuteScriptCompletedEventArgs> ExecuteScriptCompleted;
        public event EventHandler<SourceChangedEventArgs> SourceChanged;
        public event EventHandler<WebView2EventArgs> HistoryChanged;
        public event EventHandler<NavigationCompletedEventArgs> NavigationCompleted;
        public event EventHandler<WebView2EventArgs> ContainsFullScreenElementChanged;
        public event EventHandler<WebResourceRequestedEventArgs> WebResourceRequested;
        public event EventHandler<WebView2EventArgs> DocumentTitleChanged;
        public event EventHandler<NavigationCompletedEventArgs> FrameNavigationCompleted;
        public event EventHandler<NavigationStartingEventArgs> FrameNavigationStarting;
        public event EventHandler<NewWindowRequestedEventArgs> NewWindowRequested;
        public event EventHandler<PermissionRequestedEventArgs> PermissionRequested;
        public event EventHandler<ProcessFailedEventArgs> ProcessFailed;
        public event EventHandler<ScriptDialogOpeningEventArgs> ScriptDialogOpening;
        public event EventHandler<WebMessageReceivedEventArgs> WebMessageReceived;
        public event EventHandler<WebView2EventArgs> WindowCloseRequested;
        public event EventHandler<DOMContentLoadedEventArgs> DOMContentLoaded;
        public event EventHandler<WebResourceResponseReceivedEventArgs> WebResourceResponseReceived;
        public event EventHandler<AddScriptToExecuteOnDocumentCreatedCompletedEventArgs>
            ScriptToExecuteOnDocumentCreated;

        public event EventHandler<DownloadStartingEventArgs> DownloadStarting;
        public event EventHandler<FrameCreatedEventArgs> FrameCreated;
        public event EventHandler<ClientCertificateRequestedEventArgs> ClientCertificateRequested;

        public WebView2View(ICoreWebView2_7 webView):base(webView)
        {
            
            RegisterEvents();
        }

        
        private void RegisterEvents()
        {

            //add_ContainsFullScreenElementChanged
            ContainsFullScreenElementChangedEventHandler containsFullScreenElementChangedEventHandler =
                new ContainsFullScreenElementChangedEventHandler();
            containsFullScreenElementChangedEventHandler.ContainsFullScreenElementChanged +=
                OnContainsFullScreenElementChangedIntern;
            base.add_ContainsFullScreenElementChanged(containsFullScreenElementChangedEventHandler,
                out this._ContainsFullScreenElementChanged);

            //add_ContentLoading
            ContentLoadingEventHandler contentLoadingHandler = new ContentLoadingEventHandler();
            contentLoadingHandler.ContentLoading += OnContentLoadingIntern;
            base.add_ContentLoading(contentLoadingHandler, out this._ContentLoadingToken);

            //add_DocumentTitleChanged
            DocumentTitleChangedHandler documentTitleChangedHandler = new DocumentTitleChangedHandler();
            documentTitleChangedHandler.DocumentTitleChanged += OnDocumentTitleChangedIntern;
            base.add_DocumentTitleChanged(documentTitleChangedHandler, out this._DocumentTitleChangedToken);
            //add_DOMContentLoaded
            DOMContentLoadedEventHandler domContentLoadedHandler = new DOMContentLoadedEventHandler();
            domContentLoadedHandler.DOMContentLoaded += OnDOMContentLoadedIntern;
            base.add_DOMContentLoaded(domContentLoadedHandler, out this._DOMContentLoadedToken);

            //add_FrameNavigationCompleted
            NavigationCompletedEventHandler frameNavigationCompletedHandler = new NavigationCompletedEventHandler();
            frameNavigationCompletedHandler.NavigaionCompleted += OnFrameNavigationCompletedIntern;
            base.add_FrameNavigationCompleted(frameNavigationCompletedHandler,
                out this._FrameNavigationCompletedToken);

            //add_FrameNavigationStarting
            NavigationStartingEventHandler frameNavigationStarting = new NavigationStartingEventHandler();
            frameNavigationStarting.NavigationStarting += OnFrameNavigationStartingIntern;
            base.add_FrameNavigationStarting(frameNavigationStarting, out this._FrameNavigationStartingToken);

            //add_HistoryChanged
            HistoryChangedEventHandler historyChangedHandler = new HistoryChangedEventHandler();
            historyChangedHandler.HistoryChanged += OnHistoryChangedIntern;
            base.add_HistoryChanged(historyChangedHandler, out this._HistoryChangeToken);

            //add_NavigationCompleted
            NavigationCompletedEventHandler navigationCompletedHandler = new NavigationCompletedEventHandler();
            navigationCompletedHandler.NavigaionCompleted += OnNavigationCompletedIntern;
            base.add_NavigationCompleted(navigationCompletedHandler,
                out this._NavigationCompletedToken);
            //add_NavigationStarting
            NavigationStartingEventHandler navigationStartingHandler = new NavigationStartingEventHandler();
            navigationStartingHandler.NavigationStarting += OnNavigationStartingIntern;
            base.add_NavigationStarting(navigationStartingHandler, out this._NavigationStartingToken);

            //add_NewWindowRequested
            NewWindowRequestedEventHandler newWindowRequested = new NewWindowRequestedEventHandler();
            newWindowRequested.NewWindowRequested += OnNewWindowRequestedIntern;
            base.add_NewWindowRequested(newWindowRequested, out this._NewWindowRequestedToken);

            //add_PermissionRequested
            PermissionRequestedEventHandler permissionRequestedHandler = new PermissionRequestedEventHandler();
            permissionRequestedHandler.PermissionRequested += OnPermissionRequestedIntern;
            base.add_PermissionRequested(permissionRequestedHandler, out this._PermissionRequestedToken);

            //add_ProcessFailed
            ProcessFailedEventHandler processFailedHandler = new ProcessFailedEventHandler();
            processFailedHandler.ProcessFailed += OnProcessFailedIntern;
            base.add_ProcessFailed(processFailedHandler, out this._ProcessFailedToken);

            //add_ScriptDialogOpening
            ScriptDialogOpeningEventHandler scriptDialogOpeningHandler = new ScriptDialogOpeningEventHandler();
            scriptDialogOpeningHandler.ScriptDialogOpening += OnScriptDialogOpeningIntern;
            base.add_ScriptDialogOpening(scriptDialogOpeningHandler, out this._ScriptDialogOpeningToken);

            //add_SourceChanged
            SourceChangedEventHandler sourceChangedHandler = new SourceChangedEventHandler();
            sourceChangedHandler.SourceChanged += OnSourceChangedIntern;
            base.add_SourceChanged(sourceChangedHandler, out this._SourceChangedToken);

            //add_WebMessageReceived
            WebMessageReceivedEventHandler webMessageReceivedHandler = new WebMessageReceivedEventHandler();
            webMessageReceivedHandler.WebMessageReceived += OnWebMessageReceivedIntern;
            base.add_WebMessageReceived(webMessageReceivedHandler, out this._WebMessageReceivedToken);

            //add_WebResourceRequested
            WebResourceRequestedEventHandler webResourceRequestedEventHandler = new WebResourceRequestedEventHandler();
            webResourceRequestedEventHandler.WebResourceRequested += OnWebResourceRequestedIntern;
            base.add_WebResourceRequested(webResourceRequestedEventHandler, out this._WebResourceRequested);

            //add_WebResourceResponseReceived
            WebResourceResponseReceivedEventHandler webResourceResponseReceivedHandler =
                new WebResourceResponseReceivedEventHandler();
            webResourceResponseReceivedHandler.WebResourceResponseReceived += WebResourceResponseReceivedIntern;
            base.add_WebResourceResponseReceived(webResourceResponseReceivedHandler,
                out this._WebResourceResponseReceivedToken);

            //add_WindowCloseRequested
            WindowCloseRequestedHandler windowCloseRequestedHandler = new WindowCloseRequestedHandler();
            windowCloseRequestedHandler.WindowCloseRequested += OnWindowCloseRequestedIntern;
            base.add_WindowCloseRequested(windowCloseRequestedHandler, out this._WindowCloseRequestedToken);
            //add_DownloadStarting
            DownloadStartingEventHandler downloadStartingHandler = new DownloadStartingEventHandler();
            downloadStartingHandler.DownloadStarting += OnDownloadStartingIntern;
            base.add_DownloadStarting(downloadStartingHandler, out this._DownloadStartingToken);
            //add_FrameCreated
            FrameCreatedEventHandler frameCreatedHandler = new FrameCreatedEventHandler();
            frameCreatedHandler.FrameCreated += OnFrameCreatedIntern;
            base.add_FrameCreated(frameCreatedHandler, out this._FrameCreatedToken);

            //add_ClientCertificateRequested
            ClientCertificateRequestedEventHandler certificateRequestedHandler =
                new ClientCertificateRequestedEventHandler();
            certificateRequestedHandler.CertificateRequested += OncertificateRequestedIntern;
            base.add_ClientCertificateRequested(certificateRequestedHandler, out this._CertificateRequestedToken);

        }

        private void OncertificateRequestedIntern(object sender, ClientCertificateRequestedEventArgs e)
        {
            OnClientCertificateRequested(e);
        }

        private void OnFrameCreatedIntern(object sender, FrameCreatedEventArgs e)
        {
            OnFrameCreated(e);
        }

        private void OnDownloadStartingIntern(object sender, DownloadStartingEventArgs e)
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

        private void OnFrameNavigationCompletedIntern(object sender, NavigationCompletedEventArgs e)
        {
            OnFrameNavigationCompleted(e);
        }

        private void OnWindowCloseRequestedIntern(object sender, WebView2EventArgs e)
        {
            OnWindowCloseRequested(e);


        }

        private void OnWebMessageReceivedIntern(object sender, WebMessageReceivedEventArgs e)
        {
            OnWebMessageReceived(e);
        }

        private void OnScriptDialogOpeningIntern(object sender, ScriptDialogOpeningEventArgs e)
        {
            OnScriptDialogOpening(e);
        }

        private void OnProcessFailedIntern(object sender, ProcessFailedEventArgs e)
        {
            OnProcessFailed(e);
        }

        private void OnPermissionRequestedIntern(object sender, PermissionRequestedEventArgs e)
        {
            OnPermissionRequested(e);
        }

        private void OnNewWindowRequestedIntern(object sender, NewWindowRequestedEventArgs e)
        {
            OnNewWindowRequested(e);
        }

        private void OnFrameNavigationStartingIntern(object sender, NavigationStartingEventArgs e)
        {
            OnFrameNavigationStarting(e);
        }

        private void OnDocumentTitleChangedIntern(object sender, WebView2EventArgs e)
        {
            OnDocumentTitleChanged(e);
        }

        private void OnWebResourceRequestedIntern(object sender, WebResourceRequestedEventArgs e)
        {
            OnWebResourceRequested(e);
        }

        private void OnContainsFullScreenElementChangedIntern(object sender, WebView2EventArgs e)
        {
            OnContainsFullScreenElementChanged(e);
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

        

        [HandleProcessCorruptedStateExceptions]
        private void UnRegisterEvents()
        {
            
            //if (this._WebView == null) return;
            try
            {
                
               EventRegistrationTool.UnWireToken(this._NavigationStartingToken, base.remove_NavigationStarting);
                
               EventRegistrationTool.UnWireToken(this._ContentLoadingToken,base.remove_ContentLoading);

               EventRegistrationTool.UnWireToken(this._SourceChangedToken, base.remove_SourceChanged);
                
               EventRegistrationTool.UnWireToken(this._HistoryChangeToken,base.remove_HistoryChanged);
                
               EventRegistrationTool.UnWireToken(this._NavigationCompletedToken,base.remove_NavigationCompleted);
                
               EventRegistrationTool.UnWireToken(this._ContainsFullScreenElementChanged,base.remove_ContainsFullScreenElementChanged);
                
               EventRegistrationTool.UnWireToken(this._WebResourceRequested,base.remove_WebResourceRequested);
                
               EventRegistrationTool.UnWireToken(this._DocumentTitleChangedToken,base.remove_DocumentTitleChanged);
                
               EventRegistrationTool.UnWireToken(this._FrameNavigationCompletedToken,base.remove_FrameNavigationCompleted);
                
               EventRegistrationTool.UnWireToken(this._FrameNavigationStartingToken,base.remove_FrameNavigationStarting);
                
               EventRegistrationTool.UnWireToken(this._NewWindowRequestedToken,base.remove_NewWindowRequested);
                
               EventRegistrationTool.UnWireToken(this._PermissionRequestedToken,base.remove_PermissionRequested);
                
               EventRegistrationTool.UnWireToken((this._ProcessFailedToken),base.remove_ProcessFailed);
                
               EventRegistrationTool.UnWireToken(this._ScriptDialogOpeningToken,base.remove_ScriptDialogOpening);
                
               EventRegistrationTool.UnWireToken(this._WebMessageReceivedToken,base.remove_WebMessageReceived);
                
               EventRegistrationTool.UnWireToken(this._WindowCloseRequestedToken,base.remove_WindowCloseRequested);
                
               EventRegistrationTool.UnWireToken(this._DOMContentLoadedToken,base.remove_DOMContentLoaded);
                
               EventRegistrationTool.UnWireToken(this._WebResourceResponseReceivedToken,base.remove_WebResourceResponseReceived);
                
                try
                {
                    EventRegistrationTool.UnWireToken(this._DownloadStartingToken,base.remove_DownloadStarting);
                }
                catch (Exception e)
                {
                    Debug.Print("WebView2View UnregisterEvents" + e.Message);
                }

                
                EventRegistrationTool.UnWireToken(this._FrameCreatedToken,base.remove_FrameCreated);
                
                try
                {
                    EventRegistrationTool.UnWireToken(this._CertificateRequestedToken,base.remove_ClientCertificateRequested);

                }
                catch (Exception e)
                {
                    Debug.Print("WebView2View UnregisterEvents => Exception:" + e.Message);
                }
                
            }
            catch (Exception e)
            {
                Debug.Print(e.ToString());
            }

        }

        private EventRegistrationToken _NavigationStartingToken;
        private EventRegistrationToken _ContentLoadingToken;
        private EventRegistrationToken _SourceChangedToken;
        private EventRegistrationToken _HistoryChangeToken;
        private EventRegistrationToken _NavigationCompletedToken;
        private EventRegistrationToken _ContainsFullScreenElementChanged;
        private EventRegistrationToken _WebResourceRequested;
        private EventRegistrationToken _DocumentTitleChangedToken;
        private EventRegistrationToken _FrameNavigationStartingToken;
        private EventRegistrationToken _NewWindowRequestedToken;
        private EventRegistrationToken _PermissionRequestedToken;
        private EventRegistrationToken _ProcessFailedToken;
        private EventRegistrationToken _ScriptDialogOpeningToken;
        private EventRegistrationToken _WebMessageReceivedToken;
        private EventRegistrationToken _WindowCloseRequestedToken;
        private EventRegistrationToken _FrameNavigationCompletedToken;
        private EventRegistrationToken _DOMContentLoadedToken;
        private EventRegistrationToken _WebResourceResponseReceivedToken;
        private EventRegistrationToken _DownloadStartingToken;
        private EventRegistrationToken _FrameCreatedToken;
        private EventRegistrationToken _CertificateRequestedToken;

        private void OnNavigationStartingIntern(object sender, NavigationStartingEventArgs e)
        {
            OnNavigationStarting(e);
        }


        new public WebView2Settings Settings => new WebView2Settings((ICoreWebView2Settings6)base.Settings);


        public void AddScriptToExecuteOnDocumentCreated(string javaScript)
        {
            AddScriptToExecuteOnDocumentCreatedCompletedHandler handler =
                new AddScriptToExecuteOnDocumentCreatedCompletedHandler();
            handler.ScriptExecuted += OnScriptToExecuteOnDocumentCreatedIntern;
            base.AddScriptToExecuteOnDocumentCreated(javaScript, handler);
        }

        private void OnScriptToExecuteOnDocumentCreatedIntern(object sender,
            AddScriptToExecuteOnDocumentCreatedCompletedEventArgs e)
        {
            OnScriptToExecuteOnDocumentCreated(e);
        }




        public void ExecuteScript(string javaScript)
        {
            ExecuteScriptCompletedHandler handler = new ExecuteScriptCompletedHandler();
            handler.ScriptCompleted += OnExecuteScriptCompletedIntern;
            base.ExecuteScript(javaScript, handler);
        }
        public async Task<bool> PrintToPdfAsync(string file, WebView2PrintSettings printSettings)
        {
            var source = new TaskCompletionSource<(int, int)>();
            var printToPdfDelegate = new PrintToPdfCompletedDelegate(source);
            base.PrintToPdf(file,printSettings, printToPdfDelegate);
            (int errorCode, int isSuccess) result = await source.Task;
            HRESULT hr = result.errorCode;
            if(hr != HRESULT.S_OK)
                throw Marshal.GetExceptionForHR(hr);
            return (CBOOL)result.isSuccess;
        }
        public async Task<string> ExecuteScriptAsync(string javaScript)
        {
            //if (this._WebView == null)
            //    throw new InvalidOperationException("Script control not Created!");
            var source = new TaskCompletionSource<(int, string)>();
            var executeScriptDelegate = new ExecuteScriptCompletedDelegate(source);
            base.ExecuteScript(javaScript, executeScriptDelegate);

            (int errorCode, string resultObjectAsJson) result = await source.Task;
            HRESULT resultCode = result.errorCode;
            if (resultCode != HRESULT.S_OK)
                throw Marshal.GetExceptionForHR(resultCode);
            return result.resultObjectAsJson;
        }

        public string InvokeScript(string javaScript, Action<string, int, string> actionToInvoke)
        {
            ExecuteScriptCompletedHandler handler = new ExecuteScriptCompletedHandler { ActionToInvoke = actionToInvoke };
            base.ExecuteScript(javaScript, handler);
            return handler.Id;
        }

        private void OnExecuteScriptCompletedIntern(object sender, ExecuteScriptCompletedEventArgs e)
        {
            OnExecuteScriptCompleted(e);
        }

        new public bool CanGoBack => new CBOOL(base.CanGoBack);

        new public bool CanGoForward => new CBOOL(base.CanGoForward);

        public async Task CapturePreviewAsync(Stream stream, ImageFormat imageFormat)
        {
            ManagedIStream ms = new ManagedIStream(stream);
            StreamWrapper sw = new StreamWrapper(ms);
            var source = new TaskCompletionSource<int>();
            CapturePreviewCompletedDelegate handler = new CapturePreviewCompletedDelegate(source);

            base.CapturePreview((COREWEBVIEW2_CAPTURE_PREVIEW_IMAGE_FORMAT)imageFormat, sw, handler);



            int hr = await source.Task;
            if (hr != HRESULT.S_OK)
            {
                throw Marshal.GetExceptionForHR(hr);
            }


        }

        public void AddRemoteObject(string name, ref object @object)
        {

            base.AddHostObjectToScript(name, ref @object);

        }


        public void RemoveRemoteObject(string name)
        {
            base.RemoveHostObjectFromScript(name);
        }

        

        new public bool ContainsFullScreenElement => new CBOOL(base.ContainsFullScreenElement);

        new public CookieManager CookieManager => new CookieManager(base.CookieManager);

        public void AddWebResourceRequestedFilter(string uri, ResourceContext context)
        {
            base.AddWebResourceRequestedFilter(uri, (COREWEBVIEW2_WEB_RESOURCE_CONTEXT)context);
        }


        public void RemoveWebResourceRequestedFilter(string uri, ResourceContext context)
        {
            base.RemoveWebResourceRequestedFilter(uri, (COREWEBVIEW2_WEB_RESOURCE_CONTEXT)context);
        }

        protected virtual void OnNavigationStarting(NavigationStartingEventArgs e)
        {
            NavigationStarting?.Invoke(this, e);
        }

        protected override void Dispose(bool dispose)
        {
            if (dispose)
            {
                UnRegisterEvents();
            }
            base.Dispose(dispose);
        }
       

        protected virtual void OnContentLoading(ContentLoadingEventArgs e)
        {
            ContentLoading?.Invoke(this, e);
        }

        protected virtual void OnExecuteScriptCompleted(ExecuteScriptCompletedEventArgs e)
        {
            ExecuteScriptCompleted?.Invoke(this, e);
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

        protected virtual void OnContainsFullScreenElementChanged(WebView2EventArgs e)
        {
            ContainsFullScreenElementChanged?.Invoke(this, e);
        }

        protected virtual void OnWebResourceRequested(WebResourceRequestedEventArgs e)
        {
            WebResourceRequested?.Invoke(this, e);
        }

        protected virtual void OnDocumentTitleChanged(WebView2EventArgs e)
        {
            DocumentTitleChanged?.Invoke(this, e);
        }

        protected virtual void OnFrameNavigationStarting(NavigationStartingEventArgs e)
        {
            FrameNavigationStarting?.Invoke(this, e);
        }

        protected virtual void OnNewWindowRequested(NewWindowRequestedEventArgs e)
        {
            NewWindowRequested?.Invoke(this, e);
        }

        protected virtual void OnPermissionRequested(PermissionRequestedEventArgs e)
        {
            PermissionRequested?.Invoke(this, e);
        }

        protected virtual void OnProcessFailed(ProcessFailedEventArgs e)
        {
            ProcessFailed?.Invoke(this, e);
        }

        protected virtual void OnScriptDialogOpening(ScriptDialogOpeningEventArgs e)
        {
            ScriptDialogOpening?.Invoke(this, e);
        }

        protected virtual void OnWebMessageReceived(WebMessageReceivedEventArgs e)
        {
            WebMessageReceived?.Invoke(this, e);
        }

        protected virtual void OnWindowCloseRequested(WebView2EventArgs e)
        {
            WindowCloseRequested?.Invoke(this, e);
        }

        protected virtual void OnScriptToExecuteOnDocumentCreated(
            AddScriptToExecuteOnDocumentCreatedCompletedEventArgs e)
        {
            ScriptToExecuteOnDocumentCreated?.Invoke(this, e);
        }

        protected virtual void OnFrameNavigationCompleted(NavigationCompletedEventArgs e)
        {
            FrameNavigationCompleted?.Invoke(this, e);
        }

        protected virtual void OnDomContentLoaded(DOMContentLoadedEventArgs e)
        {
            DOMContentLoaded?.Invoke(this, e);
        }

        protected virtual void OnWebResourceResponseReceived(WebResourceResponseReceivedEventArgs e)
        {
            WebResourceResponseReceived?.Invoke(this, e);
        }

        protected virtual void OnDownloadStarting(DownloadStartingEventArgs e)
        {
            DownloadStarting?.Invoke(this, e);
        }

        protected virtual void OnFrameCreated(FrameCreatedEventArgs e)
        {
            FrameCreated?.Invoke(this, e);
        }

        protected virtual void OnClientCertificateRequested(ClientCertificateRequestedEventArgs e)
        {
            ClientCertificateRequested?.Invoke(this, e);
        }
    }





}