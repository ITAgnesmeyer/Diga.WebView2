// Decompiled with JetBrains decompiler
// Type: Diga.WebView2.Interop.COREWEBVIEW2_PHYSICAL_KEY_STATUS
// Assembly: Diga.WebView2.Interop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 1E8B0323-528E-4C9C-8FF8-A486637C87E1
// Assembly location: O:\webview2\V1096133\Diga.WebView2.Interop.dll

using System.Runtime.InteropServices;

namespace Diga.WebView2.Interop
{
    /// <summary>
    /// Represents the physical key status for a keyboard event in WebView2.
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public struct COREWEBVIEW2_PHYSICAL_KEY_STATUS
    {
        /// <summary>
        /// The repeat count for the key event.
        /// </summary>
        public uint RepeatCount;
        /// <summary>
        /// The scan code of the key.
        /// </summary>
        public uint ScanCode;
        /// <summary>
        /// Indicates whether the key is an extended key.
        /// </summary>
        public int IsExtendedKey;
        /// <summary>
        /// Indicates whether the menu key (ALT) is down.
        /// </summary>
        public int IsMenuKeyDown;
        /// <summary>
        /// Indicates whether the key was previously down.
        /// </summary>
        public int WasKeyDown;
        /// <summary>
        /// Indicates whether the key is released.
        /// </summary>
        public int IsKeyReleased;
    }
}
