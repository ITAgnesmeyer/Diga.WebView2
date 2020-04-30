// Decompiled with JetBrains decompiler
// Type: Diga.WebView2.Interop.COREWEBVIEW2_PHYSICAL_KEY_STATUS
// Assembly: WebView2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: B5F140DB-135D-4E8A-B1A2-1275CE2FD56A
// Assembly location: O:\webview2\webview2packages\V9488\WebView2.dll

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
