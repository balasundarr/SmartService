using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Smart.Wasl.Homes.Services.HomeAppliances.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Smart.Wasl.Homes.Services.HomeAppliances.Data.Configuration
{
    public class ApplianceConfiguration : IEntityTypeConfiguration<Appliance>
    {
        public void Configure(EntityTypeBuilder<Appliance> paramBuilder)
        {
            //Primary Table
            paramBuilder.ToTable("Appliance");

            // Set key for entity
            paramBuilder.HasKey(p => p.Id);

            // Set identity for entity (auto increment)
            paramBuilder.Property(p => p.Id).UseSqlServerIdentityColumn();

            // Set mapping for columns
            paramBuilder.Property(p => p.Id).HasColumnType("int").IsRequired();

            paramBuilder.Property(p => p.Name).HasColumnType("varchar(255)").IsRequired();
            paramBuilder.Property(p => p.PurchasedDate).HasColumnType("datetime").IsRequired();
            paramBuilder.Property(p => p.NextServiceDate).HasColumnType("datetime").IsRequired();
            paramBuilder.Property(p => p.WarrantyYears).HasColumnType("int").IsRequired();

            paramBuilder.Property(p => p.HomeAreaTypeId).HasColumnType("int").IsRequired();
            paramBuilder.Property(p => p.ApplianceActionId).HasColumnType("int").IsRequired();
            paramBuilder.Property(p => p.LocationId).HasColumnType("int").IsRequired();

            paramBuilder.Property(p => p.CreationUser).HasColumnType("varchar(25)").IsRequired();
            paramBuilder.Property(p => p.CreationDateTime).HasColumnType("datetime").IsRequired();
            paramBuilder.Property(p => p.LastUpdateUser).HasColumnType("varchar(25)");
            paramBuilder.Property(p => p.LastUpdateDateTime).HasColumnType("datetime");

            // Set concurrency token for entity
            paramBuilder.Property(p => p.Timestamp).ValueGeneratedOnAddOrUpdate().IsConcurrencyToken();

            // Add configuration for foreign keys
            //paramBuilder.HasMany(p => p.ApplianceAction).WithOne(e => e.Appliance_ApplianceAction);
            //paramBuilder.HasOne(p => p.Location).WithOne(p => p.Appliance_Location).HasForeignKey<Location>(p => p.Id);
            //paramBuilder.HasMany(p => p.Contacts).WithOne(e => e.Appliance_Contact);
            //paramBuilder.HasMany(p => p.Addresses).WithOne(e => e.Appliance_Address);

        }
    }
}
