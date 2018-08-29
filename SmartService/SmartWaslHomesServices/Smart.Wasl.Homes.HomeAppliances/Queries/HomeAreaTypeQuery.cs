using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Smart.Wasl.Homes.Services.HomeAppliances.Data;
using Smart.Wasl.Homes.Services.HomeAppliances.Domain;

namespace Smart.Wasl.Homes.Services.HomeAppliances.Queries
{
    public class HomeAreaTypeQuery
    {

        private readonly HomeAreaTypeDbContext m_Obj_HomeAreaTypeDbContext;

        public HomeAreaTypeQuery(HomeAreaTypeDbContext param_Obj_HomeAreaTypeDbContext)
        {
            m_Obj_HomeAreaTypeDbContext = param_Obj_HomeAreaTypeDbContext;
        }

        public async Task<HomeAreaType> GetHomeAreType(int param_int_id)
        {
            return await m_Obj_HomeAreaTypeDbContext
            .CP_ObjCol_HomeAreaTypes
            .Where(homeareatype => homeareatype.CPInt_Id == param_int_id)
            .Select(homeareatype => new HomeAreaType
            {

                CPInt_Id = homeareatype.CPInt_Id,
                CPStr_Name = homeareatype.CPStr_Name,
                CPStr_Description = homeareatype.CPStr_Description,
                CPInt_AppliacesId = homeareatype.CPInt_AppliacesId,
                CPInt_RoomCoordinatesId = homeareatype.CPInt_RoomCoordinatesId,
               

            })
            .FirstOrDefaultAsync();
        }
        public async Task<IEnumerable<Appliance>> GetApplianceByHomeAreaTypeId(int Param_int_HomeAreaTypeId)
        {
            var homeareatype = await m_Obj_HomeAreaTypeDbContext.CP_ObjCol_HomeAreaTypes
                .Include(h => h.CPObjCol_Appliances)
                .Include(h => h.CPObj_Location)
                .Include(h => h.CPObj_RoomCoordinates)
                .SingleAsync(h => h.CPInt_Id == Param_int_HomeAreaTypeId);

            if (homeareatype == null)
            {
                return null;
            }

            var appliances = homeareatype.CPObjCol_Appliances.Select(appliance => new Appliance
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
                CPInt_WarrantyYears = appliance.CPInt_WarrantyYears,
               

            }).ToList();


            return appliances;
        }



    }
}
