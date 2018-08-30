using Smart.Wasl.Homes.Services.HomeAppliances.Domain;
using Smart.Wasl.Homes.Services.HomeAppliances.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Smart.Wasl.Homes.Services.HomeAppliances.Data.Contracts
{
    public interface IHomeApplianceInfoRepositry
    {

        Task<IEntity> GetObjectsById(int paraId, IEntity paraEntity);

        Task<IEnumerable<IEntity>> GetAll(String paramName);

        Task<IEntity> GetLocationById(int paraId, IEntity paraEntity);

        IQueryable<IEntity> GetHomeAppliancesObjets(int paraObjectId, IEntity paraEntity);

    }
}
