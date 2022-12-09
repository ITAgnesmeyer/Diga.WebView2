using System;
using System.Data.Common;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.Types;
using Microsoft.Win32.SafeHandles;

namespace Diga.WebView2.Wrapper.Implementation
{
    public class WebView2PointerInfoInterface :  IDisposable
    {
        private ComObjectHolder<ICoreWebView2PointerInfo> _PointerInfo;
        /// Wraps in SafeHandle so resources can be released if consumer forgets to call Dispose. Recommended
        ///             pattern for any type that is not sealed.
        ///             https://docs.microsoft.com/dotnet/api/system.idisposable#idisposable-and-the-inheritance-hierarchy
        private SafeHandle handle = new SafeFileHandle(IntPtr.Zero, true);
        private bool disposedValue;

        private ICoreWebView2PointerInfo PointerInfo
        {
            get
            {
                if (this._PointerInfo == null)
                {
                    Debug.Print($"{nameof(WebView2PointerInfoInterface)} is null!");
                    throw new InvalidOperationException($"{nameof(WebView2PointerInfoInterface)} is null!");
                }
                return this._PointerInfo.Interface;
            }
            set
            {
                this._PointerInfo =new ComObjectHolder<ICoreWebView2PointerInfo>(  value);
            }
        }
        public WebView2PointerInfoInterface(ICoreWebView2PointerInfo pointerInfo)
        {
            this.PointerInfo = pointerInfo;
        }

        public uint PointerKind { get => this.PointerInfo.PointerKind; set => this.PointerInfo.PointerKind = value; }
        public uint PointerId { get => this.PointerInfo.PointerId; set => this.PointerInfo.PointerId = value; }
        public uint FrameId { get => this.PointerInfo.FrameId; set => this.PointerInfo.FrameId = value; }
        public uint PointerFlags { get => this.PointerInfo.PointerFlags; set => this.PointerInfo.PointerFlags = value; }
        public tagRECT PointerDeviceRect { get => this.PointerInfo.PointerDeviceRect; set => this.PointerInfo.PointerDeviceRect = value; }
        public tagRECT DisplayRect { get => this.PointerInfo.DisplayRect; set => this.PointerInfo.DisplayRect = value; }
        public tagPOINT PixelLocation { get => this.PointerInfo.PixelLocation; set => this.PointerInfo.PixelLocation = value; }
        public tagPOINT HimetricLocation { get => this.PointerInfo.HimetricLocation; set => this.PointerInfo.HimetricLocation = value; }
        public tagPOINT PixelLocationRaw { get => this.PointerInfo.PixelLocationRaw; set => this.PointerInfo.PixelLocationRaw = value; }
        public tagPOINT HimetricLocationRaw { get => this.PointerInfo.HimetricLocationRaw; set => this.PointerInfo.HimetricLocationRaw = value; }
        public uint Time { get => this.PointerInfo.Time; set => this.PointerInfo.Time = value; }
        public uint HistoryCount { get => this.PointerInfo.HistoryCount; set => this.PointerInfo.HistoryCount = value; }
        public int InputData { get => this.PointerInfo.InputData; set => this.PointerInfo.InputData = value; }
        public uint KeyStates { get => this.PointerInfo.KeyStates; set => this.PointerInfo.KeyStates = value; }
        public ulong PerformanceCount { get => this.PointerInfo.PerformanceCount; set => this.PointerInfo.PerformanceCount = value; }
        public int ButtonChangeKind { get => this.PointerInfo.ButtonChangeKind; set => this.PointerInfo.ButtonChangeKind = value; }
        public uint PenFlags { get => this.PointerInfo.PenFlags; set => this.PointerInfo.PenFlags = value; }
        public uint PenMask { get => this.PointerInfo.PenMask; set => this.PointerInfo.PenMask = value; }
        public uint PenPressure { get => this.PointerInfo.PenPressure; set => this.PointerInfo.PenPressure = value; }
        public uint PenRotation { get => this.PointerInfo.PenRotation; set => this.PointerInfo.PenRotation = value; }
        public int PenTiltX { get => this.PointerInfo.PenTiltX; set => this.PointerInfo.PenTiltX = value; }
        public int PenTiltY { get => this.PointerInfo.PenTiltY; set => this.PointerInfo.PenTiltY = value; }
        public uint TouchFlags { get => this.PointerInfo.TouchFlags; set => this.PointerInfo.TouchFlags = value; }
        public uint TouchMask { get => this.PointerInfo.TouchMask; set => this.PointerInfo.TouchMask = value; }
        public tagRECT TouchContact { get => this.PointerInfo.TouchContact; set => this.PointerInfo.TouchContact = value; }
        public tagRECT TouchContactRaw { get => this.PointerInfo.TouchContactRaw; set => this.PointerInfo.TouchContactRaw = value; }
        public uint TouchOrientation { get => this.PointerInfo.TouchOrientation; set => this.PointerInfo.TouchOrientation = value; }
        public uint TouchPressure { get => this.PointerInfo.TouchPressure; set => this.PointerInfo.TouchPressure = value; }

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposedValue)
            {
                if (disposing)
                {
                    this.handle.Dispose();
                    this._PointerInfo = null;
                }

                this.disposedValue = true;
            }
        }

        public void Dispose()
        {
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }

        public ICoreWebView2PointerInfo GetInterface()
        {
            return PointerInfo;
        }
       
    }

}