using Diga.WebView2.Interop;

namespace Diga.WebView2.Wrapper.Types
{
    public class Rectangle
    {
        internal tagRECT Rect;

        public static implicit operator tagRECT(Rectangle input)
        {
            return input.Rect;
        }

        public static implicit operator Rectangle(tagRECT input)
        {
            return new Rectangle(input);
        }

        public Rectangle()
        {
            this.Rect = new tagRECT();
        }

        public Rectangle(tagRECT rect)
        {
            this.Rect = rect;
        }
        public int Left{get=> this.Rect.left;
            set => this.Rect.left = value;
        }
        public int Top
        {
            get => this.Rect.top; set => this.Rect.top = value;
        }
        public int Right
        {
            get => this.Rect.right; set=> this.Rect.right = value;
        }
        public int Bottom
        {
            get => this.Rect.bottom; set => this.Rect.bottom = value;
        }
    }
}
