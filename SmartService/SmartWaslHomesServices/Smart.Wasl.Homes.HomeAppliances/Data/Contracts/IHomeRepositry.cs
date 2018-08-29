using Microsoft.EntityFrameworkCore;
using Smart.Wasl.Homes.Services.HomeAppliances.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace Smart.Wasl.Homes.Services.HomeAppliances.Data.Contracts
{
    public interface IHomeRepositry : IRepository
    {
        Task<Int32> AddHomeAsync(Home paraentity);

        Task<Int32> UpdateHomeAsync(Home parachanges);

        Task<Int32> DeleteHomeAsync(Home paraentity);

        Task<Home> GetHomeById(int paraHomeId);

        Task<IEnumerable<Address>> GetAddresssById(int paraHomeId);

        Task<IEnumerable<Contact>> GetContactsById(int paraHomeId);

        Task<IEnumerable<HomeAreaType>> GetHomeAreaTypesById(int paraHomeId);

        Task<Location> GetLocationById(int paraHomeId);
    }
}
