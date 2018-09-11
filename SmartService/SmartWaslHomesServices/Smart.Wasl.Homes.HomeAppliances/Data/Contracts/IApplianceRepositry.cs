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
        Task<Int32> AddApplianceAsync(Appliance paramEntity);

        Task<Int32> UpdateApplianceAsync(Appliance paranChanges);

        Task<Int32> DeleteApplianceAsync(Appliance paramEntity);

        Task<Appliance> GetApplianceById(int paramApplianceId);

        Task<IEnumerable<Appliance>> GetAll();

        Task<HomeAreaType> GetApplianceHomeAreaTypeById(int paramApplianceId);

        Task<ICollection<ApplianceAction>> GetApplianceActionById(int paramApplianceId);

        Task<ICollection<Contact>> GetApplianceContactsById(int paramApplianceId);

        Task<Location> GetApplianceLocationById(int paramApplianceId);
        
    }
}
