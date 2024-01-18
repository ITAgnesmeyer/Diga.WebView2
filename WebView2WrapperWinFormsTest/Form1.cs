using System;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using Diga.WebView2.Interop;
using Diga.WebView2.Scripting;
using Diga.WebView2.Scripting.DOM;
using Diga.WebView2.WinForms;
using Diga.WebView2.Wrapper;
using Diga.WebView2.Wrapper.EventArguments;
using Rectangle = System.Drawing.Rectangle;

namespace WebView2WrapperWinFormsTest
{


    public partial class Form1 : Form
    {
        private TestObject _TestObject;
        private Form _SecondForm;
        public Form1()
        {
            this._TestObject = new TestObject();

            InitializeComponent();
            this._SecondForm = new Form();
            WebView wv = new WebView();
            wv.SchemeRegistrations = this.webView1.SchemeRegistrations;

            wv.MonitoringFolder = this.webView1.MonitoringFolder;
            wv.MonitoringUrl = this.webView1.MonitoringUrl;
            wv.EnableMonitoring = this.webView1.EnableMonitoring;
            wv.EnableCgi = this.webView1.EnableCgi;
            wv.CgiExeFile = this.webView1.CgiExeFile;
            wv.CgiFileExtensions = this.webView1.CgiFileExtensions;
            wv.CgiMoitoringFolder = this.webView1.CgiMoitoringFolder;
            wv.CgiMoitoringUrl = this.webView1.CgiMoitoringUrl;
            wv.NavigationStart += (o, nse) =>
            {
                Debug.Print("second windows NavigationStart:" + nse.uri);
            };
            wv.WebResourceRequested += (o, wr) =>
            {
                Debug.Print("WEbResource requested:" + wr.Request.Uri);
            };
            wv.Dock = DockStyle.Fill;
            this._SecondForm.Controls.Add(wv);
            this._SecondForm.Show(this);
            this._SecondForm.Closing += (o, ec) =>
            {
                ec.Cancel = true;
                this._SecondForm.Visible = false;
            };



        }

        private void OnRpcEvent(object sender, RpcEventHandlerArgs e)
        {
            Debug.Print("RPCEVENT");

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

        private async void webView1_NavigationCompleted(object sender, NavigationCompletedEventArgs e)
        {
            Image img = await this.webView1.GetFavIconAsImageAsync(ImageFormat.Png);
            this.Icon = ImageToIcon(img);
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
            using (var def = e.GetDeferral())
            {
                MessageBox.Show(this, "webView1_PermissionRequested");
            }


        }

        private void webView1_WebMessageReceived(object sender, WebMessageReceivedEventArgs e)
        {
            string message = e.WebMessageAsString;
            if (string.IsNullOrEmpty(message))
                message = e.WebMessageAsJson;

            var rpc = Diga.Core.Json.DigaJson.Deserialize<RpcObject>(message);
            if (rpc == null)
                return;
            if (rpc.action == null)
                return;
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
            this.lblZoomFactor.Text = (this.webView1.ZoomFactor * 100).ToString(CultureInfo.InvariantCulture);
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
            Debug.Print("ScriptToExecuteOnDocumentCreatedCompleted:" + e.Id);
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
                //Script with Error
                //this throw ScriptException
                string script = "alert(\"hallo\"";
                string result = await this.webView1.EvalScriptAsync(script);
                await ShowMessageBoxAsync(result);
            }
            catch (ScriptException ex)
            {
                await ShowMessageBoxAsync(ex.ErrorObject.message);
            }


        }

        private Icon ImageToIcon(Image img)
        {
            Bitmap b = (Bitmap)img;
            IntPtr pIcon = b.GetHicon();
            Icon i = Icon.FromHandle(pIcon);
            return i;
        }
        private async void bnCapture_Click(object sender, EventArgs e)
        {
            Image imgIcon = await this.webView1.GetFavIconAsImageAsync(ImageFormat.Png);
            this.Icon = ImageToIcon(imgIcon);

            Image img = await this.webView1.CapturePreviewAsImageAsync(ImageFormat.Png);
            await this.webView1.UIDispatcher.InvokeAsync(() =>
            {
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

            });
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

            settings.Orientation = COREWEBVIEW2_PRINT_ORIENTATION.COREWEBVIEW2_PRINT_ORIENTATION_PORTRAIT;


            bool ok = await this.webView1.PrintToPdfAsync("C:\\temp\\test.pdf", settings);
            if (ok)
            {
                await this.webView1.GetDOMWindow().alertAsync("Content exported to PDF=C:\\temp\test.pdf");
            }
            else
            {
                await this.webView1.GetDOMWindow().alertAsync("could not export content to PDF!");
            }
        }

