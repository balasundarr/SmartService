using Smart.Wasl.Homes.Services.HomeAppliances.Data.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Smart.Wasl.Homes.Services.HomeAppliances.Domain.Interfaces;

namespace Smart.Wasl.Homes.Services.HomeAppliances.Services.Interface
{
    public interface IHomeApplianceActionService : IService
    {
        Task<IEntity> GetAction(int paramEntity);
    }
}
