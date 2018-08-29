using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Smart.Wasl.Homes.Services.HomeAppliances.Domain.Interfaces;

namespace Smart.Wasl.Homes.Services.HomeAppliances.Domain
{
    public class ChangeLogExclusion : IEntity
    {
        public ChangeLogExclusion()
        {
        }

        public int? ChangeLogExclusionID { get; set; }

        public string EntityName { get; set; }

        public string PropertyName { get; set; }
    }
}

