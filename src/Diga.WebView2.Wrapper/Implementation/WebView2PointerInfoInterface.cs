using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Diga.WebView2.Interop;
using Microsoft.Win32.SafeHandles;

namespace Diga.WebView2.Wrapper.Implementation
{
    public class WebView2PointerInfoInterface : ICoreWebView2PointerInfo, IDisposable
    {
        private ICoreWebView2PointerInfo _PointerInfo;
        /// Wraps in SafeHandle so resources can be released if consumer forgets to call Dispose. Recommended
        ///             pattern for any type that is not sealed.
        ///             https://docs.microsoft.com/dotnet/api/system.idisposable#idisposable-and-the-inheritance-hierarchy
        private SafeHandle handle = new SafeFileHandle(IntPtr.Zero, true);
        private bool disposedValue;

        private ICoreWebView2PointerInfo PointerInfo
        {
            get
            {
                if (_PointerInfo == null)
                {
                    Debug.Print($"{nameof(WebView2PointerInfoInterface)} is null!");
                    throw new InvalidOperationException($"{nameof(WebView2PointerInfoInterface)} is null!");
                }
                return _PointerInfo;
            }
            set
            {
                _PointerInfo = value;
            }
        }
        public WebView2PointerInfoInterface(ICoreWebView2PointerInfo pointerInfo)
        {
            PointerInfo = pointerInfo;
        }

        public uint PointerKind { get => PointerInfo.PointerKind; set => PointerInfo.PointerKind = value; }
        public uint PointerId { get => PointerInfo.PointerId; set => PointerInfo.PointerId = value; }
        public uint FrameId { get => PointerInfo.FrameId; set => PointerInfo.FrameId = value; }
        public uint PointerFlags { get => PointerInfo.PointerFlags; set => PointerInfo.PointerFlags = value; }
        public tagRECT PointerDeviceRect { get => PointerInfo.PointerDeviceRect; set => PointerInfo.PointerDeviceRect = value; }
        public tagRECT DisplayRect { get => PointerInfo.DisplayRect; set => PointerInfo.DisplayRect = value; }
        public tagPOINT PixelLocation { get => PointerInfo.PixelLocation; set => PointerInfo.PixelLocation = value; }
        public tagPOINT HimetricLocation { get => PointerInfo.HimetricLocation; set => PointerInfo.HimetricLocation = value; }
        public tagPOINT PixelLocationRaw { get => PointerInfo.PixelLocationRaw; set => PointerInfo.PixelLocationRaw = value; }
        public tagPOINT HimetricLocationRaw { get => PointerInfo.HimetricLocationRaw; set => PointerInfo.HimetricLocationRaw = value; }
        public uint Time { get => PointerInfo.Time; set => PointerInfo.Time = value; }
        public uint HistoryCount { get => PointerInfo.HistoryCount; set => PointerInfo.HistoryCount = value; }
        public int InputData { get => PointerInfo.InputData; set => PointerInfo.InputData = value; }
        public uint KeyStates { get => PointerInfo.KeyStates; set => PointerInfo.KeyStates = value; }
        public ulong PerformanceCount { get => PointerInfo.PerformanceCount; set => PointerInfo.PerformanceCount = value; }
        public int ButtonChangeKind { get => PointerInfo.ButtonChangeKind; set => PointerInfo.ButtonChangeKind = value; }
        public uint PenFlags { get => PointerInfo.PenFlags; set => PointerInfo.PenFlags = value; }
        public uint PenMask { get => PointerInfo.PenMask; set => PointerInfo.PenMask = value; }
        public uint PenPressure { get => PointerInfo.PenPressure; set => PointerInfo.PenPressure = value; }
        public uint PenRotation { get => PointerInfo.PenRotation; set => PointerInfo.PenRotation = value; }
        public int PenTiltX { get => PointerInfo.PenTiltX; set => PointerInfo.PenTiltX = value; }
        public int PenTiltY { get => PointerInfo.PenTiltY; set => PointerInfo.PenTiltY = value; }
        public uint TouchFlags { get => PointerInfo.TouchFlags; set => PointerInfo.TouchFlags = value; }
        public uint TouchMask { get => PointerInfo.TouchMask; set => PointerInfo.TouchMask = value; }
        public tagRECT TouchContact { get => PointerInfo.TouchContact; set => PointerInfo.TouchContact = value; }
        public tagRECT TouchContactRaw { get => PointerInfo.TouchContactRaw; set => PointerInfo.TouchContactRaw = value; }
        public uint TouchOrientation { get => PointerInfo.TouchOrientation; set => PointerInfo.TouchOrientation = value; }
        public uint TouchPressure { get => PointerInfo.TouchPressure; set => PointerInfo.TouchPressure = value; }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    handle.Dispose();
                    _PointerInfo = null;
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