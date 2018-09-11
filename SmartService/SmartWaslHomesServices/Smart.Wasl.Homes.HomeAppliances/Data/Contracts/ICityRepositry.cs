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

        Task<Int32> AddCityAsync(City paramEntity);

        Task<Int32> UpdateCityAsync(City paramChanges);

        Task<City> GetCityById(int paramCityId);

        Task<IEnumerable<City>> GetAll();

        Task<Int32> DeleteCityeAsync(City paramEntity);
               
        Task<State> GetCityStateById(int paramCityId);
                
    }
}
