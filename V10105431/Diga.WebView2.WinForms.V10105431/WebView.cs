using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Diga.WebView2.WinForms.Scripting;
using Diga.WebView2.WinForms.Scripting.DOM;
using Diga.WebView2.Wrapper;
using Diga.WebView2.Wrapper.EventArguments;
using MimeTypeExtension;



namespace Diga.WebView2.WinForms
{

    // ReSharper disable once ClassWithVirtualMembersNeverInherited.Global
    public partial class WebView : UserControl
    {
        private RpcHandler _RpcHandler;

        private const string JAVASCRIPT_CANNOT_BE_NULL_OR_EMPTY = "javaScript cannot be NULL or empty";
        private WebView2Control _WebViewControl;
        private bool _DefaultContextMenusEnabled;
        private string _Url;
        private bool _DefaultScriptDialogsEnabled = true;
        private bool _DevToolsEnabled = true;

        private bool _RemoteObjectsAllowed = true;
        private bool _IsZoomControlEnabled = true;

        private bool _IsScriptEnabled = true;

        private bool _IsStatusBarEnabled;
        private bool _IsWebMessageEnabled = true;

        private string _HtmlContent;
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
        [Editor(typeof(FolderNameEditor), typeof(System.Drawing.Design.UITypeEditor))]
        public string MonitoringFolder { get; set; }
        public string MonitoringUrl { get; set; }
        public bool EnableMonitoring { get; set; }
        public string HtmlContent
        {
            get => _HtmlContent;
            set => this.NavigateToString(value);
        }

        public bool IsZoomControlEnabled
        {
            get => _IsZoomControlEnabled;
            set
            {
                _IsZoomControlEnabled = value;
                if (this.CheckIsCreatedOrEnded)
                {
                    this._WebViewControl.Settings.IsZoomControlEnabled = value;
                }
            }
        }

        private bool _AreBrowserAcceleratorKeysEnabled = true;
        private bool _IsGeneralAutoFillEnabled;
        private bool _IsPasswordAutosaveEnabled;

        public bool IsPasswordAutosaveEnabled
        {
            get => this._IsPasswordAutosaveEnabled;
            set
            {
                this._IsPasswordAutosaveEnabled = value;
                if (this.CheckIsCreatedOrEnded)
                {
                    this._WebViewControl.Settings.IsPasswordAutosaveEnabled = value;
                }
            }
        }

        public bool IsGeneralAutoFillEnabled
        {
            get => this._IsGeneralAutoFillEnabled;
            set
            {
                this._IsGeneralAutoFillEnabled = value;
                if (this.CheckIsCreatedOrEnded)
                {
                    if (this._WebViewControl.Settings != null)
                        this._WebViewControl.Settings.IsGeneralAutofillEnabled = value;
                }
            }
        }

        public bool AreBrowserAcceleratorKeysEnabled
        {
            get => this._AreBrowserAcceleratorKeysEnabled;
            set
            {
                this._AreBrowserAcceleratorKeysEnabled = value;
                if (this.CheckIsCreatedOrEnded)
                    this._WebViewControl.Settings.AreBrowserAcceleratorKeysEnabled = value;
            }
        }
        public bool IsWebMessageEnabled
        {
            get => _IsWebMessageEnabled;
            set
            {
                _IsWebMessageEnabled = value;
                if (this.CheckIsCreatedOrEnded)
                {
                    this._WebViewControl.Settings.IsWebMessageEnabled = value;
                }
            }
        }

        public bool IsStatusBarEnabled
        {
            get => _IsStatusBarEnabled;
            set
            {
                _IsStatusBarEnabled = value;
                if (this.CheckIsCreatedOrEnded)
                {
                    this._WebViewControl.Settings.IsStatusBarEnabled = value;
                }
            }
        }

        public bool IsScriptEnabled
        {
            get => _IsScriptEnabled;
            set
            {
                _IsScriptEnabled = value;
                if (this.CheckIsCreatedOrEnded)
                {
                    this._WebViewControl.Settings.IsScriptEnabled = value;
                }
            }
        }

        public bool RemoteObjectsAllowed
        {
            get => _RemoteObjectsAllowed;

            set
            {
                _RemoteObjectsAllowed = value;
                if (this.CheckIsCreatedOrEnded)
                {
                    this._WebViewControl.Settings.AreHostObjectsAllowed = value;
                }
            }
        }

