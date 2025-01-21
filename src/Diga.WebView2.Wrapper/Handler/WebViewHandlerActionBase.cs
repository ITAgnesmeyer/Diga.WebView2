using Diga.WebView2.Interop;
using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace Diga.WebView2.Wrapper.Handler
{
    public class WebView2ShowSaveAsUICompletedHandler: WebViewHandlerActionBase<int, COREWEBVIEW2_SAVE_AS_UI_RESULT>, ICoreWebView2ShowSaveAsUICompletedHandler
    {
        public WebView2ShowSaveAsUICompletedHandler(Action<int, COREWEBVIEW2_SAVE_AS_UI_RESULT> action) : base(action)
        {
        }
        public void Invoke([In, MarshalAs(UnmanagedType.Error)] int errorCode, [In] COREWEBVIEW2_SAVE_AS_UI_RESULT result)
        {
            base.InvokeIntern(errorCode, result);
        }
    }

    public class WebViewHandlerActionBase<TArt1, TArg2>
    {
        protected Action<TArt1, TArg2> Action;
        public WebViewHandlerActionBase(Action<TArt1, TArg2> action)
        {
            this.Action = action;
        }
        protected void InvokeIntern(TArt1 art1, TArg2 art2)
        {
            try
            {
                this.Action(art1, art2);
            }
            catch (Exception ex)
            {

                Debug.Print(nameof(WebViewHandlerActionBase<TArt1,TArg2>) + " Exception:" + ex.ToString());
            }
        }
    }
}