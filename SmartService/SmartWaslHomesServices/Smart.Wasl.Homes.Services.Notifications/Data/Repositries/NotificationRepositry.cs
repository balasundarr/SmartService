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
using Microsoft.EntityFrameworkCore;

namespace Smart.Wasl.Homes.Services.Notifications.Domain.Repositries
{

    public class NotificationsRepositry : Repository, INotificationRepositry
    {

        public NotificationsRepositry(IUserInfo paramuserInfo, NotificationsDbContext paramDbContext)
           : base(paramuserInfo, paramDbContext)
        {
        }
        public Task<Int32> AddNotificationAsync(Notification paramEntity)
        {
            throw new NotImplementedException();
        }

        public Task<Int32> UpdateNotificationAsync(Notification paramChanges)
        {
            throw new NotImplementedException();
        }
        public Task<Int32> DeleteNotificationAsync(Notification paramEntity)
        {
            throw new NotImplementedException();
        }
        public Task<Notification> GetNotificatinById(int paramNotificationId)
        {
            throw new NotImplementedException();
        }
        public Task<Notification> GetNotificatinByServiceId(int paramNotificationId)
        {
            throw new NotImplementedException();
        }

        public Task<Notification> GetNotificatinByTypeId(int paramServiceId, int paramTypeId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Notification>> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
    