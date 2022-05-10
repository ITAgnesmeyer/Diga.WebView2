using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.Implementation;
using Diga.WebView2.Wrapper.Types;

namespace Diga.WebView2.Wrapper
{
    public class WebView2PointerInfo:WebView2PointerInfoInterface
    {
        public WebView2PointerInfo(ICoreWebView2PointerInfo iface):base(iface)
        {

        }
       
        public new Rectangle PointerDeviceRect
        {
            get => base.PointerDeviceRect;
            set => base.PointerDeviceRect = value;
        }

        public new Rectangle DisplayRect
        {
            get => base.DisplayRect;
            set => base.DisplayRect = value;
        }

        public new Point PixelLocation
        {
            get => base.PixelLocation;
            set => base.PixelLocation = value;
        }

        public new Point HimetricLocation
        {
            get => base.HimetricLocation;
            set => base.HimetricLocation = value;
        }

        public new Point PixelLocationRaw
        {
            get => base.PixelLocationRaw;
            set => base.PixelLocationRaw = value;
        }

        public new Point HimetricLocationRaw
        {
            get => base.HimetricLocationRaw;
            set => base.HimetricLocationRaw = value;
        }



        public new Rectangle TouchContact
        {
            get => base.TouchContact;
            set => base.TouchContact = value;
        }

        public new Rectangle TouchContactRaw
        {
            get => base.TouchContactRaw;
            set => base.TouchContactRaw = value;
        }

    }

   
}