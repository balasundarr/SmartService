using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Smart.Wasl.Homes.Services.HomeAppliances.Data;
using Smart.Wasl.Homes.Services.HomeAppliances.Domain;

namespace Smart.Wasl.Homes.Services.HomeAppliances.Queries
{
    public class AddressQuery
    {

        private readonly AddressesDbContext m_Obj_AddressesDbContext;

        public AddressQuery(AddressesDbContext param_Obj_AddressesDbContext)
        {
            m_Obj_AddressesDbContext = param_Obj_AddressesDbContext;
        }

        public async Task<Address> GetAddress(int param_int_id)
        {
            return await m_Obj_AddressesDbContext
            .CP_ObjCol_Addresses
            .Where(address => address.CPInt_Id == param_int_id)
            .Select(address => new Address
            {
                CPInt_Id = address.CPInt_Id,
                CPStr_StreetName_First = address.CPStr_StreetName_First,
                CPStr_StreetName_Second = address.CPStr_StreetName_Second,
                CPStr_AreaName = address.CPStr_AreaName,
                CPInt_LocationId = address.CPInt_LocationId,
                CPInt_CityId = address.CPInt_CityId


            })
            .FirstOrDefaultAsync();
        }




    }
}
