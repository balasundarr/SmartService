using System;


namespace Smart.Wasl.Homes.Clients.Core.Domain.Models
{

    public class RoomCoordinate 
    {
        public int _Id { get; set; }
        public Nullable<decimal> _SouthCorner { get; set; }
        public Nullable<decimal> _NorthCorner { get; set; }
        public Nullable<decimal> _EastCorner { get; set; }
        public Nullable<decimal> _WestCorner { get; set; }
        public Nullable<decimal> _SouthHeight { get; set; }
        public Nullable<decimal> _NorthHeight { get; set; }
        public Nullable<decimal> _EastHeight { get; set; }
        public Nullable<decimal> _WestHeight { get; set; }

        public HomeAreaType _HomeAreaType { get; set; }
    }

}