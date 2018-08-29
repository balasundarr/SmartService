using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Collections.ObjectModel;
using Smart.Wasl.Homes.Services.HomeAppliances.Domain.Interfaces;


namespace Smart.Wasl.Homes.Services.HomeAppliances.Domain
{
    public class State : IAuditableEntity
    {

        
        public State(int paraStateId)
        {
            Id = paraStateId;
        }

        public State()
        {
            this.Cities = new HashSet<City>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int Countryid { get; set; }

        public string CreationUser { get; set; }
        public Nullable<System.DateTime> CreationDateTime { get; set; }
        public string LastUpdateUser { get; set; }
        public Nullable<System.DateTime> LastUpdateDateTime { get; set; }
        public byte[] Timestamp { get; set; }


        public virtual ICollection<City> Cities { get; set; }
        public virtual Country Country { get; set; }
    }

}
