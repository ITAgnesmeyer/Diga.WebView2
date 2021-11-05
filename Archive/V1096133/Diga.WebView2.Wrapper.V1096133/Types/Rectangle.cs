using Diga.WebView2.Interop;

// ReSharper disable once CheckNamespace
namespace Diga.WebView2.Wrapper.Types
{
    public class Rectangle
    {
        private tagRECT _Rect;

        public static implicit operator tagRECT(Rectangle input)
        {
            return input._Rect;
        }

        public static implicit operator Rectangle(tagRECT input)
        {
            return new Rectangle(input);
        }

        public Rectangle()
        {
            this._Rect = new tagRECT();
        }

        public Rectangle(tagRECT rect)
        {
            this._Rect = rect;
        }
        public int Left
        {
            get => this._Rect.left;
            set => this._Rect.left = value;
        }
        public int Top
        {
            get => this._Rect.top; set => this._Rect.top = value;
        }
        public int Right
        {
            get => this._Rect.right; set => this._Rect.right = value;
        }
        public int Bottom
        {
            get => this._Rect.bottom; set => this._Rect.bottom = value;
        }
    }
}
