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
            this.panel1 = new System.Windows.Forms.Panel();
            this.bnCapture = new System.Windows.Forms.Button();
            this.bnScript = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.webView1 = new Diga.WebView2.WinForms.WebView();
            this.bnPostMessage = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
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
            this.panel1.Size = new System.Drawing.Size(1021, 32);
            this.panel1.TabIndex = 0;
            // 
            // bnCapture
            // 
            this.bnCapture.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bnCapture.Location = new System.Drawing.Point(858, 4);
            this.bnCapture.Name = "bnCapture";
            this.bnCapture.Size = new System.Drawing.Size(56, 23);
            this.bnCapture.TabIndex = 6;
            this.bnCapture.Text = "Capture";
            this.bnCapture.UseVisualStyleBackColor = true;
            this.bnCapture.Click += new System.EventHandler(this.bnCapture_Click);
            // 
            // bnScript
            // 
            this.bnScript.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bnScript.Location = new System.Drawing.Point(801, 4);
            this.bnScript.Name = "bnScript";
            this.bnScript.Size = new System.Drawing.Size(51, 23);
            this.bnScript.TabIndex = 5;
            this.bnScript.Text = "Script";
            this.bnScript.UseVisualStyleBackColor = true;
            this.bnScript.Click += new System.EventHandler(this.bnScript_Click);
            // 
            // button4
            // 
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("MS UI Gothic", 8.25F);
            this.button4.Location = new System.Drawing.Point(757, 4);
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
            this.button2.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.button1.Location = new System.Drawing.Point(717, 4);
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
            "https://www.itagnesmeyer.de"});
            this.textBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.textBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBox1.Location = new System.Drawing.Point(75, 6);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(635, 20);
            this.textBox1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.webView1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 32);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1021, 418);
            this.panel2.TabIndex = 1;
            // 
            // webView1
            // 
            this.webView1.BackColor = System.Drawing.Color.Black;
            this.webView1.DefaultContextMenusEnabled = false;
            this.webView1.DefaultScriptDialogsEnabled = true;
            this.webView1.DevToolsEnabled = true;
            this.webView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webView1.EnableMonitoring = true;
            this.webView1.HtmlContent = null;
            this.webView1.IsCreated = false;
            this.webView1.IsScriptEnabled = true;
            this.webView1.IsStatusBarEnabled = false;
            this.webView1.IsWebMessageEnabled = true;
            this.webView1.IsZoomControlEnabled = true;
            this.webView1.Location = new System.Drawing.Point(0, 0);
            this.webView1.MonitoringFolder = ".\\wwwroot";
            this.webView1.MonitoringUrl = "https://5b834d57-0891-4730-b6ba-c793b4e76468/";
            this.webView1.Name = "webView1";
            this.webView1.RemoteObjectsAllowed = true;
            this.webView1.Size = new System.Drawing.Size(1021, 418);
            this.webView1.TabIndex = 0;
            this.webView1.Url = "https://5b834d57-0891-4730-b6ba-c793b4e76468";
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
            this.webView1.PermissionRequested += new System.EventHandler<Diga.WebView2.Wrapper.EventArguments.PermissionRequestedEventArgs>(this.webView1_PermissionRequested);
            this.webView1.FrameNavigationCompleted += new System.EventHandler<Diga.WebView2.Wrapper.EventArguments.NavigationCompletedEventArgs>(this.webView1_FrameNavigationCompleted);
            this.webView1.FrameNavigationStarting += new System.EventHandler<Diga.WebView2.Wrapper.EventArguments.NavigationStartingEventArgs>(this.webView1_FrameNavigationStarting);
            this.webView1.WebMessageReceived += new System.EventHandler<Diga.WebView2.Wrapper.EventArguments.WebMessageReceivedEventArgs>(this.webView1_WebMessageReceived);
            this.webView1.ScriptToExecuteOnDocumentCreatedCompleted += new System.EventHandler<Diga.WebView2.Wrapper.EventArguments.AddScriptToExecuteOnDocumentCreatedCompletedEventArgs>(this.webView1_ScriptToExecuteOnDocumentCreatedCompleted);
            this.webView1.WebViewCreated += new System.EventHandler(this.webView1_WebViewCreated);
            this.webView1.BeforeWebViewDestroy += new System.EventHandler(this.webView1_BeforeWebViewDestroy);
            // 
            // bnPostMessage
            // 
            this.bnPostMessage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bnPostMessage.Location = new System.Drawing.Point(920, 4);
            this.bnPostMessage.Name = "bnPostMessage";
            this.bnPostMessage.Size = new System.Drawing.Size(56, 23);
            this.bnPostMessage.TabIndex = 7;
            this.bnPostMessage.Text = "Post";
            this.bnPostMessage.UseVisualStyleBackColor = true;
            this.bnPostMessage.Click += new System.EventHandler(this.bnPostMessage_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
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
    }
}

