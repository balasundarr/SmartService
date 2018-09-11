using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Collections.ObjectModel;
using Smart.Wasl.Homes.Services.HomeAppliances.Domain.Interfaces;

namespace Smart.Wasl.Homes.Services.HomeAppliances.Domain
{
    public class HomeAreaType : IAuditableEntity
    {
     
        public HomeAreaType(int paramHomeAreaTypeId)
        {
            Id = paramHomeAreaTypeId;
        }

        public HomeAreaType()
        {
            this.Entrances = new HashSet<Entrance>();
            this.RoomCoordinates = new HashSet<RoomCoordinate>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public int HomeId { get; set; }
        public Nullable<int> RoomCoordinateId { get; set; }

        public string CreationUser { get; set; }
        public Nullable<System.DateTime> CreationDateTime { get; set; }
        public string LastUpdateUser { get; set; }
        public Nullable<System.DateTime> LastUpdateDateTime { get; set; }
        public byte[] Timestamp { get; set; }

        public virtual Home Home { get; set; }
        public virtual ICollection<Entrance> Entrances { get; set; }
        public virtual ICollection<RoomCoordinate> RoomCoordinates { get; set; }

    }
}
