using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Smart.Wasl.Homes.Services.HomeAppliances.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Smart.Wasl.Homes.Services.HomeAppliances.Data.Configuration
{
    public class HomeAreaTypeConfiguration : IEntityTypeConfiguration<HomeAreaType>
    {
        public void Configure(EntityTypeBuilder<HomeAreaType> parabuilder)
        {
            //Primary Table
            parabuilder.ToTable("HomeAreaType");

            // Mapping for table
            parabuilder.ToTable("HomeAreaType", "Appliance");
            parabuilder.ToTable("HomeAreaType", "Location");
            parabuilder.ToTable("HomeAreaType", "RoomCoordinate");
            parabuilder.ToTable("HomeAreaType", "Entrance");


            // Set key for entity
            parabuilder.HasKey(p => p.Id);

            // Set identity for entity (auto increment)
            parabuilder.Property(p => p.Id).UseSqlServerIdentityColumn();

            // Set mapping for columns
            parabuilder.Property(p => p.Id).HasColumnType("int").IsRequired();
            parabuilder.Property(p => p.Name).HasColumnType("varchar(255)").IsRequired();
            parabuilder.Property(p => p.Description).HasColumnType("varchar(255)").IsRequired();
            
            parabuilder.Property(p => p.HomeId).HasColumnType("int").IsRequired();
            parabuilder.Property(p => p.RoomCoordinateId).HasColumnType("int").IsRequired();
          
            parabuilder.Property(p => p.CreationUser).HasColumnType("varchar(25)").IsRequired();
            parabuilder.Property(p => p.CreationDateTime).HasColumnType("datetime").IsRequired();
            parabuilder.Property(p => p.LastUpdateUser).HasColumnType("varchar(25)");
            parabuilder.Property(p => p.LastUpdateDateTime).HasColumnType("datetime");

            // Set concurrency token for entity
            parabuilder.Property(p => p.Timestamp).ValueGeneratedOnAddOrUpdate().IsConcurrencyToken();

            //// Add configuration for foreign keys
            //parabuilder.HasMany(p => p.Appliance).WithOne(e => e.HomeAreAType_Appliance);
            //parabuilder.HasOne(p => p.Location).WithOne(p => p.HomeAreaType_Location).HasForeignKey<Location>(p => p.Id);
            //parabuilder.HasOne(p => p.RoomCoordinate).WithOne(p => p.Home_RoomCoordinate).HasForeignKey<Location>(p => p.Id);

           
        }
    }
}
