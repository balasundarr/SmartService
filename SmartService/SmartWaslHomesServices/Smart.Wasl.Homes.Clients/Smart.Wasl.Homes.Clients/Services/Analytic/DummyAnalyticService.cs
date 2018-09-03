using System.Collections.Generic;

namespace Smart.Wasl.Homes.Clients.Core.Services.Analytic
{
    public class DummyAnalyticService : IAnalyticService
    {
        public void TrackEvent(string name, Dictionary<string, string> properties = null)
        {
            // Do nothing
        }
    }
}
