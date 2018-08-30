using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Smart.Wasl.Homes.Services.HomeAppliances.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Smart.Wasl.Homes.Services.HomeAppliances.Data.Configuration
{
    public class StateConfiguration : IEntityTypeConfiguration<State>
    {
        public void Configure(EntityTypeBuilder<State> parabuilder)
        {

            // Primary Table
            parabuilder.ToTable("State");
            
            // Set key for entity
            parabuilder.HasKey(p => p.Id);

            // Set identity for entity (auto increment)
            parabuilder.Property(p => p.Id).UseSqlServerIdentityColumn();

            // Set mapping for columns
            parabuilder.Property(p => p.Id).HasColumnType("int").IsRequired();
            parabuilder.Property(p => p.Name).HasColumnType("varchar(255)").IsRequired();
            parabuilder.Property(p => p.Countryid).HasColumnType("int").IsRequired();

            parabuilder.Property(p => p.CreationUser).HasColumnType("varchar(25)").IsRequired();
            parabuilder.Property(p => p.CreationDateTime).HasColumnType("datetime").IsRequired();
            parabuilder.Property(p => p.LastUpdateUser).HasColumnType("varchar(25)");
            parabuilder.Property(p => p.LastUpdateDateTime).HasColumnType("datetime");

            // Set concurrency token for entity
            parabuilder.Property(p => p.Timestamp).ValueGeneratedOnAddOrUpdate().IsConcurrencyToken();

            //// Add configuration for foreign keys
            // parabuilder.HasOne(p => p.Country).WithOne(p => p.State_Country).HasForeignKey<Country>(p => p.Id);
            
        }
    }
}
