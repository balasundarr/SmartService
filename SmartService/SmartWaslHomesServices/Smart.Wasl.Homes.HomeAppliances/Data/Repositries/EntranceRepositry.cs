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
    public class EntranceRepositry : Repository, IEntranceRepositry
    {
        public EntranceRepositry(IUserInfo parauserInfo, HomeAppliancesContext paradbContext)
         : base(parauserInfo, paradbContext)
        {
        }

        public async Task<Int32> AddEntranceAsync(Entrance paramEntity)
        {
            Add(paramEntity);

            return await CommitChangesAsync();
        }

        public async Task<Int32> UpdateEntranceAsync(Entrance paramChanges)
        {
            Update(paramChanges);

            return await CommitChangesAsync();
        }

        public async Task<Int32> DeleteEntranceAsync(Entrance paramEntity)
        {
            Remove(paramEntity);

            return await CommitChangesAsync();
        }

        public async Task<Entrance> GetEntranceById(int paramEntranceId)
            => await DbContext
               .Set<Entrance>()
               .FirstOrDefaultAsync(item => item.Id == paramEntranceId);

        public async Task<IEnumerable<Entrance>> GetAll()
          => await DbContext
             .Set<Entrance>()
             .ToListAsync();
    }
}
