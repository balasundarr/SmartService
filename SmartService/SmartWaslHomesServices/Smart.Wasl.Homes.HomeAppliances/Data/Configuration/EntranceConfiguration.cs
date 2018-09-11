﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Smart.Wasl.Homes.Services.HomeAppliances.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Smart.Wasl.Homes.Services.HomeAppliances.Data.Configuration
{
    public class EntranceConfiguration : IEntityTypeConfiguration<Entrance>
    {
        public void Configure(EntityTypeBuilder<Entrance> paramBuilder)
        {
            // Primary Table
            paramBuilder.ToTable("Entrance");

            // Set key for entity
            paramBuilder.HasKey(p => p.Id);

            // Set identity for entity (auto increment)
            paramBuilder.Property(p => p.Id).UseSqlServerIdentityColumn();

            // Set mapping for columns
            paramBuilder.Property(p => p.Id).HasColumnType("int").IsRequired();
            paramBuilder.Property(p => p.Left).HasColumnType("decimal").IsRequired();
            paramBuilder.Property(p => p.Right).HasColumnType("decimal").IsRequired();
            paramBuilder.Property(p => p.TopLeft).HasColumnType("decimal").IsRequired();
            paramBuilder.Property(p => p.TopRight).HasColumnType("decimal").IsRequired();

            paramBuilder.Property(p => p.CreationUser).HasColumnType("varchar(25)").IsRequired();
            paramBuilder.Property(p => p.CreationDateTime).HasColumnType("datetime").IsRequired();
            paramBuilder.Property(p => p.LastUpdateUser).HasColumnType("varchar(25)");
            paramBuilder.Property(p => p.LastUpdateDateTime).HasColumnType("datetime");

            //// Set concurrency token for entity
            //paramBuilder.Property(p => p.Timestamp).ValueGeneratedOnAddOrUpdate().IsConcurrencyToken();



        }
    }
}
