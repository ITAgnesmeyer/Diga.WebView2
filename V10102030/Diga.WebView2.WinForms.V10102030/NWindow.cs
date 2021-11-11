using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Diga.WebView2.WinForms
{
    public class NWindow : NativeWindow
    {
        private HandleRef _Parent;

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        private struct NativeRect
        {
            public int left;
            public int top;
            public int right;
            public int bottom;
        }

        [DllImport("user32.dll", EntryPoint = "MoveWindow")]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool MoveWindow([In()] IntPtr hWnd, int X, int Y, int nWidth, int nHeight, [MarshalAs(UnmanagedType.Bool)] bool bRepaint);


        //[DllImport("user32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
        //private static extern IntPtr CreateWindowExW(uint dwExStyle, [MarshalAs(UnmanagedType.LPWStr)] string lpClassName,
        //  [MarshalAs(UnmanagedType.LPWStr)] string lpWindowName, uint dwStyle, int x, int y, int nWidth, int nHeight,
        //  IntPtr hWndParent, IntPtr hMenu, IntPtr hInstance, IntPtr lpParam);
        /// Return Type: BOOL->int
        ///hWnd: HWND->HWND__*
        ///lpRect: LPRECT->tagRECT*
        //[DllImport("user32.dll", EntryPoint = "GetWindowRect")]
        //[return: MarshalAs(UnmanagedType.Bool)]
        //private static extern bool GetWindowRect([In()] IntPtr hWnd, [Out()] out tagRECT lpRect);

        [DllImport("user32.dll", EntryPoint = "GetClientRect")]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool GetClientRect([In()] IntPtr hWnd, [Out()] out NativeRect lpRect);

        //[DllImport("user32.dll", EntryPoint = "DestroyWindow")]
        //[return: MarshalAs(UnmanagedType.Bool)]
        //private static extern bool DestroyWindow([In()] IntPtr hWnd);

        public event EventHandler Resize;
        public event EventHandler Destroy;
        public event EventHandler Create;

        public new HandleRef Handle => new HandleRef(this, base.Handle);
        public HandleRef ParentHandle => this._Parent;

        public NWindow(Control parent)
        {
            parent.HandleCreated += OnParentHandleCreate;
            parent.HandleDestroyed += OnParentHandleDestroyed;

            this._Parent = new HandleRef(this, parent.Handle);
           
        }

        public void CreateControl()
        {
             GetClientRect(this._Parent.Handle, out NativeRect rect);
            CreateParams cp = new CreateParams();
            cp.Style = 0x10000000 | 0x40000000;
            cp.ExStyle = 0x20;
            cp.ClassName = "Static";
            cp.Parent = this._Parent.Handle;
            cp.X = 0;
            cp.Y = 0;
            cp.Width = rect.right - rect.left;
            cp.Height = rect.bottom - rect.top;

            this.CreateHandle(cp);
        }
        public override void CreateHandle(CreateParams cp)
        {
            base.CreateHandle(cp);
            if(base.Handle != IntPtr.Zero)
            {
                OnCreate();
            }
        }

        private void OnParentHandleDestroyed(object sender, EventArgs e)
        {
            OnDestroy();
            ReleaseHandle();
        }

        private void OnParentHandleCreate(object sender, EventArgs e)
        {
            //if(sender == null) return;
            //AssignHandle(((Control)sender).Handle);
        }

        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case 0x0005:
                    OnSize();
                    
                    break;
            }
            base.WndProc(ref m);
        }

        private void OnSize()
        {
            OnResize();
        }
        protected virtual void OnResize()
        {
            Resize?.Invoke(this, EventArgs.Empty);
        }

       
        protected virtual void OnDestroy()
        {
            Destroy?.Invoke(this, EventArgs.Empty);
        }
        protected virtual void OnCreate()
        {
            Create?.Invoke(this, EventArgs.Empty);
        }
        public void DockToParent()
        {
            GetClientRect(this._Parent.Handle, out NativeRect rect);
            MoveWindow(this.Handle.Handle, 0, 0, rect.right - rect.left, rect.bottom - rect.top, true);

        }
    }
}