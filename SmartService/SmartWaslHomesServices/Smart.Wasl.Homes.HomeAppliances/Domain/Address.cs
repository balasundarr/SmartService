using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Smart.Wasl.Homes.Services.HomeAppliances.Domain.Interfaces;

namespace Smart.Wasl.Homes.Services.HomeAppliances.Domain
{
    public class Address : IAuditableEntity
    {
        public Address()
        {
        }

        public Address(int paraAddressId)
        {
            Id = paraAddressId;
        }


        public int Id { get; set; }
        public string StreetName_First { get; set; }
        public string StreetName_Second { get; set; }
        public string AreaName { get; set; }
        public Nullable<int> ContactId { get; set; }

        public int LocationId { get; set; }
        public int CityId { get; set; }

        public string CreationUser { get; set; }
        public Nullable<System.DateTime> CreationDateTime { get; set; }
        public string LastUpdateUser { get; set; }
        public Nullable<System.DateTime> LastUpdateDateTime { get; set; }
        public byte[] Timestamp { get; set; }

        public virtual City City { get; set; }
        public virtual Contact Contact { get; set; }


    }
}
