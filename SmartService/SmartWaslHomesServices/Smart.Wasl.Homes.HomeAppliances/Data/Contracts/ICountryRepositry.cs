using Microsoft.EntityFrameworkCore;
using Smart.Wasl.Homes.Services.HomeAppliances.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Smart.Wasl.Homes.Services.HomeAppliances.Data.Contracts
{
    public interface ICountryRepositry : IRepository
    {
        Task<Int32> AddCountryAsync(Country paramEntity);

        Task<Int32> UpdateCountryAsync(Country paramChanges);

        Task<Int32> DeleteCountryAsync(Country paramEntity);

        Task<Country> GetCountryById(int paramCountryId);

        Task<IEnumerable<Country>> GetAll();

        Task<ICollection<State>> GetStatesById(int paramCountryId);








    }
}
