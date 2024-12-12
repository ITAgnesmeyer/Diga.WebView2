using System;
using System.Windows.Forms;

namespace WebView2WrapperWinFormsTest
{
    public partial class SelectForm : Form
    {
        private Form1 mainForm = null;
        public SelectForm()
        {
            InitializeComponent();
        }

        private void bnMainFormSelect_Click(object sender, EventArgs e)
        {
            if (this.mainForm == null || this.mainForm.IsDisposed)
            {
                this.mainForm = new Form1();

            }


            this.mainForm.Show(this);
        }
    }
}
