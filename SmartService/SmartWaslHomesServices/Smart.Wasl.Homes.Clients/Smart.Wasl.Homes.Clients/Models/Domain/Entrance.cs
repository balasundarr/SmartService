using System;

namespace Smart.Wasl.Homes.Clients.Core.Domain.Models
{
    public class Entrance 
    {
        public int _Id { get; set; }
        public Nullable<decimal> _Left { get; set; }
        public Nullable<decimal> _Right { get; set; }
        public Nullable<decimal> _TopLeft { get; set; }
        public Nullable<decimal> _TopRight { get; set; }
               
        
        public HomeAreaType _HomeAreaType { get; set; }
    }

}
