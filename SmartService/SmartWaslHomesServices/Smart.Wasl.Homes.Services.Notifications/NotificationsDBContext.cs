using Microsoft.EntityFrameworkCore;
using Smart.Wasl.Homes.Services.Notifications.Domain;
using Smart.Wasl.Homes.Services.Notifications.Data.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Smart.Wasl.Homes.Services.Notifications.Data
{
    public class NotificationsDbContext : DbContext
    
    {
        public NotificationsDbContext(DbContextOptions<NotificationsDbContext> paramOptions)
            : base(paramOptions)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Apply all configurations

            modelBuilder
                .ApplyConfiguration(new NotificationsConfigurtion());
                
            base.OnModelCreating(modelBuilder);
        }
    }
}
