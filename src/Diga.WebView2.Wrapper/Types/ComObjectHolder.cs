using System;

namespace Diga.WebView2.Wrapper.Types
{
    public class ComObjectHolder<T>
    {
        private readonly object _NativeObject;
        private T _Interface;

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
        public ComObjectHolder(object native)
        {
            _NativeObject = native ?? throw new ArgumentException($"{nameof(ComObjectHolder<T>)}/ctor {nameof(native)} cannot be null");
        }

        public static implicit operator T(ComObjectHolder<T> obj)
        {
            return obj.Interface;
        }

        public static implicit operator ComObjectHolder<T>(T obj)
        {
            return new ComObjectHolder<T>(obj);
        }
    }
}