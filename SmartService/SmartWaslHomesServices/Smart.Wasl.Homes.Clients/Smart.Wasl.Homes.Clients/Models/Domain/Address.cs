
namespace Smart.Wasl.Homes.Clients.Core.Domain.Models
{
    public class Address 
    {
        public int _Id { get; set; }
        public string _StreetName_First { get; set; }
        public string _StreetName_Second { get; set; }
        public string _AreaName { get; set; }
      
        public Location _Location { get; set; }
        public City _City { get; set; }
        public Contact _Contact { get; set; }


    }
}
