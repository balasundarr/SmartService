using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;


namespace Smart.Wasl.Homes.Clients.Core.Domain.Models
{
    public class Appliance 
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Nullable<System.DateTime> PurchasedDate { get; set; }
        public Nullable<System.DateTime> NextServiceDate { get; set; }
        public int WarrantyYears { get; set; }

        public Nullable<int> HomeAreaTypeId { get; set; }
        public Nullable<int> ApplianceActionId { get; set; }

        public HomeAreaType _HomeAreaType { get; set; }
        public Location _Location { get; set; }
        public ICollection<ApplianceAction> _ApplianceActions { get; set; }
        public Collection<Contact> _Contacts { get; set; }



    }
}
