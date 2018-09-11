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

        public void Configure(EntityTypeBuilder<Address> paramBuilder)
        {
            //Primary Table
            paramBuilder.ToTable("Address");


            // Set key for entity
            paramBuilder.HasKey(p => p.Id);

            // Set identity for entity (auto increment)
            paramBuilder.Property(p => p.Id).UseSqlServerIdentityColumn();

            // Set mapping for columns
            paramBuilder.Property(p => p.Id).HasColumnType("int").IsRequired();
            paramBuilder.Property(p => p.StreetName_First).HasColumnType("varchar(255)").IsRequired();
            paramBuilder.Property(p => p.StreetName_Second).HasColumnType("varchar(255)").IsRequired();
            paramBuilder.Property(p => p.AreaName).HasColumnType("varchar(255)").IsRequired();
            paramBuilder.Property(p => p.ContactId).HasColumnType("int").IsRequired();

            paramBuilder.Property(p => p.LocationId).HasColumnType("int").IsRequired();
            paramBuilder.Property(p => p.CityId).HasColumnType("int").IsRequired();

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
