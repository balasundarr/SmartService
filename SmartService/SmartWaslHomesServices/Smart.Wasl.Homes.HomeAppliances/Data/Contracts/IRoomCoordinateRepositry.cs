using Microsoft.EntityFrameworkCore;
using Smart.Wasl.Homes.Services.HomeAppliances.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Smart.Wasl.Homes.Services.HomeAppliances.Data.Contracts
{
    public interface IRoomCoordinateRepositry : IRepository
    {
        Task<Int32> AddRoomCoordinateAsync(RoomCoordinate paraentity);

        Task<Int32> UpdateRoomCoordinateAsync(RoomCoordinate parachanges);

        Task<Int32> DeleteRoomCoordinateAsync(RoomCoordinate paraentity);

        Task<RoomCoordinate> GetRoomCoordinateById(int paraRoomCoordinatId);

        Task<IEnumerable<RoomCoordinate>> GetAll();
    }
}
