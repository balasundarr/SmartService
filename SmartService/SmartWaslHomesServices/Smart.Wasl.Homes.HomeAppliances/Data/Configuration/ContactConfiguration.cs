using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Smart.Wasl.Homes.Services.HomeAppliances.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace Smart.Wasl.Homes.Services.HomeAppliances.Data.Configuration
{
    public class ContactConfiguration : IEntityTypeConfiguration<Contact>
    {

        public void Configure(EntityTypeBuilder<Contact> parabuilder)
        {
            //Primary Table
            parabuilder.ToTable("Contact");

            // Mapping for table
            parabuilder.ToTable("Contact", "Address");
            parabuilder.ToTable("Contact", "ContactType");


            // Set key for entity
            parabuilder.HasKey(p => p.Id);

            // Set identity for entity (auto increment)
            parabuilder.Property(p => p.Id).UseSqlServerIdentityColumn();

            // Set mapping for columns
            parabuilder.Property(p => p.Id).HasColumnType("int").IsRequired();
             parabuilder.Property(p => p.FirstName).HasColumnType("varchar(255)").IsRequired();
            parabuilder.Property(p => p.MiddleName).HasColumnType("varchar(255)").IsRequired();
            parabuilder.Property(p => p.LastName).HasColumnType("varchar(255)").IsRequired();
            parabuilder.Property(p => p.Name).HasColumnType("varchar(255)").IsRequired();
            parabuilder.Property(p => p.PhoneNumbers).HasColumnType("varchar(255)").IsRequired();
            parabuilder.Property(p => p.MobileNumbers).HasColumnType("varchar(255)").IsRequired();

            parabuilder.Property(p => p.HomeId).HasColumnType("int").IsRequired();
            parabuilder.Property(p => p.ApplianceId).HasColumnType("int").IsRequired();
            parabuilder.Property(p => p.ContactTypeId).HasColumnType("int").IsRequired();

            parabuilder.Property(p => p.CreationUser).HasColumnType("varchar(25)").IsRequired();
            parabuilder.Property(p => p.CreationDateTime).HasColumnType("datetime").IsRequired();
            parabuilder.Property(p => p.LastUpdateUser).HasColumnType("varchar(25)");
            parabuilder.Property(p => p.LastUpdateDateTime).HasColumnType("datetime");

            // Set concurrency token for entity
            parabuilder.Property(p => p.Timestamp).ValueGeneratedOnAddOrUpdate().IsConcurrencyToken();

            //// Add configuration for foreign keys
            //parabuilder.HasMany(p => p.Address).WithOne(e => e.Contact_Address);
            //parabuilder.HasOne(p => p.ContactType).WithOne(p => p.Contact_ContactType).HasForeignKey<ContactType>(p => p.Id);


           
        }
    }
}
