using System;
using System.Windows.Forms;

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

        private void webView1_NavigationStart(object sender, Diga.WebView2.Wrapper.NavigationStartingEventArgs e)
        {
            MessageBox.Show(e.Uri);
        }

        private void webView1_ContentLoading(object sender, Diga.WebView2.Wrapper.ContentLoadingEventArgs e)
        {
            MessageBox.Show("Naviagation ID=>" + e.NavigationId);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.webView1.GoForward();
        }

        private void webView1_SourceChanged(object sender, Diga.WebView2.Wrapper.SourceChangedEventArgs e)
        {
            MessageBox.Show("SourceChanged=>" + e.IsNewDocument);
        }

        private void webView1_HistoryChanged(object sender, Diga.WebView2.Wrapper.EventArguments.WebView2EventArgs e)
        {
            
        }

        private void webView1_NavigationCompleted(object sender, Diga.WebView2.Wrapper.NavigationCompletedEventArgs e)
        {
            this.textBox1.Text = this.webView1.Source;
        }
    }
}
