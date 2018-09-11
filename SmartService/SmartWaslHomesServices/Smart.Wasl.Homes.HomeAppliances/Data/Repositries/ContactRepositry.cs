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

        public async Task<int> AddContacteAsync(Contact paramEntity)
        {
            Add(paramEntity);

            return await CommitChangesAsync();
        }

        public async Task<int> UpdateContactAsync(Contact paramChanges)
        {
            Update(paramChanges);

            return await CommitChangesAsync();
        }

        public async Task<int> DeleteContactAsync(Contact paramEntity)
        {
            Remove(paramEntity);

            return await CommitChangesAsync();
        }

        public async Task<Contact> GetContactById(int paramContactId)
            => await DbContext
               .Set<Contact>()
               .FirstOrDefaultAsync(item => item.Id == paramContactId);

        public async Task<IEnumerable<Contact>> GetAll()
             => await DbContext
                .Set<Contact>()
                .ToListAsync();

        public async Task<ICollection<Address>> GetContactAddressById(int paramContactId)
        {
            Contact local_Contact = await DbContext.Set<Contact>().FirstOrDefaultAsync(item => item.Id == paramContactId);
            return (await DbContext.Set<Address>()
                .Where(item => item.ContactId == local_Contact.Id)
                .ToListAsync());

        }
        public  async Task<ContactType> GetContactTypeById(int paramContactId)
        {
            Contact local_Contact = await DbContext.Set<Contact>().FirstOrDefaultAsync(item => item.Id == paramContactId);
            return (await GetContactTypeById(local_Contact.ContactTypeId));
        }


    }
}
