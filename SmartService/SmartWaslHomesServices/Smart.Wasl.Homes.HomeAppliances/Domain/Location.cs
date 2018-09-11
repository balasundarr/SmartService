using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Collections.ObjectModel;
using Smart.Wasl.Homes.Services.HomeAppliances.Domain.Interfaces;

namespace Smart.Wasl.Homes.Services.HomeAppliances.Domain
{
    public class Location : IAuditableEntity
    {
       
        public Location(int paramLocationId)
        {
            Id = paramLocationId;
        }
        public Location()
        {
            this.Appliances = new HashSet<Appliance>();
            this.Homes = new HashSet<Home>();
        }

        public int Id { get; set; }
        public Nullable<decimal> Latitude { get; set; }
        public Nullable<decimal> Longitude { get; set; }

        public string CreationUser { get; set; }
        public Nullable<System.DateTime> CreationDateTime { get; set; }
        public string LastUpdateUser { get; set; }
        public Nullable<System.DateTime> LastUpdateDateTime { get; set; }
        public byte[] Timestamp { get; set; }


        public virtual ICollection<Appliance> Appliances { get; set; }
        public virtual ICollection<Home> Homes { get; set; }
    }
}

