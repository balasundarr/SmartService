using Smart.Wasl.Homes.Services.HomeAppliances.Domain;
using Smart.Wasl.Homes.Services.HomeAppliances.Data;
using Smart.Wasl.Homes.Services.HomeAppliances.Data.Contracts;
using Smart.Wasl.Homes.Services.HomeAppliances.Data.Repositries;
using Smart.Wasl.Homes.Services.HomeAppliances.Domain.Interfaces;
using Smart.Wasl.Homes.Services.HomeAppliances.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;

namespace Smart.Wasl.Homes.Services.HomeAppliances.Services.Interface
{
    public interface IHomeApplianceInfoService : IService
    {
        Task<IEntity> GetObjectsById(int paramId, IEntity paramEntity);

        Task<IEnumerable<IEntity>> GetAll(String paramName);

        Task<IEntity> GetLocationById(int paramId, IEntity paramEntity);
            
        Task<IEntity> GetHomeAppliancesObjets(int paramObjectId, IEntity paramEntity);
        
    }
}
