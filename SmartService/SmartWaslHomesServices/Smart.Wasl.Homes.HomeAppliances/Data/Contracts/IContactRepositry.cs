using Microsoft.EntityFrameworkCore;
using Smart.Wasl.Homes.Services.HomeAppliances.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Smart.Wasl.Homes.Services.HomeAppliances.Data.Contracts
{
    public interface IContactRepositry : IRepository
    {
        Task<Int32> AddContacteAsync(Contact paraentity);

        Task<Int32> UpdateContactAsync(Contact parachanges);

        Task<Int32> DeleteContactAsync(Contact paraentity);

        Task<Contact> GetContactById(int paraContactId);

        Task<IEnumerable<Contact>> GetAll();

        Task<ICollection<Address>> GetContactAddressById(int paraContactId);

        Task<ContactType> GetContactTypeById(int paraContactId);


    }
}
