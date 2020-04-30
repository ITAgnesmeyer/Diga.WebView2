using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

using Diga.WebView2.Wrapper;
using Diga.WebView2.Wrapper.EventArguments;

namespace WebView2WrapperWinFormsTest
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.webView1.Url = this.textBox1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.webView1.GoBack();
        }

        private void webView1_NavigationStart(object sender, NavigationStartingEventArgs e)
        {
            //MessageBox.Show(e.Uri);
        }

        private void webView1_ContentLoading(object sender, ContentLoadingEventArgs e)
        {
            //MessageBox.Show("Naviagation ID=>" + e.NavigationId);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.webView1.GoForward();
        }

        private void webView1_SourceChanged(object sender, SourceChangedEventArgs e)
        {
            //MessageBox.Show("SourceChanged=>" + e.IsNewDocument);
        }

        private void webView1_HistoryChanged(object sender, WebView2EventArgs e)
        {

        }

        private void webView1_NavigationCompleted(object sender, NavigationCompletedEventArgs e)
        {
            this.textBox1.Text =  this.webView1.Source;
            this.Text =this.webView1.BrowserVersion + "=>" + this.webView1.DocumentTitle;
        }

        private void webView1_AcceleratorKeyPressed(object sender, AcceleratorKeyPressedEventArgs e)
        {
            //MessageBox.Show(this, "webView1_AcceleratorKeyPressed");
            e.Handled = false;
        }

       

        private void webView1_DocumentTitleChanged(object sender, WebView2EventArgs e)
        {
            //MessageBox.Show(this, "webView1_DocumentTitleChanged");
        }

        private void webView1_ContainsFullScreenElementChanged(object sender, WebView2EventArgs e)
        {
            // MessageBox.Show(this, "webView1_ContainsFullScreenElementChanged");
        }

        private void webView1_WebViewGotFocus(object sender, WebView2EventArgs e)
        {
            //MessageBox.Show(this, "webView1_WebViewGotFocus");
        }

        private void webView1_FrameNavigationStarting(object sender, NavigationStartingEventArgs e)
        {
            //MessageBox.Show(this, "webView1_FrameNavigationStarting");
        }

        private void webView1_WebViewLostFocus(object sender, WebView2EventArgs e)
        {
            //MessageBox.Show(this, "webView1_WebViewLostFocus");
        }

        private void webView1_MoveFocusRequested(object sender, MoveFocusRequestedEventArgs e)
        {
            //MessageBox.Show(this, "webView1_MoveFocusRequested");
        }

        private void webView1_PermissionRequested(object sender, PermissionRequestedEventArgs e)
        {
            //MessageBox.Show(this, "webView1_PermissionRequested");
        }

        private void webView1_WebMessageReceived(object sender, WebMessageReceivedEventArgs e)
        {
            string message = e.WebMessageAsString;
                var rpc = Newtonsoft.Json.JsonConvert.DeserializeObject<Rpc>(message);

                switch (rpc.action)
                {
                    case "run_script":
                        this.webView1.InvokeScript(rpc.param.ToString());
                        break;
                    case "run_script_with_result":
                        string id = this.webView1.InvokeScript(rpc.param.ToString());
                        Rpc result = new Rpc()
                        {
                            id = id,
                            action = "get_script_result",
                            objId = rpc.objId,
                            param = id
                        };
                        string js = Newtonsoft.Json.JsonConvert.SerializeObject(result);
                        this.webView1.SendMessage(js);
                        break;
                    case "get_script_result":
                        string scriptId = rpc.param.ToString();
                        //if (window.ResultList.ContainsKey(scriptId))
                        //{
                        //    Rpc resultScriptResult = new Rpc()
                        //    {
                        //        id = rpc.id,
                        //        action = "return_script_result",
                        //        objId = rpc.objId,
                        //        param = window.ResultList[scriptId]
                        //    };
                        //    string jsResult = Newtonsoft.Json.JsonConvert.SerializeObject(resultScriptResult);
                        //    this.webView1.SendMessage(jsResult);


                        //}
                        break;
                    case "set_object_innerHtml":
                        this.webView1.InvokeScript($"document.getElementById('{rpc.objId}').innerHTML='{rpc.param}'");
                        break;
                }
        }

        private void webView1_WebResourceRequested(object sender, WebResourceRequestedEventArgs e)
        {
            Debug.Print(e.Request.Uri);
            Debug.Print(e.Request.Method);

        }

       
        private void webView1_ZoomFactorChanged(object sender, WebView2EventArgs e)
        {
            MessageBox.Show(this, "webView1_ZoomFactorChanged");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.webView1.OpenDevToolsWindow();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = this.webView1.BrowserVersion;
        }

        private void webView1_WebViewCreated(object sender, EventArgs e)
        {

            string value = File.ReadAllText("index.html");
            this.webView1.NavigateToString(value);

        }

        private void webView1_ScriptToExecuteOnDocumentCreatedCompleted(object sender, AddScriptToExecuteOnDocumentCreatedCompletedEventArgs e)
        {
            Debug.Print(e.Id);
        }
    }
}
