using System.Collections.Generic;

namespace Smart.Wasl.Homes.Clients.Core.Services.Analytic
{
    public interface IAnalyticService
    {
        void TrackEvent(string name, Dictionary<string, string> properties = null);
    }
}