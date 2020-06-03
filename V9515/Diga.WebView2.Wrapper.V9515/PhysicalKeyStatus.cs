using Diga.WebView2.Interop;

// ReSharper disable once CheckNamespace
namespace Diga.WebView2.Wrapper
{
    public class PhysicalKeyStatus
    {
        private readonly COREWEBVIEW2_PHYSICAL_KEY_STATUS _Status;
        public PhysicalKeyStatus(COREWEBVIEW2_PHYSICAL_KEY_STATUS status)
        {
            this._Status = status;
        }


        public uint RepeatCount => this._Status.RepeatCount;
        public uint ScanCode => this._Status.ScanCode;
        public int IsExtendedKey => this._Status.IsExtendedKey;
        public int IsMenuKeyDown => this._Status.IsMenuKeyDown;
        public int WasKeyDown => this._Status.WasKeyDown;
        public int IsKeyReleased => this._Status.IsKeyReleased;
    }
}