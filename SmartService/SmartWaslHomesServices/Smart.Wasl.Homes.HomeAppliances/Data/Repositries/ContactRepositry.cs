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

namespace Smart.Wasl.Homes.Services.HomeAppliances.Domain.Repositries
{
    public class ContactRepositry : Repository, IContactRepositry
    {
        public ContactRepositry(IUserInfo parauserInfo, HomeAppliancesContext paradbContext)
           : base(parauserInfo, paradbContext)
        {
        }

        public async Task<int> AddContacteAsync(Contact paraentity)
        {
            Add(paraentity);

            return await CommitChangesAsync();
        }

        public async Task<int> UpdateContactAsync(Contact parachanges)
        {
            Update(parachanges);

            return await CommitChangesAsync();
        }

        public async Task<int> DeleteContactAsync(Contact paraentity)
        {
            Remove(paraentity);

            return await CommitChangesAsync();
        }

        public async Task<Contact> GetContactById(int paraContactId)
            => await DbContext
               .Set<Contact>()
               .FirstOrDefaultAsync(item => item.Id == paraContactId);

        public async Task<ICollection<Address>> GetContactAddressById(int paraContactId)
        {
            Contact local_Contact = await DbContext.Set<Contact>().FirstOrDefaultAsync(item => item.Id == paraContactId);
            return (await DbContext.Set<Address>()
                .Where(item => item.ContactId == local_Contact.Id)
                .ToListAsync());

        }
        public  async Task<ContactType> GetContactTypeById(int paraContactId)
        {
            Contact local_Contact = await DbContext.Set<Contact>().FirstOrDefaultAsync(item => item.Id == paraContactId);
            return (await GetContactTypeById(local_Contact.ContactTypeId));
        }


    }
}
