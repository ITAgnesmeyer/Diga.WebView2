using System;
using System.IO;
using System.Windows;
using Diga.WebView2.Wrapper.EventArguments;
using Newtonsoft.Json;

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
            var rpc = JsonConvert.DeserializeObject<Rpc>(message);

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
                    var js = JsonConvert.SerializeObject(result);
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
            var rpc = JsonConvert.DeserializeObject<Rpc>(message);

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
                    var js = JsonConvert.SerializeObject(result);
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.WebView1.IsVisible = !this.WebView1.IsVisible;

            this.WebView2.Visibility = this.WebView2.Visibility == Visibility.Hidden ? Visibility.Visible : Visibility.Hidden;
        }
    }
}
