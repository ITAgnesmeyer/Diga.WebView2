using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.Types;

namespace Diga.WebView2.Wrapper
{
    public class WebView2PointerInfo:WebView2PointerInfoInterface
    {
        public WebView2PointerInfo(ICoreWebView2PointerInfo iface):base(iface)
        {

        }
       
        new public Rectangle PointerDeviceRect
        {
            get => base.PointerDeviceRect;
            set => base.PointerDeviceRect = value;
        }

        new public Rectangle DisplayRect
        {
            get => base.DisplayRect;
            set => base.DisplayRect = value;
        }

        new public Point PixelLocation
        {
            get => base.PixelLocation;
            set => base.PixelLocation = value;
        }

        new public Point HimetricLocation
        {
            get => base.HimetricLocation;
            set => base.HimetricLocation = value;
        }

        new public Point PixelLocationRaw
        {
            get => base.PixelLocationRaw;
            set => base.PixelLocationRaw = value;
        }

        new public Point HimetricLocationRaw
        {
            get => base.HimetricLocationRaw;
            set => base.HimetricLocationRaw = value;
        }



        new public Rectangle TouchContact
        {
            get => base.TouchContact;
            set => base.TouchContact = value;
        }

        new public Rectangle TouchContactRaw
        {
            get => base.TouchContactRaw;
            set => base.TouchContactRaw = value;
        }

    }

   
}