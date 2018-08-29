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
        
        public async Task<int> AddContactTypeAsync(ContactType paraentity)
        {
            Add(paraentity);

            return await CommitChangesAsync();
        }

        public async Task<int> UpdateContactTypeAsync(ContactType parachanges)
        {
            Update(parachanges);

            return await CommitChangesAsync();
        }

        public async Task<int> DeleteContactTypeAsync(ContactType paraentity)
        {
            Remove(paraentity);

            return await CommitChangesAsync();
        }
        public async Task<ContactType> GetContactTypeById(int paraContactTypeId)
        {

            Contact local_Contact = await DbContext.Set<Contact>()
                                    .FirstOrDefaultAsync(item => item.Id == paraContactTypeId);
            return (await GetContactTypeById(local_Contact.ContactTypeId));
        }

    }
}
