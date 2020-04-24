using System;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Windows.Forms;
using Diga.WebView2.WinForms;
using Diga.WebView2.Wrapper;
using Diga.WebView2.Wrapper.EventArguments;
using MimeTypeExtension;

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
            this.webView1.Url = this.textBox1.Text;
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
            this.Text = this.webView1.DocumentTitle;
        }

        private void webView1_AcceleratorKeyPressed(object sender, AcceleratorKeyPressedEventArgs e)
        {
            //MessageBox.Show(this, "webView1_AcceleratorKeyPressed");
            e.Handled = false;
        }

        private void webView1_DocumentStateChanged(object sender, DocumentStateChangedEventArgs e)
        {
            //MessageBox.Show(this, "webView1_DocumentStateChanged");
        }

        private void webView1_DocumentTitleChanged(object sender, WebView2EventArgs e)
        {
            //MessageBox.Show(this, "webView1_DocumentTitleChanged");
        }

        private void webView1_ContainsFullScreenElementChanged(object sender, WebView2EventArgs e)
        {
            // MessageBox.Show(this, "webView1_ContainsFullScreenElementChanged");
        }

        private void webView1_WebViewGotFocus(object sender, WebView2EventArgs e)
        {
            //MessageBox.Show(this, "webView1_WebViewGotFocus");
        }

        private void webView1_FrameNavigationStarting(object sender, NavigationStartingEventArgs e)
        {
            //MessageBox.Show(this, "webView1_FrameNavigationStarting");
        }

        private void webView1_WebViewLostFocus(object sender, WebView2EventArgs e)
        {
            //MessageBox.Show(this, "webView1_WebViewLostFocus");
        }

        private void webView1_MoveFocusRequested(object sender, MoveFocusRequestedEventArgs e)
        {
            //MessageBox.Show(this, "webView1_MoveFocusRequested");
        }

        private void webView1_PermissionRequested(object sender, PermissionRequestedEventArgs e)
        {
            //MessageBox.Show(this, "webView1_PermissionRequested");
        }

        private void webView1_WebMessageReceived(object sender, WebMessageReceivedEventArgs e)
        {
            //MessageBox.Show(this, "webView1_WebMessageReceived");
        }

        private void webView1_WebResourceRequested(object sender, WebResourceRequestedEventArgs e)
        {
            Debug.Print(e.Request.Uri);
            Debug.Print(e.Request.Method);

            if (e.Request.Content != null)
            {
                byte[] bytes = new byte[1000];

            }

           

            //if (GetFileStream(e.Request.Uri, out var responseInfo))
            //{
            //    var response = this.webView1.CreateResponse(responseInfo);
            //    e.Response = response;
            //    Debug.Print(e.Response.Headers.Contains("Content-Type").ToString());


            //}


        }

        private bool GetFileStream(string url, out ResponseInfo responseInfo)
        {
            if (!url.StartsWith("http://localhost:1/"))
            {
                responseInfo = null;
                return false;
            }

            string baseDirectory = Path.GetDirectoryName(Application.ExecutablePath) + "\\wwwroot";
            string file = url.Replace("http://localhost:1/", "");
            if (string.IsNullOrEmpty(file))
                file = "index.html";
            file = file.Replace("/", "\\");
            file = Path.Combine(baseDirectory, file);
            FileInfo fileInfo = new FileInfo(file);
            if (!fileInfo.Exists)
            {
                responseInfo = new ResponseInfo("<h1>Server Error</h1><h5>file not found:" + file + "</h5>");
                responseInfo.Header.Add("content-type", "text/html");
                responseInfo.ContentType = "content-type: text/html";
                responseInfo.StatusCode = 404;
                responseInfo.StatusText = "Not Found";

                return false;
            }

            string contentType = fileInfo.MimeTypeOrDefault();
            if (contentType == "document")
                Debug.Print(contentType);
            try
            {
                byte[] bytes = File.ReadAllBytes(file);
                responseInfo = new ResponseInfo(bytes);
                responseInfo.Header.Add("content-type", contentType);
                responseInfo.ContentType = "content-type: " + contentType;
                responseInfo.StatusCode = 200;
                responseInfo.StatusText = "OK";
                return true;
            }
            catch (Exception e)
            {
                string message = "Error:" + e.Message;
                responseInfo = new ResponseInfo(message);
                responseInfo.Header.Add("content-type", "text/html");
                responseInfo.ContentType = "content-type: text/html";
                responseInfo.StatusCode = 500;
                responseInfo.StatusText = "Internal Server Error";
                return true;
            }


        }
        private void webView1_ZoomFactorChanged(object sender, WebView2EventArgs e)
        {
            MessageBox.Show(this, "webView1_ZoomFactorChanged");
        }
    }
}
