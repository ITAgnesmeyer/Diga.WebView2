using Diga.WebView2.Interop;

namespace Diga.WebView2.Wrapper
{
    public class PhysicalKeyStatus
    {
        private CORE_WEBVIEW2_PHYSICAL_KEY_STATUS _status;

        public PhysicalKeyStatus(CORE_WEBVIEW2_PHYSICAL_KEY_STATUS status)
        {
            this._status = status;
        }
        public uint RepeatCount => this._status.RepeatCount;
        public uint ScanCode => this._status.ScanCode;
        public int IsExtendedKey => this._status.IsExtendedKey;
        public int IsMenuKeyDown => this._status.IsMenuKeyDown;
        public int WasKeyDown=> this._status.WasKeyDown;
        public int IsKeyReleased => this._status.IsKeyReleased;
    }
}