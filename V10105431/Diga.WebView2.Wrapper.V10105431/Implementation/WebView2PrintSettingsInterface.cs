using System;
using System.Runtime.InteropServices;
using Diga.WebView2.Interop;
using Microsoft.Win32.SafeHandles;

namespace Diga.WebView2.Wrapper.Implementation
{
    public class WebView2PrintSettingsInterface:ICoreWebView2PrintSettings, IDisposable
    {
        private ICoreWebView2PrintSettings _PrintSettings;
        private bool _IsDesposed;
        /// Wraps in SafeHandle so resources can be released if consumer forgets to call Dispose. Recommended
        ///             pattern for any type that is not sealed.
        ///             https://docs.microsoft.com/dotnet/api/system.idisposable#idisposable-and-the-inheritance-hierarchy
        private SafeHandle handle = (SafeHandle) new SafeFileHandle(IntPtr.Zero, true);
        public WebView2PrintSettingsInterface(ICoreWebView2PrintSettings printSettings)
        {
            this._PrintSettings = printSettings;
        }

        public COREWEBVIEW2_PRINT_ORIENTATION Orientation { get => this._PrintSettings.Orientation; set => this._PrintSettings.Orientation = value; }
        public double ScaleFactor { get => this._PrintSettings.ScaleFactor; set => this._PrintSettings.ScaleFactor = value; }
        public double PageWidth { get => this._PrintSettings.PageWidth; set => this._PrintSettings.PageWidth = value; }
        public double PageHeight { get => this._PrintSettings.PageHeight; set => this._PrintSettings.PageHeight = value; }
        public double MarginTop { get => this._PrintSettings.MarginTop; set => this._PrintSettings.MarginTop = value; }
        public double MarginBottom { get => this._PrintSettings.MarginBottom; set => this._PrintSettings.MarginBottom = value; }
        public double MarginLeft { get => this._PrintSettings.MarginLeft; set => this._PrintSettings.MarginLeft = value; }
        public double MarginRight { get => this._PrintSettings.MarginRight; set => this._PrintSettings.MarginRight = value; }
        public int ShouldPrintBackgrounds { get => this._PrintSettings.ShouldPrintBackgrounds; set => this._PrintSettings.ShouldPrintBackgrounds = value; }
        public int ShouldPrintSelectionOnly { get => this._PrintSettings.ShouldPrintSelectionOnly; set => this._PrintSettings.ShouldPrintSelectionOnly = value; }
        public int ShouldPrintHeaderAndFooter { get => this._PrintSettings.ShouldPrintHeaderAndFooter; set => this._PrintSettings.ShouldPrintHeaderAndFooter = value; }
        public string HeaderTitle { get => this._PrintSettings.HeaderTitle; set => this._PrintSettings.HeaderTitle = value; }
        public string FooterUri { get => this._PrintSettings.FooterUri; set => this._PrintSettings.FooterUri = value; }

        protected virtual void Dispose(bool disposing)
        {
            if (!this._IsDesposed)
            {
                if (disposing)
                {
                    this.handle.Dispose();
                    this._PrintSettings = null;
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
    }
}