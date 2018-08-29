using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Smart.Wasl.Homes.Services.HomeAppliances.Domain.Interfaces
{
    public interface IAuditableEntity : IEntity
    {
        String CreationUser { get; set; }

        DateTime? CreationDateTime { get; set; }

        String LastUpdateUser { get; set; }

        DateTime? LastUpdateDateTime { get; set; }
    }
}
