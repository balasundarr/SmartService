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
    public class CityRepositry : Repository, ICityRepositry
    {
        public CityRepositry(IUserInfo parauserInfo, HomeAppliancesContext paradbContext)
           : base(parauserInfo, paradbContext)
        {
        }

        public async Task<int> AddCityAsync(City paraentity)
        {
            Add(paraentity);

            return await CommitChangesAsync();
        }

        public async Task<int> UpdateCityAsync(City parachanges)
        {
            Update(parachanges);

            return await CommitChangesAsync();
        }

        public async Task<int> DeleteCityeAsync(City paraentity)
        {
            Remove(paraentity);

            return await CommitChangesAsync();
        }

        public async Task<City> GetCityById(int paraCityId)
        { 
            City local_City= await DbContext
           .Set<City>()
           .FirstOrDefaultAsync(item => item.Id == paraCityId);
            return local_City;
        }
        public async  Task<State> GetCityStateById(int paraCityId)
        {
            City local_City = await DbContext.Set<City>().FirstOrDefaultAsync(item => item.Id == paraCityId);
            return (await DbContext.Set<State>().FirstOrDefaultAsync(item => item.Id == local_City.Id));
        }

    }
}
