using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

using Diga.WebView2.Wrapper;
using Diga.WebView2.Wrapper.EventArguments;

namespace WebView2WrapperWinFormsTest
{
    public partial class Form1 : Form
    {
       private TestObject _TestObject;
        public Form1()
        {
            this._TestObject = new TestObject();
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
            if(e.IsSuccess == true)
            {
                this.Text = this.webView1.BrowserVersion + "=>" + this.webView1.DocumentTitle;
            }
            else
            {
                this.Text = this.webView1.BrowserVersion + "=> Error=" + e.GetErrorText() + "->" + e.WebErrorStatus;
            }
            
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
            MessageBox.Show(this, "webView1_FrameNavigationStarting");
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
            
#if CORE
            //this.webView1.OpenDevToolsWindow();
            this.webView1.RemoteObjectsAllowed = true;
#endif//0E1B9FCAB5-FB86-4D78-91DE-7BC2B4077E5B
            //this.webView1.AddRemoteObject("{60A417CA-F1AB-4307-801B-F96003F8938B} Host Object Helper", (object) new HostObjectHelper());
            //this.webView1.AddRemoteObject("0E1B9FCAB5-FB86-4D78-91DE-7BC2B4077E5", (object) new HostObjectHelper());
            this._TestObject.Name = "hallo Welt";
            this.webView1.AddRemoteObject("testObject", this._TestObject);
            string value = File.ReadAllText("index.html");
            this.webView1.NavigateToString(value);
            this.textBox1.AutoCompleteCustomSource.Add(this.webView1.MonitoringUrl);
            

        }

        private void webView1_ScriptToExecuteOnDocumentCreatedCompleted(object sender, AddScriptToExecuteOnDocumentCreatedCompletedEventArgs e)
        {
            Debug.Print(e.Id);
        }

        private async void bnScript_Click(object sender, EventArgs e)
        {
            string script = "2+3";
            string result = await this.webView1.ExecuteScriptAsync(script);
            MessageBox.Show(result);
        }

        private async void bnCapture_Click(object sender, EventArgs e)
        {
            Image img = await this.webView1.CapturePreviewAsImageAsync(ImageFormat.Png);
            Form frm = new Form();
            frm.Width = img.Width;
            frm.Height = img.Height;
            frm.StartPosition = FormStartPosition.CenterParent;
            PictureBox pb = new PictureBox();
            pb.Dock = DockStyle.Fill;
            pb.Image = img;
            frm.Controls.Add(pb);
            frm.ShowDialog(this);
        }

        private void webView1_FrameNavigationCompleted(object sender, NavigationCompletedEventArgs e)
        {
            MessageBox.Show(this, "webView1_FrameNavigationCompleted");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
           
        }

        private void webView1_BeforeWebViewDestroy(object sender, EventArgs e)
        {
            //this.webView1.RemoveRemoteObject("{60A417CA-F1AB-4307-801B-F96003F8938B} Host Object Helper");
            //this.webView1.RemoveRemoteObject("testObject");
            

        }
    }
}
