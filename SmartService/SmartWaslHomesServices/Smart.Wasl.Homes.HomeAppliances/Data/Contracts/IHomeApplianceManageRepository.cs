using Smart.Wasl.Homes.Services.HomeAppliances.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Smart.Wasl.Homes.Services.HomeAppliances.Data.Contracts
{
    public interface IHomeApplianceManageRepository
    {
        Task<Int32> AddAEntityAsync(IEntity paraentity);

        Task<Int32> UpdateEntityAsync(IEntity parachanges);

        Task<Int32> DeleteEntityAsync(IEntity paraentity);
    }
}
