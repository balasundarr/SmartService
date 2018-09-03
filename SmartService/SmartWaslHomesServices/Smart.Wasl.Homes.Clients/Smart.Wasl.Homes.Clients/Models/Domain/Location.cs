using System;
using System.Collections.Generic;

namespace Smart.Wasl.Homes.Clients.Core.Domain.Models
{
    public class Location 
    {
       
        public int _Id { get; set; }
        public Nullable<decimal> _Latitude { get; set; }
        public Nullable<decimal> _Longitude { get; set; }

        public ICollection<Appliance> _Appliances { get; set; }
        public ICollection<Home> _Homes { get; set; }
    }
}

