using System;

namespace Diga.WebView2.Wrapper.Types
{
    /// <summary>
    /// Encapsulates a COM object and provides access to its interface of type <typeparamref name="T"/>.
    /// </summary>
    /// <remarks>This class holds a native COM object and lazily initializes the interface of type
    /// <typeparamref name="T"/>  when accessed. It also provides implicit conversion operators to and from the
    /// interface type.</remarks>
    /// <typeparam name="T">The type of the interface that the COM object implements.</typeparam>
    public class ComObjectHolder<T>
    {
        private readonly object _NativeObject;
        private T _Interface;

        /// <summary>
        /// Gets the interface representation of the native object.
        /// </summary>
        public T Interface
        {
            get
            {
                if (_Interface == null)
                {
                    _Interface = (T)this._NativeObject;
                }
                return _Interface;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ComObjectHolder{T}"/> class with the specified native object.
        /// </summary>
        /// <param name="native">The native COM object to be held. Cannot be <see langword="null"/>.</param>
        /// <exception cref="ArgumentException">Thrown if <paramref name="native"/> is <see langword="null"/>.</exception>
        public ComObjectHolder(object native)
        {
            _NativeObject = native ?? throw new ArgumentException($"{nameof(ComObjectHolder<T>)}/ctor {nameof(native)} cannot be null");
        }

        /// <summary>
        /// Implicitly converts a <see cref="ComObjectHolder{T}"/> to its underlying interface type <typeparamref
        /// name="T"/>.
        /// </summary>
        /// <param name="obj">The <see cref="ComObjectHolder{T}"/> instance to convert. Must not be <see langword="null"/>.</param>
        public static implicit operator T(ComObjectHolder<T> obj)
        {
            return obj.Interface;
        }

        /// <summary>
        /// Implicitly converts an instance of type <typeparamref name="T"/> to a <see cref="ComObjectHolder{T}"/>.
        /// </summary>
        /// <param name="obj">The instance of type <typeparamref name="T"/> to be wrapped in a <see cref="ComObjectHolder{T}"/>.</param>
        public static implicit operator ComObjectHolder<T>(T obj)
        {
            return new ComObjectHolder<T>(obj);
        }
    }
}