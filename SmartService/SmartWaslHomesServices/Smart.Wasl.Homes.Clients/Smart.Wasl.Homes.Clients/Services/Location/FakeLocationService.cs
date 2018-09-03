using System.Threading.Tasks;
using Smart.Wasl.Homes.Clients.Core.Models;

namespace Smart.Wasl.Homes.Clients.Core.Services.Location
{
    public class FakeLocationService : ILocationService
    {
        public async Task<GeoLocation> GetPositionAsync()
        {
            await Task.Delay(500);

            return GeoLocation.Parse(AppSettings.DefaultFallbackMapsLocation);
        }
    }
}