// Decompiled with JetBrains decompiler
// Type: Diga.WebView2.Interop.COREWEBVIEW2_PDF_TOOLBAR_ITEMS
// Assembly: Diga.WebView2.Interop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EA95D0FC-77DE-40CE-8C3C-89517DF28E5B
// Assembly location: O:\webview2\V10118539\Diga.WebView2.Interop.dll

namespace Diga.WebView2.Interop
{
    /// <summary>
    /// Specifies the available toolbar items for the PDF viewer in WebView2.
    /// </summary>
    public enum COREWEBVIEW2_PDF_TOOLBAR_ITEMS
    {
        /// <summary>
        /// No toolbar items are shown.
        /// </summary>
        COREWEBVIEW2_PDF_TOOLBAR_ITEMS_NONE = 0,
        /// <summary>
        /// The Save button.
        /// </summary>
        COREWEBVIEW2_PDF_TOOLBAR_ITEMS_SAVE = 1,
        /// <summary>
        /// The Print button.
        /// </summary>
        COREWEBVIEW2_PDF_TOOLBAR_ITEMS_PRINT = 2,
        /// <summary>
        /// The Save As button.
        /// </summary>
        COREWEBVIEW2_PDF_TOOLBAR_ITEMS_SAVE_AS = 4,
        /// <summary>
        /// The Zoom In button.
        /// </summary>
        COREWEBVIEW2_PDF_TOOLBAR_ITEMS_ZOOM_IN = 8,
        /// <summary>
        /// The Zoom Out button.
        /// </summary>
        COREWEBVIEW2_PDF_TOOLBAR_ITEMS_ZOOM_OUT = 16, // 0x00000010
        /// <summary>
        /// The Rotate button.
        /// </summary>
        COREWEBVIEW2_PDF_TOOLBAR_ITEMS_ROTATE = 32, // 0x00000020
        /// <summary>
        /// The Fit Page button.
        /// </summary>
        COREWEBVIEW2_PDF_TOOLBAR_ITEMS_FIT_PAGE = 64, // 0x00000040
        /// <summary>
        /// The Page Layout button.
        /// </summary>
        COREWEBVIEW2_PDF_TOOLBAR_ITEMS_PAGE_LAYOUT = 128, // 0x00000080
        /// <summary>
        /// The Bookmarks button.
        /// </summary>
        COREWEBVIEW2_PDF_TOOLBAR_ITEMS_BOOKMARKS = 256, // 0x00000100
        /// <summary>
        /// The Page Selector button.
        /// </summary>
        COREWEBVIEW2_PDF_TOOLBAR_ITEMS_PAGE_SELECTOR = 512, // 0x00000200
        /// <summary>
        /// The Search button.
        /// </summary>
        COREWEBVIEW2_PDF_TOOLBAR_ITEMS_SEARCH = 1024, // 0x00000400
        /// <summary>
        /// The Full Screen button.
        /// </summary>
        COREWEBVIEW2_PDF_TOOLBAR_ITEMS_FULL_SCREEN = 2048, // 0x00000800
        /// <summary>
        /// The More Settings button.
        /// </summary>
        COREWEBVIEW2_PDF_TOOLBAR_ITEMS_MORE_SETTINGS = 4096, // 0x00001000
    }
}
