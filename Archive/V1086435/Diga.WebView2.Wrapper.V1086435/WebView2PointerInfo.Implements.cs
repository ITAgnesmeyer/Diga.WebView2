using Diga.WebView2.Interop;

namespace Diga.WebView2.Wrapper
{
    public partial class WebView2PointerInfo : ICoreWebView2PointerInfo
    {
        private readonly ICoreWebView2PointerInfo _Inteface;

        public WebView2PointerInfo()
        {
            this._Inteface = this;
        }

        public WebView2PointerInfo(ICoreWebView2PointerInfo pointerInfo)
        {
            this._Inteface = pointerInfo;
        }
        uint ICoreWebView2PointerInfo.PointerKind
        {
            get => this._Inteface.PointerKind;
            set => this._Inteface.PointerKind = value;
        }

        uint ICoreWebView2PointerInfo.PointerId
        {
            get => this._Inteface.PointerId;
            set => this._Inteface.PointerId = value;
        }

        uint ICoreWebView2PointerInfo.FrameId
        {
            get => this._Inteface.FrameId;
            set => this._Inteface.FrameId = value;
        }

        uint ICoreWebView2PointerInfo.PointerFlags
        {
            get => this._Inteface.PointerFlags;
            set => this._Inteface.PointerFlags = value;
        }

        tagRECT ICoreWebView2PointerInfo.PointerDeviceRect
        {
            get => this._Inteface.PointerDeviceRect;
            set => this._Inteface.PointerDeviceRect = value;
        }

        tagRECT ICoreWebView2PointerInfo.DisplayRect
        {
            get => this._Inteface.DisplayRect;
            set => this._Inteface.DisplayRect = value;
        }

        tagPOINT ICoreWebView2PointerInfo.PixelLocation
        {
            get => this._Inteface.PixelLocation;
            set => this._Inteface.PixelLocation = value;
        }

        tagPOINT ICoreWebView2PointerInfo.HimetricLocation
        {
            get => this._Inteface.HimetricLocation;
            set => this._Inteface.HimetricLocation = value;
        }

        tagPOINT ICoreWebView2PointerInfo.PixelLocationRaw
        {
            get => this._Inteface.PixelLocationRaw;
            set => this._Inteface.PixelLocationRaw = value;
        }

        tagPOINT ICoreWebView2PointerInfo.HimetricLocationRaw
        {
            get => this._Inteface.HimetricLocationRaw;
            set => this._Inteface.HimetricLocationRaw = value;
        }

        uint ICoreWebView2PointerInfo.Time
        {
            get => this._Inteface.Time;
            set => this._Inteface.Time = value;
        }

        uint ICoreWebView2PointerInfo.HistoryCount
        {
            get => this._Inteface.HistoryCount;
            set => this._Inteface.HistoryCount = value;
        }

        int ICoreWebView2PointerInfo.InputData
        {
            get => this._Inteface.InputData;
            set => this._Inteface.InputData = value;
        }

        uint ICoreWebView2PointerInfo.KeyStates
        {
            get => this._Inteface.KeyStates;
            set => this._Inteface.KeyStates = value;
        }

        ulong ICoreWebView2PointerInfo.PerformanceCount
        {
            get => this._Inteface.PerformanceCount;
            set => this._Inteface.PerformanceCount = value;
        }

        int ICoreWebView2PointerInfo.ButtonChangeKind
        {
            get => this._Inteface.ButtonChangeKind;
            set => this._Inteface.ButtonChangeKind = value;
        }

        uint ICoreWebView2PointerInfo.PenFlags
        {
            get => this._Inteface.PenFlags;
            set => this._Inteface.PenFlags = value;
        }

        uint ICoreWebView2PointerInfo.PenMask
        {
            get => this._Inteface.PenMask;
            set => this._Inteface.PenMask = value;
        }

        uint ICoreWebView2PointerInfo.PenPressure
        {
            get => this._Inteface.PenPressure;
            set => this._Inteface.PenPressure = value;
        }

        uint ICoreWebView2PointerInfo.PenRotation
        {
            get => this._Inteface.PenRotation;
            set => this._Inteface.PenRotation = value;
        }

        int ICoreWebView2PointerInfo.PenTiltX
        {
            get => this._Inteface.PenTiltX;
            set => this._Inteface.PenTiltX = value;
        }

        int ICoreWebView2PointerInfo.PenTiltY
        {
            get => this._Inteface.PenTiltY;
            set => this._Inteface.PenTiltY = value;
        }

        uint ICoreWebView2PointerInfo.TouchFlags
        {
            get => this._Inteface.TouchFlags;
            set => this._Inteface.TouchFlags = value;
        }

        uint ICoreWebView2PointerInfo.TouchMask
        {
            get => this._Inteface.TouchMask;
            set => this._Inteface.TouchMask = value;
        }

        tagRECT ICoreWebView2PointerInfo.TouchContact
        {
            get => this._Inteface.TouchContact;
            set => this._Inteface.TouchContact = value;
        }

        tagRECT ICoreWebView2PointerInfo.TouchContactRaw
        {
            get => this._Inteface.TouchContactRaw;
            set => this._Inteface.TouchContactRaw = value;
        }

        uint ICoreWebView2PointerInfo.TouchOrientation
        {
            get => this._Inteface.TouchOrientation;
            set => this._Inteface.TouchOrientation = value;
        }

        uint ICoreWebView2PointerInfo.TouchPressure
        {
            get => this._Inteface.TouchPressure;
            set => this._Inteface.TouchPressure = value;
        }
    }
}