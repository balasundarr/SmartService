using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Smart.Wasl.Homes.Services.HomeAppliances.Domain.Interfaces;

namespace Smart.Wasl.Homes.Services.HomeAppliances.Domain
{
    public class Appliance : IAuditableEntity
    {
       
        public Appliance(int paraApplianceId)
        {
            Id = paraApplianceId;
        }

        public Appliance()
        {
            this.ApplianceActions = new HashSet<ApplianceAction>();
            this.Contacts = new HashSet<Contact>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public Nullable<System.DateTime> PurchasedDate { get; set; }
        public Nullable<System.DateTime> NextServiceDate { get; set; }
        public int WarrantyYears { get; set; }

        public Nullable<int> HomeAreaTypeId { get; set; }
        public Nullable<int> ApplianceActionId { get; set; }
        public Nullable<int> LocationId { get; set; }

        public string CreationUser { get; set; }
        public Nullable<System.DateTime> CreationDateTime { get; set; }
        public string LastUpdateUser { get; set; }
        public Nullable<System.DateTime> LastUpdateDateTime { get; set; }
        public byte[] Timestamp { get; set; }

        public virtual Location Location { get; set; }
        public virtual ICollection<ApplianceAction> ApplianceActions { get; set; }
        public virtual ICollection<Contact> Contacts { get; set; }



    }


}
