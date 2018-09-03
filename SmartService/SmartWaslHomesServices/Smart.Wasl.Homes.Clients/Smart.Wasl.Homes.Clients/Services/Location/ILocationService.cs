using Smart.Wasl.Homes.Clients.Core.Models;
using System.Threading.Tasks;

namespace Smart.Wasl.Homes.Clients.Core.Services.Location
{
    public interface ILocationService
    {
        Task<GeoLocation> GetPositionAsync();
    }
}