using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Smart.Wasl.Homes.Services.Notifications.Domain.Interfaces;

namespace Smart.Wasl.Homes.Services.Notifications.Domain
{
    public class Notification : IAuditableEntity
    {
        public Notification()
        {
        }

        public Notification(int paramNotificationId)
        {
            Id = paramNotificationId;
        }

        public int Id { get; set; }
        public int ServiceId { get; set; }
        public int ServiceType { get; set; }
        public Nullable<System.DateTime> StartHour { get; set; }
        public int IntervalHour { get; set; }
        public int IntervalMinutes { get; set; }
        public int IntervalSeconds { get; set; }
        public int IntervalDays { get; set; }
        public int IntervalMonths { get; set; }
        public int IntervalYear { get; set; }
        public Nullable<System.DateTime> ExactDateTime { get; set; }
        public string TextBig { get; set; }
        public string TextMedium { get; set; }
        public string TextSmall { get; set; }

        public string CreationUser { get; set; }
        public Nullable<System.DateTime> CreationDateTime { get; set; }
        public string LastUpdateUser { get; set; }
        public Nullable<System.DateTime> LastUpdateDateTime { get; set; }
        public byte[] Timestamp { get; set; }

    }
}
