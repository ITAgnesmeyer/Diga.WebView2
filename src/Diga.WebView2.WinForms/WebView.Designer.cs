using System;

namespace Diga.WebView2.WinForms
{
    partial class WebView
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
            
            if (disposing )
            {

                
                if (components != null)
                {
                    components.Dispose();
                }
               
            }

            base.Dispose(disposing);
        }

        #region Vom Komponenten-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // WebView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Name = "WebView";
            this.Size = new System.Drawing.Size(800, 450);
            this.Load += new System.EventHandler(this.WebView_Load);
            this.Resize += new System.EventHandler(this.WebView_Resize);
            this.ResumeLayout(false);

        }

        

        #endregion
    }
}
