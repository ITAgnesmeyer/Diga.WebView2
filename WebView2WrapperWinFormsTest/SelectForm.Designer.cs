namespace WebView2WrapperWinFormsTest
{
    partial class SelectForm
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
            this.bnMainFormSelect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bnMainFormSelect
            // 
            this.bnMainFormSelect.Location = new System.Drawing.Point(39, 23);
            this.bnMainFormSelect.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bnMainFormSelect.Name = "bnMainFormSelect";
            this.bnMainFormSelect.Size = new System.Drawing.Size(88, 27);
            this.bnMainFormSelect.TabIndex = 0;
            this.bnMainFormSelect.Text = "MainForm";
            this.bnMainFormSelect.UseVisualStyleBackColor = true;
            this.bnMainFormSelect.Click += this.bnMainFormSelect_Click;
            // 
            // SelectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 409);
            this.Controls.Add(this.bnMainFormSelect);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "SelectForm";
            this.Text = "SelectForm";
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button bnMainFormSelect;
    }
}