        [Browsable(false)]
        public bool IsCreated { get; private set; }

        [Browsable(false)]
        public bool IsBrowserEnded { get; private set; }

        public bool DevToolsEnabled
        {
            get => _DevToolsEnabled;
            set
            {
                _DevToolsEnabled = value;
                if (this.CheckIsCreatedOrEnded)
                {
                    this._WebViewControl.Settings.AreDevToolsEnabled = value;
                }
            }
        }

        public bool DefaultScriptDialogsEnabled
        {
            get => _DefaultScriptDialogsEnabled;
            set
            {
                _DefaultScriptDialogsEnabled = value;
                if (this.CheckIsCreatedOrEnded)
                {
                    this._WebViewControl.Settings.AreDefaultScriptDialogsEnabled = value;
                }
            }
        }
        public bool DefaultContextMenusEnabled
        {
            get => _DefaultContextMenusEnabled;
            set
            {
                _DefaultContextMenusEnabled = value;
                if (this.CheckIsCreatedOrEnded)
                {
                    this._WebViewControl.Settings.AreDefaultContextMenusEnabled = value;
                }
            }
        }

        private double _ZoomFactor;
        public double ZoomFactor
        {
            get
            {
                if (this.CheckIsCreatedOrEnded)
                {
                    this._ZoomFactor = this._WebViewControl.ZoomFactor;
                }
                return _ZoomFactor;
            }
            set
            {
                this._ZoomFactor = value;
                if (this.CheckIsCreatedOrEnded)
                {
                    this._WebViewControl.ZoomFactor = this._ZoomFactor;
                }
            }
        }

        public WebView()
        {
            this._RpcHandler = new RpcHandler();
            this._RpcHandler.RpcEvent += OnRpcEventIntern;
            InitializeComponent();
            
        }

        private void OnRpcEventIntern(object sender, RpcEventHandlerArgs e)
        {
            OnScriptEvent(e);
        }

        public string Source
        {
            get
            {
                if (this.CheckIsCreatedOrEnded)
                {
                    return this._WebViewControl.Source;
                }

                return "";
            }
        }

        public CookieManager GetCookieManager
        {
            get
            {
                if (this.CheckIsCreatedOrEnded)
                    return this._WebViewControl.GetCookieManager;
                return null;

            }


        }
        public async Task<Image> CapturePreviewAsImageAsync(ImageFormat imageFormat)
        {
            using (var stream = new MemoryStream())
            {
                await this._WebViewControl.CapturePreviewAsync(stream, imageFormat);
                var retImage = Image.FromStream(stream);
                return retImage;
            }
        }

        private void OnWebWindowBeforeCreate(object sender, BeforeCreateEventArgs e)
        {
            e.Settings.AreBrowserAcceleratorKeysEnabled = this._AreBrowserAcceleratorKeysEnabled;
            e.Settings.AreDefaultContextMenusEnabled = this._DefaultContextMenusEnabled;
            e.Settings.AreDefaultScriptDialogsEnabled = this._DefaultScriptDialogsEnabled;
            e.Settings.AreDevToolsEnabled = this._DevToolsEnabled;
            e.Settings.AreHostObjectsAllowed = this._RemoteObjectsAllowed;
            e.Settings.IsGeneralAutofillEnabled = this._IsGeneralAutoFillEnabled;
            e.Settings.IsPasswordAutosaveEnabled = this._IsPasswordAutosaveEnabled;
            e.Settings.IsScriptEnabled = this._IsScriptEnabled;
            e.Settings.IsStatusBarEnabled = this._IsStatusBarEnabled;
            e.Settings.IsWebMessageEnabled = this._IsWebMessageEnabled;
            e.Settings.IsZoomControlEnabled = this._IsZoomControlEnabled;
            e.Settings.IsBuiltInErrorPageEnabled = true;
            e.Settings.IsPinchZoomEnabled = true;


        }

