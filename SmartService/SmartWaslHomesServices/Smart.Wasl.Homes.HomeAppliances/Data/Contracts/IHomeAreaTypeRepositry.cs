using Microsoft.EntityFrameworkCore;
using Smart.Wasl.Homes.Services.HomeAppliances.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Smart.Wasl.Homes.Services.HomeAppliances.Data.Contracts
{
    public interface IHomeAreaTypeRepositry : IRepository
    {
        Task<Int32> AddHomeAreaTypeAsync(HomeAreaType paraentity);

        Task<Int32> UpdateHomeAreaTypeAsync(HomeAreaType parachanges);

        Task<Int32> DeleteHomeAreaTypeAsync(HomeAreaType paraentity);

        Task<HomeAreaType> GetHomeAreaTypeById(int paraHomeAreaTypeId);

        Task<RoomCoordinate> GetHomeAreaTypeRoomCoordinateById(int paraHomeAreaTypeId);

        Task<IEnumerable<Appliance>> GetAppliancesById(int paraHomeAreaTypeId);

        Task<IEnumerable<Entrance>> GetEntranceByyId(int paraHomeAreaTypeId);
    }
}
