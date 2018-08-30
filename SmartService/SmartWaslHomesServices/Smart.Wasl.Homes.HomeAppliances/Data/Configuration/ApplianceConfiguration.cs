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
        public void Configure(EntityTypeBuilder<Appliance> parabuilder)
        {
            //Primary Table
            parabuilder.ToTable("Appliance");

            // Set key for entity
            parabuilder.HasKey(p => p.Id);

            // Set identity for entity (auto increment)
            parabuilder.Property(p => p.Id).UseSqlServerIdentityColumn();

            // Set mapping for columns
            parabuilder.Property(p => p.Id).HasColumnType("int").IsRequired();
         
            parabuilder.Property(p => p.Name).HasColumnType("varchar(255)").IsRequired();
            parabuilder.Property(p => p.PurchasedDate).HasColumnType("datetime").IsRequired();
            parabuilder.Property(p => p.NextServiceDate).HasColumnType("datetime").IsRequired();
            parabuilder.Property(p => p.WarrantyYears).HasColumnType("int").IsRequired();

            parabuilder.Property(p => p.HomeAreaTypeId).HasColumnType("int").IsRequired();
            parabuilder.Property(p => p.ApplianceActionId).HasColumnType("int").IsRequired();
            parabuilder.Property(p => p.LocationId).HasColumnType("int").IsRequired();
                             
            parabuilder.Property(p => p.CreationUser).HasColumnType("varchar(25)").IsRequired();
            parabuilder.Property(p => p.CreationDateTime).HasColumnType("datetime").IsRequired();
            parabuilder.Property(p => p.LastUpdateUser).HasColumnType("varchar(25)");
            parabuilder.Property(p => p.LastUpdateDateTime).HasColumnType("datetime");

            // Set concurrency token for entity
            parabuilder.Property(p => p.Timestamp).ValueGeneratedOnAddOrUpdate().IsConcurrencyToken();

            // Add configuration for foreign keys
            //parabuilder.HasMany(p => p.ApplianceAction).WithOne(e => e.Appliance_ApplianceAction);
            //parabuilder.HasOne(p => p.Location).WithOne(p => p.Appliance_Location).HasForeignKey<Location>(p => p.Id);
            //parabuilder.HasMany(p => p.Contacts).WithOne(e => e.Appliance_Contact);
            //parabuilder.HasMany(p => p.Addresses).WithOne(e => e.Appliance_Address);

        }
    }
}
