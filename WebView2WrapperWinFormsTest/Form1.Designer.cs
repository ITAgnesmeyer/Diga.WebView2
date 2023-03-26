namespace WebView2WrapperWinFormsTest
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblMenu = new System.Windows.Forms.Label();
            this.bnScriptSync = new System.Windows.Forms.Button();
            this.lblMuted = new System.Windows.Forms.Label();
            this.bnSrcTest = new System.Windows.Forms.Button();
            this.bnSrc = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.bnScriptTest = new System.Windows.Forms.Button();
            this.lblZoomFactor = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.button5 = new System.Windows.Forms.Button();
            this.bnPostMessage = new System.Windows.Forms.Button();
            this.bnCapture = new System.Windows.Forms.Button();
            this.bnScript = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.webView1 = new Diga.WebView2.WinForms.WebView();
            this.contextMenuMore = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.buildFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.panel2.SuspendLayout();
            this.contextMenuMore.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblMenu);
            this.panel1.Controls.Add(this.bnScriptSync);
            this.panel1.Controls.Add(this.lblMuted);
            this.panel1.Controls.Add(this.bnSrcTest);
            this.panel1.Controls.Add(this.bnSrc);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.bnScriptTest);
            this.panel1.Controls.Add(this.lblZoomFactor);
            this.panel1.Controls.Add(this.trackBar1);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.bnPostMessage);
            this.panel1.Controls.Add(this.bnCapture);
            this.panel1.Controls.Add(this.bnScript);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1325, 32);
            this.panel1.TabIndex = 0;
            // 
            // lblMenu
            // 
            this.lblMenu.AutoSize = true;
            this.lblMenu.Location = new System.Drawing.Point(1156, 12);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(31, 13);
            this.lblMenu.TabIndex = 17;
            this.lblMenu.Text = "More";
            this.lblMenu.Click += new System.EventHandler(this.lblMenu_Click);
            // 
            // bnScriptSync
            // 
            this.bnScriptSync.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bnScriptSync.Location = new System.Drawing.Point(819, 3);
            this.bnScriptSync.Name = "bnScriptSync";
            this.bnScriptSync.Size = new System.Drawing.Size(43, 23);
            this.bnScriptSync.TabIndex = 16;
            this.bnScriptSync.Text = "Script";
            this.bnScriptSync.UseVisualStyleBackColor = true;
            this.bnScriptSync.Click += new System.EventHandler(this.bnScriptSync_Click);
            // 
            // lblMuted
            // 
            this.lblMuted.AutoSize = true;
            this.lblMuted.BackColor = System.Drawing.SystemColors.Info;
            this.lblMuted.Location = new System.Drawing.Point(1287, 10);
            this.lblMuted.Name = "lblMuted";
            this.lblMuted.Size = new System.Drawing.Size(38, 13);
            this.lblMuted.TabIndex = 15;
            this.lblMuted.Text = "Sound";
            this.lblMuted.Click += new System.EventHandler(this.lblMuted_Click);
            // 
            // bnSrcTest
            // 
            this.bnSrcTest.Location = new System.Drawing.Point(1237, 7);
            this.bnSrcTest.Name = "bnSrcTest";
            this.bnSrcTest.Size = new System.Drawing.Size(41, 20);
            this.bnSrcTest.TabIndex = 14;
            this.bnSrcTest.Text = "SRC";
            this.bnSrcTest.UseVisualStyleBackColor = true;
            this.bnSrcTest.Click += new System.EventHandler(this.bnSrcTest_Click);
            // 
            // bnSrc
            // 
            this.bnSrc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bnSrc.Location = new System.Drawing.Point(995, 3);
            this.bnSrc.Name = "bnSrc";
            this.bnSrc.Size = new System.Drawing.Size(34, 24);
            this.bnSrc.TabIndex = 13;
            this.bnSrc.Text = "SRC";
            this.bnSrc.UseVisualStyleBackColor = true;
            this.bnSrc.Click += new System.EventHandler(this.bnSrc_Click);
            // 
            // button6
            // 
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Location = new System.Drawing.Point(952, 3);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(37, 23);
            this.button6.TabIndex = 12;
            this.button6.Text = "MP3";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // bnScriptTest
            // 
            this.bnScriptTest.Location = new System.Drawing.Point(1201, 7);
            this.bnScriptTest.Name = "bnScriptTest";
            this.bnScriptTest.Size = new System.Drawing.Size(30, 20);
            this.bnScriptTest.TabIndex = 11;
            this.bnScriptTest.Text = "ST";
            this.bnScriptTest.UseVisualStyleBackColor = true;
            this.bnScriptTest.Click += new System.EventHandler(this.bnScriptTest_Click);
            // 
            // lblZoomFactor
            // 
            this.lblZoomFactor.AutoSize = true;
            this.lblZoomFactor.Location = new System.Drawing.Point(1124, 10);
            this.lblZoomFactor.Name = "lblZoomFactor";
            this.lblZoomFactor.Size = new System.Drawing.Size(25, 13);
            this.lblZoomFactor.TabIndex = 10;
            this.lblZoomFactor.Text = "100";
            // 
            // trackBar1
            // 
            this.trackBar1.AutoSize = false;
            this.trackBar1.Location = new System.Drawing.Point(1035, 6);
            this.trackBar1.Maximum = 500;
            this.trackBar1.Minimum = 1;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(83, 20);
            this.trackBar1.TabIndex = 9;
            this.trackBar1.Value = 100;
            this.trackBar1.ValueChanged += new System.EventHandler(this.trackBar1_ValueChanged);
            // 
            // button5
            // 
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("MS UI Gothic", 8.25F);
            this.button5.Location = new System.Drawing.Point(722, 3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(33, 23);
            this.button5.TabIndex = 8;
            this.button5.Text = "☰";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // bnPostMessage
            // 
            this.bnPostMessage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bnPostMessage.Location = new System.Drawing.Point(913, 3);
            this.bnPostMessage.Name = "bnPostMessage";
            this.bnPostMessage.Size = new System.Drawing.Size(33, 23);
            this.bnPostMessage.TabIndex = 7;
            this.bnPostMessage.Text = "PDF";
            this.bnPostMessage.UseVisualStyleBackColor = true;
            this.bnPostMessage.Click += new System.EventHandler(this.bnPostMessage_Click);
            // 
            // bnCapture
            // 
            this.bnCapture.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bnCapture.Location = new System.Drawing.Point(868, 3);
            this.bnCapture.Name = "bnCapture";
            this.bnCapture.Size = new System.Drawing.Size(39, 23);
            this.bnCapture.TabIndex = 6;
            this.bnCapture.Text = "Capture";
            this.bnCapture.UseVisualStyleBackColor = true;
            this.bnCapture.Click += new System.EventHandler(this.bnCapture_Click);
            // 
            // bnScript
            // 
            this.bnScript.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bnScript.Location = new System.Drawing.Point(762, 3);
            this.bnScript.Name = "bnScript";
            this.bnScript.Size = new System.Drawing.Size(51, 23);
            this.bnScript.TabIndex = 5;
            this.bnScript.Text = "Async Script";
            this.bnScript.UseVisualStyleBackColor = true;
            this.bnScript.Click += new System.EventHandler(this.bnScript_Click);
            // 
            // button4
            // 
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("MS UI Gothic", 8.25F);
            this.button4.Location = new System.Drawing.Point(683, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(33, 23);
            this.button4.TabIndex = 4;
            this.button4.Text = "☰";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F);
            this.button3.Location = new System.Drawing.Point(37, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(32, 24);
            this.button3.TabIndex = 3;
            this.button3.Text = "▶";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F);
            this.button2.Location = new System.Drawing.Point(3, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(32, 24);
            this.button2.TabIndex = 2;
            this.button2.Text = "◀";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(644, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(33, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "GO";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.AutoCompleteCustomSource.AddRange(new string[] {
            "https://www.google.de",
            "https://www.itagnesmeyer.de",
            "https://github.com/ITAgnesmeyer/DigaDeployServer/releases/download/v0.0.0.1/DPack" +
                ".pack",
            "https://github.com/ITAgnesmeyer/DigaDeployServer/releases/download/v0.0.0.1/test_" +
                "x.zip",
            "https://www.youtube.com/watch?v=yE99DKTz09M"});
            this.textBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.textBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBox1.Location = new System.Drawing.Point(75, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(563, 20);
            this.textBox1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.webView1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 32);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1325, 418);
            this.panel2.TabIndex = 1;
            // 
            // webView1
            // 
            this.webView1.AreBrowserAcceleratorKeysEnabled = true;
            this.webView1.BackColor = System.Drawing.Color.Black;
            this.webView1.CgiExeFile = "C:\\php\\php-cgi.exe";
            this.webView1.CgiMoitoringFolder = "C:\\TEMP";
            this.webView1.CgiMoitoringUrl = "https://localhost:1/";
            this.webView1.DefaultBackgroundColor = System.Drawing.Color.AliceBlue;
            this.webView1.DefaultContextMenusEnabled = true;
            this.webView1.DefaultScriptDialogsEnabled = true;
            this.webView1.DevToolsEnabled = true;
            this.webView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webView1.EnableCgi = true;
            this.webView1.EnableMonitoring = true;
            this.webView1.HtmlContent = null;
            this.webView1.IsGeneralAutoFillEnabled = true;
            this.webView1.IsMuted = false;
            this.webView1.IsPasswordAutosaveEnabled = true;
            this.webView1.IsScriptEnabled = true;
            this.webView1.IsStatusBarEnabled = true;
            this.webView1.IsWebMessageEnabled = true;
            this.webView1.IsZoomControlEnabled = true;
            this.webView1.Location = new System.Drawing.Point(0, 0);
            this.webView1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.webView1.MonitoringFolder = ".\\wwwroot";
            this.webView1.MonitoringUrl = "https://5b834d57-0891-4730-b6ba-c793b4e76468/";
            this.webView1.Name = "webView1";
            this.webView1.RemoteObjectsAllowed = true;
            this.webView1.Size = new System.Drawing.Size(1325, 418);
            this.webView1.TabIndex = 0;
            this.webView1.Url = "https://www.itagnesmeyer.de";
            this.webView1.ZoomFactor = 1D;
            this.webView1.NavigationStart += new System.EventHandler<Diga.WebView2.Wrapper.EventArguments.NavigationStartingEventArgs>(this.webView1_NavigationStart);
            this.webView1.ContentLoading += new System.EventHandler<Diga.WebView2.Wrapper.EventArguments.ContentLoadingEventArgs>(this.webView1_ContentLoading);
            this.webView1.SourceChanged += new System.EventHandler<Diga.WebView2.Wrapper.EventArguments.SourceChangedEventArgs>(this.webView1_SourceChanged);
            this.webView1.HistoryChanged += new System.EventHandler<Diga.WebView2.Wrapper.EventArguments.WebView2EventArgs>(this.webView1_HistoryChanged);
            this.webView1.NavigationCompleted += new System.EventHandler<Diga.WebView2.Wrapper.EventArguments.NavigationCompletedEventArgs>(this.webView1_NavigationCompleted);
            this.webView1.WebResourceRequested += new System.EventHandler<Diga.WebView2.Wrapper.EventArguments.WebResourceRequestedEventArgs>(this.webView1_WebResourceRequested);
            this.webView1.AcceleratorKeyPressed += new System.EventHandler<Diga.WebView2.Wrapper.EventArguments.AcceleratorKeyPressedEventArgs>(this.webView1_AcceleratorKeyPressed);
            this.webView1.WebViewGotFocus += new System.EventHandler<Diga.WebView2.Wrapper.EventArguments.WebView2EventArgs>(this.webView1_WebViewGotFocus);
            this.webView1.WebViewLostFocus += new System.EventHandler<Diga.WebView2.Wrapper.EventArguments.WebView2EventArgs>(this.webView1_WebViewLostFocus);
            this.webView1.MoveFocusRequested += new System.EventHandler<Diga.WebView2.Wrapper.EventArguments.MoveFocusRequestedEventArgs>(this.webView1_MoveFocusRequested);
            this.webView1.ZoomFactorChanged += new System.EventHandler<Diga.WebView2.Wrapper.EventArguments.WebView2EventArgs>(this.webView1_ZoomFactorChanged);
            this.webView1.DocumentTitleChanged += new System.EventHandler<Diga.WebView2.Wrapper.EventArguments.WebView2EventArgs>(this.webView1_DocumentTitleChanged);
            this.webView1.ContainsFullScreenElementChanged += new System.EventHandler<Diga.WebView2.Wrapper.EventArguments.WebView2EventArgs>(this.webView1_ContainsFullScreenElementChanged);
            this.webView1.NewWindowRequested += new System.EventHandler<Diga.WebView2.Wrapper.EventArguments.NewWindowRequestedEventArgs>(this.webView1_NewWindowRequested);
            this.webView1.PermissionRequested += new System.EventHandler<Diga.WebView2.Wrapper.EventArguments.PermissionRequestedEventArgs>(this.webView1_PermissionRequested);
            this.webView1.FrameNavigationCompleted += new System.EventHandler<Diga.WebView2.Wrapper.EventArguments.NavigationCompletedEventArgs>(this.webView1_FrameNavigationCompleted);
            this.webView1.FrameNavigationStarting += new System.EventHandler<Diga.WebView2.Wrapper.EventArguments.NavigationStartingEventArgs>(this.webView1_FrameNavigationStarting);
            this.webView1.ExecuteScriptCompleted += new System.EventHandler<Diga.WebView2.Wrapper.EventArguments.ExecuteScriptCompletedEventArgs>(this.webView1_ExecuteScriptCompleted);
            this.webView1.ScriptDialogOpening += new System.EventHandler<Diga.WebView2.Wrapper.EventArguments.ScriptDialogOpeningEventArgs>(this.webView1_ScriptDialogOpening);
            this.webView1.WebMessageReceived += new System.EventHandler<Diga.WebView2.Wrapper.EventArguments.WebMessageReceivedEventArgs>(this.webView1_WebMessageReceived);
            this.webView1.ScriptToExecuteOnDocumentCreatedCompleted += new System.EventHandler<Diga.WebView2.Wrapper.EventArguments.AddScriptToExecuteOnDocumentCreatedCompletedEventArgs>(this.webView1_ScriptToExecuteOnDocumentCreatedCompleted);
            this.webView1.DownloadStarting += new System.EventHandler<Diga.WebView2.Wrapper.EventArguments.DownloadStartingEventArgs>(this.webView1_DownloadStarting);
            this.webView1.FrameCreated += new System.EventHandler<Diga.WebView2.Wrapper.EventArguments.FrameCreatedEventArgs>(this.webView1_FrameCreated);
            this.webView1.ScriptEvent += new System.EventHandler<Diga.WebView2.Scripting.RpcEventHandlerArgs>(this.OnRpcEvent);
            this.webView1.DOMContentLoaded += new System.EventHandler<Diga.WebView2.Wrapper.EventArguments.DOMContentLoadedEventArgs>(this.webView1_DOMContentLoaded);
            this.webView1.WebResourceResponseReceived += new System.EventHandler<Diga.WebView2.Wrapper.EventArguments.WebResourceResponseReceivedEventArgs>(this.webView1_WebResourceResponseReceived);
            this.webView1.WebViewCreated += new System.EventHandler(this.webView1_WebViewCreated);
            this.webView1.BeforeWebViewDestroy += new System.EventHandler(this.webView1_BeforeWebViewDestroy);
            this.webView1.IsDocumentPlayingAudioChanged += new System.EventHandler<Diga.WebView2.Wrapper.EventArguments.WebView2EventArgs>(this.webView1_IsDocumentPlayingAudioChanged);
            this.webView1.DocumentLoading += new System.EventHandler(this.webView1_DocumentLoading);
            this.webView1.DocumentUnload += new System.EventHandler(this.webView1_DocumentUnload);
            this.webView1.ContextMenuRequested += new System.EventHandler<Diga.WebView2.Wrapper.Handler.ContextMenuRequestedEventArgs>(this.webView1_ContextMenuRequested);
            // 
            // contextMenuMore
            // 
            this.contextMenuMore.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buildFormToolStripMenuItem});
            this.contextMenuMore.Name = "contextMenuMore";
            this.contextMenuMore.Size = new System.Drawing.Size(133, 26);
            // 
            // buildFormToolStripMenuItem
            // 
            this.buildFormToolStripMenuItem.Name = "buildFormToolStripMenuItem";
            this.buildFormToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.buildFormToolStripMenuItem.Text = "Build Form";
            this.buildFormToolStripMenuItem.Click += new System.EventHandler(this.buildFormToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1325, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.contextMenuMore.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private Diga.WebView2.WinForms.WebView webView1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button bnScript;
        private System.Windows.Forms.Button bnCapture;
        private System.Windows.Forms.Button bnPostMessage;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label lblZoomFactor;
        private System.Windows.Forms.Button bnScriptTest;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button bnSrc;
        private System.Windows.Forms.Button bnSrcTest;
        private System.Windows.Forms.Label lblMuted;
        private System.Windows.Forms.Button bnScriptSync;
        private System.Windows.Forms.Label lblMenu;
        private System.Windows.Forms.ContextMenuStrip contextMenuMore;
        private System.Windows.Forms.ToolStripMenuItem buildFormToolStripMenuItem;
    }
}

