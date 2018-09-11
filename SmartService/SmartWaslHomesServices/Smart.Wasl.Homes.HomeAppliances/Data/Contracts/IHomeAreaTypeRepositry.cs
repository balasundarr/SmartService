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
        Task<Int32> AddHomeAreaTypeAsync(HomeAreaType paramEntity);

        Task<Int32> UpdateHomeAreaTypeAsync(HomeAreaType paramChanges);

        Task<Int32> DeleteHomeAreaTypeAsync(HomeAreaType paramEntity);

        Task<HomeAreaType> GetHomeAreaTypeById(int paramHomeAreaTypeId);

        Task<IEnumerable<HomeAreaType>> GetAll();
               

        Task<RoomCoordinate> GetHomeAreaTypeRoomCoordinateById(int paramHomeAreaTypeId);

        Task<IEnumerable<Appliance>> GetAppliancesById(int paramHomeAreaTypeId);

        Task<IEnumerable<Entrance>> GetEntranceByyId(int paramHomeAreaTypeId);

       
      
    }
}
