using System.Collections.Generic;

namespace Smart.Wasl.Homes.Clients.Core.Domain.Models
{ 
    public class Country 
    {

        public int _Id { get; set; }
        public string _Name { get; set; }

        public ICollection<State> _States { get; set; }

    }

}
