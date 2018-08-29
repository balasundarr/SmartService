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

namespace Smart.Wasl.Homes.Services.HomeAppliances.Data.Repositries
{
    public class ApplianceActionRepositry : Repository, IApplianceActionRepositry
    {
        public ApplianceActionRepositry(IUserInfo parauserInfo, HomeAppliancesContext paradbContext)
            : base(parauserInfo, paradbContext)
        {
        }

        public async Task<int> AddApplianceActioneAsync(ApplianceAction paraentity)
        {
            Add(paraentity);

            return await CommitChangesAsync();
        }

        public async Task<int> UpdateApplianceActionAsync(ApplianceAction parachanges)
        {
            Update(parachanges);

            return await CommitChangesAsync();
        }

        public async Task<int> DeleteApplianceActioneAsync(ApplianceAction paraentity)
        {
            Remove(paraentity);

            return await CommitChangesAsync();
        }

        public async Task<ApplianceAction> GetApplianceActionById(int paraApplianceActionId)
             => await DbContext
                .Set<ApplianceAction>()
                .FirstOrDefaultAsync(item => item.Id == paraApplianceActionId);

    }
}