        private void webView1_DOMContentLoaded(object sender, DOMContentLoadedEventArgs e)
        {
            Debug.Print(e.NavigationId.ToString());
            //if(this._DIV != null)
            //    UIDispatcher.UIThread.Post(this._DIV.Dispose);
            //UIDispatcher.UIThread.Post(() =>
            //{
            //    DOMGC.CleanUp();
            //});


            this._DIV = null;

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

        //Dom-Object example
        private DOMElement _DIV;
        private void bnScriptTest_Click(object sender, EventArgs e)
        {
            //Get the script document


            if (this._DIV == null)
            {
                DOMDocument doc = this.webView1.GetDOMDocument();
                this._DIV = doc.createElement("div");
                this._DIV.id = Guid.NewGuid().ToString();
                doc.body.appendChild(this._DIV);

                //add a button element
                DOMElement element = doc.createElement("button");

                //set inner html of button 
                element.innerHTML = "Click Me";

                //set id of Button-Element
                element.id = Guid.NewGuid().ToString();

                //Get script window
                DOMWindow window = this.webView1.GetDOMWindow();

                //get the document body - Element
                this._DIV.appendChild(element);

                //handle the event
                // Important never call synchron Properties and Functions in an async function
                element.Click += OnDomElementClick1;
                element.Click += OnDomElementClick;

                element.MouseLeave += (o, args) =>
                {
                    try
                    {
                        element.style.backgroundColor = "blue";
                        element.style.color = "white";
                    }
                    catch (Exception exception)
                    {
                        Debug.Print("bnScriptTest_Click element.MouseLeave error:" + exception.Message);
                    }


                    //element.setAttribute("style","background-color: blue;color: white;");


                };

                element.MouseEnter += (o, args) =>
                {
                    try
                    {
                        element.style.backgroundColor = "white";
                        element.style.color = "black";

                    }
                    catch (Exception exception)
                    {
                        Debug.Print("bnScriptTest_Click element.MouseEnter error:" + exception.Message);
                    }
                    //element.setAttribute("style","background-color: white;color: black;");
                };

            }

        }

        private void OnDomElementClick1(object sender, DOMMouseEventArgs e)
        {
            if (sender is DOMElement element)
            {
                try
                {
                    //await element.setAttributeAsync("style", "background-color: coral;");
                    //ev.Event.relatedTarget.setAttribute("style", "background-color: coral;");
                    //DOMStyle style = await element.styleAsync;

                    element.style.backgroundColor = "coral";



                    //style.backgroundColorAsync = (StringTaskVar)"coral";

                    //read the values of MouseEvent-Object
                    int button = e.Event.button;
                    bool isAlt = e.Event.altKey;
                    bool isShift = e.Event.shiftKey;

                    //Show the information in alert
                    this.webView1.GetDOMWindow().alert($"set=>isShift={isShift}, isAlt={isAlt}, buttonNr={button}");

                    element.Click -= OnDomElementClick1;
                    MessageBox.Show("Event1 entzogen");

                }
                catch (Exception exception)
                {
                    MessageBox.Show("Error:" + exception.Message);
                    //await ShowMessageBoxAsync("Error:" + exception.Message);

                }
            }
        }

        private void OnDomElementClick(object sender, DOMMouseEventArgs e)
        {
            if (sender is DOMElement element)
            {
                DOMLocation location = new DOMLocation(this.webView1);
                try
                {

                    location.href = "/counter";
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.ToString());
                }

            }
        }

        private async Task ShowMessageBoxAsync(string message, string caption = "Message")
        {
            await this.webView1.GetDOMWindow().alertAsync(message);

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
                //string file = ofd.FileName;
                //Uri uri = new Uri(file);

                this.webView1.Navigate(ofd.FileName);
            }


        }

        private void bnSrc_Click(object sender, EventArgs e)
        {
            

            if (this.webView1.Content.Count <= 0)
                return;

            using (frmSrc src = new frmSrc(this.webView1.Content))
            {
                src.ShowDialog(this);
            }
        }

        private void bnSrcTest_Click(object sender, EventArgs e)
        {
            this.webView1.ShowPageSource();
        }

