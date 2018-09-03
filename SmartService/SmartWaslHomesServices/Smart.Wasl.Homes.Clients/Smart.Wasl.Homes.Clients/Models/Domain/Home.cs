using System.Collections.Generic;

namespace Smart.Wasl.Homes.Clients.Core.Domain.Models
{
    public class Home
    {
        public int _Id { get; set; }
        public string _Name { get; set; }
        public string _Description { get; set; }
        
        public ICollection<Contact> _Contacts { get; set; }
        public Location _Location { get; set; }
        public ICollection<HomeAreaType> _HomeAreaTypes { get; set; }
    }
}