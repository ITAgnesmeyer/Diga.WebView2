using Diga.WebView2.Interop;
using System.Drawing;

namespace Diga.WebView2.Wrapper.Types
{
    /// <summary>
    /// Represents a color value for use with WebView2, supporting conversion between <see cref="COREWEBVIEW2_COLOR"/> and <see cref="System.Drawing.Color"/>.
    /// </summary>
    /// <remarks>
    /// The <see cref="WebViewColor"/> class provides properties for the alpha, red, green, and blue components of a color.
    /// It supports implicit conversion to and from <see cref="COREWEBVIEW2_COLOR"/> and <see cref="System.Drawing.Color"/>.
    /// </remarks>
    public class WebViewColor
    {
        private COREWEBVIEW2_COLOR _ARGB;

        /// <summary>
        /// Gets or sets the alpha (transparency) component of the color.
        /// </summary>
        public byte A
        {
            get => this._ARGB.A;
            set => this._ARGB.A = value;
        }
        /// <summary>
        /// Gets or sets the red component of the color.
        /// </summary>
        public byte R
        {
            get => this._ARGB.R;
            set => this._ARGB.R = value;
        }

        /// <summary>
        /// Gets or sets the green component of the color.
        /// </summary>
        public byte G
        {
            get => this._ARGB.G;
            set => this._ARGB.G = value;
        }

        /// <summary>
        /// Gets or sets the blue component of the color.
        /// </summary>
        public byte B
        {
            get => this._ARGB.B;
            set => this._ARGB.B = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebViewColor"/> class from a <see cref="COREWEBVIEW2_COLOR"/> structure.
        /// </summary>
        /// <param name="argb">The <see cref="COREWEBVIEW2_COLOR"/> structure.</param>
        public WebViewColor(COREWEBVIEW2_COLOR argb)
        {
            this._ARGB = argb;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebViewColor"/> class with all components set to zero.
        /// </summary>
        public WebViewColor()
        {
            this._ARGB = new COREWEBVIEW2_COLOR();
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="WebViewColor"/> class with the specified ARGB components.
        /// </summary>
        /// <param name="a">The alpha component.</param>
        /// <param name="r">The red component.</param>
        /// <param name="g">The green component.</param>
        /// <param name="b">The blue component.</param>
        public WebViewColor(byte a , byte r, byte g, byte b):this()
        {
            _ARGB.A = a;
            _ARGB.R = r;
            _ARGB.G = g;
            _ARGB.B = b;
        }

        /// <summary>
        /// Implicitly converts a <see cref="WebViewColor"/> to a <see cref="Color"/>.
        /// </summary>
        /// <param name="input">The <see cref="WebViewColor"/> instance.</param>
        public static implicit operator Color(WebViewColor input)
        {
            return Color.FromArgb(input.A, input.R , input.G , input.B);
        }
        /// <summary>
        /// Implicitly converts a <see cref="Color"/> to a <see cref="WebViewColor"/>.
        /// </summary>
        /// <param name="input">The <see cref="Color"/> instance.</param>
        public static implicit operator WebViewColor(Color input)
        {
            return new WebViewColor(input.A, input.R , input.G, input.B);            
        }

        /// <summary>
        /// Implicitly converts a <see cref="WebViewColor"/> to a <see cref="COREWEBVIEW2_COLOR"/> structure.
        /// </summary>
        /// <param name="input">The <see cref="WebViewColor"/> instance.</param>
        public static implicit operator COREWEBVIEW2_COLOR(WebViewColor input)
        {
            return new COREWEBVIEW2_COLOR{A = input.A, R = input.R, G= input.G, B=input.B};
        }
        /// <summary>
        /// Implicitly converts a <see cref="COREWEBVIEW2_COLOR"/> structure to a <see cref="WebViewColor"/>.
        /// </summary>
        /// <param name="input">The <see cref="COREWEBVIEW2_COLOR"/> structure.</param>
        public static implicit operator WebViewColor(COREWEBVIEW2_COLOR input)
        {
            return new WebViewColor(input);
        }
    }
}
