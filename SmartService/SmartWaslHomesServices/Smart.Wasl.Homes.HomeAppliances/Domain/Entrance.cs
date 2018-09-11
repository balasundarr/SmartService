using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Collections.ObjectModel;
using Smart.Wasl.Homes.Services.HomeAppliances.Domain.Interfaces;

namespace Smart.Wasl.Homes.Services.HomeAppliances.Domain
{
    public class Entrance : IAuditableEntity
    {
        public Entrance()
        {
        }

        public Entrance(int paramEntranceId)
        {
            Id = paramEntranceId;
        }

        public int Id { get; set; }
        public Nullable<decimal> Left { get; set; }
        public Nullable<decimal> Right { get; set; }
        public Nullable<decimal> TopLeft { get; set; }
        public Nullable<decimal> TopRight { get; set; }

        public Nullable<int> HomeAreaTypeId { get; set; }

        public string CreationUser { get; set; }
        public Nullable<System.DateTime> CreationDateTime { get; set; }
        public string LastUpdateUser { get; set; }
        public Nullable<System.DateTime> LastUpdateDateTime { get; set; }
        public byte[] Timestamp { get; set; }

        public virtual HomeAreaType HomeAreaType { get; set; }
    }

}
