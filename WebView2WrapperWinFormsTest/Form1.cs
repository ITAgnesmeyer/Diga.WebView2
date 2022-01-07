﻿using System;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using Diga.WebView2.WinForms.Scripting;
using Diga.WebView2.WinForms.Scripting.DOM;
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

        private async void OnRpcEvent(object sender, RpcEventHandlerArgs e)
        {
            //string eventName = e.EventName;
            //string id = e.ObjectId;



            //IRpcObject rpcCls = e.RpcObject;




            //string objId = rpcCls.objId;
            //switch (eventName)
            //{
            //    case "click":
            //        {

            //            await this.webView1.GetDOMConsole().log("Hallo from Prog");
            //            DOMWindow win = this.webView1.GetDOMWindow();
            //            string name = await win.name;
            //            DOMWindow val = await win.open("", "test", "width=200,height=100");

            //            string nn = await val.name;
            //            val.name = (TaskVar<string>)"hallox";
            //            var docuemnt = await val.document;
            //            var bn = await docuemnt.createElement("button");
            //            bn.innerHTML=(TaskVar<string>)"hallo";
            //            bn.id = (TaskVar<string>)"ABC";
            //            await bn.addEventListener("click", new DOMEventListenerScript(bn), false);
            //            var vladoc = await val.document;
            //            var body = await vladoc.body;
            //            await body.appendChild(bn);
            //            nn = "name=" + nn;
            //            await win.alert("Warten");
            //            await val.alert(nn);
            //            DOMConsole console = await val.console;

            //            await console.log("werte die ich kenne");
            //            await val.moveBy(100, 100);
            //            await win.alert("Move");
            //            await val.moveTo(200, 200);
            //            win.name = (TaskVar<string>)"halllo";
                        
            //            await win.alert("Object Click:" + objId);

            //        }

            //        break;
            //}
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
            this.textBox1.Text = this.webView1.Source;
            if (e.IsSuccess == true)
            {
                this.Text = this.webView1.BrowserVersion + "=>" + this.webView1.DocumentTitle;
            }
            else
            {
                this.Text = this.webView1.BrowserVersion + "=> Error=" + e.GetErrorText() + "->" + e.WebErrorStatus;
            }

        }

        private Rectangle LastBound;
        private void webView1_AcceleratorKeyPressed(object sender, AcceleratorKeyPressedEventArgs e)
        {
            //MessageBox.Show(this, "webView1_AcceleratorKeyPressed");
            if (e.VirtualKey == 122 && e.KeyVentType == KeyEventType.KeyDown)
            {
                if (this.FormBorderStyle == FormBorderStyle.None)
                {
                    this.panel1.Visible = true;
                    this.FormBorderStyle = FormBorderStyle.Sizable;
                    this.WindowState = FormWindowState.Normal;
                    this.Bounds = this.LastBound;
                    e.Handled = true;
                    return;
                }
                else
                {

                    this.LastBound = this.Bounds;
                    this.panel1.Visible = false;
                    var rect = Screen.GetBounds(this);
                    this.FormBorderStyle = FormBorderStyle.None;
                    this.Bounds = rect;
                    e.Handled = true;
                    return;
                }

            }
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
            var rpc = Diga.Core.Json.DigaJson.Deserialize<RpcObject>(message);

            switch (rpc.action)
            {
                case "run_script":
                    this.webView1.InvokeScript(rpc.param.ToString());
                    break;
                case "run_script_with_result":
                    string id = this.webView1.InvokeScript(rpc.param.ToString());
                    RpcObject result = new RpcObject()
                    {
                        id = id,
                        action = "get_script_result",
                        objId = rpc.objId,
                        param = id
                    };
                    string js = Diga.Core.Json.DigaJson.Serialize(result);
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
            this.lblZoomFactor.Text = (this.webView1.ZoomFactor * 100).ToString();
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


            this._TestObject.Name = "hallo Welt";
            this.webView1.AddRemoteObject("testObject", this._TestObject);
            string value = File.ReadAllText("index.html");
            this.webView1.NavigateToString(value);
            this.textBox1.AutoCompleteCustomSource.Add(this.webView1.MonitoringUrl);
            this.textBox1.AutoCompleteCustomSource.Add(this.webView1.MonitoringUrl + "mp3test/testmp3.html");


        }

        private void webView1_ScriptToExecuteOnDocumentCreatedCompleted(object sender, AddScriptToExecuteOnDocumentCreatedCompletedEventArgs e)
        {
            Debug.Print(e.Id);
        }

        private async void bnScript_Click(object sender, EventArgs e)
        {

            try
            {
                string script = "5+1";
                string result = await this.webView1.EvalScriptAsync(script);
                await ShowMessageBoxAsync(result);
            }
            catch (ScriptException ex)
            {

                await ShowMessageBoxAsync(ex.ErrorObject.message);
            }

            try
            {
                string script = "alert(\"hallo\"";
                string result = await this.webView1.EvalScriptAsync(script);
                await ShowMessageBoxAsync(result);
            }
            catch (ScriptException ex)
            {
                 await ShowMessageBoxAsync(ex.ErrorObject.message);
            }


        }

        private async void bnCapture_Click(object sender, EventArgs e)
        {
            Image img = await this.webView1.CapturePreviewAsImageAsync(ImageFormat.Png);
            Form frm = new Form
            {
                Width = img.Width,
                Height = img.Height,
                StartPosition = FormStartPosition.CenterParent
            };
            PictureBox pb = new PictureBox
            {
                Dock = DockStyle.Fill,
                Image = img
            };
            frm.Controls.Add(pb);
            frm.ShowDialog(this);
        }

        private void webView1_FrameNavigationCompleted(object sender, NavigationCompletedEventArgs e)
        {
            //MessageBox.Show(this, "webView1_FrameNavigationCompleted");

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //this.webView1.Dispose();
        }

        private void webView1_BeforeWebViewDestroy(object sender, EventArgs e)
        {
            //this.webView1.RemoveRemoteObject("{60A417CA-F1AB-4307-801B-F96003F8938B} Host Object Helper");
            //this.webView1.RemoveRemoteObject("testObject");
            //this.webView1.RemoveRemoteObject("RpcHandler");

        }

        private async void bnPostMessage_Click(object sender, EventArgs e)
        {
            WebView2PrintSettings settings = this.webView1.CreatePrintSettings();
            bool ok = await this.webView1.PrintToPdfAsync("C:\\temp\\test.pdf", settings);
        }

        private void webView1_DOMContentLoaded(object sender, DOMContentLoadedEventArgs e)
        {
            Debug.Print(e.NavigationId.ToString());

        }

        private void webView1_WebResourceResponseReceived(object sender, WebResourceResponseReceivedEventArgs e)
        {
            //Debug.Print(e.Request.Uri);
            //Debug.Print(e.Response.StatusCode.ToString());
            //Debug.Print(e.Response.ReasonPhrase);
            //var it = e.Response.Headers.GetIterator();

            //if (it.HasCurrent)
            //    Debug.Print(it.Current.Name + "," + it.Current.Value);
            //while (it.MoveNext())
            //{
            //    Debug.Print(it.Current.Name + "," + it.Current.Value);
            //}
        }


        private void webView1_FrameCreated(object sender, FrameCreatedEventArgs e)
        {

            e.Frame.FrameDestroyed += (s, o) =>
            {

                if (o.Frame != null)
                {
                    if (e.Frame.IsDestroyed() == 0)
                    {
                        Debug.Print("Frame Name:" + o.Frame.name);
                    }


                }
                Debug.Print("Frame Destroyed");
            };

            e.Frame.FrameNameChanged += (s, o) =>
            {
                Debug.Print("FrameNameChanged:" + e.Frame.name);
            };
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.webView1.OpenTaskManagerWindow();
        }

        private void webView1_DownloadStarting(object sender, DownloadStartingEventArgs e)
        {
            WebView2DownloadOperation opt = e.DownloadOperation;
            opt.BytesReceivedChanged += OnByteReceived;
            opt.EstimatedEndTimeChanged += OnEstimatedEndTimeChanged;
            opt.StateChanged += OnDownloadStateChanged;
        }

        private void OnDownloadStateChanged(object sender, WebView2EventArgs e)
        {
            if (sender is WebView2DownloadOperation opt)
            {
                Debug.Print("Download State Changed:" + opt.State.ToString());
            }
        }

        private void OnEstimatedEndTimeChanged(object sender, WebView2EventArgs e)
        {
            if (sender is WebView2DownloadOperation opt)
            {
                Debug.Print("EstimatedEndTime:" + opt.EstimatedEndTime);

            }

        }

        private void OnByteReceived(object sender, WebView2EventArgs e)
        {
            if (sender is WebView2DownloadOperation opt)
            {
                Debug.Print("Byte Received:" + opt.BytesReceived);

            }
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            double dbl = this.trackBar1.Value / 100.000;
            if (dbl == 0)
                dbl = 1;
            this.webView1.ZoomFactor = dbl;
            this.lblZoomFactor.Text = (dbl * 100).ToString(CultureInfo.CurrentCulture);
        }

        private async void bnScriptTest_Click(object sender, EventArgs e)
        {
            DOMDocument doc = this.webView1.GetDOMDocument();
            DOMElement element = await  doc.createElement("button");
            element.innerHTML=(TaskVar<string>)"Click Me";
            element.id = (TaskVar<string>)Guid.NewGuid().ToString();
            DOMWindow window = this.webView1.GetDOMWindow();
            DOMEventListenerScript scriptText = new DOMEventListenerScript(element);
            var docBody = await doc.body;
            await docBody.appendChild(element);
            await element.addEventListener("click", scriptText, true);
            element.DomEvent += async (o,ev) =>
            {
                if (ev.EventName == "click")
                {
                    DOMMouseEvent me = element.GetDomObjectFromVarName<DOMMouseEvent>(ev.RpcObject.idFullName);
                    await element.setAttribute("style", "background-color: coral;");
                    int button = await me.button;
                    bool isAlt = await me.altKey;
                    bool isShift = await me.shiftKey;
                    await window.alert($"set=>isShift={isShift}, isAlt={isAlt}, buttonNr={button}");

                }
            };
          

           
        }
        private async Task ShowMessageBoxAsync(string message, string caption = "Message")
        {
            await this.webView1.GetDOMWindow().alert(message);

        }
        private void ShowMessageBox(string message, string caption = "Message")
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new Action<string, string>(ShowMessageBox), new object[] { message, caption });

            }
            else
            {
                MessageBox.Show(this, message, caption);
            }
        }

        private void webView1_ExecuteScriptCompleted(object sender, ExecuteScriptCompletedEventArgs e)
        {
            if (e.ErrorCode != 0)
            {
                Debug.Print(e.ResultObjectAsJson);
            }
        }

        private void webView1_ScriptDialogOpening(object sender, ScriptDialogOpeningEventArgs e)
        {
            Debug.Print(e.Message);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = @"*.mp3|*.mp3";
            ofd.Multiselect = false;
            DialogResult result = ofd.ShowDialog(this);
            if (result == DialogResult.OK)
            {
                string file = ofd.FileName;
                Uri uri = new Uri(file);

                this.webView1.Navigate(uri.AbsolutePath);
            }


        }

        private void bnSrc_Click(object sender, EventArgs e)
        {
            if (this.webView1.Content.Count <= 0) return;

            using (frmSrc src = new frmSrc(this.webView1.Content))
            {
                src.ShowDialog(this);
            }
        }

        private async void bnSrcTest_Click(object sender, EventArgs e)
        {
            this.webView1.ShowPageSource();
        }
    }
}
