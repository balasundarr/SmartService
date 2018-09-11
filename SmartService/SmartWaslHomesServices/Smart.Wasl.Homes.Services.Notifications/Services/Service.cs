using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Smart.Wasl.Homes.Services.Notifications.Data.Contracts;
using Smart.Wasl.Homes.Services.Notifications.Data.Repositries;
using Smart.Wasl.Homes.Services.Notifications.Domain.Interfaces;
using Smart.Wasl.Homes.Services.Notifications.Data;
using Smart.Wasl.Homes.Services.Notifications.Domain;

namespace Smart.Wasl.Homes.Services.Notifications.Services
{
    public abstract class Service : IService
    {
        protected ILogger Logger;
        protected IUserInfo UserInfo;
        protected bool Disposed;
        protected readonly NotificationsDbContext DbContext;
        protected NotificationsActionRepositry NotificationsActionRepositry;
        protected NotificationsInfoRepositry NotificationsInfoRepositry;
        protected NotificationsManageRepository NotificationsManageRepository;

        public Service(ILogger logger, IUserInfo userInfo, NotificationsDbContext dbContext)
        {
            Logger = logger;
            UserInfo = userInfo;
            DbContext = dbContext;
        }

        public void Dispose()
        {
            if (!Disposed)
            {
                DbContext?.Dispose();

                Disposed = true;
            }
        }

        protected INotificationssActionRepositry ActionRepositry
            => NotificationsActionRepositry ?? (NotificationsActionRepositry = new NotificationsActionRepositry(UserInfo, DbContext));

        protected INotificationsInfoRepositry InfoRespositry
            => NotificationsInfoRepositry ?? (NotificationsInfoRepositry = new NotificationsInfoRepositry(UserInfo, DbContext));

        protected INotificationsManageRepository ManageRepositry
            => NotificationsManageRepository ?? (NotificationsManageRepository = new NotificationsManageRepository(UserInfo, DbContext));
    }
}
