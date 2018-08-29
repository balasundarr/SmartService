using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Smart.Wasl.Homes.Services.HomeAppliances.Data;
using Smart.Wasl.Homes.Services.HomeAppliances.Domain;

namespace Smart.Wasl.Homes.Services.HomeAppliances.Queries
{
    
    public class StatesQuery
    {

        private readonly StateDbContext m_Obj_StateDbContext;

        public StatesQuery(StateDbContext param_Obj_StateDbContext)
        {
            m_Obj_StateDbContext = param_Obj_StateDbContext;
        }

        public async Task<State> GetState(int Param_int_StateId)
        {
            var state = await m_Obj_StateDbContext.CP_ObjCol_States
                .Include(h => h.CPObj_Country).ThenInclude(country => country.CPInt_Id)
                .Include(h => h.CPObj_Location).ThenInclude(location => location.CPInt_id)
                .SingleOrDefaultAsync(h => h.CPInt_Id == Param_int_StateId);

            var local_Obj_StateResult = new State()
            {
                CPInt_Id = state.CPInt_Id,
                CPStr_Name = state.CPStr_Name,
                CPInt_LocationId = state.CPInt_LocationId,
                CPInt_Countryid = state.CPInt_Countryid,
                CPObj_Location = new Location()
                {
                    CPInt_id = state.CPObj_Location.CPInt_id,
                    CPDouble_Latitude = state.CPObj_Location.CPDouble_Latitude,
                    CPDouble_Longitude = state.CPObj_Location.CPDouble_Longitude
                },
                CPObj_Country = new Country()
                {
                    CPInt_Id = state.CPObj_Country.CPInt_Id,
                    CPStr_Name = state.CPObj_Country.CPStr_Name,
                    CPObj_Location = new Location()
                    {
                        CPInt_id = state.CPObj_Country.CPObj_Location.CPInt_id,
                        CPDouble_Latitude = state.CPObj_Location.CPDouble_Latitude,
                        CPDouble_Longitude = state.CPObj_Location.CPDouble_Longitude
                    }
                }


            };
              
            return state;
        }
    



    }
}
