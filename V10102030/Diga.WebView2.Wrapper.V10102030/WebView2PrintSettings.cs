using Diga.WebView2.Interop;

namespace Diga.WebView2.Wrapper
{
    public class WebView2PrintSettingsInterface:ICoreWebView2PrintSettings
    {
        private ICoreWebView2PrintSettings _PrintSettings;
        public WebView2PrintSettingsInterface(ICoreWebView2PrintSettings printSettings)
        {
            this._PrintSettings = printSettings;
        }

        public COREWEBVIEW2_PRINT_ORIENTATION Orientation { get => _PrintSettings.Orientation; set => _PrintSettings.Orientation = value; }
        public double ScaleFactor { get => _PrintSettings.ScaleFactor; set => _PrintSettings.ScaleFactor = value; }
        public double PageWidth { get => _PrintSettings.PageWidth; set => _PrintSettings.PageWidth = value; }
        public double PageHeight { get => _PrintSettings.PageHeight; set => _PrintSettings.PageHeight = value; }
        public double MarginTop { get => _PrintSettings.MarginTop; set => _PrintSettings.MarginTop = value; }
        public double MarginBottom { get => _PrintSettings.MarginBottom; set => _PrintSettings.MarginBottom = value; }
        public double MarginLeft { get => _PrintSettings.MarginLeft; set => _PrintSettings.MarginLeft = value; }
        public double MarginRight { get => _PrintSettings.MarginRight; set => _PrintSettings.MarginRight = value; }
        public int ShouldPrintBackgrounds { get => _PrintSettings.ShouldPrintBackgrounds; set => _PrintSettings.ShouldPrintBackgrounds = value; }
        public int ShouldPrintSelectionOnly { get => _PrintSettings.ShouldPrintSelectionOnly; set => _PrintSettings.ShouldPrintSelectionOnly = value; }
        public int ShouldPrintHeaderAndFooter { get => _PrintSettings.ShouldPrintHeaderAndFooter; set => _PrintSettings.ShouldPrintHeaderAndFooter = value; }
        public string HeaderTitle { get => _PrintSettings.HeaderTitle; set => _PrintSettings.HeaderTitle = value; }
        public string FooterUri { get => _PrintSettings.FooterUri; set => _PrintSettings.FooterUri = value; }
    }

    public class WebView2PrintSettings : WebView2PrintSettingsInterface
    {
       
        public WebView2PrintSettings(ICoreWebView2PrintSettings printSettings):base(printSettings)
        {

        }
    }
}