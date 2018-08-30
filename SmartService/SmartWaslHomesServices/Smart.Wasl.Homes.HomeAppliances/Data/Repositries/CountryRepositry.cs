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

        public async Task<Int32> AddCountryAsync(Country paraentity)
        {
            Add(paraentity);

            return await CommitChangesAsync();
        }

        public async Task<Int32> UpdateCountryAsync(Country parachanges)
        {
            Update(parachanges);

            return await CommitChangesAsync();
        }

        public async Task<Int32> DeleteCountryAsync(Country paraentity)
        {
            Remove(paraentity);

            return await CommitChangesAsync();
        }

        public async Task<Country> GetCountryById(int paraCountryId)
        => await DbContext
               .Set<Country>()
               .FirstOrDefaultAsync(item => item.Id == paraCountryId);


        public async Task<IEnumerable<Country>> GetAll()
              => await DbContext
                 .Set<Country>()
                 .ToListAsync();

        public async Task<ICollection<State>> GetStatesById(int paraCountryId)
          => await DbContext
               .Set<State>()
               .Where(a => a.Countryid == paraCountryId).ToListAsync();



    }
}
