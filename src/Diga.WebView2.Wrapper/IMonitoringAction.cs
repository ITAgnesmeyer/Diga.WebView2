namespace Diga.WebView2.Wrapper
{
    public interface IMonitoringAction
    {
        string MonitoringUrl { get;  }
        string MonitoringFolder { get; }
        bool IsEnabled { get; }

        string[] FielExtensions { get; }

        bool CanExcecute(string url);

        bool Run(RequestInfo requestInfo, out ResponseInfo responseInfo);
    }
}