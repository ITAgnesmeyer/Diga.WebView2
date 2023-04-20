namespace WebView2WrapperWinFormsTest
{
    partial class MultipleControls
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.webView1 = new Diga.WebView2.WinForms.WebView();
            this.webView2 = new Diga.WebView2.WinForms.WebView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bnAddScriptToRight = new System.Windows.Forms.Button();
            this.bnAddScriptToLeft = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)this.splitContainer1).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.splitContainer1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1237, 519);
            this.panel1.TabIndex = 0;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 38);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.webView1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.webView2);
            this.splitContainer1.Size = new System.Drawing.Size(1237, 481);
            this.splitContainer1.SplitterDistance = 411;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 1;
            // 
            // webView1
            // 
            this.webView1.AreBrowserAcceleratorKeysEnabled = true;
            this.webView1.BackColor = System.Drawing.Color.Black;
            this.webView1.CgiExeFile = null;
            this.webView1.CgiFileExtensions = null;
            this.webView1.CgiMoitoringFolder = null;
            this.webView1.CgiMoitoringUrl = null;
            this.webView1.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webView1.DefaultContextMenusEnabled = false;
            this.webView1.DefaultScriptDialogsEnabled = true;
            this.webView1.DevToolsEnabled = true;
            this.webView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webView1.EnableCgi = false;
            this.webView1.EnableMonitoring = false;
            this.webView1.HtmlContent = "<h1>Left</h1>";
            this.webView1.IsGeneralAutoFillEnabled = false;
            this.webView1.IsMuted = false;
            this.webView1.IsPasswordAutosaveEnabled = false;
            this.webView1.IsScriptEnabled = true;
            this.webView1.IsStatusBarEnabled = false;
            this.webView1.IsWebMessageEnabled = true;
            this.webView1.IsZoomControlEnabled = true;
            this.webView1.Location = new System.Drawing.Point(0, 0);
            this.webView1.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.webView1.MonitoringFolder = null;
            this.webView1.MonitoringUrl = null;
            this.webView1.Name = "webView1";
            this.webView1.RemoteObjectsAllowed = true;
            this.webView1.Size = new System.Drawing.Size(411, 481);
            this.webView1.TabIndex = 0;
            this.webView1.Url = null;
            this.webView1.ZoomFactor = 0D;
            // 
            // webView2
            // 
            this.webView2.AreBrowserAcceleratorKeysEnabled = true;
            this.webView2.BackColor = System.Drawing.Color.Black;
            this.webView2.CgiExeFile = null;
            this.webView2.CgiFileExtensions = null;
            this.webView2.CgiMoitoringFolder = null;
            this.webView2.CgiMoitoringUrl = null;
            this.webView2.DefaultBackgroundColor = System.Drawing.Color.FromArgb(224, 224, 224);
            this.webView2.DefaultContextMenusEnabled = false;
            this.webView2.DefaultScriptDialogsEnabled = true;
            this.webView2.DevToolsEnabled = true;
            this.webView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webView2.EnableCgi = false;
            this.webView2.EnableMonitoring = false;
            this.webView2.HtmlContent = "<h1>Right</h1>";
            this.webView2.IsGeneralAutoFillEnabled = false;
            this.webView2.IsMuted = false;
            this.webView2.IsPasswordAutosaveEnabled = false;
            this.webView2.IsScriptEnabled = true;
            this.webView2.IsStatusBarEnabled = false;
            this.webView2.IsWebMessageEnabled = true;
            this.webView2.IsZoomControlEnabled = true;
            this.webView2.Location = new System.Drawing.Point(0, 0);
            this.webView2.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.webView2.MonitoringFolder = null;
            this.webView2.MonitoringUrl = null;
            this.webView2.Name = "webView2";
            this.webView2.RemoteObjectsAllowed = true;
            this.webView2.Size = new System.Drawing.Size(821, 481);
            this.webView2.TabIndex = 0;
            this.webView2.Url = null;
            this.webView2.ZoomFactor = 0D;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.bnAddScriptToRight);
            this.panel2.Controls.Add(this.bnAddScriptToLeft);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1237, 38);
            this.panel2.TabIndex = 0;
            // 
            // bnAddScriptToRight
            // 
            this.bnAddScriptToRight.Location = new System.Drawing.Point(146, 5);
            this.bnAddScriptToRight.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bnAddScriptToRight.Name = "bnAddScriptToRight";
            this.bnAddScriptToRight.Size = new System.Drawing.Size(133, 27);
            this.bnAddScriptToRight.TabIndex = 1;
            this.bnAddScriptToRight.Text = "Right Add Script";
            this.bnAddScriptToRight.UseVisualStyleBackColor = true;
            this.bnAddScriptToRight.Click += this.bnAddScriptToRight_Click;
            // 
            // bnAddScriptToLeft
            // 
            this.bnAddScriptToLeft.Location = new System.Drawing.Point(5, 5);
            this.bnAddScriptToLeft.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bnAddScriptToLeft.Name = "bnAddScriptToLeft";
            this.bnAddScriptToLeft.Size = new System.Drawing.Size(133, 27);
            this.bnAddScriptToLeft.TabIndex = 0;
            this.bnAddScriptToLeft.Text = "Left Add Script";
            this.bnAddScriptToLeft.UseVisualStyleBackColor = true;
            this.bnAddScriptToLeft.Click += this.bnAddScriptToLeft_Click;
            // 
            // MultipleControls
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1237, 519);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "MultipleControls";
            this.Text = "MultipleControls";
            this.panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)this.splitContainer1).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private Diga.WebView2.WinForms.WebView webView1;
        private Diga.WebView2.WinForms.WebView webView2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button bnAddScriptToRight;
        private System.Windows.Forms.Button bnAddScriptToLeft;
    }
}