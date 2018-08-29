using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Smart.Wasl.Homes.Services.HomeAppliances.Data;
using Smart.Wasl.Homes.Services.HomeAppliances.Domain;

namespace Smart.Wasl.Homes.Services.HomeAppliances.Queries
{
    public class ContactQuery
    {

        private readonly ContactsDbContext m_Obj_ContactsDbContext;

        public ContactQuery(ContactsDbContext param_Obj_ContactsDbContext)
        {
            m_Obj_ContactsDbContext = param_Obj_ContactsDbContext;
        }

        public async Task<Contact> GetContact(int Param_int_ContactId)
        {
            return await m_Obj_ContactsDbContext
            .CP_ObjCol_Contacts
            .Where(contact => contact.CPInt_Id == Param_int_ContactId)
            .Select(contact => new Contact
            {

                CPInt_Id = contact.CPInt_Id,
                CPStr_FirstName = contact.CPStr_FirstName,
                CPStr_MiddleName = contact.CPStr_MiddleName,
                CPStr_LastName = contact.CPStr_LastName,
                CPStr_Name = contact.CPStr_Name,
                CPInt_AddressId = contact.CPInt_AddressId,
                CPInt_ContactTypeId = contact.CPInt_ContactTypeId,
                CPStr_PhoneNumbersDetail = contact.CPStr_PhoneNumbersDetail,
                CPStr_MobileNumbersDetail = contact.CPStr_MobileNumbersDetail,
                

            })
            .FirstOrDefaultAsync();
        }




    }
}
