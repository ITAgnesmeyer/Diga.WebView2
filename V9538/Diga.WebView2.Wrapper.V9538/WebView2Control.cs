﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.EventArguments;
using Diga.WebView2.Wrapper.Handler;
using Diga.WebView2.Wrapper.Types;


// ReSharper disable once CheckNamespace
namespace Diga.WebView2.Wrapper
{
    public class WebView2Control : IDisposable
    {
        public event EventHandler Created;
        public event EventHandler<BeforeCreateEventArgs> BeforeCreate;
        public event EventHandler<NavigationStartingEventArgs> NavigateStart;
        public event EventHandler<ContentLoadingEventArgs> ContentLoading;
        public event EventHandler<SourceChangedEventArgs> SourceChanged;
        public event EventHandler<WebView2EventArgs> HistoryChanged;
        public event EventHandler<NavigationCompletedEventArgs> NavigationCompleted;
        public event EventHandler<WebResourceRequestedEventArgs> WebResourceRequested;
        public event EventHandler<WebView2EventArgs> ContainsFullScreenElementChanged;
        public event EventHandler<AcceleratorKeyPressedEventArgs> AcceleratorKeyPressed;
        public event EventHandler<WebView2EventArgs> GotFocus;
        public event EventHandler<WebView2EventArgs> LostFocus;
        public event EventHandler<MoveFocusRequestedEventArgs> MoveFocusRequested;
        public event EventHandler<WebView2EventArgs> ZoomFactorChanged;
        public event EventHandler<WebView2EventArgs> DocumentTitleChanged;
        public event EventHandler<NewWindowRequestedEventArgs> NewWindowRequested;
        public event EventHandler<PermissionRequestedEventArgs> PermissionRequested;
        public event EventHandler<NavigationCompletedEventArgs> FrameNavigationCompleted;
        public event EventHandler<NavigationStartingEventArgs> FrameNavigationStarting;
        public event EventHandler<ExecuteScriptCompletedEventArgs> ExecuteScriptCompleted;
        public event EventHandler<ProcessFailedEventArgs> ProcessFailed;
        public event EventHandler<ScriptDialogOpeningEventArgs> ScriptDialogOpening;
        public event EventHandler<WebMessageReceivedEventArgs> WebMessageReceived;
        public event EventHandler<WebView2EventArgs> WindowCloseRequested;
        public event EventHandler<AddScriptToExecuteOnDocumentCreatedCompletedEventArgs>
            ScriptToExecuteOnDocumentCreatedCompleted;

        public event EventHandler<WebView2EventArgs> NewBrowserVersionAvailable;
        public event EventHandler<EnvironmentCompletedHandlerArgs> BeforeEnvironmentCompleted;
        private WebView2Settings _Settings;
        private string _BrowserInfo;
        private object HostHelper;
        private const string HostHelperName = "{60A417CA-F1AB-4307-801B-F96003F8938B} Host Object Helper";
        private Dictionary<string, object> _RemoteObjects = new Dictionary<string, object>();

        private WebView2Environment Environment { get; set; }
        public WebView2Control(IntPtr parentHandle) : this(parentHandle, string.Empty, string.Empty, string.Empty)
        {

        }
        public WebView2Control(IntPtr parentHandle, string browserExecutableFolder, string userDataFolder, string additionalBrowserArguments)
        {
            this.ParentHandle = parentHandle;
            this.BrowserExecutableFolder = browserExecutableFolder;
            this.UserDataFolder = userDataFolder;
            this.AdditionalBrowserArguments = additionalBrowserArguments;
            CreateWebView();
        }

