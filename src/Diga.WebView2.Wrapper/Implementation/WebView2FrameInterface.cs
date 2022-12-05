﻿using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.EventArguments;
using Microsoft.Win32.SafeHandles;

namespace Diga.WebView2.Wrapper.Implementation
{
    public class WebView2FrameInterface : ICoreWebView2Frame, IDisposable
    {
        private ICoreWebView2Frame _Args;
        private bool disposedValue;

        /// Wraps in SafeHandle so resources can be released if consumer forgets to call Dispose. Recommended
        ///             pattern for any type that is not sealed.
        ///             https://docs.microsoft.com/dotnet/api/system.idisposable#idisposable-and-the-inheritance-hierarchy
        private SafeHandle handle = new SafeFileHandle(IntPtr.Zero, true);

        private ICoreWebView2Frame Args
        {
            get
            {
                if (_Args == null)
                {
                    Debug.Print(nameof(WebView2FrameInterface) + " Args is null");
                    throw new InvalidOperationException(nameof(WebView2FrameInterface) + " Args is null");
                }

                return _Args;
            }
            set
            {
                _Args = value;
            }
        }

        public WebView2FrameInterface(ICoreWebView2Frame args)
        {
            if (args == null)
                throw new ArgumentNullException(nameof(args));
            _Args = args;

        }
        public string name => Args.name;

        public void add_NameChanged([In, MarshalAs(UnmanagedType.Interface)] ICoreWebView2FrameNameChangedEventHandler eventHandler, out EventRegistrationToken token)
        {
            Args.add_NameChanged(eventHandler, out token);
        }

        public void remove_NameChanged([In] EventRegistrationToken token)
        {
            Args.remove_NameChanged(token);
        }

        public void AddHostObjectToScriptWithOrigins([In, MarshalAs(UnmanagedType.LPWStr)] string name, ref object @object, [In] uint originsCount, [In, MarshalAs(UnmanagedType.LPWStr)] ref string origins)
        {
            Args.AddHostObjectToScriptWithOrigins(name, ref @object, originsCount, ref origins);
        }

        public void RemoveHostObjectFromScript([In, MarshalAs(UnmanagedType.LPWStr)] string name)
        {
            Args.RemoveHostObjectFromScript(name);
        }

        public void add_Destroyed([In, MarshalAs(UnmanagedType.Interface)] ICoreWebView2FrameDestroyedEventHandler eventHandler, out EventRegistrationToken token)
        {
            Args.add_Destroyed(eventHandler, out token);
        }

        public void remove_Destroyed([In] EventRegistrationToken token)
        {
            Args.remove_Destroyed(token);
        }

        public int IsDestroyed()
        {
            return Args.IsDestroyed();
        }


        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {

                    handle.Dispose();
                    _Args = null;
                }

                disposedValue = true;
            }
        }



        public void Dispose()
        {
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}