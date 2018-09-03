using System.Collections.Generic;

namespace Smart.Wasl.Homes.Clients.Core.Domain.Models
{
    public class HomeAreaType
    {
        public int _RoomId { get; set; }
        public string _RoomName { get; set; }
        public int _RoomType { get; set; }

        public List<string> _Pictures { get; set; }
        public List<Appliance> _Appliances { get; set; }
        public Home _Home { get; set; }
        public ICollection<Entrance> _Entrances { get; set; }
        public ICollection<RoomCoordinate> _RoomCoordinates { get; set; }

    }
}