        private IntPtr ParentHandle { get; }
        public string BrowserExecutableFolder { get; }
        public string UserDataFolder { get; }
        public string AdditionalBrowserArguments { get; }
        private void CreateWebView()
        {
            this.HostHelper = new HostObjectHelper();
            var handler = new EnvironmentCompletedHandler(this.ParentHandle);
            handler.ControllerCompleted += OnControllerCompleted;
            handler.BeforeEnvironmentCompleted += OnBeforeEnvironmentCompletedIntern;
            handler.AfterEnvironmentCompleted += OnAfterEnvironmentCompletedIntern;
            handler.PrepareControllerCreate += OnBeforeControllerCreateIntern;

            Native.GetAvailableCoreWebView2BrowserVersionString(this.BrowserExecutableFolder, out string browserInfo);
            this._BrowserInfo = browserInfo;

            //Native.CreateCoreWebView2EnvironmentWithDetails(this.BrowserExecutableFolder, this.UserDataFolder, this.AdditionalBrowserArguments, handler);
            WebView2EnvironmentOptions options = new WebView2EnvironmentOptions
            {
                AdditionalBrowserArguments = this.AdditionalBrowserArguments
            };

            Native.CreateCoreWebView2EnvironmentWithOptions(this.BrowserExecutableFolder, this.UserDataFolder, options,
                handler);

        }

        public string BrowserInfo => this._BrowserInfo;
        private void OnBeforeControllerCreateIntern(object sender, BeforeControllerCreateEventArgs e)
        {
            OnBeforeCreate(new BeforeCreateEventArgs(e.Settings));
        }

        private void OnAfterEnvironmentCompletedIntern(object sender, EnvironmentCompletedHandlerArgs e)
        {
            this.Environment = e.Environment;
            this.Environment.NewBrowserVersionAvailable += OnNewBrowserVersionAvailableIntern;
        }

        private void OnNewBrowserVersionAvailableIntern(object sender, WebView2EventArgs e)
        {
            OnNewBrowserVersionAvailable(e);
        }

        private void OnBeforeEnvironmentCompletedIntern(object sender, EnvironmentCompletedHandlerArgs e)
        {
            OnBeforeEnvironmentCompleted(e);
        }

        private void OnControllerCompleted(object sender, ControllerCompletedArgs e)
        {
            this.Controller = new WebView2Controller(e.Controller);
            this.Controller.AcceleratorKeyPressed += OnAcceleratorKeyPressedIntern;
            this.Controller.GotFocus += OnGotFocusIntern;
            this.Controller.LostFocus += OnLostFocusIntern;
            this.Controller.MoveFocusRequested += OnMoveFocusRequestedIntern;
            this.Controller.ZoomFactorChanged += OnZoomFactorChangedIntern;

            this.WebView = new WebView2View(e.WebView);
            this.WebView.NavigationStarting += OnNavigateStartIntern;
            this.WebView.ContentLoading += OnContentLoadingIntern;
            this.WebView.SourceChanged += OnSourceChangedInternal;
            this.WebView.HistoryChanged += OnHistoryChangedInternal;
            this.WebView.NavigationCompleted += OnNavigationCompletedIntern;
            this.WebView.WebResourceRequested += OnWebResourceRequestedIntern;
            this.WebView.ContainsFullScreenElementChanged += OnContainsFullScreenElementChangedIntern;
            this.WebView.DocumentTitleChanged += OnDocumentTitleChangedIntern;
            this.WebView.NewWindowRequested += OnNewWindowRequestedIntern;
            this.WebView.PermissionRequested += OnPermissionRequestedIntern;
            this.WebView.FrameNavigationCompleted += OnFrameNavigationCompletedIntern;
            this.WebView.FrameNavigationStarting += OnFrameNavigationStartingIntern;
            this.WebView.ExecuteScriptCompleted += OnExecuteScriptCompletedIntern;
            this.WebView.ProcessFailed += OnProcessFailedIntern;
            this.WebView.ScriptDialogOpening += OnScriptDialogOpeningIntern;
            this.WebView.WebMessageReceived += OnWebMessageReceivedIntern;
            this.WebView.WindowCloseRequested += OnWindowCloseRequestedIntern;
            this.WebView.ScriptToExecuteOnDocumentCreated += OnScriptToExecuteOnDocumentCreatedIntern;

            this._Settings = new WebView2Settings(this.WebView.Settings);
            this.WebView.AddRemoteObject(HostHelperName,ref this.HostHelper);
            
            OnCreated();
        }

