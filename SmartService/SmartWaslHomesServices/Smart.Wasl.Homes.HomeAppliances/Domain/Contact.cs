using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Smart.Wasl.Homes.Services.HomeAppliances.Domain.Interfaces;

namespace Smart.Wasl.Homes.Services.HomeAppliances.Domain
{
    public class Contact : IAuditableEntity
    {
 
       
        public Contact(int paramContactId)
        {
            Id = paramContactId;
        }
        public Contact()
        {
            this.Addresses = new HashSet<Address>();
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Name { get; set; }
        public string PhoneNumbers { get; set; }
        public string MobileNumbers { get; set; }

        public int HomeId { get; set; }
        public int ApplianceId { get; set; }
        public int ContactTypeId { get; set; }

        public string CreationUser { get; set; }
        public Nullable<System.DateTime> CreationDateTime { get; set; }
        public string LastUpdateUser { get; set; }
        public Nullable<System.DateTime> LastUpdateDateTime { get; set; }
        public byte[] Timestamp { get; set; }

   
        public virtual ICollection<Address> Addresses { get; set; }
        public virtual Appliance Appliance { get; set; }
        public virtual ContactType ContactType { get; set; }
        public virtual Home Home { get; set; }

    }
}
