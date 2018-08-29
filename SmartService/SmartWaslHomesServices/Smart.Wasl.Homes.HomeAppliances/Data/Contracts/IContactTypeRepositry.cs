using Microsoft.EntityFrameworkCore;
using Smart.Wasl.Homes.Services.HomeAppliances.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Smart.Wasl.Homes.Services.HomeAppliances.Data.Contracts
{
    public interface IContactTypeRepositry : IRepository
    {
        Task<Int32> AddContactTypeAsync(ContactType paraentity);

        Task<Int32> UpdateContactTypeAsync(ContactType parachanges);

        Task<Int32> DeleteContactTypeAsync(ContactType paraentity);

        Task<ContactType> GetContactTypeById(int paraContactTypeId);

    }
}
