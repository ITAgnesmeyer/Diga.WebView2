﻿using System;
using System.Diagnostics;
using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.Types;

namespace Diga.WebView2.Wrapper.Implementation
{
    public class WebView2Profile6Interface : WebView2Profile5Interface
    {
        private ComObjectHolder<ICoreWebView2Profile6> _Iface;
        private ICoreWebView2Profile6 Iface
        {
            get
            {
                if (_Iface == null)
                {
                    Debug.Print(nameof(WebView2Profile6Interface) + "=>" + nameof(Iface) + " is null");

                    throw new InvalidOperationException(nameof(WebView2Profile6Interface) + "=>" + nameof(Iface) + " is null");
                }
                return _Iface.Interface;
            }
            set => _Iface = new ComObjectHolder<ICoreWebView2Profile6>(value);
        }
        public WebView2Profile6Interface(ICoreWebView2Profile6 iface) : base(iface)
        {
            Iface = iface ?? throw new ArgumentNullException(nameof(iface));
        }

        private bool _IsDisposed;
        protected override void Dispose(bool disposing)
        {
            if (_IsDisposed) return;
            if (disposing)
            {
                _Iface = null;
                _IsDisposed = true;
            }
            base.Dispose(disposing);
        }

        public int IsPasswordAutosaveEnabled { get => this.Iface.IsPasswordAutosaveEnabled; set => this.Iface.IsPasswordAutosaveEnabled = value; }
        public int IsGeneralAutofillEnabled { get => this.Iface.IsGeneralAutofillEnabled; set => this.Iface.IsGeneralAutofillEnabled = value; }
    }
}