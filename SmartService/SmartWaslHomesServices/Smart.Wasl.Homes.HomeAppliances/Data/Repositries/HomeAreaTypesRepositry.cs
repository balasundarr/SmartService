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

namespace Smart.Wasl.Homes.Services.HomeAppliances.Domain.Repositries
{
    public class HomeAreaTypeRepositry : Repository, IHomeAreaTypeRepositry
    {
        public HomeAreaTypeRepositry(IUserInfo parauserInfo, HomeAppliancesContext paradbContext)
          : base(parauserInfo, paradbContext)
        {
        }
        public async Task<Int32> AddHomeAreaTypeAsync(HomeAreaType paraentity)
        {
            Add(paraentity);

            return await CommitChangesAsync();
        }
        public async Task<Int32> UpdateHomeAreaTypeAsync(HomeAreaType parachanges)
        {
            Update(parachanges);

            return await CommitChangesAsync();
        }
        public async Task<Int32> DeleteHomeAreaTypeAsync(HomeAreaType paraentity)
        {
            Remove(paraentity);

            return await CommitChangesAsync();
        }

        public async Task<HomeAreaType> GetHomeAreaTypeById(int paraHomeAreaTypeId)
            => await DbContext
                .Set<HomeAreaType>()
                .FirstOrDefaultAsync(item => item.Id == paraHomeAreaTypeId);

        public async Task<IEnumerable<Appliance>> GetAppliancesById(int paraHomeAreaTypeId)
        {

            var homeareatype = await DbContext.Set<HomeAreaType>().FirstAsync(item => item.Id == paraHomeAreaTypeId);
            return (await DbContext.Set<Appliance>()
                 .Where(item => item.HomeAreaTypeId == paraHomeAreaTypeId)
                .ToListAsync());
        }

        public async Task<RoomCoordinate> GetHomeAreaTypeRoomCoordinateById(int paraHomeAreaTypeId)
        => await DbContext
                .Set<RoomCoordinate>()
                .FirstOrDefaultAsync(item => item.HomeAreaTypeId == paraHomeAreaTypeId);

        public async Task<IEnumerable<Entrance>> GetEntranceByyId(int paraHomeAreaTypeId)
        =>   await DbContext.Set<Entrance>()
                .Where(item => item.HomeAreaTypeId == paraHomeAreaTypeId)
                .ToListAsync();
    }
    
}
