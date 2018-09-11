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
        Task<Int32> AddHomeAsync(Home paramEntity);

        Task<Int32> UpdateHomeAsync(Home paramChanges);

        Task<Int32> DeleteHomeAsync(Home paramEntity);

        Task<Home> GetHomeById(int paramHomeId);

        Task<IEnumerable<Home>> GetAll();

        Task<IEnumerable<Address>> GetAddresssById(int paramHomeId);

        Task<IEnumerable<Contact>> GetContactsById(int paramHomeId);

        Task<IEnumerable<HomeAreaType>> GetHomeAreaTypesById(int paramHomeId);

        Task<Location> GetLocationById(int paramHomeId);

 
    }
}
