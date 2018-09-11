using Microsoft.EntityFrameworkCore;
using Smart.Wasl.Homes.Services.Notifications.Domain;
using Smart.Wasl.Homes.Services.Notifications.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Smart.Wasl.Homes.Services.Notifications.Data.Contracts
{
    public interface INotificationRepositry : IRepository
    {
        Task<Int32> AddNotificationAsync(Notification paramEntity);

        Task<Int32> UpdateNotificationAsync(Notification paramChanges);

        Task<Int32> DeleteNotificationAsync(Notification paramEntity);

        Task<Notification> GetNotificatinById(int paramNotificationId);

        Task<Notification> GetNotificatinByServiceId(int paramNotificationId);

        Task<Notification> GetNotificatinByTypeId(int paramServiceId, int paramTypeId);

        Task<IEnumerable<Notification>> GetAll();
    }
}
