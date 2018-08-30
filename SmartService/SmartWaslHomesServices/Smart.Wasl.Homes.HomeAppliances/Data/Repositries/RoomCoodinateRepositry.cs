using Smart.Wasl.Homes.Services.HomeAppliances.Domain;
using Smart.Wasl.Homes.Services.HomeAppliances.Data;
using Smart.Wasl.Homes.Services.HomeAppliances.Data.Contracts;
using Smart.Wasl.Homes.Services.HomeAppliances.Data.Repositries;
using Smart.Wasl.Homes.Services.HomeAppliances.Domain.Interfaces;
using Smart.Wasl.Homes.Services.HomeAppliances.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
namespace Smart.Wasl.Homes.Services.HomeAppliances.Data.Repositries
{
    public class RoomCoodinateRepositry :  Repository,  IRoomCoordinateRepositry
    {
        public RoomCoodinateRepositry(IUserInfo parauserInfo, HomeAppliancesContext paradbContext)
            : base(parauserInfo, paradbContext)
        {
        }

        public async Task<int> AddRoomCoordinateAsync(RoomCoordinate paraentity)
        {
            Add(paraentity);

            return await CommitChangesAsync();
        }
        public async Task<int> UpdateRoomCoordinateAsync(RoomCoordinate parachanges)
        {
            Update(parachanges);

            return await CommitChangesAsync();
        }


        public async Task<int> DeleteRoomCoordinateAsync(RoomCoordinate paraentity)
        {
            Remove(paraentity);

            return await CommitChangesAsync();
        }

        public async Task<RoomCoordinate> GetRoomCoordinateById(int paraRoomCoordinatId)
            => await DbContext
            .Set<RoomCoordinate>()
           .FirstOrDefaultAsync(item => item.Id == paraRoomCoordinatId);

        public async Task<IEnumerable<RoomCoordinate>> GetAll()
           => await DbContext
               .Set<RoomCoordinate>()
               .ToListAsync();

    }
}
