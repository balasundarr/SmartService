using Microsoft.EntityFrameworkCore;
using Smart.Wasl.Homes.Services.HomeAppliances.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Smart.Wasl.Homes.Services.HomeAppliances.Data.Contracts
{
    public interface IApplianceRepositry : IRepository
    {
        Task<Int32> AddApplianceAsync(Appliance paraentity);

        Task<Int32> UpdateApplianceAsync(Appliance parachanges);

        Task<Int32> DeleteApplianceAsync(Appliance paraentity);

        Task<Appliance> GetApplianceById(int paraApplianceId);

        Task<HomeAreaType> GetApplianceHomeAreaTypeById(int paraApplianceId);

        Task<ICollection<ApplianceAction>> GetApplianceActionById(int paraApplianceId);

        Task<ICollection<Contact>> GetApplianceContactsById(int paraApplianceId);

        Task<Location> GetApplianceLocationById(int paraApplianceId);
        
    }
}
