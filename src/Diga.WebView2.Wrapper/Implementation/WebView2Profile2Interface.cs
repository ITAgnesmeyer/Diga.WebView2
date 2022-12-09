using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.Types;

namespace Diga.WebView2.Wrapper.Implementation
{
    public class WebView2Profile2Interface : WebView2ProfileInterface
    {
        private ComObjectHolder< ICoreWebView2Profile2> _Profile;
        private ICoreWebView2Profile2 Profile
        {
            get
            {
                if (this._Profile == null)
                {
                    Debug.Print(nameof(WebView2Settings3Interface) + "." + nameof(this.Profile) + " is null");
                    throw new InvalidOperationException(nameof(WebView2Settings3Interface) + "." + nameof(this.Profile) + " is null");

                }
                return this._Profile.Interface;
            }
            set
            {
                this._Profile = new ComObjectHolder<ICoreWebView2Profile2>(value);
            }
        }

        public ICoreWebView2Profile2 GetInterface()
        {
            return this.Profile;
        }
        public WebView2Profile2Interface(ICoreWebView2Profile2 profile):base(profile)
        {
            this.Profile = profile ?? throw new ArgumentNullException(nameof(profile));
        }

        public void ClearBrowsingData([In] COREWEBVIEW2_BROWSING_DATA_KINDS dataKinds, [In, MarshalAs(UnmanagedType.Interface)] ICoreWebView2ClearBrowsingDataCompletedHandler handler)
        {
            this.Profile.ClearBrowsingData(dataKinds, handler);
        }

        public void ClearBrowsingDataInTimeRange([In] COREWEBVIEW2_BROWSING_DATA_KINDS dataKinds, [In] double startTime, [In] double endTime, [In, MarshalAs(UnmanagedType.Interface)] ICoreWebView2ClearBrowsingDataCompletedHandler handler)
        {
            this.Profile.ClearBrowsingDataInTimeRange(dataKinds, startTime, endTime, handler);
        }

        public void ClearBrowsingDataAll([In, MarshalAs(UnmanagedType.Interface)] ICoreWebView2ClearBrowsingDataCompletedHandler handler)
        {
            this.Profile.ClearBrowsingDataAll(handler);
        }
    }
}