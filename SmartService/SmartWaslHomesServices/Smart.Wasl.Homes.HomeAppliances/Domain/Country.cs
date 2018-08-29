using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Collections.ObjectModel;
using Smart.Wasl.Homes.Services.HomeAppliances.Domain.Interfaces;

namespace Smart.Wasl.Homes.Services.HomeAppliances.Domain
{
    public class Country : IAuditableEntity
    {


        public Country(int paraCountryTypeId)
        {
            Id = paraCountryTypeId;
        }

        public Country()
        {
            this.States = new HashSet<State>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public string CreationUser { get; set; }
        public Nullable<System.DateTime> CreationDateTime { get; set; }
        public string LastUpdateUser { get; set; }
        public Nullable<System.DateTime> LastUpdateDateTime { get; set; }
        public byte[] Timestamp { get; set; }

        public virtual ICollection<State> States { get; set; }

    }

}
