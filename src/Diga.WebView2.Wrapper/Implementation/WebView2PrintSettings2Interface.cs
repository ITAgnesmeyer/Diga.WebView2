using System;
using System.Diagnostics;
using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.Types;

namespace Diga.WebView2.Wrapper.Implementation
{
    public class WebView2PrintSettings2Interface : WebView2PrintSettingsInterface
    {
        private ComObjectHolder<ICoreWebView2PrintSettings2> _PrintSettings;
        private ICoreWebView2PrintSettings2 PrinterSettings
        {
            get
            {
                if (this._PrintSettings == null)
                {
                    Debug.Print(nameof(WebView2PrintSettings2Interface) + "." + nameof(this.PrinterSettings) + " is null");
                    throw new InvalidOperationException(nameof(WebView2PrintSettings2Interface) + "." + nameof(this.PrinterSettings) + " is null");

                }
                return this._PrintSettings.Interface;
            }
            set => this._PrintSettings = new ComObjectHolder<ICoreWebView2PrintSettings2>(value);
        }
        public WebView2PrintSettings2Interface(ICoreWebView2PrintSettings2 printSettings) : base(printSettings)
        {
            this.PrinterSettings = printSettings;
        }

        public string PageRanges { get => this.PrinterSettings.PageRanges; set => this.PrinterSettings.PageRanges = value; }
        public int PagesPerSide { get => this.PrinterSettings.PagesPerSide; set => this.PrinterSettings.PagesPerSide = value; }
        public int Copies { get => this.PrinterSettings.Copies; set => this.PrinterSettings.Copies = value; }
        public COREWEBVIEW2_PRINT_COLLATION Collation { get => this.PrinterSettings.Collation; set => this.PrinterSettings.Collation = value; }
        public COREWEBVIEW2_PRINT_COLOR_MODE ColorMode { get => this.PrinterSettings.ColorMode; set => this.PrinterSettings.ColorMode = value; }
        public COREWEBVIEW2_PRINT_DUPLEX Duplex { get => this.PrinterSettings.Duplex; set => this.PrinterSettings.Duplex = value; }
        public COREWEBVIEW2_PRINT_MEDIA_SIZE MediaSize { get => this.PrinterSettings.MediaSize; set => this.PrinterSettings.MediaSize = value; }
        public string PrinterName { get => this.PrinterSettings.PrinterName; set => this.PrinterSettings.PrinterName = value; }
    }
}