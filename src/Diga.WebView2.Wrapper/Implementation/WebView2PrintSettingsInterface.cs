using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.Types;
using Microsoft.Win32.SafeHandles;

namespace Diga.WebView2.Wrapper.Implementation
{
    public class WebView2PrintSettingsInterface: IDisposable
    {
        private object _PrintSettings;
        private bool _IsDesposed;
        /// Wraps in SafeHandle so resources can be released if consumer forgets to call Dispose. Recommended
        ///             pattern for any type that is not sealed.
        ///             https://docs.microsoft.com/dotnet/api/system.idisposable#idisposable-and-the-inheritance-hierarchy
        private readonly SafeHandle handle = (SafeHandle) new SafeFileHandle(IntPtr.Zero, true);

        private ICoreWebView2PrintSettings PrinterSettings
        {
            get
            {
                if (_PrintSettings == null)
                {
                    Debug.Print(nameof(WebView2SettingsInterface) + "." + nameof(PrinterSettings) + " is null");
                    throw new InvalidOperationException(nameof(WebView2SettingsInterface) + "." + nameof(PrinterSettings) + " is null");

                }
                return (ICoreWebView2PrintSettings)_PrintSettings;
            }
        }

        public WebView2PrintSettingsInterface(ICoreWebView2PrintSettings printSettings)
        {
            this._PrintSettings = printSettings;
            //CloneInterface(printSettings);
        }

        public ComObjectHolder<ICoreWebView2PrintSettings> NativeSettings => new ComObjectHolder<ICoreWebView2PrintSettings>(this._PrintSettings);
        //private void CloneInterface(ICoreWebView2PrintSettings printSettings)
        //{
        //    this.FooterUri = printSettings.FooterUri;
        //    this.HeaderTitle = printSettings.HeaderTitle;
        //    this.MarginBottom = printSettings.MarginBottom;
        //    this.MarginLeft = printSettings.MarginLeft;
        //    this.MarginRight = printSettings.MarginRight;
        //    this.MarginTop = printSettings.MarginTop;
        //    this.Orientation = printSettings.Orientation;
        //    this.PageHeight = printSettings.PageHeight;
        //    this.PageWidth = printSettings.PageWidth;
        //    this.ScaleFactor = printSettings.ScaleFactor;
        //    this.ShouldPrintBackgrounds = printSettings.ShouldPrintBackgrounds;
        //    this.ShouldPrintHeaderAndFooter = printSettings.ShouldPrintHeaderAndFooter;
        //    this.ShouldPrintSelectionOnly = printSettings.ShouldPrintSelectionOnly;
        //}
        public COREWEBVIEW2_PRINT_ORIENTATION Orientation { get => this.PrinterSettings.Orientation; set => this.PrinterSettings.Orientation = value; }
        public double ScaleFactor { get => this.PrinterSettings.ScaleFactor; set => this.PrinterSettings.ScaleFactor = value; }
        public double PageWidth { get => this.PrinterSettings.PageWidth; set => this.PrinterSettings.PageWidth = value; }
        public double PageHeight { get => this.PrinterSettings.PageHeight; set => this.PrinterSettings.PageHeight = value; }
        public double MarginTop { get => this.PrinterSettings.MarginTop; set => this.PrinterSettings.MarginTop = value; }
        public double MarginBottom { get => this.PrinterSettings.MarginBottom; set => this.PrinterSettings.MarginBottom = value; }
        public double MarginLeft { get => this.PrinterSettings.MarginLeft; set => this.PrinterSettings.MarginLeft = value; }
        public double MarginRight { get => this.PrinterSettings.MarginRight; set => this.PrinterSettings.MarginRight = value; }
        public int ShouldPrintBackgrounds { get => this.PrinterSettings.ShouldPrintBackgrounds; set => this.PrinterSettings.ShouldPrintBackgrounds = value; }
        public int ShouldPrintSelectionOnly { get => this.PrinterSettings.ShouldPrintSelectionOnly; set => this.PrinterSettings.ShouldPrintSelectionOnly = value; }
        public int ShouldPrintHeaderAndFooter { get => this.PrinterSettings.ShouldPrintHeaderAndFooter; set => this.PrinterSettings.ShouldPrintHeaderAndFooter = value; }
        public string HeaderTitle { get => this.PrinterSettings.HeaderTitle; set => this.PrinterSettings.HeaderTitle = value; }
        public string FooterUri { get => this.PrinterSettings.FooterUri; set => this.PrinterSettings.FooterUri = value; }

        protected virtual void Dispose(bool disposing)
        {
            if (!this._IsDesposed)
            {
                if (disposing)
                {
                    this.handle.Dispose();
                    //this._PrintSettings = null;
                }


                this._IsDesposed = true;
            }
        }



        public void Dispose()
        {
            // Ändern Sie diesen Code nicht. Fügen Sie Bereinigungscode in der Methode "Dispose(bool disposing)" ein.
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }

        //public COREWEBVIEW2_PRINT_ORIENTATION Orientation { get; set; }
        //public double ScaleFactor { get; set; }
        //public double PageWidth { get; set; }
        //public double PageHeight { get; set; }
        //public double MarginTop { get; set; }
        //public double MarginBottom { get; set; }
        //public double MarginLeft { get; set; }
        //public double MarginRight { get; set; }
        //public int ShouldPrintBackgrounds { get; set; }
        //public int ShouldPrintSelectionOnly { get; set; }
        //public int ShouldPrintHeaderAndFooter { get; set; }
        //public string HeaderTitle { get; set; }
        //public string FooterUri { get; set; }
    }
}