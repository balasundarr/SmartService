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
        public HomeApplianceInfoService(ILogger<HomeApplianceInfoService> paralogger, IUserInfo parauserInfo, HomeAppliancesContext paradbContext)
             : base(paralogger, parauserInfo, paradbContext)
        {
        }
        public async Task<IEntity> GetObjectsById(int paraId, IEntity paraentity)
        {
            return (await InfoRespositry.GetObjectsById( paraId,paraentity));
        }

        public Task<IEntity> GetLocationById(int paraId, IEntity paraEntity)
        {
            throw new NotImplementedException();
        }


        public Task<IEntity> GetHomeAppliancesObjets(int paraObjectId, IEntity paraEntity)
        {
            throw new NotImplementedException();
        }
    }
}
