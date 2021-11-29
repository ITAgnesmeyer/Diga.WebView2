using Diga.WebView2.Interop;

namespace Diga.WebView2.Wrapper
{
    public class WebView2PointerInfoInterface: ICoreWebView2PointerInfo
    {
        private readonly ICoreWebView2PointerInfo _PonterInof;
        public WebView2PointerInfoInterface(ICoreWebView2PointerInfo pointerInfo)
        {
            this._PonterInof = pointerInfo;
        }

        public uint PointerKind { get => _PonterInof.PointerKind; set => _PonterInof.PointerKind = value; }
        public uint PointerId { get => _PonterInof.PointerId; set => _PonterInof.PointerId = value; }
        public uint FrameId { get => _PonterInof.FrameId; set => _PonterInof.FrameId = value; }
        public uint PointerFlags { get => _PonterInof.PointerFlags; set => _PonterInof.PointerFlags = value; }
        public tagRECT PointerDeviceRect { get => _PonterInof.PointerDeviceRect; set => _PonterInof.PointerDeviceRect = value; }
        public tagRECT DisplayRect { get => _PonterInof.DisplayRect; set => _PonterInof.DisplayRect = value; }
        public tagPOINT PixelLocation { get => _PonterInof.PixelLocation; set => _PonterInof.PixelLocation = value; }
        public tagPOINT HimetricLocation { get => _PonterInof.HimetricLocation; set => _PonterInof.HimetricLocation = value; }
        public tagPOINT PixelLocationRaw { get => _PonterInof.PixelLocationRaw; set => _PonterInof.PixelLocationRaw = value; }
        public tagPOINT HimetricLocationRaw { get => _PonterInof.HimetricLocationRaw; set => _PonterInof.HimetricLocationRaw = value; }
        public uint Time { get => _PonterInof.Time; set => _PonterInof.Time = value; }
        public uint HistoryCount { get => _PonterInof.HistoryCount; set => _PonterInof.HistoryCount = value; }
        public int InputData { get => _PonterInof.InputData; set => _PonterInof.InputData = value; }
        public uint KeyStates { get => _PonterInof.KeyStates; set => _PonterInof.KeyStates = value; }
        public ulong PerformanceCount { get => _PonterInof.PerformanceCount; set => _PonterInof.PerformanceCount = value; }
        public int ButtonChangeKind { get => _PonterInof.ButtonChangeKind; set => _PonterInof.ButtonChangeKind = value; }
        public uint PenFlags { get => _PonterInof.PenFlags; set => _PonterInof.PenFlags = value; }
        public uint PenMask { get => _PonterInof.PenMask; set => _PonterInof.PenMask = value; }
        public uint PenPressure { get => _PonterInof.PenPressure; set => _PonterInof.PenPressure = value; }
        public uint PenRotation { get => _PonterInof.PenRotation; set => _PonterInof.PenRotation = value; }
        public int PenTiltX { get => _PonterInof.PenTiltX; set => _PonterInof.PenTiltX = value; }
        public int PenTiltY { get => _PonterInof.PenTiltY; set => _PonterInof.PenTiltY = value; }
        public uint TouchFlags { get => _PonterInof.TouchFlags; set => _PonterInof.TouchFlags = value; }
        public uint TouchMask { get => _PonterInof.TouchMask; set => _PonterInof.TouchMask = value; }
        public tagRECT TouchContact { get => _PonterInof.TouchContact; set => _PonterInof.TouchContact = value; }
        public tagRECT TouchContactRaw { get => _PonterInof.TouchContactRaw; set => _PonterInof.TouchContactRaw = value; }
        public uint TouchOrientation { get => _PonterInof.TouchOrientation; set => _PonterInof.TouchOrientation = value; }
        public uint TouchPressure { get => _PonterInof.TouchPressure; set => _PonterInof.TouchPressure = value; }
    }
   
}