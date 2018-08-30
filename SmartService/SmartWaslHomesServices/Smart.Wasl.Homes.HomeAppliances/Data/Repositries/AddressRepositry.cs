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

namespace Smart.Wasl.Homes.Services.HomeAppliances.Domain.Repositries
{
    public class AddressRepositry : Repository , IAddressRepositry
    {
        public AddressRepositry(IUserInfo parauserInfo, HomeAppliancesContext paradbContext)
            : base(parauserInfo, paradbContext)
        {
        }

        public async Task<int> AddAddressAsync(Address paraentity)
        {
            Add(paraentity);

            return await CommitChangesAsync();
        }

        public async Task<int> UpdateAddressAsync(Address parachanges)
        {
            Update(parachanges);

            return await CommitChangesAsync();
        }

        public async Task<int> DeleteAddressAsync(Address paraentity)
        {
            Remove(paraentity);

            return await CommitChangesAsync();
        }

        public async Task<Address> GetAddressById(int paraAddressId)
                 => await DbContext
                 .Set<Address>()
                .FirstOrDefaultAsync(item => item.Id == paraAddressId);


        public async Task<IEnumerable<Address>> GetAll()
              => await DbContext
                  .Set<Address>()
                  .ToListAsync();

        public async Task<City> GetAddresByCityId(int paraAddressId)
             => await DbContext.Set<City>().Include(a => a.Addresses)
                  .FirstOrDefaultAsync(item => item.Id == paraAddressId);

        public async Task<Location> GetAddressLocationById(int paraAddressId)
        {

            Address local_Address = await DbContext.Set<Address>().FirstAsync(x => x.Id == paraAddressId);
            return (await DbContext.Set<Location>().FirstAsync(item => item.Id == local_Address.LocationId));

        }
    }
}
