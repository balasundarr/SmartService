using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Smart.Wasl.Homes.Services.HomeAppliances.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Smart.Wasl.Homes.Services.HomeAppliances.Data.Configuration
{
    public class RoomCoordinateConfiguration : IEntityTypeConfiguration<RoomCoordinate>
    {
        public void Configure(EntityTypeBuilder<RoomCoordinate> parabuilder)
        {
            // Primary Table
            parabuilder.ToTable("RoomCoordinate");

            // Mapping for table
            parabuilder.ToTable("RoomCoordinate", "HomeAreaType");


            // Set key for entity
            parabuilder.HasKey(p => p.Id);

            // Set identity for entity (auto increment)
            parabuilder.Property(p => p.Id).UseSqlServerIdentityColumn();

            // Set mapping for columns
            parabuilder.Property(p => p.Id).HasColumnType("int").IsRequired();
          
            parabuilder.Property(p => p.SouthCorner).HasColumnType("decimal").IsRequired();
            parabuilder.Property(p => p.NorthCorner).HasColumnType("decimal").IsRequired();
            parabuilder.Property(p => p.EastCorner).HasColumnType("decimal").IsRequired();
            parabuilder.Property(p => p.WestCorner).HasColumnType("decimal").IsRequired();
            parabuilder.Property(p => p.SouthHeight).HasColumnType("decimal").IsRequired();
            parabuilder.Property(p => p.NorthHeight).HasColumnType("decimal").IsRequired();
            parabuilder.Property(p => p.EastHeight).HasColumnType("decimal").IsRequired();
            parabuilder.Property(p => p.WestHeight).HasColumnType("decimal").IsRequired();
          
            parabuilder.Property(p => p.CreationUser).HasColumnType("varchar(25)").IsRequired();
            parabuilder.Property(p => p.CreationDateTime).HasColumnType("datetime").IsRequired();
            parabuilder.Property(p => p.LastUpdateUser).HasColumnType("varchar(25)");
            parabuilder.Property(p => p.LastUpdateDateTime).HasColumnType("datetime");

            // Set concurrency token for entity
            parabuilder.Property(p => p.Timestamp).ValueGeneratedOnAddOrUpdate().IsConcurrencyToken();

            //// Add configuration for foreign keys
            //parabuilder.HasMany(p => p.Entrances).WithOne(e => e.RoomCoordinates_Entrance);
        }
    }
}
