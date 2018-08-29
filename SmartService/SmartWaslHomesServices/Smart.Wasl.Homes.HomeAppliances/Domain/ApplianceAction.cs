using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using Smart.Wasl.Homes.Services.HomeAppliances.Domain.Interfaces;

namespace Smart.Wasl.Homes.Services.HomeAppliances.Domain
{
    public class ApplianceAction : IAuditableEntity
    {
        public ApplianceAction()
        {
        }

        public ApplianceAction(int paraApplianceActionId)
        {
            Id = paraApplianceActionId;
        }

        public int Id { get; set; }
        public string Action { get; set; }
        public Nullable<int> ApplianceId { get; set; }

        public string CreationUser { get; set; }
        public Nullable<System.DateTime> CreationDateTime { get; set; }
        public string LastUpdateUser { get; set; }
        public Nullable<System.DateTime> LastUpdateDateTime { get; set; }
        public byte[] Timestamp { get; set; }

        public virtual Appliance Appliance { get; set; }



}
}
