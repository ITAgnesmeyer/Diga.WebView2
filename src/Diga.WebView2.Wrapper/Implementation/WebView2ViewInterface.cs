using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.Types;
using Microsoft.Win32.SafeHandles;

namespace Diga.WebView2.Wrapper.Implementation
{
    [EditorBrowsable(EditorBrowsableState.Advanced)]
    public class WebView2ViewInterface :  IDisposable
    {
        private ComObjectHolder<ICoreWebView2> _WebView;
        /// Wraps in SafeHandle so resources can be released if consumer forgets to call Dispose. Recommended
        ///             pattern for any type that is not sealed.
        ///             https://docs.microsoft.com/dotnet/api/system.idisposable#idisposable-and-the-inheritance-hierarchy
        private readonly SafeHandle handle = new SafeFileHandle(IntPtr.Zero, true);
        private ICoreWebView2 WebView
        {
            get
            {
                if (this._WebView == null)
                {
                    Debug.Print(nameof(WebView2ViewInterface) + "." + nameof(this.WebView) + " is null");
                    throw new InvalidOperationException(nameof(WebView2ViewInterface) + "." + nameof(this.WebView) + " is null");

                }
                return this._WebView.Interface;
            }
            set
            {
                this._WebView = new ComObjectHolder<ICoreWebView2>(value);
            }
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public WebView2ViewInterface(ICoreWebView2 webView)
        {
            if (webView == null)
                throw new ArgumentNullException(nameof(webView));

            this.WebView = webView;
        }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public ICoreWebView2Settings Settings => this.WebView.Settings;
        [EditorBrowsable(EditorBrowsableState.Never)]
        public string Source => this.WebView.Source;
        [EditorBrowsable(EditorBrowsableState.Never)]
        public void Navigate([In, MarshalAs(UnmanagedType.LPWStr)] string uri)
        {
            this.WebView.Navigate(uri);
        }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public void NavigateToString([In, MarshalAs(UnmanagedType.LPWStr)] string htmlContent)
        {
            this.WebView.NavigateToString(htmlContent);
        }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public void add_NavigationStarting([In, MarshalAs(UnmanagedType.Interface)] ICoreWebView2NavigationStartingEventHandler eventHandler, out EventRegistrationToken token)
        {
            this.WebView.add_NavigationStarting(eventHandler, out token);
        }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public void remove_NavigationStarting([In] EventRegistrationToken token)
        {
            this.WebView.remove_NavigationStarting(token);
        }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public void add_ContentLoading([In, MarshalAs(UnmanagedType.Interface)] ICoreWebView2ContentLoadingEventHandler eventHandler, out EventRegistrationToken token)
        {
            this.WebView.add_ContentLoading(eventHandler, out token);
        }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public void remove_ContentLoading([In] EventRegistrationToken token)
        {
            this.WebView.remove_ContentLoading(token);
        }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public void add_SourceChanged([In, MarshalAs(UnmanagedType.Interface)] ICoreWebView2SourceChangedEventHandler eventHandler, out EventRegistrationToken token)
        {
            this.WebView.add_SourceChanged(eventHandler, out token);
        }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public void remove_SourceChanged([In] EventRegistrationToken token)
        {
            this.WebView.remove_SourceChanged(token);
        }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public void add_HistoryChanged([In, MarshalAs(UnmanagedType.Interface)] ICoreWebView2HistoryChangedEventHandler eventHandler, out EventRegistrationToken token)
        {
            this.WebView.add_HistoryChanged(eventHandler, out token);
        }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public void remove_HistoryChanged([In] EventRegistrationToken token)
        {
            this.WebView.remove_HistoryChanged(token);
        }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public void add_NavigationCompleted([In, MarshalAs(UnmanagedType.Interface)] ICoreWebView2NavigationCompletedEventHandler eventHandler, out EventRegistrationToken token)
        {
            this.WebView.add_NavigationCompleted(eventHandler, out token);
        }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public void remove_NavigationCompleted([In] EventRegistrationToken token)
        {
            this.WebView.remove_NavigationCompleted(token);
        }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public void add_FrameNavigationStarting([In, MarshalAs(UnmanagedType.Interface)] ICoreWebView2NavigationStartingEventHandler eventHandler, out EventRegistrationToken token)
        {
            this.WebView.add_FrameNavigationStarting(eventHandler, out token);
        }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public void remove_FrameNavigationStarting([In] EventRegistrationToken token)
        {
            this.WebView.remove_FrameNavigationStarting(token);
        }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public void add_FrameNavigationCompleted([In, MarshalAs(UnmanagedType.Interface)] ICoreWebView2NavigationCompletedEventHandler eventHandler, out EventRegistrationToken token)
        {
            this.WebView.add_FrameNavigationCompleted(eventHandler, out token);
        }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public void remove_FrameNavigationCompleted([In] EventRegistrationToken token)
        {
            this.WebView.remove_FrameNavigationCompleted(token);
        }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public void add_ScriptDialogOpening([In, MarshalAs(UnmanagedType.Interface)] ICoreWebView2ScriptDialogOpeningEventHandler eventHandler, out EventRegistrationToken token)
        {
            this.WebView.add_ScriptDialogOpening(eventHandler, out token);
        }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public void remove_ScriptDialogOpening([In] EventRegistrationToken token)
        {
            this.WebView.remove_ScriptDialogOpening(token);
        }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public void add_PermissionRequested([In, MarshalAs(UnmanagedType.Interface)] ICoreWebView2PermissionRequestedEventHandler eventHandler, out EventRegistrationToken token)
        {
            this.WebView.add_PermissionRequested(eventHandler, out token);
        }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public void remove_PermissionRequested([In] EventRegistrationToken token)
        {
            this.WebView.remove_PermissionRequested(token);
        }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public void add_ProcessFailed([In, MarshalAs(UnmanagedType.Interface)] ICoreWebView2ProcessFailedEventHandler eventHandler, out EventRegistrationToken token)
        {
            this.WebView.add_ProcessFailed(eventHandler, out token);
        }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public void remove_ProcessFailed([In] EventRegistrationToken token)
        {
            this.WebView.remove_ProcessFailed(token);
        }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public void AddScriptToExecuteOnDocumentCreated([In, MarshalAs(UnmanagedType.LPWStr)] string javaScript, [In, MarshalAs(UnmanagedType.Interface)] ICoreWebView2AddScriptToExecuteOnDocumentCreatedCompletedHandler handler)
        {
            this.WebView.AddScriptToExecuteOnDocumentCreated(javaScript, handler);
        }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public void RemoveScriptToExecuteOnDocumentCreated([In, MarshalAs(UnmanagedType.LPWStr)] string id)
        {
            this.WebView.RemoveScriptToExecuteOnDocumentCreated(id);
        }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public void ExecuteScript([In, MarshalAs(UnmanagedType.LPWStr)] string javaScript, [In, MarshalAs(UnmanagedType.Interface)] ICoreWebView2ExecuteScriptCompletedHandler handler)
        {
            this.WebView.ExecuteScript(javaScript, handler);
        }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public void CapturePreview([In] COREWEBVIEW2_CAPTURE_PREVIEW_IMAGE_FORMAT imageFormat, [In, MarshalAs(UnmanagedType.Interface)] IStream imageStream, [In, MarshalAs(UnmanagedType.Interface)] ICoreWebView2CapturePreviewCompletedHandler handler)
        {
            this.WebView.CapturePreview(imageFormat, imageStream, handler);
        }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public void Reload()
        {
            this.WebView.Reload();
        }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public void PostWebMessageAsJson([In, MarshalAs(UnmanagedType.LPWStr)] string webMessageAsJson)
        {
            this.WebView.PostWebMessageAsJson(webMessageAsJson);
        }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public void PostWebMessageAsString([In, MarshalAs(UnmanagedType.LPWStr)] string webMessageAsString)
        {
            this.WebView.PostWebMessageAsString(webMessageAsString);
        }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public void add_WebMessageReceived([In, MarshalAs(UnmanagedType.Interface)] ICoreWebView2WebMessageReceivedEventHandler handler, out EventRegistrationToken token)
        {
            this.WebView.add_WebMessageReceived(handler, out token);
        }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public void remove_WebMessageReceived([In] EventRegistrationToken token)
        {
            this.WebView.remove_WebMessageReceived(token);
        }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public void CallDevToolsProtocolMethod([In, MarshalAs(UnmanagedType.LPWStr)] string methodName, [In, MarshalAs(UnmanagedType.LPWStr)] string parametersAsJson, [In, MarshalAs(UnmanagedType.Interface)] ICoreWebView2CallDevToolsProtocolMethodCompletedHandler handler)
        {
            this.WebView.CallDevToolsProtocolMethod(methodName, parametersAsJson, handler);
        }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint BrowserProcessId => this.WebView.BrowserProcessId;
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int CanGoBack => this.WebView.CanGoBack;
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int CanGoForward => this.WebView.CanGoForward;
        [EditorBrowsable(EditorBrowsableState.Never)]
        public void GoBack()
        {
            this.WebView.GoBack();
        }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public void GoForward()
        {
            this.WebView.GoForward();
        }
        [EditorBrowsable(EditorBrowsableState.Never)]
        [return: MarshalAs(UnmanagedType.Interface)]
        public ICoreWebView2DevToolsProtocolEventReceiver GetDevToolsProtocolEventReceiver([In, MarshalAs(UnmanagedType.LPWStr)] string eventName)
        {
            return this.WebView.GetDevToolsProtocolEventReceiver(eventName);
        }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public void Stop()
        {
            this.WebView.Stop();
        }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public void add_NewWindowRequested([In, MarshalAs(UnmanagedType.Interface)] ICoreWebView2NewWindowRequestedEventHandler eventHandler, out EventRegistrationToken token)
        {
            this.WebView.add_NewWindowRequested(eventHandler, out token);
        }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public void remove_NewWindowRequested([In] EventRegistrationToken token)
        {
            this.WebView.remove_NewWindowRequested(token);
        }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public void add_DocumentTitleChanged([In, MarshalAs(UnmanagedType.Interface)] ICoreWebView2DocumentTitleChangedEventHandler eventHandler, out EventRegistrationToken token)
        {
            this.WebView.add_DocumentTitleChanged(eventHandler, out token);
        }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public void remove_DocumentTitleChanged([In] EventRegistrationToken token)
        {
            this.WebView.remove_DocumentTitleChanged(token);
        }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public string DocumentTitle => this.WebView.DocumentTitle;
        [EditorBrowsable(EditorBrowsableState.Never)]
        public void AddHostObjectToScript([In, MarshalAs(UnmanagedType.LPWStr)] string name, [In] ref object @object)
        {
            this.WebView.AddHostObjectToScript(name, ref @object);
        }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public void RemoveHostObjectFromScript([In, MarshalAs(UnmanagedType.LPWStr)] string name)
        {
            this.WebView.RemoveHostObjectFromScript(name);
        }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public void OpenDevToolsWindow()
        {
            this.WebView.OpenDevToolsWindow();
        }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public void add_ContainsFullScreenElementChanged([In, MarshalAs(UnmanagedType.Interface)] ICoreWebView2ContainsFullScreenElementChangedEventHandler eventHandler, out EventRegistrationToken token)
        {
            this.WebView.add_ContainsFullScreenElementChanged(eventHandler, out token);
        }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public void remove_ContainsFullScreenElementChanged([In] EventRegistrationToken token)
        {
            this.WebView.remove_ContainsFullScreenElementChanged(token);
        }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int ContainsFullScreenElement => this.WebView.ContainsFullScreenElement;
        [EditorBrowsable(EditorBrowsableState.Never)]
        public void add_WebResourceRequested([In, MarshalAs(UnmanagedType.Interface)] ICoreWebView2WebResourceRequestedEventHandler eventHandler, out EventRegistrationToken token)
        {
            this.WebView.add_WebResourceRequested(eventHandler, out token);
        }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public void remove_WebResourceRequested([In] EventRegistrationToken token)
        {
            this.WebView.remove_WebResourceRequested(token);
        }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public void AddWebResourceRequestedFilter([In, MarshalAs(UnmanagedType.LPWStr)] string uri, [In] COREWEBVIEW2_WEB_RESOURCE_CONTEXT ResourceContext)
        {
            this.WebView.AddWebResourceRequestedFilter(uri, ResourceContext);
        }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public void RemoveWebResourceRequestedFilter([In, MarshalAs(UnmanagedType.LPWStr)] string uri, [In] COREWEBVIEW2_WEB_RESOURCE_CONTEXT ResourceContext)
        {
            this.WebView.RemoveWebResourceRequestedFilter(uri, ResourceContext);
        }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public void add_WindowCloseRequested([In, MarshalAs(UnmanagedType.Interface)] ICoreWebView2WindowCloseRequestedEventHandler eventHandler, out EventRegistrationToken token)
        {
            this.WebView.add_WindowCloseRequested(eventHandler, out token);
        }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public void remove_WindowCloseRequested([In] EventRegistrationToken token)
        {
            this.WebView.remove_WindowCloseRequested(token);
        }
        private bool _IsDesposed;
        protected virtual void Dispose(bool disposing)
        {
            if (!this._IsDesposed)
            {
                if (disposing)
                {
                    this.handle.Dispose();
                    this._WebView = null;
                }

                this._IsDesposed = true;
            }
        }



        public void Dispose()
        {
            // Ändern Sie diesen Code nicht. Fügen Sie Bereinigungscode in der Methode "Dispose(bool disposing)" ein.
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}