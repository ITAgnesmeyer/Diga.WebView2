// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace

namespace Diga.WebView2.Wrapper.Types
{

    /// <summary>
    /// Represents a C-style boolean value with implicit conversions to and from <see cref="bool"/> and <see cref="int"/>.
    /// </summary>
    public sealed class CBOOL
    {
        private bool _Value;

        /// <summary>
        /// Initializes a new instance of the <see cref="CBOOL"/> class with a value of <c>false</c>.
        /// </summary>
        public CBOOL()
        {
            this._Value = false;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CBOOL"/> class from an integer value (0 = false, any other = true).
        /// </summary>
        /// <param name="input">The integer value to convert.</param>
        public CBOOL(int input)
        {
            this.Value = input;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CBOOL"/> class from a boolean value.
        /// </summary>
        /// <param name="input">The boolean value to use.</param>
        public CBOOL(bool input)
        {
            this._Value = input;
        }

        /// <summary>
        /// Implicitly converts a <see cref="CBOOL"/> to a <see cref="bool"/>.
        /// </summary>
        /// <param name="input">The <see cref="CBOOL"/> instance.</param>
        public static implicit operator bool(CBOOL input)
        {
            return input._Value;
        }

        /// <summary>
        /// Implicitly converts a <see cref="bool"/> to a <see cref="CBOOL"/>.
        /// </summary>
        /// <param name="input">The boolean value.</param>
        public static implicit operator CBOOL(bool input)
        {
            return new CBOOL(input);
        }

        /// <summary>
        /// Implicitly converts a <see cref="CBOOL"/> to an <see cref="int"/> (1 = true, 0 = false).
        /// </summary>
        /// <param name="input">The <see cref="CBOOL"/> instance.</param>
        public static implicit operator int(CBOOL input)
        {
            return input.Value;
        }

        /// <summary>
        /// Implicitly converts an <see cref="int"/> to a <see cref="CBOOL"/> (0 = false, any other = true).
        /// </summary>
        /// <param name="input">The integer value.</param>
        public static implicit operator CBOOL(int input)
        {
            return new CBOOL(input);
        }

        /// <summary>
        /// Gets or sets the value as an integer (1 = true, 0 = false).
        /// </summary>
        public int Value
        {
            get
            {
                if (this._Value)
                    return 1;
                else
                    return 0;
            }
            set
            {
                if (value == 0)
                    this._Value = false;
                else
                    this._Value = true;
            }
        }
    }
    
}