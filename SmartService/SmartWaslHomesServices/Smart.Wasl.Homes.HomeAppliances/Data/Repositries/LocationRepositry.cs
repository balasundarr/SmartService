using Smart.Wasl.Homes.Services.HomeAppliances.Domain;
using Smart.Wasl.Homes.Services.HomeAppliances.Data;
using Smart.Wasl.Homes.Services.HomeAppliances.Data.Contracts;
using Smart.Wasl.Homes.Services.HomeAppliances.Data.Repositries;
using Smart.Wasl.Homes.Services.HomeAppliances.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Smart.Wasl.Homes.Services.HomeAppliances.Data.Repositries
{

    public class LocationRepositry : Repository, ILocationRepositry
    {
        public LocationRepositry(IUserInfo parauserInfo, HomeAppliancesContext paradbContext)
            : base(parauserInfo, paradbContext)
        {
        }

        public async Task<Int32> AddLocationAsync(Location paramEntity)
        {
            Add(paramEntity);

            return await CommitChangesAsync();
        }

        public async Task<Int32> UpdateLocationAsync(Location paramChanges)
        {
            Update(paramChanges);

            return await CommitChangesAsync();
        }

        public async Task<Int32> DeleteLocationAsync(Location paramEntity)
        {
            Remove(paramEntity);

            return await CommitChangesAsync();
        }
        public async Task<Location> GetLocationById(int paramLocatioId)
         => await DbContext
               .Set<Location>()
               .FirstOrDefaultAsync(item => item.Id == paramLocatioId);

        public async Task<IEnumerable<Location>> GetAll()
           => await DbContext
              .Set<Location>()
              .ToListAsync();


    }
}
