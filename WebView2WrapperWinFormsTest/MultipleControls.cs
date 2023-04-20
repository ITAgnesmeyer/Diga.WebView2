using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Diga.WebView2.Scripting.DOM;

namespace WebView2WrapperWinFormsTest
{
    public partial class MultipleControls : Form
    {
        public MultipleControls()
        {
            InitializeComponent();
        }

        private void bnAddScriptToLeft_Click(object sender, EventArgs e)
        {
            var document = this.webView1.GetDOMDocument();
            var window = this.webView1.GetDOMWindow();

            var element = document.createElement("button");
            element.innerHTML = "Run Message";
            element.Click += (o, x) =>
            {
                DOMLocation location = new DOMLocation(this.webView1);
                location.href = "diga://resources/test.html";
            };

            
            document.body.appendChild(element);
        }

        private void bnAddScriptToRight_Click(object sender, EventArgs e)
        {
            var document = this.webView2.GetDOMDocument();
            var window = this.webView2.GetDOMWindow();

            var element = document.createElement("button");
            element.innerHTML = "Run Message";
            element.Click += (o, x) =>
            {
                window.alert("Test Alert");
            };
            document.body.appendChild(element);
        }
    }
}