        private void webView1_IsDocumentPlayingAudioChanged(object sender, WebView2EventArgs e)
        {
            if (this.lblMuted.Text == "PLAY")
            {
                this.lblMuted.Text = "STOP";
            }
            else
            {
                this.lblMuted.Text = "PLAY";
            }
        }

        private void lblMuted_Click(object sender, EventArgs e)
        {

            this.webView1.IsMuted = !this.webView1.IsMuted;
            if (this.webView1.IsMuted)
            {
                this.lblMuted.BackColor = Color.Red;
            }
            else
            {
                this.lblMuted.BackColor = Color.Green;
            }



        }

        private void bnScriptSync_Click(object sender, EventArgs e)
        {
            try
            {
                string script = "5+1";
                string result = this.webView1.EvalScriptSync(script);
                MessageBox.Show(result);
            }
            catch (ScriptException exception)
            {
                MessageBox.Show(exception.ErrorObject.message);
            }

            try
            {
                string script = "alert(\"hallo\"";
                string result = this.webView1.EvalScriptSync(script);
                MessageBox.Show(result);
            }
            catch (ScriptException exception)
            {
                MessageBox.Show(exception.ErrorObject.message);

            }

            try
            {
                string script = "return 5+1;";
                string result = this.webView1.ExecuteScriptSync(script);
                MessageBox.Show(result);
            }
            catch (ScriptException exception)
            {
                MessageBox.Show(exception.ErrorObject.message);
            }

            try
            {
                string script = "alert(\"hallo\";";
                string result = this.webView1.ExecuteScriptSync(script);
                MessageBox.Show(result);
            }
            catch (ScriptException exception)
            {
                MessageBox.Show(exception.ErrorObject.message);

            }
        }

        private void webView1_DocumentLoading(object sender, EventArgs e)
        {
            Debug.Print("DOM-Loading");
        }

        private void webView1_DocumentUnload(object sender, EventArgs e)
        {

            this._DIV = null;


            Debug.Print("Unload Document");
        }


        private WebView2ContextMenuItem _Item;
        private WebView2ContextMenuItem _Sub1;

        /* Nicht gemergte Änderung aus Projekt "WebView2WrapperWinFormsTest.Core (net7.0-windows)"
        Vor:
                private void webView1_ContextMenuRequested(object sender, Diga.WebView2.Wrapper.Handler.ContextMenuRequestedEventArgs e)
        Nach:
                private void webView1_ContextMenuRequested(object sender, Diga.WebView2.Wrapper.EventArguments.ContextMenuRequestedEventArgs e)
        */

        /* Nicht gemergte Änderung aus Projekt "WebView2WrapperWinFormsTest.Core (net8.0-windows)"
        Vor:
                private void webView1_ContextMenuRequested(object sender, Diga.WebView2.Wrapper.Handler.ContextMenuRequestedEventArgs e)
        Nach:
                private void webView1_ContextMenuRequested(object sender, Diga.WebView2.Wrapper.EventArguments.ContextMenuRequestedEventArgs e)
        */

        /* Nicht gemergte Änderung aus Projekt "WebView2WrapperWinFormsTest.Core (net6.0-windows)"
        Vor:
                private void webView1_ContextMenuRequested(object sender, Diga.WebView2.Wrapper.Handler.ContextMenuRequestedEventArgs e)
        Nach:
                private void webView1_ContextMenuRequested(object sender, Diga.WebView2.Wrapper.EventArguments.ContextMenuRequestedEventArgs e)
        */
        private void webView1_ContextMenuRequested(object sender, ContextMenuRequestedEventArgs e)
        {
            using (var c = e.GetDeferral())
            {
                if (e.ContextMenuTarget.Kind ==
                    COREWEBVIEW2_CONTEXT_MENU_TARGET_KIND.COREWEBVIEW2_CONTEXT_MENU_TARGET_KIND_PAGE)
                {

                    uint count = e.MenuItems.Count;

                    if (this._Sub1 == null)
                    {
                        this._Item = this.webView1.CreateContextMenuItem("test", null,
                            COREWEBVIEW2_CONTEXT_MENU_ITEM_KIND.COREWEBVIEW2_CONTEXT_MENU_ITEM_KIND_COMMAND);
                        this._Item.CustomItemSelected += (oo, ee) =>
                        {


                            ScriptContext.Run(() =>
                            {
                                var profile = this.webView1.Profile;
                                string message = $"Profile:{Environment.NewLine}";
                                message += $"Download Folder:{profile.DefaultDownloadFolderPath}{Environment.NewLine}";
                                message += $"Is Private Mode:{profile.IsInPrivateModeEnabled}{Environment.NewLine}";
                                message += $"Preferred color scheme:{profile.PreferredColorScheme}{Environment.NewLine}";
                                message += $"Profile Name:{profile.ProfileName}{Environment.NewLine}";
                                this.webView1.GetDOMWindow().alert(message);
                            });


                        };
                        this._Sub1 = this.webView1.CreateContextMenuItem("sub1", null,
                            COREWEBVIEW2_CONTEXT_MENU_ITEM_KIND.COREWEBVIEW2_CONTEXT_MENU_ITEM_KIND_SUBMENU);
                        this._Sub1.Children.InsertValueAtIndex(0, this._Item);
                        e.MenuItems.InsertValueAtIndex(count, this._Sub1);
                    }
                    else
                    {

                        e.MenuItems.RemoveValueAtIndex(0);
                        e.MenuItems.RemoveValueAtIndex(0);

                        count--;
                        count--;
                        //bool ok = false;
                        e.MenuItems.InsertValueAtIndex(count, this._Sub1);
                        //e.Handled = true;
                    }
                }
            }

        }

