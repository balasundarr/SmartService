using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Smart.Wasl.Homes.Services.HomeAppliances.Data;
using Smart.Wasl.Homes.Services.HomeAppliances.Domain;

namespace Smart.Wasl.Homes.Services.HomeAppliances.Queries
{
    public class HomeQuery
    {

        private readonly HomeDbContext m_Obj_HomeDbContext;
     

        public HomeQuery(HomeDbContext param_Obj_HomeDbContext)
        {
            m_Obj_HomeDbContext = param_Obj_HomeDbContext;
        }

        public async Task<Home> GetHome(int Param_int_HomeId)
        {
          
            return await m_Obj_HomeDbContext
                .CP_ObjCol_Homes
                .Where(home => home.CPInt_Id == Param_int_HomeId
    )           .Select(home => new Home
                {
                    CPInt_Id = home.CPInt_Id,
                    CPStr_Name = home.CPStr_Name,
                    CPStr_Description = home.CPStr_Description,
                    CPInt_AddressId  = home.CPInt_AddressId,
                    CPInt_LocationId = home.CPInt_LocationId,
                    CPInt_ContatsId = home.CPInt_ContatsId,
                    CPInt_HomeAreaTypesId = home.CPInt_HomeAreaTypesId,
                  
                })
                .FirstOrDefaultAsync();

        }
        public async Task<IEnumerable<HomeAreaType>> GetHomeAreTypesByHome(int Param_int_HomeId)
        {
            var home = await m_Obj_HomeDbContext.CP_ObjCol_Homes
                .Include(h => h.CPInt_HomeAreaTypesId)
                .SingleAsync(h => h.CPInt_Id == Param_int_HomeId);

            if (home == null)
            {
                return null;
            }

            var homeareatypes = home.CPObjCol_HomeAreas.Select(homeareatype => new HomeAreaType
            {
                CPInt_Id = homeareatype.CPInt_Id,
                CPStr_Name = homeareatype.CPStr_Name,
                CPStr_Description = homeareatype.CPStr_Description,
                CPInt_AppliacesId = homeareatype.CPInt_AppliacesId,
                CPInt_LocationId = homeareatype.CPInt_LocationId,
                CPInt_RoomCoordinatesId = homeareatype.CPInt_RoomCoordinatesId,
                

            }).ToList();

            
            return homeareatypes;
        }

        public async Task<IEnumerable<Contact>> GetContactsByHome(int Param_int_homeId)
        {
            var home = await m_Obj_HomeDbContext.CP_ObjCol_Homes
                .Include(h => h.CPInt_HomeAreaTypesId)
                .SingleAsync(h => h.CPInt_Id == Param_int_homeId);

            if (home == null)
            {
                return null;
            }

            var contacts = home.CPObjCol_Contacts.Select(contact => new Contact
            {

                CPInt_Id = contact.CPInt_Id,
                CPStr_FirstName = contact.CPStr_FirstName,
                CPStr_MiddleName = contact.CPStr_MiddleName,
                CPStr_LastName = contact.CPStr_LastName,
                CPStr_Name = contact.CPStr_Name,
                CPInt_AddressId = contact.CPInt_AddressId,
                CPInt_ContactTypeId = contact.CPInt_ContactTypeId,
                CPStr_PhoneNumbersDetail = contact.CPStr_PhoneNumbersDetail,
                CPStr_MobileNumbersDetail = contact.CPStr_MobileNumbersDetail,

            }).ToList();


            return contacts;
        }


    }
}
