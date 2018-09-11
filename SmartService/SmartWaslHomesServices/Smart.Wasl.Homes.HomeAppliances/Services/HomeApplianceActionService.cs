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
    public class HomeApplianceActionService : Service , IHomeApplianceActionService
    {
        public HomeApplianceActionService(ILogger<HomeApplianceActionService> paramLogger, IUserInfo paramUserInfo, HomeAppliancesContext paramDbContext)
            : base(paramLogger, paramUserInfo, paramDbContext)
        {
        }
        public Task<IEntity> GetAction(int paramEntity)
        {
            throw new NotFiniteNumberException();
        }
    }
}
