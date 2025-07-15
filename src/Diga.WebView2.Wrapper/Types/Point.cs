using Diga.WebView2.Interop;

namespace Diga.WebView2.Wrapper.Types
{
    /// <summary>
    /// Represents a point in a two-dimensional coordinate system.
    /// </summary>
    /// <remarks>
    /// The <see cref="Point"/> class provides properties to access and modify the X and Y
    /// coordinates of the point. It also supports implicit conversion to and from the <see cref="tagPOINT"/>
    /// structure.
    /// </remarks>
    public class Point
    {
        private tagPOINT _Point;

        /// <summary>
        /// Implicitly converts a <see cref="Point"/> to a <see cref="tagPOINT"/> structure.
        /// </summary>
        /// <param name="input">The <see cref="Point"/> instance.</param>
        public static implicit operator tagPOINT(Point input)
        {
            return input._Point;
        }

        /// <summary>
        /// Implicitly converts a <see cref="tagPOINT"/> structure to a <see cref="Point"/> instance.
        /// </summary>
        /// <param name="input">The <see cref="tagPOINT"/> structure.</param>
        public static implicit operator Point(tagPOINT input)
        {
            return new Point(input);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Point"/> class at the origin (0,0).
        /// </summary>
        public Point()
        {
            this._Point = new tagPOINT();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Point"/> class from a <see cref="tagPOINT"/> structure.
        /// </summary>
        /// <param name="point">The <see cref="tagPOINT"/> structure.</param>
        public Point(tagPOINT point)
        {
            this._Point = point;
        }

        /// <summary>
        /// Gets or sets the X coordinate of the point.
        /// </summary>
        public int x
        {
            get => this._Point.x;
            set => this._Point.x = value;
        }

        /// <summary>
        /// Gets or sets the Y coordinate of the point.
        /// </summary>
        public int y
        {
            get => this._Point.y;
            set => this._Point.y = value;
        }
    }
}