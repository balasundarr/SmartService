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

        public void Configure(EntityTypeBuilder<Contact> paramBuilder)
        {
            //Primary Table
            paramBuilder.ToTable("Contact");

            // Set key for entity
            paramBuilder.HasKey(p => p.Id);

            // Set identity for entity (auto increment)
            paramBuilder.Property(p => p.Id).UseSqlServerIdentityColumn();

            // Set mapping for columns
            paramBuilder.Property(p => p.Id).HasColumnType("int").IsRequired();
            paramBuilder.Property(p => p.FirstName).HasColumnType("varchar(255)").IsRequired();
            paramBuilder.Property(p => p.MiddleName).HasColumnType("varchar(255)").IsRequired();
            paramBuilder.Property(p => p.LastName).HasColumnType("varchar(255)").IsRequired();
            paramBuilder.Property(p => p.Name).HasColumnType("varchar(255)").IsRequired();
            paramBuilder.Property(p => p.PhoneNumbers).HasColumnType("varchar(255)").IsRequired();
            paramBuilder.Property(p => p.MobileNumbers).HasColumnType("varchar(255)").IsRequired();

            paramBuilder.Property(p => p.HomeId).HasColumnType("int").IsRequired();
            paramBuilder.Property(p => p.ApplianceId).HasColumnType("int").IsRequired();
            paramBuilder.Property(p => p.ContactTypeId).HasColumnType("int").IsRequired();

            paramBuilder.Property(p => p.CreationUser).HasColumnType("varchar(25)").IsRequired();
            paramBuilder.Property(p => p.CreationDateTime).HasColumnType("datetime").IsRequired();
            paramBuilder.Property(p => p.LastUpdateUser).HasColumnType("varchar(25)");
            paramBuilder.Property(p => p.LastUpdateDateTime).HasColumnType("datetime");

            // Set concurrency token for entity
            paramBuilder.Property(p => p.Timestamp).ValueGeneratedOnAddOrUpdate().IsConcurrencyToken();

            //// Add configuration for foreign keys
            //paramBuilder.HasMany(p => p.Address).WithOne(e => e.Contact_Address);
            //paramBuilder.HasOne(p => p.ContactType).WithOne(p => p.Contact_ContactType).HasForeignKey<ContactType>(p => p.Id);



        }
    }
}
