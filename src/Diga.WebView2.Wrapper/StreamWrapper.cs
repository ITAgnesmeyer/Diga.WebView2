using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Security;
using System.Threading.Tasks;
using Microsoft.Win32.SafeHandles;
using STATSTG = System.Runtime.InteropServices.ComTypes.STATSTG;
// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming

// ReSharper disable once CheckNamespace
namespace Diga.WebView2.Wrapper
{


    internal static class StreamSeek
    {
        public const int STREAM_SEEK_SET = 0x0;

        public const int STREAM_SEEK_CUR = 0x1;

        public const int STREAM_SEEK_END = 0x2;
    }
    internal static class Stgm
    {
        public const int STGM_READ = 0x00000000;

        public const int STGM_WRITE = 0x00000001;

        public const int STGM_READWRITE = 0x00000002;

        public const int STGM_SHARE_EXCLUSIVE = 0x00000010;

        public const int STGM_CREATE = 0x00001000;

        public const int STGM_TRANSACTED = 0x00010000;

        public const int STGM_CONVERT = 0x00020000;

        public const int STGM_DELETEONRELEASE = 0x04000000;
    }
    internal static class Stgty
    {
        public const int STGTY_STORAGE = 1;

        public const int STGTY_STREAM = 2;

        public const int STGTY_LOCKBYTES = 3;

        public const int STGTY_PROPERTY = 4;
    }

    // The class ManagedIStream is not COM-visible. Its purpose is to be able to invoke COM interfaces
    // from managed code rather than the contrary.
    internal class ManagedIStream : IStream
    {

        /// Wraps in SafeHandle so resources can be released if consumer forgets to call Dispose. Recommended
        ///             pattern for any type that is not sealed.
        ///             https://docs.microsoft.com/dotnet/api/system.idisposable#idisposable-and-the-inheritance-hierarchy
        private SafeHandle handle = (SafeHandle) new SafeFileHandle(IntPtr.Zero, true);
        /// <summary>
        /// Constructor
        /// </summary>
        internal ManagedIStream(ref Stream ioStream)
        {
            this._ioStream = ioStream ?? throw new ArgumentNullException("ioStream");
        }

        /// <summary>
        /// Read at most bufferSize bytes into buffer and return the effective
        /// number of bytes read in bytesReadPtr (unless null).
        /// </summary>
        /// <remarks>
        /// mscorlib disassembly shows the following MarshalAs parameters
        /// void Read([Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex=1)] byte[] pv, int cb, IntPtr pcbRead);
        /// This means marshaling code will have found the size of the array buffer in the parameter bufferSize.
        /// </remarks>
        ///<SecurityNote>
        ///     Critical: calls Marshal.WriteInt32 which LinkDemands, takes pointers as input
        ///</SecurityNote>
        [SecurityCritical]
        void IStream.Read(Byte[] buffer, Int32 bufferSize, IntPtr bytesReadPtr)
        {
            Int32 bytesRead = this._ioStream.Read(buffer, 0, bufferSize);
            if (bytesReadPtr != IntPtr.Zero)
            {
                Marshal.WriteInt32(bytesReadPtr, bytesRead);
            }
        }

        /// <summary>
        /// Move the stream pointer to the specified position.
        /// </summary>
        /// <remarks>
        /// System.IO.stream supports searching past the end of the stream, like
        /// OLE streams.
        /// newPositionPtr is not an out parameter because the method is required
        /// to accept NULL pointers.
        /// </remarks>
        ///<SecurityNote>
        ///     Critical: calls Marshal.WriteInt64 which LinkDemands, takes pointers as input
        ///</SecurityNote>
        [SecurityCritical]
        void IStream.Seek(Int64 offset, Int32 origin, IntPtr newPositionPtr)
        {
            SeekOrigin seekOrigin;

            // The operation will generally be I/O bound, so there is no point in
            // eliminating the following switch by playing on the fact that
            // System.IO uses the same integer values as IStream for SeekOrigin.
            switch (origin)
            {
                case StreamSeek.STREAM_SEEK_SET:
                    seekOrigin = SeekOrigin.Begin;
                    break;
                case StreamSeek.STREAM_SEEK_CUR:
                    seekOrigin = SeekOrigin.Current;
                    break;
                case StreamSeek.STREAM_SEEK_END:
                    seekOrigin = SeekOrigin.End;
                    break;
                default:
                    throw new ArgumentOutOfRangeException("origin");
            }
            long position = this._ioStream.Seek(offset, seekOrigin);

            // Dereference newPositionPtr and assign to the pointed location.
            if ((newPositionPtr == IntPtr.Zero))
            {
                return;
            }
            Marshal.WriteInt64(newPositionPtr, position);
        }

