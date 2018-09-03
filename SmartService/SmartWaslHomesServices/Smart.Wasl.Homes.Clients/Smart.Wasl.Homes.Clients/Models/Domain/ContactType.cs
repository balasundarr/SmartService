using System.Collections.Generic;

namespace Smart.Wasl.Homes.Clients.Core.Domain.Models
{
    public class ContactType 
    {

        public int _Id { get; set; }
        public string _Name { get; set; }
                     
        public ICollection<Contact> _Contacts { get; set; }
    }
}
