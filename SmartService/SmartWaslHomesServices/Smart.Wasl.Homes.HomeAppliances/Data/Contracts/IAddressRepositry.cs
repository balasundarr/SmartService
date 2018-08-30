using Microsoft.EntityFrameworkCore;
using Smart.Wasl.Homes.Services.HomeAppliances.Domain;
using Smart.Wasl.Homes.Services.HomeAppliances.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Smart.Wasl.Homes.Services.HomeAppliances.Data.Contracts
{
    public interface IAddressRepositry: IRepository
    {
        Task<Int32> AddAddressAsync(Address paraentity);

        Task<Int32> UpdateAddressAsync(Address parachanges);

        Task<Int32> DeleteAddressAsync(Address paraentity);

        Task<Address> GetAddressById(int paraAddressId);

        Task<IEnumerable<Address>> GetAll();

        Task<City> GetAddresByCityId(int paraAddressId);

        Task<Location> GetAddressLocationById(int paraAddressId);


    }
}
