using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Smart.Wasl.Homes.Services.HomeAppliances.Data;
using Smart.Wasl.Homes.Services.HomeAppliances.Domain;

namespace Smart.Wasl.Homes.Services.HomeAppliances.Queries
{
    public class AppliancesQuery
    {

        private readonly ApplianceDbContext m_Obj_ApplianceDbContext;

        public AppliancesQuery(ApplianceDbContext Param_Obj_ApplianceDbContext)
        {
            m_Obj_ApplianceDbContext = Param_Obj_ApplianceDbContext;
        }

        public async Task<Appliance> GetAppliance(int param_int_id)
        {
            return await m_Obj_ApplianceDbContext
            .CP_ObjCol_Appliances
            .Where(appliance => appliance.CPInt_Id == param_int_id)
            .Select(appliance => new Appliance
            {

                CPInt_Id = appliance.CPInt_Id,
                CPStr_Name = appliance.CPStr_Name,
                CPInt_TypeId = appliance.CPInt_TypeId,
                CPInt_StateId = appliance.CPInt_StateId,
                CPInt_LocationId = appliance.CPInt_LocationId,
                CPInt_ContactsId = appliance.CPInt_ContactsId,
                CPInt_AddressId = appliance.CPInt_AddressId,
                CPDate_PurchasedDate = appliance.CPDate_PurchasedDate,
                CPDate_NextServiceDate = appliance.CPDate_NextServiceDate,
                CPInt_WarrantyYears = appliance.CPInt_WarrantyYears
            })
            .FirstOrDefaultAsync();
        }




    }
}
