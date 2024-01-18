using System.IO;
using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.Implementation;
// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming

// ReSharper disable once CheckNamespace
namespace Diga.WebView2.Wrapper
{
    public class WebView2SharedBuffer:WebView2SharedBufferInteface
    {
        public WebView2SharedBuffer(ICoreWebView2SharedBuffer args):base(args) { }

        public new Stream OpenStream()
        {
            return new ComStream(base.OpenStream());
        }

    }
    //public class StreamWrapper : IStream,IDisposable
    //{
    //    private IStream _Interface;
    //    private bool disposedValue;
    //    /// Wraps in SafeHandle so resources can be released if consumer forgets to call Dispose. Recommended
    //    ///             pattern for any type that is not sealed.
    //    ///             https://docs.microsoft.com/dotnet/api/system.idisposable#idisposable-and-the-inheritance-hierarchy
    //    private SafeHandle handle = (SafeHandle) new SafeFileHandle(IntPtr.Zero, true);
    //    public StreamWrapper(IStream iface)
    //    {
    //        this._Interface = iface;
    //    }

    //    public void Read(byte[] pv, int cb, IntPtr pcbRead)
    //    {
    //        this._Interface.Read(pv, cb, pcbRead);
    //    }

    //    public void Write(byte[] pv, int cb, IntPtr pcbWritten)
    //    {
    //        this._Interface.Write(pv, cb, pcbWritten);
    //    }

    //    public void Seek(long dlibMove, int dwOrigin, IntPtr plibNewPosition)
    //    {
    //        this._Interface.Seek(dlibMove, dwOrigin, plibNewPosition);
    //    }

    //    public void SetSize(long libNewSize)
    //    {
    //        this._Interface.SetSize(libNewSize);
    //    }

    //    public void CopyTo(IStream pstm, long cb, IntPtr pcbRead, IntPtr pcbWritten)
    //    {
    //        this._Interface.CopyTo(pstm, cb, pcbRead, pcbWritten);
    //    }

    //    public void Commit(int grfCommitFlags)
    //    {
    //        this._Interface.Commit(grfCommitFlags);
    //    }

    //    public void Revert()
    //    {
    //        this._Interface.Revert();
    //    }

    //    public void LockRegion(long libOffset, long cb, int dwLockType)
    //    {
    //        this._Interface.LockRegion(libOffset, cb, dwLockType);
    //    }

    //    public void UnlockRegion(long libOffset, long cb, int dwLockType)
    //    {
    //        this._Interface.UnlockRegion(libOffset, cb, dwLockType);
    //    }

    //    public void Stat(out STATSTG pstatstg, int grfStatFlag)
    //    {
    //        this._Interface.Stat(out pstatstg, grfStatFlag);
    //    }

    //    public void Clone(out IStream ppstm)
    //    {
    //        this._Interface.Clone(out ppstm);
    //    }

    //    protected virtual void Dispose(bool disposing)
    //    {
    //        if (!disposedValue)
    //        {
    //            if (disposing)
    //            {
    //                // TODO: Verwalteten Zustand (verwaltete Objekte) bereinigen

    //            }

    //            this._Interface = null;
    //            // TODO: Nicht verwaltete Ressourcen (nicht verwaltete Objekte) freigeben und Finalizer überschreiben
    //            // TODO: Große Felder auf NULL setzen
    //            disposedValue = true;
    //        }
    //    }

    //    // // TODO: Finalizer nur überschreiben, wenn "Dispose(bool disposing)" Code für die Freigabe nicht verwalteter Ressourcen enthält
    //    ~StreamWrapper()
    //    {
    //        // Ändern Sie diesen Code nicht. Fügen Sie Bereinigungscode in der Methode "Dispose(bool disposing)" ein.
    //        Dispose(disposing: false);
    //    }

    //    public void Dispose()
    //    {
    //        // Ändern Sie diesen Code nicht. Fügen Sie Bereinigungscode in der Methode "Dispose(bool disposing)" ein.
    //        Dispose(disposing: true);
    //        GC.SuppressFinalize(this);
    //    }
    //}
}