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
        public async Task<Int32> AddHomeAreaTypeAsync(HomeAreaType paramEntity)
        {
            Add(paramEntity);

            return await CommitChangesAsync();
        }
        public async Task<Int32> UpdateHomeAreaTypeAsync(HomeAreaType paramChanges)
        {
            Update(paramChanges);

            return await CommitChangesAsync();
        }
        public async Task<Int32> DeleteHomeAreaTypeAsync(HomeAreaType paramEntity)
        {
            Remove(paramEntity);

            return await CommitChangesAsync();
        }

        public async Task<HomeAreaType> GetHomeAreaTypeById(int paramHomeAreaTypeId)
            => await DbContext
                .Set<HomeAreaType>()
                .FirstOrDefaultAsync(item => item.Id == paramHomeAreaTypeId);

        public async Task<IEnumerable<HomeAreaType>> GetAll()
          => await DbContext
              .Set<HomeAreaType>()
              .ToListAsync();

        public async Task<IEnumerable<Appliance>> GetAppliancesById(int paramHomeAreaTypeId)
        {

            var homeareatype = await DbContext.Set<HomeAreaType>().FirstAsync(item => item.Id == paramHomeAreaTypeId);
            return (await DbContext.Set<Appliance>()
                 .Where(item => item.HomeAreaTypeId == paramHomeAreaTypeId)
                .ToListAsync());
        }

        public async Task<RoomCoordinate> GetHomeAreaTypeRoomCoordinateById(int paramHomeAreaTypeId)
        => await DbContext
                .Set<RoomCoordinate>()
                .FirstOrDefaultAsync(item => item.HomeAreaTypeId == paramHomeAreaTypeId);

        public async Task<IEnumerable<Entrance>> GetEntranceByyId(int paramHomeAreaTypeId)
        =>   await DbContext.Set<Entrance>()
                .Where(item => item.HomeAreaTypeId == paramHomeAreaTypeId)
                .ToListAsync();
    }
    
}
