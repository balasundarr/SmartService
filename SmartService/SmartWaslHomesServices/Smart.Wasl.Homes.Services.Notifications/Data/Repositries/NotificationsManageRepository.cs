using Smart.Wasl.Homes.Services.Notifications.Data;
using Smart.Wasl.Homes.Services.Notifications.Data.Contracts;
using Smart.Wasl.Homes.Services.Notifications.Data.Repositries;
using Smart.Wasl.Homes.Services.Notifications.Domain;
using Smart.Wasl.Homes.Services.Notifications.Domain.Interfaces;
using Smart.Wasl.Homes.Services.Notifications.Domain.Repositries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Smart.Wasl.Homes.Services.Notifications.Data.Repositries
{
    public class NotificationsManageRepository : Repository, INotificationsManageRepository
    {


        public NotificationsManageRepository(IUserInfo paramUserInfo, NotificationsDbContext paramDbContext)
           : base(paramUserInfo, paramDbContext)
        {
        }
    }
    }

