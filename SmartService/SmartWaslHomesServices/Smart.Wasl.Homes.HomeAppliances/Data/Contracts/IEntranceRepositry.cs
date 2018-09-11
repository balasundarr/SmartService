using Microsoft.EntityFrameworkCore;
using Smart.Wasl.Homes.Services.HomeAppliances.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Smart.Wasl.Homes.Services.HomeAppliances.Data.Contracts
{
    public interface IEntranceRepositry : IRepository
    {
        Task<Int32> AddEntranceAsync(Entrance paramEntity);

        Task<Int32> UpdateEntranceAsync(Entrance paramChanges);

        Task<Int32> DeleteEntranceAsync(Entrance paramEntity);

        Task<Entrance> GetEntranceById(int paramEntranceId);

        Task<IEnumerable<Entrance>> GetAll();
    }
}
