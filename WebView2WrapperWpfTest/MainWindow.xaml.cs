using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

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
            string value = File.ReadAllText("index.html");
            this.WebView1.NavigateToString(value);
            //this.textBox1.AutoCompleteCustomSource.Add(this.WebView1.MonitoringUrl);
            
        }

        private void WebView2_WebViewCreated(object sender, EventArgs e)
        {
            this.WebView2.AddRemoteObject("testObject", this._TestObject);
            string value = File.ReadAllText("index.html");
            this.WebView2.NavigateToString(value);
        }

        private void WebView2_WebMessageReceived(object sender, Diga.WebView2.Wrapper.EventArguments.WebMessageReceivedEventArgs e)
        {
            string message = e.WebMessageAsString;
            var rpc = Newtonsoft.Json.JsonConvert.DeserializeObject<Rpc>(message);

            switch (rpc.action)
            {
                case "run_script":
                    this.WebView2.InvokeScript(rpc.param.ToString());
                    break;
                case "run_script_with_result":
                    string id = this.WebView2.InvokeScript(rpc.param.ToString());
                    Rpc result = new Rpc()
                    {
                        id = id,
                        action = "get_script_result",
                        objId = rpc.objId,
                        param = id
                    };
                    string js = Newtonsoft.Json.JsonConvert.SerializeObject(result);
                    this.WebView2.SendMessage(js);
                    break;
                case "get_script_result":
                    string scriptId = rpc.param.ToString();
                    
                    break;
                case "set_object_innerHtml":
                    this.WebView2.InvokeScript($"document.getElementById('{rpc.objId}').innerHTML='{rpc.param}'");
                    break;
            }
        }

        private void WebView1_WebMessageReceived(object sender, Diga.WebView2.Wrapper.EventArguments.WebMessageReceivedEventArgs e)
        {
            string message = e.WebMessageAsString;
            var rpc = Newtonsoft.Json.JsonConvert.DeserializeObject<Rpc>(message);

            switch (rpc.action)
            {
                case "run_script":
                    this.WebView1.InvokeScript(rpc.param.ToString());
                    break;
                case "run_script_with_result":
                    string id = this.WebView1.InvokeScript(rpc.param.ToString());
                    Rpc result = new Rpc()
                    {
                        id = id,
                        action = "get_script_result",
                        objId = rpc.objId,
                        param = id
                    };
                    string js = Newtonsoft.Json.JsonConvert.SerializeObject(result);
                    this.WebView1.SendMessage(js);
                    break;
                case "get_script_result":
                    string scriptId = rpc.param.ToString();
                    
                    break;
                case "set_object_innerHtml":
                    this.WebView1.InvokeScript($"document.getElementById('{rpc.objId}').innerHTML='{rpc.param}'");
                    break;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (this.WebView1.IsVisible)
                this.WebView1.IsVisible = false;
            else
            {
                this.WebView1.IsVisible = true;
            }

            if (this.WebView2.Visibility == Visibility.Hidden)
                this.WebView2.Visibility = Visibility.Visible;
            else
            {
                this.WebView2.Visibility = Visibility.Hidden;
            }

        }
    }
}
