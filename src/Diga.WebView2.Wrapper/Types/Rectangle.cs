using Diga.WebView2.Interop;

// ReSharper disable once CheckNamespace
namespace Diga.WebView2.Wrapper.Types
{

    /// <summary>
    /// Represents a rectangle defined by its left, top, right, and bottom edges.
    /// </summary>
    /// <remarks>
    /// The <see cref="Rectangle"/> class provides properties to access and modify the edges of the
    /// rectangle. It also supports implicit conversion to and from <see cref="tagRECT"/> structures, allowing seamless
    /// interoperability with APIs that use <see cref="tagRECT"/>.
    /// </remarks>
    public class Rectangle
    {
        private tagRECT _Rect;

        /// <summary>
        /// Implicitly converts a <see cref="Rectangle"/> to a <see cref="tagRECT"/> structure.
        /// </summary>
        /// <param name="input">The <see cref="Rectangle"/> instance.</param>
        public static implicit operator tagRECT(Rectangle input)
        {
            return input._Rect;
        }

        /// <summary>
        /// Implicitly converts a <see cref="tagRECT"/> structure to a <see cref="Rectangle"/> instance.
        /// </summary>
        /// <param name="input">The <see cref="tagRECT"/> structure.</param>
        public static implicit operator Rectangle(tagRECT input)
        {
            return new Rectangle(input);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Rectangle"/> class with all edges set to zero.
        /// </summary>
        public Rectangle()
        {
            this._Rect = new tagRECT();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Rectangle"/> class from a <see cref="tagRECT"/> structure.
        /// </summary>
        /// <param name="rect">The <see cref="tagRECT"/> structure.</param>
        public Rectangle(tagRECT rect)
        {
            this._Rect = rect;
        }

        /// <summary>
        /// Gets or sets the left edge of the rectangle.
        /// </summary>
        public int Left
        {
            get => this._Rect.left;
            set => this._Rect.left = value;
        }
        /// <summary>
        /// Gets or sets the top edge of the rectangle.
        /// </summary>
        public int Top
        {
            get => this._Rect.top; set => this._Rect.top = value;
        }
        /// <summary>
        /// Gets or sets the right edge of the rectangle.
        /// </summary>
        public int Right
        {
            get => this._Rect.right; set => this._Rect.right = value;
        }
        /// <summary>
        /// Gets or sets the bottom edge of the rectangle.
        /// </summary>
        public int Bottom
        {
            get => this._Rect.bottom; set => this._Rect.bottom = value;
        }
    }
}
