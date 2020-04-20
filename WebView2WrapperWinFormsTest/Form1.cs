using System;
using System.Windows.Forms;
using Diga.WebView2.Wrapper;
using Diga.WebView2.Wrapper.EventArguments;

namespace WebView2WrapperWinFormsTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
           this.webView1.Url =  this.textBox1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.webView1.GoBack();
        }

        private void webView1_NavigationStart(object sender, NavigationStartingEventArgs e)
        {
            //MessageBox.Show(e.Uri);
        }

        private void webView1_ContentLoading(object sender, ContentLoadingEventArgs e)
        {
            //MessageBox.Show("Naviagation ID=>" + e.NavigationId);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.webView1.GoForward();
        }

        private void webView1_SourceChanged(object sender, SourceChangedEventArgs e)
        {
            //MessageBox.Show("SourceChanged=>" + e.IsNewDocument);
        }

        private void webView1_HistoryChanged(object sender, WebView2EventArgs e)
        {
            
        }

        private void webView1_NavigationCompleted(object sender, NavigationCompletedEventArgs e)
        {
            this.textBox1.Text = this.webView1.Source;
        }

        private void webView1_AcceleratorKeyPressed(object sender, AcceleratorKeyPressedEventArgs e)
        {
            MessageBox.Show(this, "webView1_AcceleratorKeyPressed");
        }
    }
}
