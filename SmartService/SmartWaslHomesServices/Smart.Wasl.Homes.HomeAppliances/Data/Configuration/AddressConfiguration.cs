using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Smart.Wasl.Homes.Services.HomeAppliances.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Smart.Wasl.Homes.Services.HomeAppliances.Data.Configuration
{
    public class AddressConfiguration : IEntityTypeConfiguration<Address>
    {

        public void Configure(EntityTypeBuilder<Address> parabuilder)
        {
            //Primary Table
            parabuilder.ToTable("Address");

            // Mapping for table
            parabuilder.ToTable("Address", "Location");
            parabuilder.ToTable("Address", "City");

            // Set key for entity
            parabuilder.HasKey(p => p.Id);

            // Set identity for entity (auto increment)
            parabuilder.Property(p => p.Id).UseSqlServerIdentityColumn();

            // Set mapping for columns
            parabuilder.Property(p => p.Id).HasColumnType("int").IsRequired();
            parabuilder.Property(p => p.StreetName_First).HasColumnType("varchar(255)").IsRequired();
            parabuilder.Property(p => p.StreetName_Second).HasColumnType("varchar(255)").IsRequired();
            parabuilder.Property(p => p.AreaName).HasColumnType("varchar(255)").IsRequired();
            parabuilder.Property(p => p.ContactId).HasColumnType("int").IsRequired();

            parabuilder.Property(p => p.LocationId).HasColumnType("int").IsRequired();
            parabuilder.Property(p => p.CityId).HasColumnType("int").IsRequired();

            parabuilder.Property(p => p.CreationUser).HasColumnType("varchar(25)").IsRequired();
            parabuilder.Property(p => p.CreationDateTime).HasColumnType("datetime").IsRequired();
            parabuilder.Property(p => p.LastUpdateUser).HasColumnType("varchar(25)");
            parabuilder.Property(p => p.LastUpdateDateTime).HasColumnType("datetime");

            // Set concurrency token for entity
            parabuilder.Property(p => p.Timestamp).ValueGeneratedOnAddOrUpdate().IsConcurrencyToken();

            // Add configuration for foreign keys
            //parabuilder.HasOne(p => p.City).WithOne(p => p.City_Address).HasForeignKey<City>(p => p.Id);
            //parabuilder.HasOne(p => p.Contact).WithOne(p => p.C).HasForeignKey<Contact>(p => p.Id);


            // Add configuration for uniques
           
        }
    }
}
