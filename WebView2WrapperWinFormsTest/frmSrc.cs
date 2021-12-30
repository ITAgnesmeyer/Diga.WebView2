using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebView2WrapperWinFormsTest
{
    public partial class frmSrc : Form
    {
        private List<string> _Content;
        private int _CurrentIndex;

        private string Current
        {
            get
            {
                if(this._Content.Count > this._CurrentIndex)
                    return this._Content[this._CurrentIndex];
                return string.Empty;
            } 
        }

        private void MoveNext()
        {
            this._CurrentIndex++;
            if(this._CurrentIndex >= this._Content.Count)
                this._CurrentIndex = this._Content.Count- 1;
            SetCurrentText();
        }

        private void SetCurrentText()
        {
            int index = this._CurrentIndex + 1;
            this.lblCurrent.Text = index.ToString();
        }
        private void MovePrevious()
        {
            this._CurrentIndex--;
            if(this._CurrentIndex < 0)
                this._CurrentIndex = 0;
            SetCurrentText();
        }
        public frmSrc(List<string> content)
        {
            this._Content = content;
            InitializeComponent();
            this.txtContent.Text = this.Current;
            SetCurrentText();
            this.lblAnzahl.Text = this._Content.Count.ToString();
        }

        private void bnBack_Click(object sender, EventArgs e)
        {
            this.MovePrevious();
            this.txtContent.Text = this.Current;
        }

        private void bnForward_Click(object sender, EventArgs e)
        {
            this.MoveNext();
            this.txtContent.Text = this.Current;
        }
    }
}
