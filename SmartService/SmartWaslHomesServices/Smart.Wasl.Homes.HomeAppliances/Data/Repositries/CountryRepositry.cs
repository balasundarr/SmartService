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
    public class CountryRepositry : Repository,ICountryRepositry
    {
        public CountryRepositry(IUserInfo parauserInfo, HomeAppliancesContext paradbContext)
         : base(parauserInfo, paradbContext)
        {
        }

        public async Task<Int32> AddCountryAsync(Country paramEntity)
        {
            Add(paramEntity);

            return await CommitChangesAsync();
        }

        public async Task<Int32> UpdateCountryAsync(Country paramChanges)
        {
            Update(paramChanges);

            return await CommitChangesAsync();
        }

        public async Task<Int32> DeleteCountryAsync(Country paramEntity)
        {
            Remove(paramEntity);

            return await CommitChangesAsync();
        }

        public async Task<Country> GetCountryById(int paramCountryId)
        => await DbContext
               .Set<Country>()
               .FirstOrDefaultAsync(item => item.Id == paramCountryId);


        public async Task<IEnumerable<Country>> GetAll()
              => await DbContext
                 .Set<Country>()
                 .ToListAsync();

        public async Task<ICollection<State>> GetStatesById(int paramCountryId)
          => await DbContext
               .Set<State>()
               .Where(a => a.Countryid == paramCountryId).ToListAsync();



    }
}
