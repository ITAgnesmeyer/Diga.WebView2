﻿using System;
using System.Globalization;
using System.IO;
using System.Numerics;
using System.Windows;
using Diga.Core.Json;
using Diga.WebView2.Scripting.DOM;

using Diga.WebView2.Wrapper.EventArguments;


namespace WebView2WrapperWpfTest
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private TestObject _TestObject;

        public MainWindow()
        {
            this._TestObject = new TestObject();
            InitializeComponent();
        }



        private void WebView1_WebViewCreated(object sender, EventArgs e)
        {
            this._TestObject.Name = "hallo Welt";
            this.WebView1.AddRemoteObject("testObject", this._TestObject);

            var value = File.ReadAllText("index.html");
            this.WebView1.NavigateToString(value);
            //this.textBox1.AutoCompleteCustomSource.Add(this.WebView1.MonitoringUrl);

        }

        private void WebView2_WebViewCreated(object sender, EventArgs e)
        {
            this.WebView2.AddRemoteObject("testObject", this._TestObject);
            var value = File.ReadAllText("index.html");
            this.WebView2.NavigateToString(value);
        }

        private void WebView2_WebMessageReceived(object sender, WebMessageReceivedEventArgs e)
        {
            var message = e.WebMessageAsString;
            var rpc = DigaJson.Deserialize<Rpc>(message);

            switch (rpc.action)
            {
                case "run_script":
                    this.WebView2.InvokeScript(rpc.param);
                    break;
                case "run_script_with_result":
                    var id = this.WebView2.InvokeScript(rpc.param);
                    var result = new Rpc
                    {
                        id = id,
                        action = "get_script_result",
                        objId = rpc.objId,
                        param = id
                    };
                    var js = DigaJson.Serialize(result);
                    this.WebView2.SendMessage(js);
                    break;
                case "get_script_result":
                    var scriptId = rpc.param;

                    break;
                case "set_object_innerHtml":
                    this.WebView2.InvokeScript($"document.getElementById('{rpc.objId}').innerHTML='{rpc.param}'");
                    break;
            }
        }

        private void WebView1_WebMessageReceived(object sender, WebMessageReceivedEventArgs e)
        {
            var message = e.WebMessageAsString;
            var rpc = DigaJson.Deserialize<Rpc>(message);

            switch (rpc.action)
            {
                case "run_script":
                    this.WebView1.InvokeScript(rpc.param);
                    break;
                case "run_script_with_result":
                    var id = this.WebView1.InvokeScript(rpc.param);
                    var result = new Rpc
                    {
                        id = id,
                        action = "get_script_result",
                        objId = rpc.objId,
                        param = id
                    };
                    var js = DigaJson.Serialize(result);
                    this.WebView1.SendMessage(js);
                    break;
                case "get_script_result":
                    var scriptId = rpc.param;

                    break;
                case "set_object_innerHtml":
                    this.WebView1.InvokeScript($"document.getElementById('{rpc.objId}').innerHTML='{rpc.param}'");
                    break;
            }
        }

        private DOMElement _BUTTON;

        private void ButtonAction()
        {
            if (this._BUTTON == null)
            {
                this._BUTTON = this.WebView3.GetDOMDocument().getElementById("ga_button");
                if (!this._BUTTON.VarExist())
                {
                    this._BUTTON = null;
                    MessageBox.Show("Could not get Button");
                    this.WebView3.GetDOMWindow().alertAsync("TEST");
                }
                else
                {
                    this._BUTTON.Click += (o, ev) =>
                    {
                        DOMElement elem = this.WebView3.GetDOMDocument().createElement("canvas");
                        this.WebView3.GetDOMDocument().body.appendChild(elem);

                        DOMCanvasElement can = new DOMCanvasElement(elem);
                        can.width = 200;
                        can.height = 100;

                        var ctx = can.GetContext2D();
                        ctx.moveTo(0, 0);
                        ctx.lineTo(200,100);
                        ctx.stroke();



                        MessageBox.Show("Test from Button");
                    };
                }
            }
            var now = DateTime.Now;
            var zeroDate = DateTime.MinValue.AddHours(now.Hour).AddMinutes(now.Minute).AddSeconds(now.Second).AddMilliseconds(now.Millisecond);
            int uniqueId = (int)(zeroDate.Ticks / 10000) ;
            Random r = new Random(uniqueId);
            int nr = r.Next();
            
            this.WebView1.NavigateToString($"<h1>{uniqueId}</h1><h2>{nr}</h2>");
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //Diga.Core.Threading.UIDispatcher.UIThread.Post(ButtonAction);
            ButtonAction();
            //this.WebView1.IsVisible = !this.WebView1.IsVisible;

            //this.WebView2.Visibility = this.WebView2.Visibility == Visibility.Hidden ? Visibility.Visible : Visibility.Hidden;
        }
    }
}
