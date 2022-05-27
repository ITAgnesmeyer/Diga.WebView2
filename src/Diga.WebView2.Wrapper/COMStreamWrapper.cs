using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;

namespace Diga.WebView2.Wrapper
{
    internal class COMStreamWrapper : Stream
    {
        private IStream istream;
        private IntPtr mInt64;

        public COMStreamWrapper(IStream source)
        {
            this.istream = source;
            this.mInt64 = Marshal.AllocCoTaskMem(8);
        }

        ~COMStreamWrapper() => Marshal.FreeCoTaskMem(this.mInt64);

        public override bool CanRead => true;

        public override bool CanSeek => false;

        public override bool CanWrite => true;

        public override void Flush() => this.istream.Commit(0);

        public override long Length
        {
            get
            {
                System.Runtime.InteropServices.ComTypes.STATSTG pstatstg;
                this.istream.Stat(out pstatstg, 1);
                return pstatstg.cbSize;
            }
        }

        public override long Position
        {
            get => throw new NotSupportedException();
            set => throw new NotSupportedException();
        }

        public override int Read(byte[] buffer, int offset, int count)
        {
            if (offset != 0)
                throw new NotImplementedException();
            this.istream.Read(buffer, count, this.mInt64);
            return Marshal.ReadInt32(this.mInt64);
        }

        public override long Seek(long offset, SeekOrigin origin)
        {
            this.istream.Seek(offset, (int) origin, this.mInt64);
            return Marshal.ReadInt64(this.mInt64);
        }

        public override void SetLength(long value) => this.istream.SetSize(value);

        public override void Write(byte[] buffer, int offset, int count)
        {
            if (offset != 0)
                throw new NotImplementedException();
            this.istream.Write(buffer, count, IntPtr.Zero);
        }
    }
}