        /// <summary>
        /// Sets stream's size.
        /// </summary>
        void IStream.SetSize(Int64 libNewSize)
        {
            this._ioStream.SetLength(libNewSize);
        }

        /// <summary>
        /// Obtain stream stats.
        /// </summary>
        /// <remarks>
        /// STATSG has to be qualified because it is defined both in System.Runtime.InteropServices and
        /// System.Runtime.InteropServices.ComTypes.
        /// The STATSTG structure is shared by streams, storages and byte arrays. Members irrelevant to streams
        /// or not available from System.IO.Stream are not returned, which leaves only cbSize and grfMode as 
        /// meaningful and available pieces of information.
        /// grfStatFlag is used to indicate whether the stream name should be returned and is ignored because
        /// this information is unavailable.
        /// </remarks>
        void IStream.Stat(out STATSTG streamStats, int grfStatFlag)
        {
            streamStats = new STATSTG();
            streamStats.type = Stgty.STGTY_STREAM;
            streamStats.cbSize = this._ioStream.Length;

            // Return access information in grfMode.
            streamStats.grfMode = 0; // default value for each flag will be false
            if (this._ioStream.CanRead && this._ioStream.CanWrite)
            {
                streamStats.grfMode |= Stgm.STGM_READWRITE;
            }
            else if (this._ioStream.CanRead)
            {
                streamStats.grfMode |= Stgm.STGM_READ;
            }
            else if (this._ioStream.CanWrite)
            {
                streamStats.grfMode |= Stgm.STGM_WRITE;
            }
            else
            {
                // A stream that is neither readable nor writable is a closed stream.
                // Note the use of an exception that is known to the interop marshaller
                // (unlike ObjectDisposedException).
                throw new IOException("A stream that is neither readable nor writable is a closed stream.");
            }
        }

        /// <summary>
        /// Write at most bufferSize bytes from buffer.
        /// </summary>
        ///<SecurityNote>
        ///     Critical: calls Marshal.WriteInt32 which LinkDemands, takes pointers as input
        ///</SecurityNote>
        [SecurityCritical]
        void IStream.Write(Byte[] buffer, Int32 bufferSize, IntPtr bytesWrittenPtr)
        {
            this._ioStream.Write(buffer, 0, bufferSize);
            if (bytesWrittenPtr != IntPtr.Zero)
            {
                // If fewer than bufferSize bytes had been written, an exception would
                // have been thrown, so it can be assumed we wrote bufferSize bytes.
                Marshal.WriteInt32(bytesWrittenPtr, bufferSize);
            }
        }

        #region Unimplemented methods
        /// <summary>
        /// Create a clone.
        /// </summary>
        /// <remarks>
        /// Not implemented.
        /// </remarks>
        void IStream.Clone(out IStream streamCopy)
        {
            streamCopy = null;
            throw new NotSupportedException();
        }

        /// <summary>
        /// Read at most bufferSize bytes from the receiver and write them to targetStream.
        /// </summary>
        /// <remarks>
        /// Not implemented.
        /// </remarks>
        void IStream.CopyTo(IStream targetStream, Int64 bufferSize, IntPtr buffer, IntPtr bytesWrittenPtr)
        {
            throw new NotSupportedException();
        }

        /// <summary>
        /// Commit changes.
        /// </summary>
        /// <remarks>
        /// Only relevant to transacted streams.
        /// </remarks>
        void IStream.Commit(Int32 flags)
        {
            throw new NotSupportedException();
        }

