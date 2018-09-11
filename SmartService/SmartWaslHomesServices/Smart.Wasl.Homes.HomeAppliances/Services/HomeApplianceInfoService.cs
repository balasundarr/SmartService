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

namespace Smart.Wasl.Homes.Services.HomeAppliances.Services
{
    public class HomeApplianceInfoService : Service, IHomeApplianceInfoService
    {
        public HomeApplianceInfoService(ILogger<HomeApplianceInfoService> paramLogger, IUserInfo paramUserInfo, HomeAppliancesContext paramDbContext)
             : base(paramLogger, paramUserInfo, paramDbContext)
        {
        }
        public async Task<IEntity> GetObjectsById(int paraId, IEntity paramEntity)
        {
            return (await InfoRespositry.GetObjectsById( paraId,paramEntity));
        }

        public async Task<IEnumerable<IEntity>> GetAll(String paramName)
        {
            return (await InfoRespositry.GetAll(paramName));
        }
        public Task<IEntity> GetLocationById(int paraId, IEntity paramEntity)
        {
            throw new NotImplementedException();
        }


        public Task<IEntity> GetHomeAppliancesObjets(int paramObjectId, IEntity paramEntity)
        {
            throw new NotImplementedException();
        }
    }
}
