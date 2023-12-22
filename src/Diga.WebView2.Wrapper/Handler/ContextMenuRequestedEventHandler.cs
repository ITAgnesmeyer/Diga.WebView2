using System;
using System.Diagnostics;
using System.Runtime.ExceptionServices;
using System.Security;
using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.EventArguments;

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
#pragma warning disable SYSLIB0032
        [HandleProcessCorruptedStateExceptions]
#pragma warning restore SYSLIB0032
        public void Invoke(ICoreWebView2 sender, ICoreWebView2ContextMenuRequestedEventArgs args)
        {
            try
            {
                
                OnContextMenuRequested(new ContextMenuRequestedEventArgs(args));
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