        private void OnWebWindowCreated(object sender, EventArgs e)
        {
            this.IsCreated = true;
            this.AddRemoteObject("RpcHandler",this._RpcHandler);
            this.AddScriptToExecuteOnDocumentCreated("class ScriptErrorObject{constructor(e,t,r,n,i,c){this.name=e,this.message=t,this.fileName=r,this.lineNumber=n,this.columnNumber=i,this.stack=c}}window.external={sendMessage:function(e){window.chrome.webview.postMessage(e)},receiveMessage:function(e){window.chrome.webview.addEventListener(\"message\",(function(t){e(t.data)}))},evalScript:function(e){try{return eval(e)}catch(e){let t=new ScriptErrorObject(e.name,e.message,e.fileName,e.lineNumber,e.columnNumber,e.stack);return JSON.stringify(t)}},executeScript:function(e){try{return new Function(e)()}catch(e){let t=new ScriptErrorObject(e.name,e.message,e.fileName,e.lineNumber,e.columnNumber,e.stack);return JSON.stringify(t)}}};");
            this.AddScriptToExecuteOnDocumentCreated("window.external.raiseRpcEvent= async function(action, obj) { try {const varToString = varObj => Object.keys(varObj)[0]; const rpcHandler = window.chrome.webview.hostObjects.RpcHandler;const rpcObj = await rpcHandler.GetNewRpc();rpcObj.objId = obj.id;rpcObj.action = action;rpcObj.varname=varToString({obj}); rpcObj.param = \"empty\";rpcObj.item=document.getElementById(obj.id);let r = await rpcHandler.Handle(await rpcObj.id, await rpcObj.action, rpcObj);let b = await rpcHandler.ReleaseObject(rpcObj); } catch (e) { alert(e); } }");

            //"window.external = { sendMessage: function(message) { window.chrome.webview.postMessage(message); }, receiveMessage: function(callback) { window.chrome.webview.addEventListener('message', function(e) { callback(e.data); }); } };");
            if (this._DefaultBackgroundColor != Color.Empty)
                this._WebViewControl.DefaultBackgroundColor = _DefaultBackgroundColor;
            if (!string.IsNullOrEmpty(this._Url))
                this.Navigate(this.Url);
            if (!string.IsNullOrEmpty(this._HtmlContent))
                this.NavigateToString(this._HtmlContent);
            if (this._ZoomFactor != 0)
                this.ZoomFactor = this._ZoomFactor;

            OnWebViewCreated();

        }

