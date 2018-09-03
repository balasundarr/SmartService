using System.Collections.Generic;


namespace Smart.Wasl.Homes.Clients.Core.Domain.Models
{
    public class State 
    {
        public int _Id { get; set; }
        public string _Name { get; set; }
      
        public ICollection<City> _Cities { get; set; }
        public Country _Country { get; set; }
    }

}
