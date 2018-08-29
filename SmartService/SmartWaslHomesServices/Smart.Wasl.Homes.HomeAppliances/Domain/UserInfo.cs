using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Smart.Wasl.Homes.Services.HomeAppliances.Domain.Interfaces;

namespace Smart.Wasl.Homes.Services.HomeAppliances.Domain
{
    public class UserInfo : IUserInfo
    {
        public UserInfo()
        {
        }

       public string Name { get; set; }
    }
}