        private void webView1_NewWindowRequested(object sender, NewWindowRequestedEventArgs e)
        {
            using (var def = e.GetDeferral())
            {
                this._SecondForm.Visible = true;

                if (this._SecondForm.Controls[0] is WebView wv)
                {
                    this._SecondForm.Visible = true;
                    //wv.Navigate(e.uri);
                    //e.NewWindow = wv.WebView2;
                    if (e.WindowFeatures != null)
                    {
                        if (e.WindowFeatures.HasSize == 1)
                        {
                            this._SecondForm.Width = (int)e.WindowFeatures.Width;
                            this._SecondForm.Height = (int)e.WindowFeatures.Height;
                        }

                        if (e.WindowFeatures.HasPosition == 1)
                        {
                            this._SecondForm.Left = (int)e.WindowFeatures.left;
                            this._SecondForm.Top = (int)e.WindowFeatures.top;
                        }
                    }
                    wv.Navigate(e.uri);
                    e.Handled = 1;
                }


            }
        }

        private void buildFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DOMDocument doc = this.webView1.GetDOMDocument();
            DOMElement form = doc.createElement("form");
            form.id = "mainFrom";
            //form.setAttribute("method","GET");
            form.setAttribute("action", "https://5b834d57-0891-4730-b6ba-c793b4e76468/");
            //form.setAttribute("encrypt","multipart/form-data");

            DOMElement userfile = doc.createElement("input");
            userfile.setAttribute("type", "file");
            userfile.setAttribute("name", "userfile");
            userfile.id = "userFile";
            form.appendChild(userfile);
            DOMElement br = doc.createElement("br");
            form.appendChild(br);
            DOMElement upload_btn = doc.createElement("input");
            upload_btn.setAttribute("type", "submit");
            upload_btn.setAttribute("name", "upload_btn");
            upload_btn.setAttribute("value", "upload");
            form.appendChild(upload_btn);
            DOMEventListenerScript scr = new DOMEventListenerScript(userfile, "change");
            userfile.addEventListener("change", scr, false);
            doc.body.appendChild(form);
            userfile.DomEvent += (o, ev) =>
            {
                try
                {
                    string objId = ev.RpcObject.objId;
                    string value = userfile.GetProperty<string>("value");
                    string fullPath = userfile.GetProperty<string>("files[0].name");
                    MessageBox.Show($"Event:{ev.EventName}\nObjId:{objId}\nElement_EventID:{ev.ObjectId}\nElement:{userfile.id}\nValue:{value}");

                    DOMElement x = doc.createElement("h1");
                    x.innerText = value;
                    doc.body.appendChild(x);

                }
                catch (Exception exception)
                {
                    MessageBox.Show(this, "Error:" + exception.Message, "Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            };

        }


        private void lblMenu_Click(object sender, EventArgs e)
        {
            contextMenuMore.Show(lblMenu, 0, lblMenu.Height);

        }

        private void multipleControlsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (MultipleControls multipeControls = new MultipleControls())
            {
                multipeControls.ShowDialog(this);
            }

        }

        private void webView1_CompoisitionControllerCursorChanged(object sender, CursorChangedEventArgs e)
        {
            IntPtr cursorId = e.CompositionController.Cursor;
            Cursor cursor = new Cursor(cursorId);
            this.Cursor = cursor;
            Debug.Print("webView1_CompoisitionControllerCursorChanged");
        }
    }
}