        private bool CheckIsCreatedOrEnded
        {
            get
            {
                if (!this.IsCreated) return false;
                if (this.IsBrowserEnded) return false;
                return true;
            }
        }
        public void Navigate(string url)
        {
            this._Url = url;
            if (this.CheckIsCreatedOrEnded && !string.IsNullOrEmpty(this.Url))
            {
                try
                {
                    this._WebViewControl.Navigate(this._Url);
                }
                catch (Exception e)
                {
                    MessageBox.Show(this, e.Message, @"Navigation Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }

        }

        public void NavigateToString(string htmlContent)
        {
            _HtmlContent = htmlContent;
            if (this.CheckIsCreatedOrEnded && !string.IsNullOrEmpty(this._HtmlContent))
            {
                try
                {
                    this._WebViewControl.NavigateToString(_HtmlContent);
                }
                catch (Exception e)
                {
                    MessageBox.Show(owner: this, e.Message, @"Navigation Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
        public string Url
        {
            get => _Url;
            set
            {
                _Url = value;
                if (this.CheckIsCreatedOrEnded)
                {
                    this.Navigate(value);
                }
            }
        }

        public void GoBack()
        {
            if (!this.CheckIsCreatedOrEnded) return;
            if (this._WebViewControl.CanGoBack)
                this._WebViewControl.GoBack();
        }

        public void GoForward()
        {
            if (!this.CheckIsCreatedOrEnded) return;
            if (this._WebViewControl.CanGoForward)
                this._WebViewControl.GoForward();


        }
        public void AddScriptToExecuteOnDocumentCreated(string javaScript)
        {
            if (!this.CheckIsCreatedOrEnded) return;
            this._WebViewControl.AddScriptToExecuteOnDocumentCreated(javaScript);

        }

        public void SendMessage(string message)
        {
            this._WebViewControl.PostWebMessageAsString(message);
        }
        public void PostWebMessageAsJson(string webMessageAsJson)
        {
            this._WebViewControl.PostWebMessageAsJson(webMessageAsJson);

        }

        public void PostWebMessageAsString(string webMessageAsString)
        {
            this._WebViewControl.PostWebMessageAsString(webMessageAsString);
        }

        public void AddRemoteObject(string name, object @object)
        {
            if (!this.CheckIsCreatedOrEnded) return;
            this._WebViewControl.AddRemoteObject(name, @object);
        }

        public void Reload()
        {
            this._WebViewControl.Reload();
        }
        public void RemoveRemoteObject(string name)
        {
            this._WebViewControl.RemoveRemoteObject(name);
        }
#pragma warning disable CA2208

        private static void ScriptZeroTest(string javaScript)
        {
            if (string.IsNullOrEmpty(javaScript))
                throw new ArgumentNullException(JAVASCRIPT_CANNOT_BE_NULL_OR_EMPTY);

        }
#pragma warning restore CA2208
        public void ExecuteScript(string javaScript)
        {
            if (!this.CheckIsCreatedOrEnded)
                return;

            ScriptZeroTest(javaScript);

            string scrptToExecute = $"window.external.executeScript(\"{{{javaScript.Replace("\"", "\\'")}}}\")";
            this._WebViewControl.ExecuteScript(scrptToExecute);
        }
        public void EvalScript(string javaScript)
        {
            if (!this.CheckIsCreatedOrEnded) return;

            ScriptZeroTest(javaScript);

            string scriptToExecute = $"window.external.evalScript(\"{javaScript.Replace("\"", "\\'")}\")";
            this._WebViewControl.ExecuteScript(scriptToExecute);
        }
        /// <summary>
        /// Evaluate script async with Exception Check
        /// </summary>
        /// <remarks>
        /// For exception check the added Function window.external.evalScript will bie executed
        /// </remarks>
        /// <param name="javaScript"></param>
        /// <returns></returns>
        /// <exception cref="InvalidOperationException"></exception>
        /// <exception cref="ScriptException"></exception>
        public async Task<string> EvalScriptAsync(string javaScript)
        {
            if (!this.CheckIsCreatedOrEnded)
                throw new InvalidOperationException("Browser already destroyed");

            ScriptZeroTest(javaScript);

            string scriptToExecute = $"window.external.evalScript(\"{javaScript.Replace("\"", "\\'")}\")";
            string result = await this._WebViewControl.ExecuteScriptAsync(scriptToExecute);
            ScriptErrorObject errObj = ScriptSerializationHelper.GetScriptErrorObject(result);
            if (errObj != null)
            {
                throw new ScriptException(errObj);
            }
            return result;
        }


        /// <summary>
        /// Execute the Script directly no Exception will be thrown
        /// </summary>
        /// <param name="javaScript">Script to execute</param>
        /// <returns>Result String</returns>
        /// <exception cref="InvalidOperationException"></exception>
        public async Task<string> ExecuteScriptDirectAsync(string javaScript)
        {
            if (!this.CheckIsCreatedOrEnded)
                throw new InvalidOperationException("Browser not created or Crashed");
            ScriptZeroTest(javaScript);
            string result = await this._WebViewControl.ExecuteScriptAsync(javaScript);
            return result;
        }

