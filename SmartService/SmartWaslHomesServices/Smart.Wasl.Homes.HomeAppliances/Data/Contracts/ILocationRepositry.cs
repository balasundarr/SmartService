using Microsoft.EntityFrameworkCore;
using Smart.Wasl.Homes.Services.HomeAppliances.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Smart.Wasl.Homes.Services.HomeAppliances.Data.Contracts
{
    public interface ILocationRepositry : IRepository
    {

        Task<Int32> AddLocationAsync(Location paraentity);

        Task<Int32> UpdateLocationAsync(Location parachanges);

        Task<Int32> DeleteLocationAsync(Location paraentity);

        Task<Location> GetLocationById(int paraLocationId);

        Task<IEnumerable<Location>> GetAll();
    }
}
