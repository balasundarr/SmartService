using Microsoft.EntityFrameworkCore;
using Smart.Wasl.Homes.Services.HomeAppliances.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Smart.Wasl.Homes.Services.HomeAppliances.Data.Contracts
{
    public interface IStateRepositry : IRepository
    {
        Task<Int32> AddStateAsync(State paramEntity);

        Task<Int32> UpdateStateAsync(State paramChanges);

        Task<Int32> DeleteStateAsync(State paramEntity);

        Task<State> GetStateById(int paraStateId);

        Task<Country> GetCountryById(int paraStateId);

        Task<IEnumerable<State>> GetAll();
    }
}