        public void ExecuteScriptDirect(string javaScript)
        {
            if (!this.CheckIsCreatedOrEnded)
                throw new InvalidOperationException("Browser not created or Crashed");
            ScriptZeroTest(javaScript);
            this._WebViewControl.ExecuteScript(javaScript);

        }
        /// <summary>
        /// Execute the Script with Exception - Check => window.external.executeScript
        /// </summary>
        /// <param name="javaScript"></param>
        /// <returns>string</returns>
        /// <exception cref="InvalidOperationException"></exception>
        /// <exception cref="ScriptException"></exception>
        public async Task<string> ExecuteScriptAsync(string javaScript)
        {
            if (!this.CheckIsCreatedOrEnded)
                throw new InvalidOperationException("Browser not created or Crashed");
            ScriptZeroTest(javaScript);

            string scrptToExecute = $"window.external.executeScript(\"{{{javaScript.Replace("\"", "\\'")}}}\")";
            string result = await this._WebViewControl.ExecuteScriptAsync(scrptToExecute);
            ScriptErrorObject errorObj = ScriptSerializationHelper.GetScriptErrorObject(result);
            if (errorObj != null)
            {
                throw new ScriptException(errorObj);
            }
            return result;
        }

        //private string ExecuteScriptSync(string javaScript)
        //{
        //    if (!this.CheckIsCreatedOrEnded)
        //        throw new InvalidOperationException("Browser not created or Crashed");
        //    ScriptZeroTest(javaScript);

        //    string scrptToExecute = $"window.external.executeScript(\"{{{javaScript.Replace("\"", "\\'")}}}\")";
        //    string result = this._WebViewControl.ExecuteScriptSync(scrptToExecute);
        //    ScriptErrorObject errorObj = ScriptSerializationHelper.GetScriptErrorObject(result);
        //    if (errorObj != null)
        //    {
        //        throw new ScriptException(errorObj);
        //    }
        //    return result;

        //}
        public WebView2PrintSettings CreatePrintSettings()
        {
            return this._WebViewControl.CreatePrintSettings();
        }
        public async Task<bool> PrintToPdfAsync(string file, WebView2PrintSettings printSettings)
        {
            if (!this.CheckIsCreatedOrEnded)
                throw new InvalidOperationException("Browser not Created or Crashed");
            return await this._WebViewControl.PrintPdfAsync(file, printSettings);
        }

        /// <summary>
        /// Invoke a script and returns a unique ID for the script 
        /// </summary>
        /// <param name="javaScript"></param>
        /// <returns>Unique ID which can be used to identify the Return - Event</returns>
        /// <exception cref="InvalidOperationException">Throws if the Control is not ready</exception>
        public string InvokeScript(string javaScript)
        {
            if (!this.CheckIsCreatedOrEnded)
                throw new InvalidOperationException("Browser not created or Crashed");

            ScriptZeroTest(javaScript);

            string result = this._WebViewControl.InvokeScript(javaScript, (id, errorCode, jsonResult) =>
            {

                OnExecuteScriptCompleted(new ExecuteScriptCompletedEventArgs(errorCode, jsonResult, id));

            });

            return result;
        }

        [Browsable(false)]
        public string DocumentTitle
        {
            get => this._WebViewControl.DocumentTitle;

        }

        public DOMDocument GetDOMDocument()
        {
            if (!this.CheckIsCreatedOrEnded)
                throw new InvalidOperationException("Browser not created or Crashed");
            return new DOMDocument(this);
        }

        public DOMConsole GetDOMConsole()
        {
            if (!this.CheckIsCreatedOrEnded)
                throw new InvalidOperationException("Browser not created or Crashed");
            return new DOMConsole(this);
        }

        public DOMWindow GetDOMWindow()
        {
            if (!this.CheckIsCreatedOrEnded)
                throw new InvalidOperationException("Browser not created or Crashed");
            return new DOMWindow(this);
        }
        public void OpenDevToolsWindow()
        {
            this._WebViewControl.OpenDevToolsWindow();
        }

        public void OpenTaskManagerWindow()
        {
            this._WebViewControl.OpenTaskManagerWindow();
        }
