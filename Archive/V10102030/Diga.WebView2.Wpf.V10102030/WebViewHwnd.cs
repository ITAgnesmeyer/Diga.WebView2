using System;
using System.Runtime.InteropServices;
using System.Windows.Interop;
using Diga.WebView2.Interop;

namespace Diga.WebView2.Wpf
{
    internal class WebViewHwnd : HwndHost
    {

        [DllImport("user32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
        private static extern IntPtr CreateWindowExW(uint dwExStyle, [MarshalAs(UnmanagedType.LPWStr)] string lpClassName, 
            [MarshalAs(UnmanagedType.LPWStr)] string lpWindowName, uint dwStyle, int x, int y, int nWidth, int nHeight, 
            IntPtr hWndParent, IntPtr hMenu, IntPtr hInstance, IntPtr lpParam);
        /// Return Type: BOOL->int
        ///hWnd: HWND->HWND__*
        ///lpRect: LPRECT->tagRECT*
        [DllImport("user32.dll", EntryPoint="GetWindowRect")]
        [return: MarshalAs(System.Runtime.InteropServices.UnmanagedType.Bool)]
        private static extern  bool GetWindowRect([In()] System.IntPtr hWnd, [Out()] out tagRECT lpRect) ;
     
        [DllImport("user32.dll", EntryPoint="GetClientRect")]
        [return: MarshalAs(System.Runtime.InteropServices.UnmanagedType.Bool)]
        private static extern  bool GetClientRect([In()] System.IntPtr hWnd, [Out()] out tagRECT lpRect) ;
      
        [DllImport("user32.dll", EntryPoint="DestroyWindow")]
        [return: MarshalAs(System.Runtime.InteropServices.UnmanagedType.Bool)]
        private static extern  bool DestroyWindow([In()] System.IntPtr hWnd) ;

        public event EventHandler Resize;
        public event EventHandler Destroy; 
        private HandleRef _Hanlde;

        public new HandleRef Handle => this._Hanlde;

        protected override HandleRef BuildWindowCore(HandleRef hwndParent)
        {
            GetClientRect(hwndParent.Handle, out tagRECT rect);

            IntPtr ptr = CreateWindowExW(0x20, "static", null, 0x10000000 | 0x40000000, 0, 0, rect.right - rect.left, rect.bottom - rect.top, hwndParent.Handle,
                IntPtr.Zero, Marshal.GetHINSTANCE(typeof(WebViewHwnd).Module), IntPtr.Zero);
            this._Hanlde = new HandleRef(this, ptr);
           
            return this._Hanlde;
        }

        protected override IntPtr WndProc(IntPtr hwnd, int msg, IntPtr wParam, IntPtr lParam, ref bool handled)
        {
            switch (msg)
            {
                case 0x0005:
                    OnSize();
                    break;
            }
            return base.WndProc(hwnd, msg, wParam, lParam, ref handled);

        }

        private void OnSize()
        {
            OnResize();
        }
        protected override void DestroyWindowCore(HandleRef hwnd)
        {
            OnDestroy();
            DestroyWindow(hwnd.Handle);
        }

        protected virtual void OnResize()
        {
            Resize?.Invoke(this, EventArgs.Empty);
        }

        protected virtual void OnDestroy()
        {
            Destroy?.Invoke(this, EventArgs.Empty);
        }
    }
}