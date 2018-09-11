using Smart.Wasl.Homes.Services.HomeAppliances.Domain;
using Smart.Wasl.Homes.Services.HomeAppliances.Data;
using Smart.Wasl.Homes.Services.HomeAppliances.Data.Contracts;
using Smart.Wasl.Homes.Services.HomeAppliances.Data.Repositries;
using Smart.Wasl.Homes.Services.HomeAppliances.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Smart.Wasl.Homes.Services.HomeAppliances.Data.Repositries
{
    public class ContactTypeRepositry : Repository, IContactTypeRepositry
    {
        public ContactTypeRepositry(IUserInfo parauserInfo, HomeAppliancesContext paradbContext)
          : base(parauserInfo, paradbContext)
        {
        }
        
        public async Task<int> AddContactTypeAsync(ContactType paramEntity)
        {
            Add(paramEntity);

            return await CommitChangesAsync();
        }

        public async Task<int> UpdateContactTypeAsync(ContactType paramChanges)
        {
            Update(paramChanges);

            return await CommitChangesAsync();
        }

        public async Task<int> DeleteContactTypeAsync(ContactType paramEntity)
        {
            Remove(paramEntity);

            return await CommitChangesAsync();
        }
        public async Task<ContactType> GetContactTypeById(int paramContactTypeId)
        => await DbContext
           .Set<ContactType>()
           .FirstOrDefaultAsync(item => item.Id == paramContactTypeId);

        public async Task<IEnumerable<ContactType>> GetAll()
          => await DbContext
             .Set<ContactType>()
             .ToListAsync();

    }
}
