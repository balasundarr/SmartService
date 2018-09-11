using Smart.Wasl.Homes.Services.Notifications.Domain;
using Smart.Wasl.Homes.Services.Notifications.Data;
using Smart.Wasl.Homes.Services.Notifications.Data.Contracts;
using Smart.Wasl.Homes.Services.Notifications.Data.Repositries;
using Smart.Wasl.Homes.Services.Notifications.Domain.Interfaces;
using Smart.Wasl.Homes.Services.Notifications.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;

namespace Smart.Wasl.Homes.Services.Notifications.Services
{
    public class NotificationInfoService : Service, INotificationsInfoService
    {
        public NotificationInfoService(ILogger<NotificationInfoService> paramLogger, IUserInfo paramUserInfo, NotificationsDbContext paramDbContext)
            : base(paramLogger, paramUserInfo, paramDbContext)
        {
        }
    }
}
