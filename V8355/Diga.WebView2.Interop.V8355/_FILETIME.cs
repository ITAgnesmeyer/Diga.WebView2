﻿// Decompiled with JetBrains decompiler
// Type: WebView2._FILETIME
// Assembly: WebView2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5F0D75F7-60BF-43BB-8231-ACD9063B7411
// Assembly location: O:\macos\WebView2.dll

using System.Runtime.InteropServices;

namespace Diga.WebView2.Interop
{
  [StructLayout(LayoutKind.Sequential, Pack = 4)]
  public struct _FILETIME
  {
    public uint dwLowDateTime;
    public uint dwHighDateTime;
  }
}
