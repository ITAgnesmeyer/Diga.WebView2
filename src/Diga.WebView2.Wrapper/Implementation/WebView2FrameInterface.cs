using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.EventArguments;
using Diga.WebView2.Wrapper.Types;
using Microsoft.Win32.SafeHandles;

namespace Diga.WebView2.Wrapper.Implementation
{
    public class WebView2FrameInterface : IDisposable
    {
        private ComObjectHolder<ICoreWebView2Frame> _Args;
        private bool disposedValue;

        /// Wraps in SafeHandle so resources can be released if consumer forgets to call Dispose. Recommended
        ///             pattern for any type that is not sealed.
        ///             https://docs.microsoft.com/dotnet/api/system.idisposable#idisposable-and-the-inheritance-hierarchy
        private SafeHandle handle = new SafeFileHandle(IntPtr.Zero, true);

        private ICoreWebView2Frame Args
        {
            get
            {
                if (this._Args == null)
                {
                    Debug.Print(nameof(WebView2FrameInterface) + " Args is null");
                    throw new InvalidOperationException(nameof(WebView2FrameInterface) + " Args is null");
                }

                return this._Args.Interface;
            }
            set
            {
                this._Args = new ComObjectHolder<ICoreWebView2Frame>( value);
            }
        }

        public WebView2FrameInterface(ICoreWebView2Frame args)
        {
            if (args == null)
                throw new ArgumentNullException(nameof(args));
            this.Args = args;

        }
        public string name => this.Args.name;

        public void add_NameChanged([In, MarshalAs(UnmanagedType.Interface)] ICoreWebView2FrameNameChangedEventHandler eventHandler, out EventRegistrationToken token)
        {
            this.Args.add_NameChanged(eventHandler, out token);
        }

        public void remove_NameChanged([In] EventRegistrationToken token)
        {
            this.Args.remove_NameChanged(token);
        }

        public void AddHostObjectToScriptWithOrigins([In, MarshalAs(UnmanagedType.LPWStr)] string name, ref object @object, [In] uint originsCount, [In, MarshalAs(UnmanagedType.LPWStr)] ref string origins)
        {
            this.Args.AddHostObjectToScriptWithOrigins(name, ref @object, originsCount, ref origins);
        }

        public void RemoveHostObjectFromScript([In, MarshalAs(UnmanagedType.LPWStr)] string name)
        {
            this.Args.RemoveHostObjectFromScript(name);
        }

        public void add_Destroyed([In, MarshalAs(UnmanagedType.Interface)] ICoreWebView2FrameDestroyedEventHandler eventHandler, out EventRegistrationToken token)
        {
            this.Args.add_Destroyed(eventHandler, out token);
        }

        public void remove_Destroyed([In] EventRegistrationToken token)
        {
            this.Args.remove_Destroyed(token);
        }

        public int IsDestroyed()
        {
            return this.Args.IsDestroyed();
        }


        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposedValue)
            {
                if (disposing)
                {
                    this.handle.Dispose();
                    this._Args = null;
                }

                this.disposedValue = true;
            }
        }



        public void Dispose()
        {
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }

        
    }
}