        /// <summary>
        /// Lock at most byteCount bytes starting at offset.
        /// </summary>
        /// <remarks>
        /// Not supported by System.IO.Stream.
        /// </remarks>
        void IStream.LockRegion(Int64 offset, Int64 byteCount, Int32 lockType)
        {
            throw new NotSupportedException();
        }

        /// <summary>
        /// Undo writes performed since last Commit.
        /// </summary>
        /// <remarks>
        /// Relevant only to transacted streams.
        /// </remarks>
        void IStream.Revert()
        {
            throw new NotSupportedException();
        }

        /// <summary>
        /// Unlock the specified region.
        /// </summary>
        /// <remarks>
        /// Not supported by System.IO.Stream.
        /// </remarks>
        void IStream.UnlockRegion(Int64 offset, Int64 byteCount, Int32 lockType)
        {
            throw new NotSupportedException();
        }
        #endregion Unimplemented methods

        #region Fields
        private  Stream _ioStream;
       
        #endregion Fields
    }

    /// <summary>
    /// Provides a managed wrapper for a COM IStream interface, allowing for reading and writing operations on the
    /// underlying COM stream.
    /// </summary>
    /// <remarks>This class extends the <see cref="Stream"/> class to provide a .NET interface for interacting
    /// with COM streams. It supports reading and writing operations, but does not support seeking. The class ensures
    /// proper memory management by allocating and freeing unmanaged memory as needed.</remarks>
    public class ComStream : Stream
    {
        private IStream _IStream;
        private IntPtr _Int64;
     
        /// <summary>
        /// Initializes a new instance of the <see cref="ComStream"/> class using the specified COM stream.
        /// </summary>
        /// <param name="source">The COM stream to be wrapped by this instance. Cannot be <see langword="null"/>.</param>
        public ComStream(IStream source)
        {
            this._IStream = source;
            this._Int64 = Marshal.AllocCoTaskMem(8);
        }

        /// <summary>
        /// Commits any buffered data to the underlying storage.
        /// </summary>
        /// <remarks>This method ensures that all data written to the stream is persisted.  It is
        /// typically used to ensure data integrity before closing the stream.</remarks>
        public override void Flush()
        {
            this._IStream.Commit(0);
        }


        
        public override int Read(byte[] buffer, int offset, int count)
        {
            if (offset != 0)
                throw new NotSupportedException();
            this._IStream.Read(buffer, count, this._Int64);
            return Marshal.ReadInt32(this._Int64);
        }

        public async Task<byte[]> GetAllBytesAsync()
        {
            long len = this.Length;
            
            byte[] bytes = new byte[len];
            int read = await this.ReadAsync(bytes, 0, (int)len);
            return bytes;
        }
        public byte[] GetAllBytes()
        {
            long len = this.Length;
            byte[] bytes = new byte[len];
            this.Read(bytes, 0, (int)len);
            return bytes;
        }
        public override long Seek(long offset, SeekOrigin origin)
        {
            this._IStream.Seek(offset, (int) origin, this._Int64);
            return Marshal.ReadInt64(this._Int64);
        }

        public override void SetLength(long value)
        {
            this._IStream.SetSize(value);
        }

        public override void Write(byte[] buffer, int offset, int count)
        {
            if (offset != 0)
                throw new NotImplementedException();
            this._IStream.Write(buffer, count, IntPtr.Zero);
        }

        public override bool CanRead => true;

        public override bool CanSeek => false;

        public override bool CanWrite => true;

        public override long Length
        {
            get
            {
                System.Runtime.InteropServices.ComTypes.STATSTG pstatstg;
                this._IStream.Stat(out pstatstg, 1);
                return pstatstg.cbSize;
            }
        }

        public override long Position
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
            if (disposing)
            {
                Marshal.FreeCoTaskMem(this._Int64);
            }
        }

        ~ComStream()
        {
            Marshal.FreeCoTaskMem(this._Int64);
        }
    }
    
}