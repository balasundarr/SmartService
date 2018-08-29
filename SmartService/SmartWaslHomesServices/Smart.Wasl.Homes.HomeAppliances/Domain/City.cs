using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Smart.Wasl.Homes.Services.HomeAppliances.Domain.Interfaces;

namespace Smart.Wasl.Homes.Services.HomeAppliances.Domain
{
    public class City : IAuditableEntity
    {

       
       
        public City()
        {
            this.Addresses = new HashSet<Address>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int StateId { get; set; }

        public string CreationUser { get; set; }
        public Nullable<System.DateTime> CreationDateTime { get; set; }
        public string LastUpdateUser { get; set; }
        public Nullable<System.DateTime> LastUpdateDateTime { get; set; }
        public byte[] Timestamp { get; set; }

        public virtual ICollection<Address> Addresses { get; set; }
        public virtual State State { get; set; }
        
    }
}