        private void UnWireEvents()
        {
            if (this.Environment != null)
            {
                this.Environment.NewBrowserVersionAvailable -= OnNewBrowserVersionAvailableIntern;
            }
            if (this.Controller != null)
            {
                this.Controller.AcceleratorKeyPressed -= OnAcceleratorKeyPressedIntern;
                this.Controller.GotFocus -= OnGotFocusIntern;
                this.Controller.LostFocus -= OnLostFocusIntern;
                this.Controller.MoveFocusRequested -= OnMoveFocusRequestedIntern;
                this.Controller.ZoomFactorChanged -= OnZoomFactorChangedIntern;

            }

            if (this.WebView != null)
            {
                this.WebView.NavigationStarting -= OnNavigateStartIntern;
                this.WebView.ContentLoading -= OnContentLoadingIntern;
                this.WebView.SourceChanged -= OnSourceChangedInternal;
                this.WebView.HistoryChanged -= OnHistoryChangedInternal;
                this.WebView.NavigationCompleted -= OnNavigationCompletedIntern;
                this.WebView.WebResourceRequested -= OnWebResourceRequestedIntern;
                this.WebView.ContainsFullScreenElementChanged -= OnContainsFullScreenElementChangedIntern;
                this.WebView.DocumentTitleChanged -= OnDocumentTitleChangedIntern;
                this.WebView.NewWindowRequested -= OnNewWindowRequestedIntern;
                this.WebView.PermissionRequested -= OnPermissionRequestedIntern;
                this.WebView.FrameNavigationCompleted -= OnFrameNavigationCompletedIntern;
                this.WebView.FrameNavigationStarting -= OnFrameNavigationStartingIntern;
                this.WebView.ExecuteScriptCompleted -= OnExecuteScriptCompletedIntern;
                this.WebView.ProcessFailed -= OnProcessFailedIntern;
                this.WebView.ScriptDialogOpening -= OnScriptDialogOpeningIntern;
                this.WebView.WebMessageReceived -= OnWebMessageReceivedIntern;
                this.WebView.WindowCloseRequested -= OnWindowCloseRequestedIntern;
                this.WebView.ScriptToExecuteOnDocumentCreated -= OnScriptToExecuteOnDocumentCreatedIntern;

            }
        }
        private void OnFrameNavigationCompletedIntern(object sender, NavigationCompletedEventArgs e)
        {
            OnFrameNavigationCompleted(e);
        }

        private void OnZoomFactorChangedIntern(object sender, WebView2EventArgs e)
        {

            OnZoomFactorChanged(e);
        }

