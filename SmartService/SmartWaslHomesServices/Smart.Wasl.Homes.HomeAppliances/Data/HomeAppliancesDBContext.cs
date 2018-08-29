using Microsoft.EntityFrameworkCore;
using Smart.Wasl.Homes.Services.HomeAppliances.Domain;
using Smart.Wasl.Homes.Services.HomeAppliances.Data.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Smart.Wasl.Homes.Services.HomeAppliances.Data
{
    public class HomeAppliancesContext : DbContext
    {
        public HomeAppliancesContext(DbContextOptions<HomeAppliancesContext> paraoptions)
            : base(paraoptions)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Apply all configurations

            modelBuilder
                .ApplyConfiguration(new ApplianceConfiguration())
                .ApplyConfiguration(new ApplianceActionConfiguration());

            modelBuilder
                .ApplyConfiguration(new ContactConfiguration())
                .ApplyConfiguration(new ContactTypeConfiguration());
 
            modelBuilder
                .ApplyConfiguration(new RoomCoordinateConfiguration())
                .ApplyConfiguration(new EntranceConfiguration());

            modelBuilder
                .ApplyConfiguration(new HomeConfiguration())
                .ApplyConfiguration(new HomeAreaTypeConfiguration())
                .ApplyConfiguration(new LocationConfiguration());
               

            modelBuilder
                .ApplyConfiguration(new AddressConfiguration())
                .ApplyConfiguration(new CountryConfiguration())
                .ApplyConfiguration(new StateConfiguration())
                .ApplyConfiguration(new CityConfiguration());



            base.OnModelCreating(modelBuilder);
        }
    }
    
}
