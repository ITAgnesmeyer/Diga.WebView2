// Decompiled with JetBrains decompiler
// Type: Diga.WebView2.Interop.COREWEBVIEW2_PHYSICAL_KEY_STATUS
// Assembly: Diga.WebView2.Interop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: AAF9543A-0FE1-46E7-BB2C-D24EA0535C0F
// Assembly location: O:\webview2\v1077444\Diga.WebView2.Interop.dll

using System.Runtime.InteropServices;

namespace Diga.WebView2.Interop
{
  [StructLayout(LayoutKind.Sequential, Pack = 4)]
  public struct COREWEBVIEW2_PHYSICAL_KEY_STATUS
  {
    public uint RepeatCount;
    public uint ScanCode;
    public int IsExtendedKey;
    public int IsMenuKeyDown;
    public int WasKeyDown;
    public int IsKeyReleased;
  }
}
