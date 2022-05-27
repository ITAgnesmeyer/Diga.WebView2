using System;
using System.Diagnostics;
using System.Runtime.ExceptionServices;
using System.Security;
using Diga.WebView2.Interop;

namespace Diga.WebView2.Wrapper.Handler
{
    public class ContextMenuRequestedEventHandler : ICoreWebView2ContextMenuRequestedEventHandler
    {
        //public event EventHandler<ContextMenuRequestedEventArgs> ContextMenuRequested;
        private ContextMenuRequestDelegate _CallBack;
        public ContextMenuRequestedEventHandler(ContextMenuRequestDelegate callback)
        {
            this._CallBack= callback;
        }
        [SecurityCritical]
        [HandleProcessCorruptedStateExceptions]
        public void Invoke(ICoreWebView2 sender, ICoreWebView2ContextMenuRequestedEventArgs args)
        {
            try
            {
                object arg = args;
                OnContextMenuRequested(new ContextMenuRequestedEventArgs(arg));
            }
            catch (Exception ex)
            {
                Debug.Print(nameof(ContextMenuRequestedEventHandler) + " Exception:" + ex.ToString());
            }
            
        }

        private void OnContextMenuRequested(ContextMenuRequestedEventArgs e)
        {
            //ContextMenuRequested?.Invoke(this, e);
            this._CallBack(e);
        }

        public delegate void ContextMenuRequestDelegate(ContextMenuRequestedEventArgs args);
    }
}