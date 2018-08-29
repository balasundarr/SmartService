using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Collections.ObjectModel;
using Smart.Wasl.Homes.Services.HomeAppliances.Domain.Interfaces;

namespace Smart.Wasl.Homes.Services.HomeAppliances.Domain
{

    public class RoomCoordinate : IAuditableEntity
    {
        public RoomCoordinate()
        {
        }

        public RoomCoordinate(int paraRoomCoordinateId)
        {
            Id = paraRoomCoordinateId;
        }

        public int Id { get; set; }
        public Nullable<decimal> SouthCorner { get; set; }
        public Nullable<decimal> NorthCorner { get; set; }
        public Nullable<decimal> EastCorner { get; set; }
        public Nullable<decimal> WestCorner { get; set; }
        public Nullable<decimal> SouthHeight { get; set; }
        public Nullable<decimal> NorthHeight { get; set; }
        public Nullable<decimal> EastHeight { get; set; }
        public Nullable<decimal> WestHeight { get; set; }

        public Nullable<int> HomeAreaTypeId { get; set; }

        public string CreationUser { get; set; }
        public Nullable<System.DateTime> CreationDateTime { get; set; }
        public string LastUpdateUser { get; set; }
        public Nullable<System.DateTime> LastUpdateDateTime { get; set; }
        public byte[] Timestamp { get; set; }

        public virtual HomeAreaType HomeAreaType { get; set; }
    }

}