        private void OnScriptToExecuteOnDocumentCreatedIntern(object sender, AddScriptToExecuteOnDocumentCreatedCompletedEventArgs e)
        {
            OnScriptToExecuteOnDocumentCreatedCompleted(e);
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

        private void OnExecuteScriptCompletedIntern(object sender, ExecuteScriptCompletedEventArgs e)
        {
            OnExecuteScriptCompleted(e);

        }

        private void OnFrameNavigationStartingIntern(object sender, NavigationStartingEventArgs e)
        {
            OnFrameNavigationStarting(e);
        }

        private void OnPermissionRequestedIntern(object sender, PermissionRequestedEventArgs e)
        {
            OnPermissionRequested(e);
        }

        private void OnNewWindowRequestedIntern(object sender, NewWindowRequestedEventArgs e)
        {
            OnNewWindowRequested(e);
        }

        private void OnDocumentTitleChangedIntern(object sender, WebView2EventArgs e)
        {
            OnDocumentTitleChanged(e);
        }

        private void OnContainsFullScreenElementChangedIntern(object sender, WebView2EventArgs e)
        {
            OnContainsFullScreenElementChanged(e);
        }

        private void OnMoveFocusRequestedIntern(object sender, MoveFocusRequestedEventArgs e)
        {
            OnMoveFocusRequested(e);
        }

        private void OnLostFocusIntern(object sender, WebView2EventArgs e)
        {
            OnLostFocus(e);
        }

        private void OnGotFocusIntern(object sender, WebView2EventArgs e)
        {
            OnGotFocus(e);
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

        private void OnHistoryChangedInternal(object sender, WebView2EventArgs e)
        {
            OnHistoryChanged(e);
        }

        private void OnSourceChangedInternal(object sender, SourceChangedEventArgs e)
        {
            OnSourceChanged(e);
        }

        private void OnContentLoadingIntern(object sender, ContentLoadingEventArgs e)
        {
            OnContentLoading(e);
        }

        private void OnNavigateStartIntern(object sender, NavigationStartingEventArgs e)
        {
            OnNavigateStart(e);
        }

        private WebView2View WebView
        {
            get;
            set;
        }

        private WebView2Controller Controller { get; set; }

        public void DockToParent()
        {
            tagRECT rect;
            Native.GetClientRect(this.ParentHandle, out rect);
            this.Controller.Bounds = rect;
        }

        public void Navigate(string url)
        {

            this.WebView.Navigate(url);


        }

        public void NavigateToString(string htmlContent)
        {
            this.WebView.NavigateToString(htmlContent);

        }

        public void GoBack()
        {
            this.WebView.GoBack();

        }

        public void GoForward()
        {
            this.WebView.GoForward();

        }

        public void Close()
        {
            this.Controller.Close();
        }
        public void Reload()
        {
            this.WebView.Reload();
        }
        public bool CanGoBack => this.WebView.CanGoBack;
        public bool CanGoForward => this.WebView.CanGoForward;
        public string DocumentTitle => this.WebView.DocumentTitle;
        public WebView2Settings Settings => this._Settings;

        public string Source => this.WebView.Source;

        public void CleanupControls()
        {
           

            while (this._RemoteObjects.Count > 0)
            {
                var keyValue = this._RemoteObjects.ElementAt(0);
                this.RemoveRemoteObject(keyValue.Key);
            }
                
            
            this.Controller?.Dispose();
            this.Environment?.Dispose();
            this.WebView?.Dispose();
        }
        public void Dispose()
        {
            UnWireEvents();
        }

        protected virtual void OnCreated()
        {
            Created?.Invoke(this, EventArgs.Empty);

        }

        protected virtual void OnBeforeCreate(BeforeCreateEventArgs e)
        {
            BeforeCreate?.Invoke(this, e);
        }

        protected virtual void OnNavigateStart(NavigationStartingEventArgs e)
        {
            NavigateStart?.Invoke(this, e);
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

        protected virtual void OnWebResourceRequested(WebResourceRequestedEventArgs e)
        {
            WebResourceRequested?.Invoke(this, e);
        }

        public WebResourceResponse GetResponseStream(Stream stream, int statusCode, string statusText, string headers,
            string contentType)
        {
            ManagedIStream mStream = new ManagedIStream(stream);


            var responseInterface =
                this.Environment.CreateWebResourceResponse(mStream, statusCode, statusText, headers);
            WebResourceResponse wrapper = new WebResourceResponse(responseInterface);
            return wrapper;
        }

        public void OpenDevToolsWindow()
        {
            this.WebView.OpenDevToolsWindow();
        }


        protected virtual void OnAcceleratorKeyPressed(AcceleratorKeyPressedEventArgs e)
        {
            AcceleratorKeyPressed?.Invoke(this, e);
        }

        protected virtual void OnGotFocus(WebView2EventArgs e)
        {
            GotFocus?.Invoke(this, e);
        }

        protected virtual void OnLostFocus(WebView2EventArgs e)
        {
            LostFocus?.Invoke(this, e);
        }

        protected virtual void OnMoveFocusRequested(MoveFocusRequestedEventArgs e)
        {
            MoveFocusRequested?.Invoke(this, e);
        }

        protected virtual void OnZoomFactorChanged(WebView2EventArgs e)
        {
            ZoomFactorChanged?.Invoke(this, e);
        }

        protected virtual void OnContainsFullScreenElementChanged(WebView2EventArgs e)
        {
            ContainsFullScreenElementChanged?.Invoke(this, e);
        }

        protected virtual void OnDocumentTitleChanged(WebView2EventArgs e)
        {
            DocumentTitleChanged?.Invoke(this, e);
        }

        protected virtual void OnNewWindowRequested(NewWindowRequestedEventArgs e)
        {
            NewWindowRequested?.Invoke(this, e);
        }

        protected virtual void OnPermissionRequested(PermissionRequestedEventArgs e)
        {
            PermissionRequested?.Invoke(this, e);
        }

        protected virtual void OnFrameNavigationStarting(NavigationStartingEventArgs e)
        {
            FrameNavigationStarting?.Invoke(this, e);
        }

        protected virtual void OnExecuteScriptCompleted(ExecuteScriptCompletedEventArgs e)
        {
            ExecuteScriptCompleted?.Invoke(this, e);
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

        public void AddScriptToExecuteOnDocumentCreated(string javaScript)
        {
            this.WebView.AddScriptToExecuteOnDocumentCreated(javaScript);
        }

        public void PostWebMessageAsJson(string webMessageAsJson)
        {
            this.WebView.PostWebMessageAsJson(webMessageAsJson);
        }

        public void PostWebMessageAsString(string webMessageAsString)
        {
            this.WebView.PostWebMessageAsString(webMessageAsString);
        }
        
        public void AddRemoteObject(string name, object obj)
        {
            if (string.IsNullOrEmpty(name))
                throw new ArgumentException("Name cannot be empty");

            if(name == HostHelperName)
                throw new InvalidOperationException($"The object({name}) already exists");
            try
            {
                IntPtr pdisp = Marshal.GetIDispatchForObject(obj);

                // If we got here without throwing an exception, the QI for IDispatch succeeded.
                Marshal.Release(pdisp);
            }
            catch (PlatformNotSupportedException e)
            {
                Debug.Print(e.Message);
            }
            catch (Exception ex)
            {
                throw new InvalidComObjectException("This object does not implement the interface IDispatch", ex);
            }

            if (this._RemoteObjects.ContainsKey(name))
                throw new InvalidOperationException($"The object({name}) already exists");
            object localObject = obj;
            this._RemoteObjects.Add(name, localObject);
            this.WebView.AddRemoteObject(name, ref localObject);

        }

        public void RemoveRemoteObject(string name)
        {
            if (this._RemoteObjects.ContainsKey(name))
                this._RemoteObjects.Remove(name);
            else
            {
                throw new KeyNotFoundException($"Cannot find RemoteObject({name})");
            }
            try
            {
                this.WebView.RemoveRemoteObject(name);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        public void ExecuteScript(string javaScript)
        {
            this.WebView.ExecuteScript(javaScript);
        }

        public async Task<string> ExecuteScriptAsync(string javaScript)
        {
            return await this.WebView.ExecuteScriptAsync(javaScript);
        }

        public string InvokeScript(string javaScript, Action<string, int, string> actionToInvoke)
        {
            return this.WebView.InvokeScript(javaScript, actionToInvoke);
        }


        public async Task CapturePreviewAsync(Stream stream, ImageFormat imageFormat)
        {
            await this.WebView.CapturePreviewAsync(stream, imageFormat);
        }
        protected virtual void OnScriptToExecuteOnDocumentCreatedCompleted(AddScriptToExecuteOnDocumentCreatedCompletedEventArgs e)
        {
            ScriptToExecuteOnDocumentCreatedCompleted?.Invoke(this, e);
        }

        protected virtual void OnFrameNavigationCompleted(NavigationCompletedEventArgs e)
        {
            FrameNavigationCompleted?.Invoke(this, e);
        }

        protected virtual void OnNewBrowserVersionAvailable(WebView2EventArgs e)
        {
            NewBrowserVersionAvailable?.Invoke(this, e);
        }

        protected virtual void OnBeforeEnvironmentCompleted(EnvironmentCompletedHandlerArgs e)
        {
            BeforeEnvironmentCompleted?.Invoke(this, e);
        }
    }
}