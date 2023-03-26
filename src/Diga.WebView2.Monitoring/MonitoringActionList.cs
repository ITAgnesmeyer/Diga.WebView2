using System.Collections.Generic;
using Diga.WebView2.Monitoring.CGI;
using Diga.WebView2.Wrapper;

namespace Diga.WebView2.Monitoring
{
    public class MonitoringActionList
    {
        private readonly List<IMonitoringAction> _List;
        public MonitoringActionList()
        {
            this.FileMonitoring = new FileMonitoring();
            this.CgiMointoring = new CgiMoitoring();
            
            this._List = new List<IMonitoringAction>
            {
                this.FileMonitoring,
                new ResourceMonitoring(true),
                this.CgiMointoring
            };
        }
        public FileMonitoring FileMonitoring { get; private set; }
        public CgiMoitoring CgiMointoring { get; private set; }
        public IMonitoringAction GetFirstActiveWithUrl(string url)
        {
            foreach (IMonitoringAction monitoringAction in this._List)
            {
                if (monitoringAction.IsEnabled && url.StartsWith(monitoringAction.MonitoringUrl))
                {
                    return monitoringAction;
                }
            }
            return null;
        }
        public bool IsAnyActiveWithUrl(string url)
        {
            foreach (IMonitoringAction monitoringAction in this._List)
            {
                if (monitoringAction.IsEnabled)
                {
                    if(url.StartsWith(monitoringAction.MonitoringUrl))
                        return true;
                }
            }
            return false;
        }
        public bool IsAnyActive()
        {
            foreach (IMonitoringAction monitoringAction in this._List)
            {
                if(monitoringAction.IsEnabled)
                    return true;
            }
            return false;
        }
        public bool ContainsUrl(string url)
        {
            foreach (IMonitoringAction monitoringAction in this._List)
            {
                if(url.StartsWith( monitoringAction.MonitoringUrl ))
                    return true;
            }
            return false;
        }
        public bool Contains(IMonitoringAction action)
        {
            foreach (IMonitoringAction monitoringAction in this._List)
            {
                if (monitoringAction.MonitoringUrl == action.MonitoringUrl)
                {
                    return true;
                }
            }
            return false;
        }
        public bool Add(IMonitoringAction action)
        {
            if (Contains(action))
                return false;
            this._List.Add(action);
            return true;
        }
    }
}