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
    public class StatesRepositry : Repository, IStateRepositry
    {
        public StatesRepositry(IUserInfo parauserInfo, HomeAppliancesContext paradbContext)
            : base(parauserInfo, paradbContext)
        {
        }
        public async Task<Int32> AddStateAsync(State paraentity)
        {
            Add(paraentity);

            return await CommitChangesAsync();
        }
        public async Task<Int32> UpdateStateAsync(State parachanges)
        {
            Update(parachanges);

            return await CommitChangesAsync();
        }
        public async Task<Int32> DeleteStateAsync(State paraentity)
        {
            Remove(paraentity);

            return await CommitChangesAsync();
        }
        public async Task<State> GetStateById(int paraStateId)
         => await DbContext
                .Set<State>()
                .FirstOrDefaultAsync(item => item.Id == paraStateId);
               
        public async Task<Country> GetCountryById(int paraStateId)
        {
            State local_State = await DbContext.Set<State>().FirstOrDefaultAsync(item => item.Id == paraStateId);
            return (await DbContext.Set<Country>().FirstOrDefaultAsync(item => item.Id == local_State.Id));

        }
    }
}
