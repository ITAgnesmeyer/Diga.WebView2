using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.Types;
using Microsoft.Win32.SafeHandles;

namespace Diga.WebView2.Wrapper.Implementation
{
    public class WebView2ScriptExceptionInterface :Exception , IDisposable //, ICoreWebView2ScriptException
    {
        private ComObjectHolder<ICoreWebView2ScriptException> _Iface;
        private bool _IsDesposed;

        /// Wraps in SafeHandle so resources can be released if consumer forgets to call Dispose. Recommended
        ///             pattern for any type that is not sealed.
        ///             https://docs.microsoft.com/dotnet/api/system.idisposable#idisposable-and-the-inheritance-hierarchy
        private SafeHandle handle = new SafeFileHandle(IntPtr.Zero, true);
        public WebView2ScriptExceptionInterface(ICoreWebView2ScriptException iface)//:base(iface.Message) 
        {
            Iface = iface ?? throw new ArgumentNullException(nameof(iface));
        }

        private ICoreWebView2ScriptException Iface
        {
            get
            {
                if (_Iface == null)
                {
                    Debug.Print(nameof(WebView2ScriptExceptionInterface) + "=>" + nameof(Iface) + " is null");

                    throw new InvalidOperationException(nameof(WebView2ScriptExceptionInterface) + "=>" + nameof(Iface) + " is null");
                }

                return _Iface.Interface;
            }
            set => _Iface = new ComObjectHolder<ICoreWebView2ScriptException>(value);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_IsDesposed)
            {
                if (disposing)
                {
                    handle.Dispose();
                    _Iface = null;
                }

                _IsDesposed = true;
            }
        }

        public void Dispose()
        {
            // Ändern Sie diesen Code nicht. Fügen Sie Bereinigungscode in der Methode "Dispose(bool disposing)" ein.
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
        
        public uint LineNumber => Iface.LineNumber;

        public uint ColumnNumber => Iface.ColumnNumber;

        public string name => Iface.name;
        
        public override string Message => Iface.Message;

        public string ToJson => Iface.ToJson;
        public override string ToString()
        {
            string msg = $"{this.name}(line:{this.LineNumber}/col:{this.ColumnNumber}) => {this.Message} => {base.ToString()}" ; 
            return msg;
        }
    }
}