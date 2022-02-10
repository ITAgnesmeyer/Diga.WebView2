namespace Diga.WebView2.Wrapper.EventArguments
{
    public class FrameDestroyedEventArgs : FrameNameChangedEventArgs
    {
        public FrameDestroyedEventArgs(Frame frame, object args):base(frame,args)
        {
            
        }
    }
}