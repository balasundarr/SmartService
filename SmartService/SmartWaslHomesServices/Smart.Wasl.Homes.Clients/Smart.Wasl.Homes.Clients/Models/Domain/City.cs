using System;
using System.Collections.Generic;


namespace Smart.Wasl.Homes.Clients.Core.Domain.Models
{
    public class City 
    {
        public int _Id { get; set; }
        public string _Name { get; set; }
       

        public ICollection<Address> _Addresses { get; set; }
        public State _State { get; set; }

    }
}
