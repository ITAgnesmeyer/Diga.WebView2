using Diga.WebView2.Interop;

namespace Diga.WebView2.Wrapper
{
    public class StreamWrapper : IStream
    {
        private IStream _Interface;

        public StreamWrapper(IStream iface)
        {
            this._Interface = iface;
        }

        private IStream ToInterface()
        {
            return this;
        }

        public void RemoteRead(out byte pv, uint cb, out uint pcbRead)
        {
            this.ToInterface().RemoteRead(out pv, cb, out pcbRead);
        }

        public void RemoteWrite(ref byte pv, uint cb, out uint pcbWritten)
        {
            this.ToInterface().RemoteWrite(ref pv, cb, out pcbWritten);
        }

        public void RemoteSeek(long dlibMove, uint dwOrigin, out ulong plibNewPosition)
        {
            _LARGE_INTEGER largeint = new _LARGE_INTEGER { QuadPart = dlibMove };

            this.ToInterface().RemoteSeek(largeint, dwOrigin, out _ULARGE_INTEGER uLarge);
            plibNewPosition = uLarge.QuadPart;
        }


        public void SetSize(ulong libNewSize)
        {
            this.ToInterface().SetSize(new _ULARGE_INTEGER { QuadPart = libNewSize });
        }


        public void RemoteCopyTo(StreamWrapper pstm, ulong cb, out ulong pcbRead,
            out ulong pcbWritten)
        {
            this.ToInterface().RemoteCopyTo(pstm, new _ULARGE_INTEGER { QuadPart = cb }, out _ULARGE_INTEGER plRead,
                out _ULARGE_INTEGER plWrite);
            pcbRead = plRead.QuadPart;
            pcbWritten = plWrite.QuadPart;
        }

        public void Commit(uint grfCommitFlags)
        {
            this.ToInterface().Commit(grfCommitFlags);
        }


        public void Revert()
        {
            this.ToInterface().Revert();
        }

        public void LockRegion(ulong libOffset, ulong cb, uint dwLockType)
        {
            this.ToInterface().LockRegion(new _ULARGE_INTEGER { QuadPart = libOffset },
                new _ULARGE_INTEGER { QuadPart = cb }, dwLockType);
        }

        public void UnlockRegion(ulong libOffset, ulong cb, uint dwLockType)
        {
            this.ToInterface().UnlockRegion(new _ULARGE_INTEGER { QuadPart = libOffset },
                new _ULARGE_INTEGER { QuadPart = cb }, dwLockType);
        }

        public void Stat(out tagSTATSTG pstatstg, uint grfStatFlag)
        {
            this.ToInterface().Stat(out pstatstg, grfStatFlag);
        }

        public void Clone(out StreamWrapper ppstm)
        {
            this.ToInterface().Clone(out IStream ppIstrm);
            ppstm = new StreamWrapper(ppIstrm);
        }
        void ISequentialStream.RemoteRead(out byte pv, uint cb, out uint pcbRead)
        {
            this._Interface.RemoteRead(out pv, cb, out pcbRead);
        }

        void IStream.RemoteWrite(ref byte pv, uint cb, out uint pcbWritten)
        {
            this._Interface.RemoteWrite(ref pv, cb, out pcbWritten);
        }

        void IStream.RemoteSeek(_LARGE_INTEGER dlibMove, uint dwOrigin, out _ULARGE_INTEGER plibNewPosition)
        {
            this._Interface.RemoteSeek(dlibMove, dwOrigin, out plibNewPosition);
        }

        void IStream.SetSize(_ULARGE_INTEGER libNewSize)
        {
            this._Interface.SetSize(libNewSize);
        }

        void IStream.RemoteCopyTo(IStream pstm, _ULARGE_INTEGER cb, out _ULARGE_INTEGER pcbRead, out _ULARGE_INTEGER pcbWritten)
        {
            this._Interface.RemoteCopyTo(pstm, cb, out pcbRead, out pcbWritten);
        }

        void IStream.Commit(uint grfCommitFlags)
        {
            this._Interface.Commit(grfCommitFlags);
        }

        void IStream.Revert()
        {
            this._Interface.Revert();
        }

        void IStream.LockRegion(_ULARGE_INTEGER libOffset, _ULARGE_INTEGER cb, uint dwLockType)
        {
            this._Interface.LockRegion(libOffset, cb, dwLockType);
        }

        void IStream.UnlockRegion(_ULARGE_INTEGER libOffset, _ULARGE_INTEGER cb, uint dwLockType)
        {
            this._Interface.UnlockRegion(libOffset, cb, dwLockType);
        }

        void IStream.Stat(out tagSTATSTG pstatstg, uint grfStatFlag)
        {
            this._Interface.Stat(out pstatstg, grfStatFlag);
        }

        void IStream.Clone(out IStream ppstm)
        {
            this._Interface.Clone(out ppstm);
        }

        void IStream.RemoteRead(out byte pv, uint cb, out uint pcbRead)
        {
            this._Interface.RemoteRead(out pv, cb, out pcbRead);
        }

        void ISequentialStream.RemoteWrite(ref byte pv, uint cb, out uint pcbWritten)
        {
            this._Interface.RemoteWrite(ref pv, cb, out pcbWritten);
        }
    }
}