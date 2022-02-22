using Diga.WebView2.Interop;
using System.Drawing;

namespace Diga.WebView2.Wrapper.Types
{
    public class WebViewColor
    {
        private COREWEBVIEW2_COLOR _ARGB;

        public byte A
        {
            get => this._ARGB.A;
            set => this._ARGB.A = value;
        }
        public byte R
        {
            get => this._ARGB.R;
            set => this._ARGB.R = value;
        }

        public byte G
        {
            get => this._ARGB.G;
            set => this._ARGB.G = value;
        }

        public byte B
        {
            get => this._ARGB.B;
            set => this._ARGB.B = value;
        }

        public WebViewColor(COREWEBVIEW2_COLOR argb)
        {
            this._ARGB = argb;
        }

        public WebViewColor()
        {
            this._ARGB = new COREWEBVIEW2_COLOR();
        }
        public WebViewColor(byte a , byte r, byte g, byte b):this()
        {
            _ARGB.A = a;
            _ARGB.R = r;
            _ARGB.G = g;
            _ARGB.B = b;
        }

        public static implicit operator Color(WebViewColor input)
        {
            return Color.FromArgb(input.A, input.R , input.G , input.B);
        }
        public static implicit operator WebViewColor(Color input)
        {
            return new WebViewColor(input.A, input.R , input.G, input.B);            
        }

        public static implicit operator COREWEBVIEW2_COLOR(WebViewColor input)
        {
            return new COREWEBVIEW2_COLOR{A = input.A, R = input.R, G= input.G, B=input.B};

        }
        public static implicit operator WebViewColor(COREWEBVIEW2_COLOR input)
        {
            return new WebViewColor(input);
        }
    }
}
