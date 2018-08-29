using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Smart.Wasl.Homes.Services.HomeAppliances.Data;
using Smart.Wasl.Homes.Services.HomeAppliances.Domain;

namespace Smart.Wasl.Homes.Services.HomeAppliances.Queries
{
    public class CountryQuery
    {
      
        private readonly CountryDbContext m_Obj_CountryDbContext;

        private readonly StateDbContext m_Obj_StateDbContext;

        public CountryQuery(CountryDbContext param_Obj_CountryDbContext)
        {
            m_Obj_CountryDbContext = param_Obj_CountryDbContext;
        }
        public CountryQuery(CountryDbContext param_Obj_CountrydbContext, StateDbContext param_Obj_StatedbContext)
        {
            m_Obj_CountryDbContext = param_Obj_CountrydbContext;
            m_Obj_StateDbContext = param_Obj_StatedbContext;
        }
        public async Task<IEnumerable<Country>> GetAll()
        {
            return await m_Obj_CountryDbContext
                .CP_ObjCol_Countries
               .Select(country => new Country
               {
                   CPInt_Id = country.CPInt_Id,
                   CPStr_Name = country.CPStr_Name,
                   CPInt_LocationId = country.CPInt_LocationId

               })
                .ToListAsync();
        }

        public async Task<Country> GetCountry(int Param_int_CountryId)
        {
            return await m_Obj_CountryDbContext
            .CP_ObjCol_Countries
            .Where(country => country.CPInt_Id == Param_int_CountryId)
            .Select(country => new Country
            {
                CPInt_Id = country.CPInt_Id,
                CPStr_Name = country.CPStr_Name,
                CPInt_LocationId = country.CPInt_LocationId



            })
            .FirstOrDefaultAsync();
            
        }
        public async Task<IEnumerable<State>> GetStateByCountry(int Param_int_CountryId)
        {
            var local_Obj_Countries = await m_Obj_CountryDbContext.CP_ObjCol_Countries
                .Include(h => h.CPObCol_States)
                .SingleAsync(h => h.CPInt_Id == Param_int_CountryId);

            if (local_Obj_Countries == null)
            {
                return null;
            }

            var local_Obj_States = local_Obj_Countries.CPObCol_States.Select(state => new State
            {
                CPInt_Id = state.CPInt_Id,
                CPStr_Name = state.CPStr_Name,
                CPInt_LocationId = state.CPInt_LocationId,
                CPInt_Countryid = state.CPInt_Countryid,
                CPObj_Country = local_Obj_Countries
       
            }).ToList();


            return local_Obj_States;
        }

    }
}
