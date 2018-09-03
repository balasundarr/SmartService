using System.Collections.Generic;



namespace Smart.Wasl.Homes.Clients.Core.Domain.Models
{
    public class Contact 
    {
        
        public int _Id { get; set; }
        public string _FirstName { get; set; }
        public string _MiddleName { get; set; }
        public string _LastName { get; set; }
        public string _Name { get; set; }
        public string _PhoneNumbers { get; set; }
        public string _MobileNumbers { get; set; }
       
        public ICollection<Address> _Addresses { get; set; }
        public Appliance _Appliance { get; set; }
        public ContactType _ContactType { get; set; }
        public Home _Home { get; set; }

    }
}
