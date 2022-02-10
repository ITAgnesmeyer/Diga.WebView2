using Diga.WebView2.Interop;

namespace Diga.WebView2.Wrapper.Types
{
    public class Point
    {
        private tagPOINT _Point;

        public static implicit operator tagPOINT(Point input)
        {
            return input._Point;
        }

        public static implicit operator Point(tagPOINT input)
        {
            return new Point(input);
        }
        public Point()
        {
            this._Point = new tagPOINT();
            
        }

        public Point(tagPOINT point)
        {
            this._Point = point;
        }
        public int x
        {
            get => this._Point.x;
            set => this._Point.x = value;
        }

        public int y
        {
            get => this._Point.y;
            set => this._Point.y = value;
        }
    }
}