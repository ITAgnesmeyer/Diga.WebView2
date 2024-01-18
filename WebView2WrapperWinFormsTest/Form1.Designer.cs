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
            components = new System.ComponentModel.Container();
            panel1 = new System.Windows.Forms.Panel();
            lblMenu = new System.Windows.Forms.Label();
            bnScriptSync = new System.Windows.Forms.Button();
            lblMuted = new System.Windows.Forms.Label();
            bnSrcTest = new System.Windows.Forms.Button();
            bnSrc = new System.Windows.Forms.Button();
            button6 = new System.Windows.Forms.Button();
            bnScriptTest = new System.Windows.Forms.Button();
            lblZoomFactor = new System.Windows.Forms.Label();
            trackBar1 = new System.Windows.Forms.TrackBar();
            button5 = new System.Windows.Forms.Button();
            bnPostMessage = new System.Windows.Forms.Button();
            bnCapture = new System.Windows.Forms.Button();
            bnScript = new System.Windows.Forms.Button();
            button4 = new System.Windows.Forms.Button();
            button3 = new System.Windows.Forms.Button();
            button2 = new System.Windows.Forms.Button();
            button1 = new System.Windows.Forms.Button();
            textBox1 = new System.Windows.Forms.TextBox();
            panel2 = new System.Windows.Forms.Panel();
            webView1 = new Diga.WebView2.WinForms.WebView();
            contextMenuMore = new System.Windows.Forms.ContextMenuStrip(components);
            buildFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            multipleControlsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            panel2.SuspendLayout();
            contextMenuMore.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(lblMenu);
            panel1.Controls.Add(bnScriptSync);
            panel1.Controls.Add(lblMuted);
            panel1.Controls.Add(bnSrcTest);
            panel1.Controls.Add(bnSrc);
            panel1.Controls.Add(button6);
            panel1.Controls.Add(bnScriptTest);
            panel1.Controls.Add(lblZoomFactor);
            panel1.Controls.Add(trackBar1);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(bnPostMessage);
            panel1.Controls.Add(bnCapture);
            panel1.Controls.Add(bnScript);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(textBox1);
            panel1.Dock = System.Windows.Forms.DockStyle.Top;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(1546, 37);
            panel1.TabIndex = 0;
            // 
            // lblMenu
            // 
            lblMenu.AutoSize = true;
            lblMenu.Location = new System.Drawing.Point(1349, 14);
            lblMenu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblMenu.Name = "lblMenu";
            lblMenu.Size = new System.Drawing.Size(35, 15);
            lblMenu.TabIndex = 17;
            lblMenu.Text = "More";
            lblMenu.Click += lblMenu_Click;
            // 
            // bnScriptSync
            // 
            bnScriptSync.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            bnScriptSync.Location = new System.Drawing.Point(955, 3);
            bnScriptSync.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            bnScriptSync.Name = "bnScriptSync";
            bnScriptSync.Size = new System.Drawing.Size(50, 27);
            bnScriptSync.TabIndex = 16;
            bnScriptSync.Text = "Script";
            bnScriptSync.UseVisualStyleBackColor = true;
            bnScriptSync.Click += bnScriptSync_Click;
            // 
            // lblMuted
            // 
            lblMuted.AutoSize = true;
            lblMuted.BackColor = System.Drawing.SystemColors.Info;
            lblMuted.Location = new System.Drawing.Point(1502, 12);
            lblMuted.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblMuted.Name = "lblMuted";
            lblMuted.Size = new System.Drawing.Size(41, 15);
            lblMuted.TabIndex = 15;
            lblMuted.Text = "Sound";
            lblMuted.Click += lblMuted_Click;
            // 
            // bnSrcTest
            // 
            bnSrcTest.Location = new System.Drawing.Point(1443, 8);
            bnSrcTest.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            bnSrcTest.Name = "bnSrcTest";
            bnSrcTest.Size = new System.Drawing.Size(48, 23);
            bnSrcTest.TabIndex = 14;
            bnSrcTest.Text = "SRC";
            bnSrcTest.UseVisualStyleBackColor = true;
            bnSrcTest.Click += bnSrcTest_Click;
            // 
            // bnSrc
            // 
            bnSrc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            bnSrc.Location = new System.Drawing.Point(1161, 3);
            bnSrc.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            bnSrc.Name = "bnSrc";
            bnSrc.Size = new System.Drawing.Size(40, 28);
            bnSrc.TabIndex = 13;
            bnSrc.Text = "SRC";
            bnSrc.UseVisualStyleBackColor = true;
            bnSrc.Click += bnSrc_Click;
            // 
            // button6
            // 
            button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button6.Location = new System.Drawing.Point(1111, 3);
            button6.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            button6.Name = "button6";
            button6.Size = new System.Drawing.Size(43, 27);
            button6.TabIndex = 12;
            button6.Text = "MP3";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // bnScriptTest
            // 
            bnScriptTest.Location = new System.Drawing.Point(1401, 8);
            bnScriptTest.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            bnScriptTest.Name = "bnScriptTest";
            bnScriptTest.Size = new System.Drawing.Size(35, 23);
            bnScriptTest.TabIndex = 11;
            bnScriptTest.Text = "ST";
            bnScriptTest.UseVisualStyleBackColor = true;
            bnScriptTest.Click += bnScriptTest_Click;
            // 
            // lblZoomFactor
            // 
            lblZoomFactor.AutoSize = true;
            lblZoomFactor.Location = new System.Drawing.Point(1311, 12);
            lblZoomFactor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblZoomFactor.Name = "lblZoomFactor";
            lblZoomFactor.Size = new System.Drawing.Size(25, 15);
            lblZoomFactor.TabIndex = 10;
            lblZoomFactor.Text = "100";
            // 
            // trackBar1
            // 
            trackBar1.AutoSize = false;
            trackBar1.Location = new System.Drawing.Point(1208, 7);
            trackBar1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            trackBar1.Maximum = 500;
            trackBar1.Minimum = 1;
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new System.Drawing.Size(97, 23);
            trackBar1.TabIndex = 9;
            trackBar1.Value = 100;
            trackBar1.ValueChanged += trackBar1_ValueChanged;
            // 
            // button5
            // 
            button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button5.Font = new System.Drawing.Font("MS UI Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            button5.Location = new System.Drawing.Point(842, 3);
            button5.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            button5.Name = "button5";
            button5.Size = new System.Drawing.Size(38, 27);
            button5.TabIndex = 8;
            button5.Text = "☰";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // bnPostMessage
            // 
            bnPostMessage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            bnPostMessage.Location = new System.Drawing.Point(1065, 3);
            bnPostMessage.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            bnPostMessage.Name = "bnPostMessage";
            bnPostMessage.Size = new System.Drawing.Size(38, 27);
            bnPostMessage.TabIndex = 7;
            bnPostMessage.Text = "PDF";
            bnPostMessage.UseVisualStyleBackColor = true;
            bnPostMessage.Click += bnPostMessage_Click;
            // 
            // bnCapture
            // 
            bnCapture.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            bnCapture.Location = new System.Drawing.Point(1013, 3);
            bnCapture.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            bnCapture.Name = "bnCapture";
            bnCapture.Size = new System.Drawing.Size(46, 27);
            bnCapture.TabIndex = 6;
            bnCapture.Text = "Capture";
            bnCapture.UseVisualStyleBackColor = true;
            bnCapture.Click += bnCapture_Click;
            // 
            // bnScript
            // 
            bnScript.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            bnScript.Location = new System.Drawing.Point(889, 3);
            bnScript.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            bnScript.Name = "bnScript";
            bnScript.Size = new System.Drawing.Size(59, 27);
            bnScript.TabIndex = 5;
            bnScript.Text = "Async Script";
            bnScript.UseVisualStyleBackColor = true;
            bnScript.Click += bnScript_Click;
            // 
            // button4
            // 
            button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button4.Font = new System.Drawing.Font("MS UI Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            button4.Location = new System.Drawing.Point(797, 3);
            button4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            button4.Name = "button4";
            button4.Size = new System.Drawing.Size(38, 27);
            button4.TabIndex = 4;
            button4.Text = "☰";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button3.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            button3.Location = new System.Drawing.Point(43, 3);
            button3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(37, 28);
            button3.TabIndex = 3;
            button3.Text = "▶";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button2.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            button2.Location = new System.Drawing.Point(4, 3);
            button2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(37, 28);
            button2.TabIndex = 2;
            button2.Text = "◀";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button1.Location = new System.Drawing.Point(751, 3);
            button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(38, 27);
            button1.TabIndex = 1;
            button1.Text = "GO";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.AutoCompleteCustomSource.AddRange(new string[] { "https://www.google.de", "https://www.itagnesmeyer.de", "https://github.com/ITAgnesmeyer/DigaDeployServer/releases/download/v0.0.0.1/DPack.pack", "https://github.com/ITAgnesmeyer/DigaDeployServer/releases/download/v0.0.0.1/test_x.zip", "https://www.youtube.com/watch?v=yE99DKTz09M" });
            textBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            textBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            textBox1.Location = new System.Drawing.Point(88, 5);
            textBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(656, 23);
            textBox1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(webView1);
            panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            panel2.Location = new System.Drawing.Point(0, 37);
            panel2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(1546, 482);
            panel2.TabIndex = 1;
            // 
            // webView1
            // 
            webView1.AreBrowserAcceleratorKeysEnabled = true;
            webView1.BackColor = System.Drawing.Color.Black;
            webView1.CgiExeFile = "C:\\xampp\\php\\php-cgi.exe";
            webView1.CgiFileExtensions = new string[]
    {
    "php"
    };
            webView1.CgiMoitoringFolder = "C:\\xampp\\htdocs";
            webView1.CgiMoitoringUrl = "https://localhost:8885/";
            webView1.DefaultBackgroundColor = System.Drawing.Color.AliceBlue;
            webView1.DefaultContextMenusEnabled = true;
            webView1.DefaultScriptDialogsEnabled = true;
            webView1.DevToolsEnabled = true;
            webView1.Dock = System.Windows.Forms.DockStyle.Fill;
            webView1.EnableCgi = true;
            webView1.EnableMonitoring = true;
            webView1.HtmlContent = null;
            webView1.IsGeneralAutoFillEnabled = true;
            webView1.IsMuted = false;
            webView1.IsPasswordAutosaveEnabled = true;
            webView1.IsScriptEnabled = true;
            webView1.IsStatusBarEnabled = true;
            webView1.IsWebMessageEnabled = true;
            webView1.IsZoomControlEnabled = true;
            webView1.Location = new System.Drawing.Point(0, 0);
            webView1.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            webView1.MonitoringFolder = ".\\wwwroot";
            webView1.MonitoringUrl = "https://5b834d57-0891-4730-b6ba-c793b4e76468/";
            webView1.Name = "webView1";
            webView1.RemoteObjectsAllowed = true;
            webView1.SchemeRegistrations = null;
            webView1.Size = new System.Drawing.Size(1546, 482);
            webView1.TabIndex = 0;
            webView1.Url = "https://www.itagnesmeyer.de";
            webView1.ZoomFactor = 1D;
            webView1.NavigationStart += webView1_NavigationStart;
            webView1.ContentLoading += webView1_ContentLoading;
            webView1.SourceChanged += webView1_SourceChanged;
            webView1.HistoryChanged += webView1_HistoryChanged;
            webView1.NavigationCompleted += webView1_NavigationCompleted;
            webView1.WebResourceRequested += webView1_WebResourceRequested;
            webView1.AcceleratorKeyPressed += webView1_AcceleratorKeyPressed;
            webView1.WebViewGotFocus += webView1_WebViewGotFocus;
            webView1.WebViewLostFocus += webView1_WebViewLostFocus;
            webView1.MoveFocusRequested += webView1_MoveFocusRequested;
            webView1.ZoomFactorChanged += webView1_ZoomFactorChanged;
            webView1.DocumentTitleChanged += webView1_DocumentTitleChanged;
            webView1.ContainsFullScreenElementChanged += webView1_ContainsFullScreenElementChanged;
            webView1.NewWindowRequested += webView1_NewWindowRequested;
            webView1.PermissionRequested += webView1_PermissionRequested;
            webView1.FrameNavigationCompleted += webView1_FrameNavigationCompleted;
            webView1.FrameNavigationStarting += webView1_FrameNavigationStarting;
            webView1.ExecuteScriptCompleted += webView1_ExecuteScriptCompleted;
            webView1.ScriptDialogOpening += webView1_ScriptDialogOpening;
            webView1.WebMessageReceived += webView1_WebMessageReceived;
            webView1.ScriptToExecuteOnDocumentCreatedCompleted += webView1_ScriptToExecuteOnDocumentCreatedCompleted;
            webView1.DownloadStarting += webView1_DownloadStarting;
            webView1.FrameCreated += webView1_FrameCreated;
            webView1.ScriptEvent += OnRpcEvent;
            webView1.DOMContentLoaded += webView1_DOMContentLoaded;
            webView1.WebResourceResponseReceived += webView1_WebResourceResponseReceived;
            webView1.WebViewCreated += webView1_WebViewCreated;
            webView1.BeforeWebViewDestroy += webView1_BeforeWebViewDestroy;
            webView1.IsDocumentPlayingAudioChanged += webView1_IsDocumentPlayingAudioChanged;
            webView1.DocumentLoading += webView1_DocumentLoading;
            webView1.DocumentUnload += webView1_DocumentUnload;
            webView1.ContextMenuRequested += webView1_ContextMenuRequested;
            webView1.CompoisitionControllerCursorChanged += webView1_CompoisitionControllerCursorChanged;
            // 
            // contextMenuMore
            // 
            contextMenuMore.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { buildFormToolStripMenuItem, multipleControlsToolStripMenuItem });
            contextMenuMore.Name = "contextMenuMore";
            contextMenuMore.Size = new System.Drawing.Size(164, 48);
            // 
            // buildFormToolStripMenuItem
            // 
            buildFormToolStripMenuItem.Name = "buildFormToolStripMenuItem";
            buildFormToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            buildFormToolStripMenuItem.Text = "Build Form";
            buildFormToolStripMenuItem.Click += buildFormToolStripMenuItem_Click;
            // 
            // multipleControlsToolStripMenuItem
            // 
            multipleControlsToolStripMenuItem.Name = "multipleControlsToolStripMenuItem";
            multipleControlsToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            multipleControlsToolStripMenuItem.Text = "MultipleControls";
            multipleControlsToolStripMenuItem.Click += multipleControlsToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1546, 519);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "Form1";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            panel2.ResumeLayout(false);
            contextMenuMore.ResumeLayout(false);
            ResumeLayout(false);
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
        private System.Windows.Forms.ToolStripMenuItem multipleControlsToolStripMenuItem;
    }
}

