using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Smart.Wasl.Homes.Services.Notifications.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Smart.Wasl.Homes.Services.Notifications.Data.Configuration
{
    public class NotificationsConfigurtion : IEntityTypeConfiguration<Notification>
    {
        public void Configure(EntityTypeBuilder<Notification> paramBuilder)
        {
            //Primary Table
            paramBuilder.ToTable("Address");


            // Set key for entity
            paramBuilder.HasKey(p => p.Id);

            // Set identity for entity (auto increment)
            paramBuilder.Property(p => p.Id).UseSqlServerIdentityColumn();

            // Set mapping for columns
             
            paramBuilder.Property(p => p.Id).HasColumnType("int").IsRequired();
            paramBuilder.Property(p => p.ServiceId).HasColumnType("int").IsRequired();
            paramBuilder.Property(p => p.ServiceType).HasColumnType("int").IsRequired();
            paramBuilder.Property(p => p.StartHour).HasColumnType("datetime");
            paramBuilder.Property(p => p.IntervalHour).HasColumnType("int");
            paramBuilder.Property(p => p.IntervalMinutes).HasColumnType("int");
            paramBuilder.Property(p => p.IntervalSeconds).HasColumnType("int");
            paramBuilder.Property(p => p.IntervalDays).HasColumnType("int");
            paramBuilder.Property(p => p.IntervalMonths).HasColumnType("int");
            paramBuilder.Property(p => p.IntervalYear).HasColumnType("int");
            paramBuilder.Property(p => p.ExactDateTime).HasColumnType("datetime");

            paramBuilder.Property(p => p.TextBig).HasColumnType("varchar(255)").IsRequired();
            paramBuilder.Property(p => p.TextMedium).HasColumnType("varchar(255)").IsRequired();
            paramBuilder.Property(p => p.TextSmall).HasColumnType("varchar(255)").IsRequired();


            paramBuilder.Property(p => p.CreationUser).HasColumnType("varchar(25)").IsRequired();
            paramBuilder.Property(p => p.CreationDateTime).HasColumnType("datetime").IsRequired();
            paramBuilder.Property(p => p.LastUpdateUser).HasColumnType("varchar(25)");
            paramBuilder.Property(p => p.LastUpdateDateTime).HasColumnType("datetime");

            // Set concurrency token for entity
            paramBuilder.Property(p => p.Timestamp).ValueGeneratedOnAddOrUpdate().IsConcurrencyToken();

            // Add configuration for foreign keys
            //paramBuilder.HasOne(p => p.City).WithOne(p => p.City_Address).HasForeignKey<City>(p => p.Id);
            //paramBuilder.HasOne(p => p.Contact).WithOne(p => p.C).HasForeignKey<Contact>(p => p.Id);


            // Add configuration for uniques

        }
    }
}
