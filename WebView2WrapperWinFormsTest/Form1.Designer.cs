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
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.webView1 = new Diga.WebView2.WinForms.WebView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 32);
            this.panel1.TabIndex = 0;
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
            this.button2.Text = "◄";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(717, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Go";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
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
            this.panel2.Size = new System.Drawing.Size(800, 418);
            this.panel2.TabIndex = 1;
            // 
            // webView1
            // 
            this.webView1.BackColor = System.Drawing.Color.Black;
            this.webView1.DefaultContextMenusEnabled = false;
            this.webView1.DefaultScriptDialogsEnabled = true;
            this.webView1.DevToolsEnabled = true;
            this.webView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webView1.HtmlContent = null;
            this.webView1.IsCreated = false;
            this.webView1.IsScriptEnabled = true;
            this.webView1.IsStatusBarEnabled = true;
            this.webView1.IsWebMessageEnabled = true;
            this.webView1.Location = new System.Drawing.Point(0, 0);
            this.webView1.Name = "webView1";
            this.webView1.Size = new System.Drawing.Size(800, 418);
            this.webView1.TabIndex = 0;
            this.webView1.Url = "https://www.itagnesmeyer.de";
            this.webView1.NavigationStart += new System.EventHandler<Diga.WebView2.Wrapper.NavigationStartingEventArgs>(this.webView1_NavigationStart);
            this.webView1.ContentLoading += new System.EventHandler<Diga.WebView2.Wrapper.ContentLoadingEventArgs>(this.webView1_ContentLoading);
            this.webView1.SourceChanged += new System.EventHandler<Diga.WebView2.Wrapper.SourceChangedEventArgs>(this.webView1_SourceChanged);
            this.webView1.HistoryChanged += new System.EventHandler<Diga.WebView2.Wrapper.EventArguments.WebView2EventArgs>(this.webView1_HistoryChanged);
            this.webView1.NavigationCompleted += new System.EventHandler<Diga.WebView2.Wrapper.NavigationCompletedEventArgs>(this.webView1_NavigationCompleted);
            this.webView1.AcceleratorKeyPressed += new System.EventHandler<Diga.WebView2.Wrapper.AcceleratorKeyPressedEventArgs>(this.webView1_AcceleratorKeyPressed);
            this.webView1.ContainsFullScreenElementChanged += new System.EventHandler<Diga.WebView2.Wrapper.EventArguments.WebView2EventArgs>(this.webView1_ContainsFullScreenElementChanged);
            this.webView1.DocumentStateChanged += new System.EventHandler<Diga.WebView2.Wrapper.DocumentStateChangedEventArgs>(this.webView1_DocumentStateChanged);
            this.webView1.DocumentTitleChanged += new System.EventHandler<Diga.WebView2.Wrapper.EventArguments.WebView2EventArgs>(this.webView1_DocumentTitleChanged);
            this.webView1.FrameNavigationStarting += new System.EventHandler<Diga.WebView2.Wrapper.NavigationStartingEventArgs>(this.webView1_FrameNavigationStarting);
            this.webView1.WebViewGotFocus += new System.EventHandler<Diga.WebView2.Wrapper.EventArguments.WebView2EventArgs>(this.webView1_WebViewGotFocus);
            this.webView1.WebViewLostFocus += new System.EventHandler<Diga.WebView2.Wrapper.EventArguments.WebView2EventArgs>(this.webView1_WebViewLostFocus);
            this.webView1.MoveFocusRequested += new System.EventHandler<Diga.WebView2.Wrapper.MoveFocusRequestedEventArgs>(this.webView1_MoveFocusRequested);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
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
    }
}

