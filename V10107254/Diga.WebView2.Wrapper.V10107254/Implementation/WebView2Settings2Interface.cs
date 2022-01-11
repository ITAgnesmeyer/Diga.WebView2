﻿using Diga.WebView2.Interop;
using System;
using System.Diagnostics;

// ReSharper disable once CheckNamespace
namespace Diga.WebView2.Wrapper.Implementation
{
    public class WebView2Settings2Interface : WebView2SettingsInterface, ICoreWebView2Settings2
    {
        private ICoreWebView2Settings2 _Settings;

        private ICoreWebView2Settings2 Settings
        {
            get
            {
                if (_Settings == null)
                {
                    Debug.Print(nameof(WebView2Settings2Interface) + "." + nameof(Settings) + " is null");
                    throw new InvalidOperationException(nameof(WebView2Settings2Interface) + "." + nameof(Settings) + " is null");

                }
                return _Settings;
            }
            set
            {
                _Settings = value;
            }
        }

        public WebView2Settings2Interface(ICoreWebView2Settings2 settings) : base(settings)
        {
            if (settings == null)
                throw new ArgumentNullException(nameof(settings));
            _Settings = settings;
        }

        public string UserAgent { get => Settings.UserAgent; set => Settings.UserAgent = value; }
        private bool _IsDisposed;
        protected override void Dispose(bool disposing)
        {
            if (_IsDisposed) return;
            if (disposing)
            {
                _Settings = null;
                _IsDisposed = true;
            }


            base.Dispose(disposing);
        }
    }
}