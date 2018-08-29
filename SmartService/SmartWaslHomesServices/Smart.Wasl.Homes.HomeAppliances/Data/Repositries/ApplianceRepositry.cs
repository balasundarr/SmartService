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
    public class ApplianceRepositry :  Repository, IApplianceRepositry
    {
        public ApplianceRepositry(IUserInfo parauserInfo, HomeAppliancesContext paradbContext)
           : base(parauserInfo, paradbContext)
        {
        }

        public async Task<int> AddApplianceAsync(Appliance paraentity)
        {
            Add(paraentity);

            return await CommitChangesAsync();
        }

        public async Task<int> UpdateApplianceAsync(Appliance parachanges)
        {
            Update(parachanges);

            return await CommitChangesAsync();
        }

        public async Task<int> DeleteApplianceAsync(Appliance paraentity)
        {
            Remove(paraentity);

            return await CommitChangesAsync();
        }

        public async Task<Appliance> GetApplianceById(int paraApplianceId)
            => await DbContext
              .Set<Appliance>()
                .FirstOrDefaultAsync(item => item.Id == paraApplianceId);

        public async Task<HomeAreaType> GetApplianceHomeAreaTypeById(int paraApplianceId)
        {
            Appliance local_Appliance = await DbContext
                .Set<Appliance>()
                .FirstOrDefaultAsync(item => item.Id == paraApplianceId);
            return (await DbContext
                .Set<HomeAreaType>()
                .FirstOrDefaultAsync(item => item.Id == local_Appliance.HomeAreaTypeId));

        }

        public async Task<ICollection<ApplianceAction>> GetApplianceActionById(int paraApplianceId)
        {
            Appliance local_Appliance = await DbContext
                .Set<Appliance>()
                .FirstOrDefaultAsync(item => item.Id == paraApplianceId);
            return (await DbContext
                .Set<ApplianceAction>()
                .Where(item => item.Id == local_Appliance.ApplianceActionId)
                .ToListAsync());

        }

        public async  Task<ICollection<Contact>> GetApplianceContactsById(int paraApplianceId)
            => await DbContext
                    .Set<Contact>()
                    .Where(item => item.ApplianceId == paraApplianceId)
                    .ToListAsync();

        public async Task<Location> GetApplianceLocationById(int paraApplianceId)
        {
            Appliance local_Appliance = await DbContext
                .Set<Appliance>()
                .FirstOrDefaultAsync(item => item.Id == paraApplianceId);

            return (await DbContext
            .Set<Location>()
            .FirstOrDefaultAsync(item => item.Id == local_Appliance.LocationId));


        }



    }
}
