using System;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper;
using Diga.WebView2.Wrapper.Types;


namespace Diga.WebView2.WinForms
{
    public partial class WebView
    {
        #region Public Functions

        public async Task<Image> CapturePreviewAsImageAsync(ImageFormat imageFormat)
        {
            using (var stream = new MemoryStream())
            {
                await this._WebViewControl.CapturePreviewAsync(stream, imageFormat);
                var retImage = Image.FromStream(stream);
                return retImage;
            }
        }

        public async Task<Image> GetFavIconAsImageAsync(ImageFormat imageFormat)
        {
            using (var stream = new MemoryStream())
            {
                await this._WebViewControl.GetFavIconAsync(stream, imageFormat);
                var retImage = Image.FromStream(stream);
                return retImage;
            }
        }
        public void Navigate(string url)
        {
            this._Url = url;
            if (this.CheckIsCreatedOrEnded && !string.IsNullOrEmpty(this.Url))
            {
                try
                {
                    this._WebViewControl.Navigate(this._Url);
                }
                catch (Exception e)
                {
                    MessageBox.Show(this, e.Message, @"Navigation Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void NavigateToString(string htmlContent)
        {
            this._HtmlContent = htmlContent;
            if (this.CheckIsCreatedOrEnded && !string.IsNullOrEmpty(this._HtmlContent))
            {
                try
                {
                    this._WebViewControl.NavigateToString(this._HtmlContent);
                }
                catch (Exception e)
                {
                    MessageBox.Show(owner: this, e.Message, @"Navigation Error!", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }

        public void GoBack()
        {
            if (!this.CheckIsCreatedOrEnded) return;
            if (this._WebViewControl.CanGoBack)
                this._WebViewControl.GoBack();
        }

        public void GoForward()
        {
            if (!this.CheckIsCreatedOrEnded) return;
            if (this._WebViewControl.CanGoForward)
                this._WebViewControl.GoForward();
        }

        public void AddScriptToExecuteOnDocumentCreated(string javaScript)
        {
            if (!this.CheckIsCreatedOrEnded) return;
            this._WebViewControl.AddScriptToExecuteOnDocumentCreated(javaScript);
        }

        public void SendMessage(string message)
        {
            this._WebViewControl.PostWebMessageAsString(message);
        }

        public void PostWebMessageAsJson(string webMessageAsJson)
        {
            this._WebViewControl.PostWebMessageAsJson(webMessageAsJson);
        }

        public void PostWebMessageAsString(string webMessageAsString)
        {
            this._WebViewControl.PostWebMessageAsString(webMessageAsString);
        }

        public void AddRemoteObject(string name, object @object)
        {
            if (!this.CheckIsCreatedOrEnded) return;
            this._WebViewControl.AddRemoteObject(name, @object);
        }

        public void Reload()
        {
            this._WebViewControl.Reload();
        }

        public void RemoveRemoteObject(string name)
        {
            this._WebViewControl.RemoveRemoteObject(name);
        }

        public WebView2PrintSettings CreatePrintSettings()
        {
            return this._WebViewControl.CreatePrintSettings();

        }

        public void PrintToPdf(string file, ICoreWebView2PrintSettings printerSettings)
        {
            this._WebViewControl.PrintPdf(file, printerSettings);
        }
        public async Task<bool> PrintToPdfAsync(string file, WebView2PrintSettings printSettings)
        {
            CheckIsCreatedOrEndedWithThrow();
            return await this._WebViewControl.PrintPdfAsync(file, printSettings);
        }

        public void OpenDevToolsWindow()
        {
            this._WebViewControl.OpenDevToolsWindow();
        }

        public void OpenTaskManagerWindow()
        {
            this._WebViewControl.OpenTaskManagerWindow();
        }

        public WebResourceResponse CreateResponse(ResponseInfo responseInfo)
        {
            WebResourceResponse response = null;
            if (this.CheckIsCreatedOrEnded)
            {
                response = this._WebViewControl.GetResponseStream(responseInfo.Stream, responseInfo.StatusCode,
                    responseInfo.StatusText, responseInfo.HeaderToString(), responseInfo.ContentType);
            }

            return response;
        }
        public WebView2ContextMenuItem CreateContextMenuItem(string label, Stream iconStream,COREWEBVIEW2_CONTEXT_MENU_ITEM_KIND kind)
        {
            return this._WebViewControl.CreateContextMenuItem(label,iconStream, kind);
        }

        public void ShowPageSource()
        {
            string uri = this.Source;


            Navigate($"view-source:{uri}");
        }

        #endregion
    }
}