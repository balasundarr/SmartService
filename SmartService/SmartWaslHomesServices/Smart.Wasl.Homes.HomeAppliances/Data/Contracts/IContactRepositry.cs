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
        Task<Int32> AddContacteAsync(Contact paramEntity);

        Task<Int32> UpdateContactAsync(Contact paramChanges);

        Task<Int32> DeleteContactAsync(Contact paramEntity);

        Task<Contact> GetContactById(int paramContactId);

        Task<IEnumerable<Contact>> GetAll();

        Task<ICollection<Address>> GetContactAddressById(int paramContactId);

        Task<ContactType> GetContactTypeById(int paramContactId);


    }
}
