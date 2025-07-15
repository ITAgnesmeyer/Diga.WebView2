// Decompiled with JetBrains decompiler
// Type: Diga.WebView2.Interop.COREWEBVIEW2_COLOR
// Assembly: Diga.WebView2.Interop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 1E8B0323-528E-4C9C-8FF8-A486637C87E1
// Assembly location: O:\webview2\V1096133\Diga.WebView2.Interop.dll

using System.Runtime.InteropServices;

namespace Diga.WebView2.Interop
{
    /// <summary>
    /// Represents a color value with alpha, red, green, and blue components for WebView2 interop.
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public struct COREWEBVIEW2_COLOR
    {
        /// <summary>
        /// The alpha (transparency) component of the color.
        /// </summary>
        public byte A;
        /// <summary>
        /// The red component of the color.
        /// </summary>
        public byte R;
        /// <summary>
        /// The green component of the color.
        /// </summary>
        public byte G;
        /// <summary>
        /// The blue component of the color.
        /// </summary>
        public byte B;
    }
}
