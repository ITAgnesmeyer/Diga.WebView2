using System;

namespace Diga.WebView2.Wrapper.Types
{
    internal class ComObjctHolder<T>
    {
        private object _NativeObject;
        private T _Interface;

        public T Interface
        {
            get
            {
                if (_Interface == null)
                {
                    _Interface = (T)_NativeObject;
                }
                return _Interface;
            }
        }
        public ComObjctHolder(object native)
        {
            _NativeObject = native ?? throw new ArgumentException($"{nameof(ComObjctHolder<T>)}/ctor {nameof(native)} cannot be null");
        }

    }
}