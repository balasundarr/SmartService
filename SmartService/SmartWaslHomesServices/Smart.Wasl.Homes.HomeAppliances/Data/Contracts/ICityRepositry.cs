using Microsoft.EntityFrameworkCore;
using Smart.Wasl.Homes.Services.HomeAppliances.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Smart.Wasl.Homes.Services.HomeAppliances.Data.Contracts
{
    public interface ICityRepositry : IRepository
    {

        Task<Int32> AddCityAsync(City paraentity);

        Task<Int32> UpdateCityAsync(City parachanges);

        Task<City> GetCityById(int paraCityId);

        Task<Int32> DeleteCityeAsync(City paraentity);
               
        Task<State> GetCityStateById(int paraCityId);
                
    }
}
