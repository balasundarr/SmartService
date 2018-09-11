using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Collections.ObjectModel;
using Smart.Wasl.Homes.Services.HomeAppliances.Domain.Interfaces;


namespace Smart.Wasl.Homes.Services.HomeAppliances.Domain
{
    public class Home : IAuditableEntity
    {
       
        public Home(int paramHomeId)
        {
            Id = paramHomeId;
        }
        public Home()
        {
            this.Contacts = new HashSet<Contact>();
            this.HomeAreaTypes = new HashSet<HomeAreaType>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public Nullable<int> LocationId { get; set; }

        public string CreationUser { get; set; }
        public Nullable<System.DateTime> CreationDateTime { get; set; }
        public string LastUpdateUser { get; set; }
        public Nullable<System.DateTime> LastUpdateDateTime { get; set; }
        public byte[] Timestamp { get; set; }


        public virtual ICollection<Contact> Contacts { get; set; }
        public virtual Location Location { get; set; }
        public virtual ICollection<HomeAreaType> HomeAreaTypes { get; set; }

    }
}
