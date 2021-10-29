using Diga.WebView2.Interop;

namespace Diga.WebView2.Wrapper
{
    public class WebView2PrintSettings : ICoreWebView2PrintSettings
    {
        public COREWEBVIEW2_PRINT_ORIENTATION Orientation { get; set; }
        public double ScaleFactor { get; set; }
        public double PageWidth { get; set; }
        public double PageHeight { get; set; }
        public double MarginTop { get; set; }
        public double MarginBottom { get; set; }
        public double MarginLeft { get; set; }
        public double MarginRight { get; set; }
        public int ShouldPrintBackgrounds { get; set; }
        public int ShouldPrintSelectionOnly { get; set; }
        public int ShouldPrintHeaderAndFooter { get; set; }
        public string HeaderTitle { get; set; }
        public string FooterUri { get; set; }
    }
}