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
        Task<Int32> AddStateAsync(State paraentity);

        Task<Int32> UpdateStateAsync(State parachanges);

        Task<Int32> DeleteStateAsync(State paraentity);

        Task<State> GetStateById(int paraStateId);

        Task<Country> GetCountryById(int paraStateId);

        Task<IEnumerable<State>> GetAll();
    }
}
