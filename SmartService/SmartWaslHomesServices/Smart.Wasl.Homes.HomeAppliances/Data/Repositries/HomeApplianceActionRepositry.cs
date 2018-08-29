using Microsoft.EntityFrameworkCore;
using Smart.Wasl.Homes.Services.HomeAppliances.Data;
using Smart.Wasl.Homes.Services.HomeAppliances.Data.Contracts;
using Smart.Wasl.Homes.Services.HomeAppliances.Data.Repositries;
using Smart.Wasl.Homes.Services.HomeAppliances.Domain;
using Smart.Wasl.Homes.Services.HomeAppliances.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Smart.Wasl.Homes.Services.HomeAppliances.Services
{
    public class HomeApplianceActionRepositry : Repository, IHomeApplianceActionRepositry
    {
        public HomeApplianceActionRepositry(IUserInfo parauserInfo, HomeAppliancesContext paradbContext)
            : base(parauserInfo, paradbContext)
        {
        }
       
        public Task<String> GetApplianceState(int paraApplianceID)
        {
            throw new NotImplementedException();
        }



        public Task<Int32> SetApplianceAction(int paraApplianceID, string paraAction)
        {
            throw new NotImplementedException();
        }
    }
}
