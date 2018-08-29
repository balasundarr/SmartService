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
    public class HomeRepositry : Repository, IHomeRepositry
    {
        public HomeRepositry(IUserInfo parauserInfo, HomeAppliancesContext paradbContext)
          : base(parauserInfo, paradbContext)
        {
        }

        public async Task<int> AddHomeAsync(Home paraentity)
        {
            Add(paraentity);

            return await CommitChangesAsync();
        }

        public async Task<int> UpdateHomeAsync(Home parachanges)
        {
            Update(parachanges);

            return await CommitChangesAsync();
        }

        public async Task<int> DeleteHomeAsync(Home paraentity)
        {
            Remove(paraentity);

            return await CommitChangesAsync();
        }
        public async Task<Home> GetHomeById(int paraHomeId)
            => await DbContext
                .Set<Home>()
                .FirstOrDefaultAsync(item => item.Id == paraHomeId);

        public async Task<IEnumerable<Address>> GetAddresssById(int paraHomeId)
          => await DbContext.Set<Address>().Include(a => a.Contact)
                  .Where(item => item.Contact.HomeId == paraHomeId && item.Contact.ContactTypeId == 3)
                  .ToListAsync();

        public async Task<IEnumerable<Contact>>  GetContactsById(int paraHomeId)
         => await DbContext.Set<Contact>().Include(a => a.Home)
                  .Where(item => item.Home.Id == paraHomeId).ToListAsync();

        public async Task<IEnumerable<HomeAreaType>> GetHomeAreaTypesById(int paraHomeId)
         => await DbContext.Set<HomeAreaType>().Include(a => a.Home).
                  Where(item => item.Home.Id == paraHomeId).ToListAsync();

        public async Task<Location> GetLocationById(int paraHomeId)
        {
            var local_Home = await DbContext.Set<Home>().FirstAsync(item => item.Id == paraHomeId);
            return (await DbContext.Set<Location>().FirstAsync(item => item.Id == local_Home.LocationId));

        }
    }
}
