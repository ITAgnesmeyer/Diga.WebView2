using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.Implementation;


namespace Diga.WebView2.Wrapper.EventArguments
{






    public class WebResourceRequestedEventArgs : WebResourceRequestedEventArgs2Interface//EventArgs, ICoreWebView2WebResourceRequestedEventArgs, IDisposable
    {
        //private ICoreWebView2WebResourceRequestedEventArgs _Args;
        //private bool disposedValue;
        ///// Wraps in SafeHandle so resources can be released if consumer forgets to call Dispose. Recommended
        /////             pattern for any type that is not sealed.
        /////             https://docs.microsoft.com/dotnet/api/system.idisposable#idisposable-and-the-inheritance-hierarchy
        //private SafeHandle handle = (SafeHandle)new SafeFileHandle(IntPtr.Zero, true);
        public WebResourceRequestedEventArgs(ICoreWebView2WebResourceRequestedEventArgs2 args):base(args)
        {
            //this._Args = args;
        }

        //private ICoreWebView2WebResourceRequestedEventArgs ToInterface()
        //{
        //    return _Args;
        //}

        public new WebResourceRequest Request => new WebResourceRequest(base.Request);

        public new WebResourceResponse Response
        {
            get
            {
                if (base.Response == null)
                    return null;
                return new WebResourceResponse(base.Response);
            }
            set
            {
                base.Response = value.ToInterface();
            }
        }


        public new WebView2Deferral GetDeferral()
        {
            return new WebView2Deferral(base.GetDeferral());
        }

 
        

        // // TODO: Finalizer nur überschreiben, wenn "Dispose(bool disposing)" Code für die Freigabe nicht verwalteter Ressourcen enthält
        ~WebResourceRequestedEventArgs()
        {
            // Ändern Sie diesen Code nicht. Fügen Sie Bereinigungscode in der Methode "Dispose(bool disposing)" ein.
            Dispose(disposing: false);
        }

        
    }
}