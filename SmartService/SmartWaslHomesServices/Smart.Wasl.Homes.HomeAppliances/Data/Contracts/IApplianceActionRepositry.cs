using Smart.Wasl.Homes.Services.HomeAppliances.Domain;
using Smart.Wasl.Homes.Services.HomeAppliances.Data;
using Smart.Wasl.Homes.Services.HomeAppliances.Data.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Smart.Wasl.Homes.Services.HomeAppliances.Data.Contracts
{
    public interface IApplianceActionRepositry : IRepository
    {

        Task<Int32> AddApplianceActioneAsync(ApplianceAction paramEntity);

        Task<Int32> UpdateApplianceActionAsync(ApplianceAction paramChanges);

        Task<Int32> DeleteApplianceActioneAsync(ApplianceAction paramEntity);

        Task<ApplianceAction> GetApplianceActionById(int paramApplianceActionId);

        Task<IEnumerable<ApplianceAction>> GetAll();


    }
}
