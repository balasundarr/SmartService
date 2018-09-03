using System.Threading.Tasks;

namespace Smart.Wasl.Homes.Clients.Core.Services.Chart
{
    public interface IChartService
    {
        Task<Microcharts.Chart> GetTemperatureChartAsync();
        Task<Microcharts.Chart> GetGreenChartAsync();
    }
}