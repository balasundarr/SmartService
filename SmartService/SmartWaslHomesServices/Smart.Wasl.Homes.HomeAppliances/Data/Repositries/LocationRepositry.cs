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

        public async Task<Int32> AddLocationAsync(Location paraentity)
        {
            Add(paraentity);

            return await CommitChangesAsync();
        }

        public async Task<Int32> UpdateLocationAsync(Location parachanges)
        {
            Update(parachanges);

            return await CommitChangesAsync();
        }

        public async Task<Int32> DeleteLocationAsync(Location paraentity)
        {
            Remove(paraentity);

            return await CommitChangesAsync();
        }
        public async Task<Location> GetLocationById(int paraLocatioId)
         => await DbContext
               .Set<Location>()
               .FirstOrDefaultAsync(item => item.Id == paraLocatioId);



    }
}
