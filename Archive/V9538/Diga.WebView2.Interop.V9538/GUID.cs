// Decompiled with JetBrains decompiler
// Type: WebView2.GUID
// Assembly: WebView2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 680EA815-80DF-438D-AA0D-D4F0EB9B8A6C
// Assembly location: O:\webview2\V9538\WebView2.dll

using System.Runtime.InteropServices;

namespace Diga.WebView2.Interop
{
  [StructLayout(LayoutKind.Sequential, Pack = 4)]
  public struct GUID
  {
    public uint Data1;
    public ushort Data2;
    public ushort Data3;
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
    public byte[] Data4;
  }
}
