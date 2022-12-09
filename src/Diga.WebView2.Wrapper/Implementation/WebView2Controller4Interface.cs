using System;
using System.Diagnostics;
using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.Types;

namespace Diga.WebView2.Wrapper.Implementation
{
    public class WebView2Controller4Interface : WebView2Controller3Interface
    {
        private ComObjectHolder< ICoreWebView2Controller4> _Controller;
        private ICoreWebView2Controller4 Controller
        {
            get
            {
                if (this._Controller == null)
                {
                    Debug.Print(nameof(WebView2Controller4Interface) + "=>" + nameof(this.Controller) + " is null");

                    throw new InvalidOperationException(nameof(WebView2Controller4Interface) + "=>" + nameof(this.Controller) + " is null");
                }
                return this._Controller.Interface;
            }
            set => this._Controller = new ComObjectHolder<ICoreWebView2Controller4>(value);
        }
        public WebView2Controller4Interface(ICoreWebView2Controller4 controller):base(controller)
        {
            this.Controller = controller ?? throw new ArgumentNullException(nameof(controller));
        }

        public int AllowExternalDrop { get => this.Controller.AllowExternalDrop; set => this.Controller.AllowExternalDrop = value; }
    }
}