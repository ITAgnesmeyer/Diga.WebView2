// Decompiled with JetBrains decompiler
// Type: WebView2.COREWEBVIEW2_PHYSICAL_KEY_STATUS
// Assembly: WebView2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 4848E93B-2D8E-488A-B413-2977821823D1
// Assembly location: O:\webview2\V9515\WebView2.dll

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
