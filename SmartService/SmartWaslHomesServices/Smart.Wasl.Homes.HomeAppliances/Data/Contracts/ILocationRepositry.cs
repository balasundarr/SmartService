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

        Task<Int32> AddLocationAsync(Location paramEntity);

        Task<Int32> UpdateLocationAsync(Location paramChanges);

        Task<Int32> DeleteLocationAsync(Location paramEntity);

        Task<Location> GetLocationById(int paramLocationId);

        Task<IEnumerable<Location>> GetAll();
    }
}
