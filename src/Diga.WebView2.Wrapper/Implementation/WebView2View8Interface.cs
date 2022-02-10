using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Diga.WebView2.Interop;

namespace Diga.WebView2.Wrapper.Implementation
{
    public class WebView2View8Interface : WebView2View7Interface, ICoreWebView2_8
    {
        private ICoreWebView2_8 _WebView;
        private ICoreWebView2_8 WebView
        {
            get
            {
                if (this._WebView == null)
                {
                    Debug.Print(nameof(WebView2View8Interface) + "." + nameof(this.WebView) + " is null");
                    throw new InvalidOperationException(nameof(WebView2View8Interface) + "." + nameof(this.WebView) + " is null");

                }
                return this._WebView;
            }
            set
            {
                this._WebView = value;
            }


        }
        public WebView2View8Interface(ICoreWebView2_8 webView) : base(webView)
        {
            this._WebView = webView ?? throw new ArgumentNullException(nameof(webView));
        }

        public void add_IsMutedChanged([In, MarshalAs(UnmanagedType.Interface)] ICoreWebView2IsMutedChangedEventHandler eventHandler, out EventRegistrationToken token)
        {
            this.WebView.add_IsMutedChanged(eventHandler, out token);
        }

        public void remove_IsMutedChanged([In] EventRegistrationToken token)
        {
            this.WebView.remove_IsMutedChanged(token);
        }

        public int IsMuted { get => this.WebView.IsMuted; set => this.WebView.IsMuted = value; }

        public void add_IsDocumentPlayingAudioChanged([In, MarshalAs(UnmanagedType.Interface)] ICoreWebView2IsDocumentPlayingAudioChangedEventHandler eventHandler, out EventRegistrationToken token)
        {
            this.WebView.add_IsDocumentPlayingAudioChanged(eventHandler, out token);
        }

        public void remove_IsDocumentPlayingAudioChanged([In] EventRegistrationToken token)
        {
            this.WebView.remove_IsDocumentPlayingAudioChanged(token);
        }

        public int IsDocumentPlayingAudio => this.WebView.IsDocumentPlayingAudio;

        private bool _IsDisposed;
        protected override void Dispose(bool disposing)
        {
            if (this._IsDisposed) return;
            if (disposing)
            {
                this._WebView = null;
                this._IsDisposed = true;
            }
            base.Dispose(disposing);
        }
    }
}