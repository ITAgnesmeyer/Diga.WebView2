// Decompiled with JetBrains decompiler
// Type: WebView2.WEBVIEW2_PHYSICAL_KEY_STATUS
// Assembly: WebView2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5F0D75F7-60BF-43BB-8231-ACD9063B7411
// Assembly location: O:\macos\WebView2.dll

using System.Runtime.InteropServices;

namespace Diga.WebView2.Interop
{
  [StructLayout(LayoutKind.Sequential, Pack = 4)]
  public struct WEBVIEW2_PHYSICAL_KEY_STATUS
  {
    public uint RepeatCount;
    public uint ScanCode;
    public int IsExtendedKey;
    public int IsMenuKeyDown;
    public int WasKeyDown;
    public int IsKeyReleased;
  }
}
