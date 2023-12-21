using Diga.WebView2.Interop;

namespace Diga.WebView2.Wrapper.EventArguments
{

    public class BrowserProcessExitedEventArgs : ICoreWebView2BrowserProcessExitedEventArgs
    {
        private ICoreWebView2BrowserProcessExitedEventArgs _Iface;

        public BrowserProcessExitedEventArgs(ICoreWebView2BrowserProcessExitedEventArgs iface )
        {
            this._Iface = iface;
        }
        public COREWEBVIEW2_BROWSER_PROCESS_EXIT_KIND BrowserProcessExitKind => this._Iface.BrowserProcessExitKind;

        public uint BrowserProcessId => this._Iface.BrowserProcessId;
    }
}