/*
        private bool IsInDesignMode()
        {
            if (LicenseManager.UsageMode == System.ComponentModel.LicenseUsageMode.Designtime)
                return true;
            else
            {
                Control ctrl = this;

                while (ctrl != null)
                {
                    if (ctrl.Site != null && ctrl.Site.DesignMode)
                        return true;
                    ctrl = ctrl.Parent;
                }

                return System.Diagnostics.Process.GetCurrentProcess().ProcessName == "devenv";
            }
        }
*/
        private void CreateWebViewControl(IntPtr parent)
        {
            try
            {


                this._WebViewControl = new WebView2Control(parent);
                this._WebViewControl.Created += OnWebWindowCreated;
                this._WebViewControl.BeforeCreate += OnWebWindowBeforeCreate;
                this._WebViewControl.NavigateStart += OnNavigationStartIntern;
                this._WebViewControl.AcceleratorKeyPressed += OnAcceleratorKeyPressedIntern;
                this._WebViewControl.GotFocus += OnGotFocusIntern;
                this._WebViewControl.LostFocus += OnLostFocusIntern;
                this._WebViewControl.MoveFocusRequested += OnMoveFocusRequestedIntern;
                this._WebViewControl.ZoomFactorChanged += OnZoomFactorChangedIntern;
                this._WebViewControl.ContainsFullScreenElementChanged += OnContainsFullScreenElementChangedIntern;

                this._WebViewControl.NewWindowRequested += OnNewWindowRequestedIntern;
                this._WebViewControl.PermissionRequested += OnPermissionRequestedIntern;
                this._WebViewControl.DocumentTitleChanged += OnDocumentTitleChangedIntern;
                this._WebViewControl.FrameNavigationCompleted += OnFrameNavigationCompletedIntern;
                this._WebViewControl.FrameNavigationStarting += OnFrameNavigationStartingIntern;
                this._WebViewControl.ProcessFailed += OnProcessFailedIntern;
                this._WebViewControl.ScriptDialogOpening += OnScriptDialogOpeningIntern;
                this._WebViewControl.WebMessageReceived += OnWebMessageReceivedIntern;
                this._WebViewControl.ScriptToExecuteOnDocumentCreatedCompleted += ScriptToExecuteOnDocumentCreatedCompletedIntern;

                this._WebViewControl.WindowCloseRequested += OnWindowCloseRequestedIntern;
                this._WebViewControl.ExecuteScriptCompleted += OnExecuteScriptCompletedIntern;
                this._WebViewControl.WebResourceRequested += OnWebResourceRequestedIntern;
                this._WebViewControl.ContentLoading += OnContentLoadingIntern;
                this._WebViewControl.SourceChanged += OnSourceChangedIntern;
                this._WebViewControl.HistoryChanged += OnHistoryChangedIntern;
                this._WebViewControl.NavigationCompleted += OnNavigationCompletedIntern;
                this._WebViewControl.NewBrowserVersionAvailable += OnNewBrowserVersionAvailableIntern;
                this._WebViewControl.DOMContentLoaded += OnDOMContentLoadedIntern;
                this._WebViewControl.WebResourceResponseReceived += WebResourceResponseReceivedIntern;
                this._WebViewControl.DownloadStarting += OnDownalodStartingIntern;
                this._WebViewControl.FrameCreated += OnFrameCreatedIntern;
                this._WebViewControl.RasterizationScaleChanged += OnRasterizationScaleChangedIntern;

            }
            catch (Exception ex)
            {
                Debug.Print(nameof(CreateWebViewControl) + " Exception:" + ex);

            }

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
        private void ScriptToExecuteOnDocumentCreatedCompletedIntern(object sender, AddScriptToExecuteOnDocumentCreatedCompletedEventArgs e)
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

        private void WebView_Resize(object sender, EventArgs e)
        {
            if (this.CheckIsCreatedOrEnded)
            {
                this._WebViewControl.DockToParent();
            }
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

        protected virtual void OnScriptToExecuteOnDocumentCreatedCompleted(AddScriptToExecuteOnDocumentCreatedCompletedEventArgs e)
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

        public WebResourceResponse CreateResponse(ResponseInfo responseInfo)
        {
            WebResourceResponse response = null;
            if (this.CheckIsCreatedOrEnded)
            {
                response = this._WebViewControl.GetResponseStream(responseInfo.Stream, responseInfo.StatusCode,
                    responseInfo.StatusText, responseInfo.HeaderToString(), responseInfo.ContentType);
            }

            return response;
        }
        private bool GetFileStream(string url, out ResponseInfo responseInfo)
        {
            if (!url.StartsWith(this.MonitoringUrl))
            {
                responseInfo = null;
                return false;
            }

            string baseDirectory = this.MonitoringFolder;
            string file = url.Replace(this.MonitoringUrl, "");
            if (string.IsNullOrEmpty(file))
                file = "index.html";
            file = file.Replace("/", "\\");
            file = Path.Combine(baseDirectory, file);
            FileInfo fileInfo = new FileInfo(file);
            if (!fileInfo.Exists)
            {
                responseInfo = new ResponseInfo("<h1>Server Error</h1><h5>file not found:" + file + "</h5>");
                responseInfo.Header.Add("content-type", "text/html; charset=utf-8");
                responseInfo.ContentType = "content-type: text/html; charset=utf-8";
                responseInfo.StatusCode = 404;
                responseInfo.StatusText = "Not Found";

                return false;
            }

            string contentType = fileInfo.MimeTypeOrDefault();
            if (contentType == "document")
                Debug.Print(contentType);
            try
            {
                byte[] bytes = File.ReadAllBytes(file);
                responseInfo = new ResponseInfo(bytes);
                string utf8Extension = GetUtf8IfNeeded(contentType);

                responseInfo.Header.Add("content-type", contentType + utf8Extension);

                responseInfo.ContentType = "content-type: " + contentType + utf8Extension;
                responseInfo.StatusCode = 200;
                responseInfo.StatusText = "OK";
                return true;
            }
            catch (Exception e)
            {
                string message = "Error:" + e.Message;
                responseInfo = new ResponseInfo(message);
                responseInfo.Header.Add("content-type", "text/html; charset=utf-8");
                responseInfo.ContentType = "content-type; charset=utf-8";
                responseInfo.StatusCode = 500;
                responseInfo.StatusText = "Internal Server Error";
                return true;
            }


        }

        private static string GetUtf8IfNeeded(string contentType)
        {
            if (string.IsNullOrEmpty(contentType))
                return "";

            bool needUtf8 = false;

            switch (contentType)
            {
                case "application/x-javascript":
                case "text/html":
                case "text/css":
                case "application/javascript":
                case "application/json":
                    needUtf8 = true;
                    break;
            }

            if (needUtf8)
                return "; charset=utf-8";
            return "";
        }

        public List<string> Content
        {
            get
            {
                if (!CheckIsCreatedOrEnded)
                {
                    return new List<string>();
                }

                return this._WebViewControl.Content;
            }
        }

        public Task<string> PageSource => GetDocumentText();

        public void ShowPageSource()
        {
            string uri = this.Source;
            

            this.Navigate($"view-source:{uri}");
        }
        private async Task<string> GetDocumentText()
        {
            DOMDocument doc = this.GetDOMDocument();
            try
            {
                string html = await doc.documentElement.GetOuterHTML;
                if (html.StartsWith("\""))
                    html = html.Substring(1);
                if (html.EndsWith("\""))
                {
                    html = html.Substring(0, html.Length - 1);
                }
                html= System.Text.RegularExpressions.Regex.Unescape(html);
                //string enc = html= System.Text.RegularExpressions.Regex.Escape(html);
                html = html.Replace("\n", Environment.NewLine);
                return html;

            }
            catch (Exception e)
            {
                Debug.Print(e.ToString());
                throw;
            }

        }
        protected virtual void OnWebResourceRequested(WebResourceRequestedEventArgs e)
        {


            if (this.EnableMonitoring)
            {
                if (GetFileStream(e.Request.Uri, out var responseInfo))
                {
                    var response = this.CreateResponse(responseInfo);
                    e.Response = response;
                }
            }


            WebResourceRequested?.Invoke(this, e);
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

        //protected override void WndProc(ref Message m)
        //{


        //    Debug.Print("MSG=>" + m.Msg.ToString());
        //    switch (m.Msg)
        //    {
        //        //WM_DESTROY
        //        case 0x0002:

        //            Thread.Sleep(100);

        //            Thread.Sleep(100);
        //            break;
        //    }
        //    base.WndProc(ref m);

        //}

        protected override void DestroyHandle()
        {
            if (this._WebViewControl != null)
            {
                OnBeforeWebViewDestroy();
                this._WebViewControl.IsVisible = false;
                this._WebViewControl.ParentWindow = new System.Runtime.InteropServices.HandleRef(this._WebViewControl, IntPtr.Zero);
            }
            base.DestroyHandle();
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

        }

        protected virtual void OnDomContentLoaded(DOMContentLoadedEventArgs e)
        {
            DOMContentLoaded?.Invoke(this, e);
        }

        protected virtual void OnWebResourceResponseReceived(WebResourceResponseReceivedEventArgs e)
        {


            WebResourceResponseReceived?.Invoke(this, e);
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

        private Color _DefaultBackgroundColor = Color.Empty;
        public Color DefaultBackgroundColor
        {
            get
            {


                if (this.CheckIsCreatedOrEnded)
                {
                    this._DefaultBackgroundColor = this._WebViewControl.DefaultBackgroundColor;
                }

                return _DefaultBackgroundColor;
            }
            set
            {
                _DefaultBackgroundColor = value;
                if (this.CheckIsCreatedOrEnded)
                {
                    this._WebViewControl.DefaultBackgroundColor = _DefaultBackgroundColor;
                }

            }

        }



        private void WebView_Load(object sender, EventArgs e)
        {
            CreateWebViewControl(this.Handle);
        }

        protected virtual void OnScriptEvent(RpcEventHandlerArgs e)
        {
            ScriptEvent?.Invoke(this, e);
        }
    }
}
