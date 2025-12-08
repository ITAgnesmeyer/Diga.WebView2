using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.Types;
using Microsoft.Win32.SafeHandles;

namespace Diga.WebView2.Wrapper.Implementation
{
    public class SaveAsUIShowingEventArgsInterface :EventArgs, IDisposable
    {
        private ComObjectHolder<ICoreWebView2SaveAsUIShowingEventArgs> _Args;
        /// Wraps in SafeHandle so resources can be released if consumer forgets to call Dispose. Recommended
        ///             pattern for any type that is not sealed.
        ///             https://docs.microsoft.com/dotnet/api/system.idisposable#idisposable-and-the-inheritance-hierarchy
        private SafeHandle handle = (SafeHandle)new SafeFileHandle(IntPtr.Zero, true);
        private bool disposedValue;

        private ICoreWebView2SaveAsUIShowingEventArgs Args
        {
            get
            {
                if (this._Args == null)
                {
                    Debug.Print(nameof(SaveAsUIShowingEventArgsInterface) + "=>" + nameof(this.Args) + " is null");
                    throw new InvalidOperationException(nameof(SaveAsUIShowingEventArgsInterface) + "=>" + nameof(this.Args) + " is null");
                }
                return this._Args.Interface;
            }
            set { this._Args = new ComObjectHolder<ICoreWebView2SaveAsUIShowingEventArgs>(value); }
        }

        public SaveAsUIShowingEventArgsInterface(ICoreWebView2SaveAsUIShowingEventArgs args)
        {
            if (args == null)
                throw new ArgumentNullException(nameof(args));
            this.Args = args;
        }

        public string ContentMimeType => Args.ContentMimeType;

        public int Cancel { get => Args.Cancel; set => Args.Cancel = value; }
        public int SuppressDefaultDialog { get => Args.SuppressDefaultDialog; set => Args.SuppressDefaultDialog = value; }

        [return: MarshalAs(UnmanagedType.Interface)]
        public ICoreWebView2Deferral GetDeferral()
        {
            return Args.GetDeferral();
        }

        public string SaveAsFilePath { get => Args.SaveAsFilePath; set => Args.SaveAsFilePath = value; }
        public int AllowReplace { get => Args.AllowReplace; set => Args.AllowReplace = value; }
        public COREWEBVIEW2_SAVE_AS_KIND Kind { get => Args.Kind; set => Args.Kind = value; }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    handle.Dispose();
                    Args = null;
                }

                // TODO: Nicht verwaltete Ressourcen (nicht verwaltete Objekte) freigeben und Finalizer überschreiben
                // TODO: Große Felder auf NULL setzen
                disposedValue = true;
            }
        }

        // // TODO: Finalizer nur überschreiben, wenn "Dispose(bool disposing)" Code für die Freigabe nicht verwalteter Ressourcen enthält
        // ~SaveAsUIShowingEventArgsInterface()
        // {
        //     // Ändern Sie diesen Code nicht. Fügen Sie Bereinigungscode in der Methode "Dispose(bool disposing)" ein.
        //     Dispose(disposing: false);
        // }

        public void Dispose()
        {
            // Ändern Sie diesen Code nicht. Fügen Sie Bereinigungscode in der Methode "Dispose(bool disposing)" ein.
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}