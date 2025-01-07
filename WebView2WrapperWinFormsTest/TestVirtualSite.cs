using Diga.WebView2.Interop;
using Diga.WebView2.Scripting;
using Diga.WebView2.Scripting.DOM;
using System;

namespace WebView2WrapperWinFormsTest
{
    internal class TestVirtualSite: ResourceVirtualSite 
    {
        public TestVirtualSite(IWebViewControl webViewControl, string query) : base(webViewControl,  query)
        {
        }
        protected override void OnInitialize()
        {
            var mainView = this.GetDOMDocument().getElementById("MainView");
            var brelem = this.GetDOMDocument().createElement("br");
            var infoText = this.GetDOMDocument().createElement("input");
            infoText.id = "infoText";
            infoText.className = "input-diga-norm";
            infoText.setAttribute("type", "text");
            infoText.style.width = "50%";
            mainView.MouseMove += (o, me) =>
            {
                var x = me.Event.clientX;
                var y = me.Event.clientY;
                infoText.SetProperty("value", $"X:{x},Y:{y}");

            };
            DOMElement text = this.GetDOMDocument().createElement("input");
            text.id = "txt1";
            text.className = "input-diga-norm";
            text.setAttribute("type", "text");
            text.FocusIn += (o, args) =>
            {
                args.Event.cancelBubble = true;
                infoText.SetProperty("value", "FocusIn");
                //this.webView1.GetDOMWindow().alert("FocusIn");
            };
            text.FocusOut += (o, args) =>
            {
                var el = args.Event.relatedTarget;
                var typeName = el.GetTypeName();
                try
                {
                    if (el != null)
                    {

                        if (typeName != "Null")
                        {
                            infoText.SetProperty("value", $"blur from {text.GetTypeName()}{text.id} new focus on {typeName}.{el.id}");
                        }

                    }

                }
                catch (Exception ex)
                {
                    this.GetDOMWindow().alert(ex.Message);
                }

            };
            text.Input += (o, args) =>
            {
                DOMResultString st = args.Event.data;
                infoText.SetProperty("value", st);
                //this.webView1.GetDOMWindow().alert("Input");
            };

            DOMElement elem = this.GetDOMDocument().createElement("button");
            elem.id = "btn1";
            elem.innerText = "Click Me";
            elem.className = "bt-diga-main bt-diga-norm";
            elem.Click += (o, args) =>
            {
                var stroage = this.GetDOMWindow().sessionStorage;

                DOMResultString oldVal = stroage.getItem("btvalue");
                if (oldVal != null)
                {
                    if (oldVal == "null")
                        oldVal = "0";
                }

                int val = int.Parse(oldVal);
                text.SetProperty("value", $"Button Clicked:{val}");
                val++;
                stroage.setItem("btvalue", val.ToString());
                stroage.Dispose();
            };

            mainView.appendChild(brelem);
            mainView.appendChild(text);
            mainView.appendChild(elem);
            mainView.appendChild(brelem);
            mainView.appendChild(infoText);
            //this._Elements.Push(mainView);
            //this._Elements.Push(brelem);
            //this._Elements.Push(text);
            //this._Elements.Push(elem);
            //this._Elements.Push(infoText);

        }
    }
}
