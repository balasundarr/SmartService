﻿using Smart.Wasl.Homes.Services.HomeAppliances.Domain;
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
    public class HomeApplianceManageService : Service, IHomeApplianceManageService
    {
        public HomeApplianceManageService(ILogger<HomeApplianceManageService> logger, IUserInfo userInfo, HomeAppliancesContext dbContext)
           : base(logger, userInfo, dbContext)
        {
        }
        public async Task<Int32> AddEntityAsync(IEntity paramEntity)
        {
            return (await HomeApplianceManageRepository.AddAEntityAsync(paramEntity));

        }

        public async Task<int> UpdateEntityAsync(IEntity paramChanges)
        {
            return (await HomeApplianceManageRepository.UpdateEntityAsync(paramChanges));
        }

        public async Task<int> DeleteEntityAsync(IEntity paramEntity)
        {
            return (await HomeApplianceManageRepository.DeleteEntityAsync(paramEntity));
        }
    }
}
