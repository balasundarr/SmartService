﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Smart.Wasl.Homes.Services.HomeAppliances.Data.Contracts
{
    public interface IHomeApplianceActionRepositry
    {
        Task<String> GetApplianceState(int paramApplianceID);

        Task<Int32> SetApplianceAction(int paramApplianceID, string paramAction);
    }
}
