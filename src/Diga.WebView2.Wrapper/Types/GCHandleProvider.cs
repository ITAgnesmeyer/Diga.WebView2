using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Text;

namespace Diga.WebView2.Wrapper.Types
{
    internal unsafe static class ObjectRefHandler
    {
        public static IntPtr AddressOf(object o)
        {
            if(o == null) return IntPtr.Zero;
            TypedReference reference = __makeref(o);
            TypedReference* pRef = &reference;
            return (IntPtr)pRef;
        }
    }

  
    internal static class ObjectHandleExtensions
    {
        public static IntPtr ToIntPtr(this object target)
        {
            return GCHandle.Alloc(target).ToIntPtr();
        }

        public static GCHandle ToGcHandle(this object target)
        {
            return GCHandle.Alloc(target,GCHandleType.Pinned);
        }

        public static IntPtr ToIntPtr(this GCHandle target)
        {
            return GCHandle.ToIntPtr(target);
        }
    }
    internal class GCHandleProvider : IDisposable
    {
        public GCHandleProvider(object target)
        {
            Handle = target.ToGcHandle();
        }

        public IntPtr Pointer => Handle.ToIntPtr();

        public GCHandle Handle { get; }

        private void ReleaseUnmanagedResources()
        {
            if (Handle.IsAllocated) Handle.Free();
        }

        public void Dispose()
        {
            ReleaseUnmanagedResources();
            GC.SuppressFinalize(this);
        }

        ~GCHandleProvider()
        {
            ReleaseUnmanagedResources();
        }
    }
}
