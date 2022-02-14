using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using Diga.Core.Threading;
using Diga.WebView2.Wpf.Scripting;
using Diga.WebView2.Wrapper;
using Diga.WebView2.Wrapper.EventArguments;


namespace Diga.WebView2.Wpf
{
    /// <summary>
    /// Interaction logic for UserControl1.xaml
    /// </summary>
    public partial class WebView : UserControl
    {
        private WebView2Control _WebViewControl;


        public WebView()
        {
            this._RpcHandler = new RpcHandler();
            this._RpcHandler.RpcEvent += OnRpcEventIntern;
            InitializeComponent();
        }


        #region Internal Functions

        private bool CheckIsCreatedOrEnded
        {
            get
            {
                if (!this.IsCreated) return false;
                if (this.IsBrowserEnded) return false;
                return true;
            }
        }

        private void CheckIsCreatedOrEndedWithThrow()
        {
            if (!this.CheckIsCreatedOrEnded)
                throw new InvalidOperationException("Browser not Created or Crashed");
        }


        private void UserControl_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            if (this.IsCreated)
            {
                this._WebViewControl.DockToParent();
            }
        }

        private void CreateWebViewControl(IntPtr parent)
        {
            try
            {
                this._WebViewControl = new WebView2Control(parent);
                WireEvents(this._WebViewControl);
            }
            catch (Exception ex)
            {
                Debug.Print(nameof(CreateWebViewControl) + " Exception:" + ex);
            }
        }

        private void WebWindowInitSettings(BeforeCreateEventArgs e)
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


        private void WebWindowInitAction()
        {
            this.IsCreated = true;
            AddRemoteObject("RpcHandler", this._RpcHandler);
            AddScriptToExecuteOnDocumentCreated(
                "class ScriptErrorObject{constructor(e,t,r,n,i,c){this.name=e,this.message=t,this.fileName=r,this.lineNumber=n,this.columnNumber=i,this.stack=c}}window.external={sendMessage:function(e){window.chrome.webview.postMessage(e)},receiveMessage:function(e){window.chrome.webview.addEventListener(\"message\",(function(t){e(t.data)}))},evalScript:function(e){try{return eval(e)}catch(e){let t=new ScriptErrorObject(e.name,e.message,e.fileName,e.lineNumber,e.columnNumber,e.stack);return JSON.stringify(t)}},executeScript:function(e){try{return new Function(e)()}catch(e){let t=new ScriptErrorObject(e.name,e.message,e.fileName,e.lineNumber,e.columnNumber,e.stack);return JSON.stringify(t)}}};");
            AddScriptToExecuteOnDocumentCreated(
                "window.external.raiseRpcEvent= async function(action, obj,objName,eventObj) { if(window.diga == undefined) window.diga = new Object(); try { const rpcHandler = window.chrome.webview.hostObjects.RpcHandler;const rpcObj = await rpcHandler.GetNewRpc(); let vn=await rpcObj.idName;window.diga[vn]=eventObj;rpcObj.objId = obj.id;rpcObj.action = action;rpcObj.varname=objName; rpcObj.param = \"empty\";rpcObj.item=document.getElementById(obj.id);let r = await rpcHandler.Handle(await rpcObj.id, await rpcObj.action, rpcObj);let b = await rpcHandler.ReleaseObject(rpcObj); } catch (e) { alert(e); } }");

            //"window.external = { sendMessage: function(message) { window.chrome.webview.postMessage(message); }, receiveMessage: function(callback) { window.chrome.webview.addEventListener('message', function(e) { callback(e.data); }); } };");
            //if (this._DefaultBackgroundColor != Colors.White)
            this.DefaultBackgroundColor = this._DefaultBackgroundColor;
            if (!string.IsNullOrEmpty(this._Url))
                Navigate(this.Url);
            if (!string.IsNullOrEmpty(this._HtmlContent))
                NavigateToString(this._HtmlContent);
            if (this._ZoomFactor != 0)
                this.ZoomFactor = this._ZoomFactor;
        }

        private void ViewHwnd_Loaded(object sender, RoutedEventArgs e)
        {
            var h = this.ViewHwnd.Handle;

            if (h.Handle == IntPtr.Zero)
                return;
            try
            {
                CreateWebViewControl(h.Handle);
            }
            catch (Exception ex)
            {
                Debug.Print("ViewHwend_Loaded Exception:" + ex.Message);
            }
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
        }

        private void ViewHwnd_SizeChanged(object sender, SizeChangedEventArgs e)
        {
        }

        private void ViewHwnd_Resize(object sender, EventArgs e)
        {
            if (this.IsCreated)
            {
                this._WebViewControl.DockToParent();
            }
        }

        private void ViewHwnd_Destroy(object sender, EventArgs e)
        {
            //this._WebViewControl?.CleanupControls();
        }
        private void CheckIsInUiThread([CallerMemberName] string member = "")
        {
            if (!UIDispatcher.UIThread.CheckAccess())
                throw new InvalidOperationException($"method ({member}) can only execute on UI-Thread");
        }
        #endregion
    }
}