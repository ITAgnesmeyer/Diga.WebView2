using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.Types;

namespace Diga.WebView2.Wrapper
{
    public partial class WebView2PointerInfo
    {
        private ICoreWebView2PointerInfo ToInterface()
        {
            return this;
        }
        public uint PointerKind
        {
            get => this.ToInterface().PointerKind;
            set => this.ToInterface().PointerKind = value;
        }

        public uint PointerId
        {
            get => this.ToInterface().PointerId;
            set => this.ToInterface().PointerId = value;
        }

        public uint FrameId
        {
            get => this.ToInterface().FrameId;
            set => this.ToInterface().FrameId = value;
        }

        public uint PointerFlags
        {
            get => this.ToInterface().PointerFlags;
            set => this.ToInterface().PointerFlags = value;
        }

        public Rectangle PointerDeviceRect
        {
            get => this.ToInterface().PointerDeviceRect;
            set => this.ToInterface().PointerDeviceRect = value;
        }

        public Rectangle DisplayRect
        {
            get => this.ToInterface().DisplayRect;
            set => this.ToInterface().DisplayRect = value;
        }

        public Point PixelLocation
        {
            get => this.ToInterface().PixelLocation;
            set => this.ToInterface().PixelLocation = value;
        }

        public Point HimetricLocation
        {
            get => this.ToInterface().HimetricLocation;
            set => this.ToInterface().HimetricLocation = value;
        }

        public Point PixelLocationRaw
        {
            get => this.ToInterface().PixelLocationRaw;
            set => this.ToInterface().PixelLocationRaw = value;
        }

        public Point HimetricLocationRaw
        {
            get => this.ToInterface().HimetricLocationRaw;
            set => this.ToInterface().HimetricLocationRaw = value;
        }

        public uint Time
        {
            get => this.ToInterface().Time;
            set => this.ToInterface().Time = value;
        }

        public uint HistoryCount
        {
            get => this.ToInterface().HistoryCount;
            set => this.ToInterface().HistoryCount = value;
        }

        public int InputData
        {
            get => this.ToInterface().InputData;
            set => this.ToInterface().InputData = value;
        }

        public uint KeyStates
        {
            get => this.ToInterface().KeyStates;
            set => this.ToInterface().KeyStates = value;
        }

        public ulong PerformanceCount
        {
            get => this.ToInterface().PerformanceCount;
            set => this.ToInterface().PerformanceCount = value;
        }

        public int ButtonChangeKind
        {
            get => this.ToInterface().ButtonChangeKind;
            set => this.ToInterface().ButtonChangeKind = value;
        }

        public uint PenFlags
        {
            get => this.ToInterface().PenFlags;
            set => this.ToInterface().PenFlags = value;
        }

        public uint PenMask
        {
            get => this.ToInterface().PenMask;
            set => this.ToInterface().PenMask = value;
        }

        public uint PenPressure
        {
            get => this.ToInterface().PenPressure;
            set => this.ToInterface().PenPressure = value;
        }

        public uint PenRotation
        {
            get => this.ToInterface().PenRotation;
            set => this.ToInterface().PenRotation = value;
        }

        public int PenTiltX
        {
            get => this.ToInterface().PenTiltX;
            set => this.ToInterface().PenTiltX = value;
        }

        public int PenTiltY
        {
            get => this.ToInterface().PenTiltY;
            set => this.ToInterface().PenTiltY = value;
        }

        public uint TouchFlags
        {
            get => this.ToInterface().TouchFlags;
            set => this.ToInterface().TouchFlags = value;
        }

        public uint TouchMask
        {
            get => this.ToInterface().TouchMask;
            set => this.ToInterface().TouchMask = value;
        }

        public tagRECT TouchContact
        {
            get => this.ToInterface().TouchContact;
            set => this.ToInterface().TouchContact = value;
        }

        public tagRECT TouchContactRaw
        {
            get => this.ToInterface().TouchContactRaw;
            set => this.ToInterface().TouchContactRaw = value;
        }

        public uint TouchOrientation
        {
            get => this.ToInterface().TouchOrientation;
            set => this.ToInterface().TouchOrientation = value;
        }

        public uint TouchPressure
        {
            get => this.ToInterface().TouchPressure;
            set => this.ToInterface().TouchPressure = value;
        }
    }

   
}