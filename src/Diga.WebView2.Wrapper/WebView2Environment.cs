using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices.ComTypes;
using System.Security;
using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.EventArguments;
using Diga.WebView2.Wrapper.Handler;
using Diga.WebView2.Wrapper.Implementation;

// ReSharper disable once CheckNamespace
namespace Diga.WebView2.Wrapper
{


    public partial class WebView2Environment : WebView2Environment14Interface
    {
        public event EventHandler<WebView2EventArgs> NewBrowserVersionAvailable;
        public event EventHandler<BrowserProcessExitedEventArgs> BrowserProcessExited;
        private EventRegistrationToken _NewBrowserVersionAvailableToken;
        private EventRegistrationToken _BrowserProcessExitedToken;


        public WebView2Environment(ICoreWebView2Environment14 environment) : base(environment)
        {
            if (environment == null)
                throw new ArgumentNullException(nameof(environment));

            this.RegisterEvents();
        }


        public WebResourceRequest CreateWebResourceRequest(string url, string method,Stream postData, string headerString)
        {
          
            
            var request = base.CreateWebResourceRequest(url, method,  new ManagedIStream(ref postData), headerString);
            return new WebResourceRequest(request);
        }
       public new WebView2PointerInfo CreateCoreWebView2PointerInfo()
        {
            return new WebView2PointerInfo(base.CreateCoreWebView2PointerInfo());
        }

       public WebView2ContextMenuItem CreateContextMenuItem(string label,Stream iconStream,
           COREWEBVIEW2_CONTEXT_MENU_ITEM_KIND kind)
       {
           
           
           return new WebView2ContextMenuItem(base.CreateContextMenuItem(label, iconStream == null ? (IStream) null : (IStream) new ManagedIStream(ref iconStream), kind));
       }

        private void RegisterEvents()
        {
            //add_NewBrowserVersionAvailable

            NewBrowserVersionAvailableEventHandler newBrowserVersionAvailableHandler = new NewBrowserVersionAvailableEventHandler();
            newBrowserVersionAvailableHandler.NewBrowserVersionAvailable += OnNewBrowserVersionAvailableInternal;
            this.add_NewBrowserVersionAvailable(newBrowserVersionAvailableHandler,
                out this._NewBrowserVersionAvailableToken);
            BrowserProcessExitedEventHandler browserProcessExitedEventHandler = new BrowserProcessExitedEventHandler();
            browserProcessExitedEventHandler.BrowserProcessExited += OnBrowserProcessExitedIntern;
            this.add_BrowserProcessExited(browserProcessExitedEventHandler, out this._BrowserProcessExitedToken);
        }

        private void OnBrowserProcessExitedIntern(object sender, BrowserProcessExitedEventArgs e)
        {
            OnBrowserProcessExited(e);
        }
        [SecurityCritical]
#pragma warning disable SYSLIB0032 // Typ oder Element ist veraltet
        [HandleProcessCorruptedStateExceptions]
#pragma warning restore SYSLIB0032 // Typ oder Element ist veraltet
        private void UnRegisterEvents()
        {
            //if(this._Interface == null) return;
            try
            {
                EventRegistrationTool.UnWireToken(this._NewBrowserVersionAvailableToken, this.remove_NewBrowserVersionAvailable);
                EventRegistrationTool.UnWireToken(this._BrowserProcessExitedToken, this.remove_BrowserProcessExited);
            }
            catch (Exception exception)
            {
                Debug.Print(exception.ToString());
            }

        }
        private void OnNewBrowserVersionAvailableInternal(object sender, WebView2EventArgs e)
        {
            OnNewBrowserVersionAvailable(e);
        }


        protected virtual void OnNewBrowserVersionAvailable(WebView2EventArgs e)
        {
            NewBrowserVersionAvailable?.Invoke(this, e);
        }
        private bool _IsDisposed;
        protected override void Dispose(bool disposing)
        {
            if (this._IsDisposed) return;

            if (disposing)
            {
                this.UnRegisterEvents();
                this._IsDisposed = true;
            }
            base.Dispose(disposing);
        }



        protected virtual void OnBrowserProcessExited(BrowserProcessExitedEventArgs e)
        {
            BrowserProcessExited?.Invoke(this, e);
        }


        public new WebView2PrintSettings CreatePrintSettings()
        {
            ICoreWebView2PrintSettings settings = base.CreatePrintSettings();
            return new WebView2PrintSettings(settings);
        }

        public new  WebView2SharedBuffer CreateSharedBuffer(ulong bufferSize)
        {
            return new WebView2SharedBuffer(base.CreateSharedBuffer(bufferSize));
        }

        public new FileSystemHandle CreateWebFileSystemFileHandle(string path, COREWEBVIEW2_FILE_SYSTEM_HANDLE_PERMISSION permission)
        {
            return new FileSystemHandle(base.CreateWebFileSystemFileHandle(path, permission));
        }


        public new FileSystemHandle CreateWebFileSystemDirectoryHandle(string path, COREWEBVIEW2_FILE_SYSTEM_HANDLE_PERMISSION permission)
        {
            return new FileSystemHandle(base.CreateWebFileSystemDirectoryHandle(path, permission));
        }
    }
}